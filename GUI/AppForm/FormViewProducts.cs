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
using BL.Models;
using BL.Services;

namespace GUI.AppForm
{
    public partial class FormViewProducts : Form
    {
        private ProductService productService;
        private int cur_id_product;
        public FormViewProducts(ProductService productService)
        {
            this.productService = productService;
            InitializeComponent();
            updateDataTable();
        }

        public void updateDataTable()
        {
            dgProducts.DataSource = productService.viewAllProducts();
            tbName.Text = "";
            tbPrice.Text = "";
            tbQuantity.Text = "";
            tbManufacturer.Text = "";
            tbDescription.Text = "";
        }

        private void FormViewProducts_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_input_empty() == false)
                    throw new Exception("Input empty");
                int price;
                int quantity;
                if ((int.TryParse(tbPrice.Text, out price) == false) || (int.TryParse(tbQuantity.Text, out quantity) == false))
                    throw new Exception("Input Error, We need number!");
                productService.AddProduct(new Product(-1, tbName.Text, price, quantity, tbManufacturer.Text, tbDescription.Text));
                updateDataTable();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_input_empty() == false)
                    throw new Exception("Input empty");
                int price;
                int quantity;
                if ((int.TryParse(tbPrice.Text, out price) == false) || (int.TryParse(tbQuantity.Text, out quantity) == false))
                    throw new Exception("Input Error, We need number!");
                productService.DelProduct(new Product(cur_id_product, tbName.Text, price, quantity, tbManufacturer.Text, tbDescription.Text));
                updateDataTable();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_input_empty() == false)
                    throw new Exception("Input empty");
                int price;
                int quantity;
                if ((int.TryParse(tbPrice.Text, out price) == false) || (int.TryParse(tbQuantity.Text, out quantity) == false))
                    throw new Exception("Input Error, We need number!");
                productService.UpdateProduct(new Product(cur_id_product, tbName.Text, price, quantity, tbManufacturer.Text, tbDescription.Text));
                updateDataTable();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId < 0) { rowId = 0; }
            DataGridViewRow row = dgProducts.Rows[rowId];
            cur_id_product = Convert.ToInt32(row.Cells[0].Value.ToString());
            tbName.Text = row.Cells[1].Value.ToString();
            tbPrice.Text = row.Cells[2].Value.ToString();
            tbQuantity.Text = row.Cells[3].Value.ToString();
            tbManufacturer.Text = row.Cells[4].Value.ToString();
            tbDescription.Text = row.Cells[5].Value.ToString();
        }
        private bool check_input_empty()
        {
            if (tbName.Text == "" || tbPrice.Text == "" || tbQuantity.Text == "" || tbManufacturer.Text == "" || tbDescription.Text == "")
                return false;
            return true;
        }
    }
}
