using BL.Models;
using BL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.AppForm
{
    public partial class FormViewPromosByClient : Form
    {
        private PromoService promoService;
        private int cur_id_promo;
        private int id_user;
        public FormViewPromosByClient(int id_user, PromoService promoService)
        {
            this.id_user = id_user;
            this.promoService = promoService;
            InitializeComponent();
            updateDataTable();
        }

        public void updateDataTable()
        {
            dgPromos.DataSource = promoService.GetPromoByIdUser(id_user);
            tbCode.Text = "";
            tbDiscount.Text = "";
            tbStart.Text = "";
            tbEnd.Text = "";
        }
        private void dgPromos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowId = e.RowIndex;
            if (rowId < 0) { rowId = 0; }
            DataGridViewRow row = dgPromos.Rows[rowId];
            cur_id_promo = Convert.ToInt32(row.Cells[0].Value.ToString());
            tbCode.Text = row.Cells[1].Value.ToString();
            tbDiscount.Text = row.Cells[2].Value.ToString();
            tbStart.Text = row.Cells[3].Value.ToString();
            tbEnd.Text = row.Cells[4].Value.ToString();
        }
        private bool check_input_empty()
        {
            if (tbCode.Text == "" || tbDiscount.Text == "" || tbStart.Text == "" || tbEnd.Text == "")
                return false;
            return true;
        }
    }
}
