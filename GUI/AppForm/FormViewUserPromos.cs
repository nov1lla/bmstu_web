using BL.Models;
using BL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI.AppForm
{
    public partial class FormViewUserPromos : Form
    {
        private PromoService promoService;
        private int id_promo;
        private int cur_id_userPromo;
        public FormViewUserPromos(int id_promo, PromoService promoService)
        {
            this.id_promo = id_promo;
            this.promoService = promoService;

            InitializeComponent();
            updateDataTable();
        }

        public void updateDataTable()
        {
            dgUserPromos.DataSource = promoService.GetUserPromoByPromo(id_promo);
            tbIdPromo.Text = id_promo.ToString();
            tbIdUser.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_input_empty() == false)
                    throw new Exception("Input error");
                int id_user;
                if (int.TryParse(tbIdUser.Text, out id_user) == false)
                    throw new Exception("Input Error, We need number!");
                promoService.AddUserPromo(new UserPromo(-1, id_user, id_promo));
                updateDataTable();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgUserPromos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId < 0) { rowId = 0; }
            DataGridViewRow row = dgUserPromos.Rows[rowId];
            cur_id_userPromo = Convert.ToInt32(row.Cells[0].Value.ToString());
            tbIdUser.Text = row.Cells[1].Value.ToString();
            tbIdPromo.Text = row.Cells[2].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_input_empty() == false)
                    throw new Exception("Input error");
                int id_user;
                if (int.TryParse(tbIdUser.Text, out id_user) == false)
                    throw new Exception("Input Error, We need number!");
                promoService.DelUserPromo(new UserPromo(cur_id_userPromo, id_user, id_promo));
                updateDataTable();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private bool check_input_empty()
        {
            if (tbIdUser.Text == "" || tbIdPromo.Text == "")
                return false;
            return true;
        }
    }
}
