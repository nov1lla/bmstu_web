using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BL.Models;
using BL.Services;

namespace GUI.AppForm
{
    public partial class FormViewPromos : Form
    {
        private PromoService promoService;
        private int cur_id_promo;
        public FormViewPromos(PromoService promoService)
        {
            this.promoService = promoService;
            InitializeComponent();
            updateDataTable();
        }

        public void updateDataTable()
        {
            dgPromos.DataSource = promoService.viewAllPromos();
            tbCode.Text = "";
            tbDiscount.Text = "";
            tbStart.Text = "";
            tbEnd.Text = "";
        }

        private void FormViewPromos_Load(object sender, EventArgs e)
        {

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

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_input_empty() == false)
                    throw new Exception("Input error");
                int discount;
                if (int.TryParse(tbDiscount.Text, out discount) == false)
                    throw new Exception("Input Error, We need number!");
                promoService.DelPromo(new Promo(cur_id_promo, tbCode.Text, Convert.ToInt32(tbDiscount.Text), DateTime.Parse(tbStart.Text), DateTime.Parse(tbEnd.Text)));
                updateDataTable();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_input_empty() == false)
                    throw new Exception("Input error");
                int discount;
                if (int.TryParse(tbDiscount.Text, out discount) == false)
                    throw new Exception("Input Error, We need number!");
                promoService.AddPromo(new Promo(-1, tbCode.Text, Convert.ToInt32(tbDiscount.Text), DateTime.Parse(tbStart.Text), DateTime.Parse(tbEnd.Text)));
                updateDataTable();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_input_empty() == false)
                    throw new Exception("Input error");
                int discount;
                if (int.TryParse(tbDiscount.Text, out discount) == false)
                    throw new Exception("Input Error, We need number!");
                promoService.UpdatePromo(new Promo(cur_id_promo, tbCode.Text, Convert.ToInt32(tbDiscount.Text), DateTime.Parse(tbStart.Text), DateTime.Parse(tbEnd.Text)));
                updateDataTable();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgPromos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) { rowID = 0; }
            DataGridViewRow row = dgPromos.Rows[rowID];
            cur_id_promo = Convert.ToInt32(row.Cells[0].Value.ToString());

            FormViewUserPromos frmUserPromos = new FormViewUserPromos(cur_id_promo, promoService);
            frmUserPromos.Show();
        }
        private bool check_input_empty()
        {
            if (tbCode.Text == "" || tbDiscount.Text == "" || tbStart.Text == "" || tbEnd.Text == "")
                return false;
            return true;
        }
    }
}
