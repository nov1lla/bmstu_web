using BL.Models;
using BL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.AppForm
{
    public partial class FormViewProductsByClient : Form
    {
        private ProductService productService;
        private CartService cartService;
        private ItemCartService itemCartService;
        private int cur_id_product;
        private int id_cart;
        private int id_user;
        public FormViewProductsByClient(int id_user, ProductService productService, CartService cartService, ItemCartService itemCartService)
        {
            this.id_user = id_user;
            this.productService = productService;
            InitializeComponent();
            updateDataTable();
            this.cartService = cartService;
            this.itemCartService = itemCartService;
            setValueComboBox();
        }
        public void setValueComboBox()
        {
            List<Cart> carts = cartService.GetCartByIdUser(id_user);
            foreach (Cart cart in carts)
            {
                cbCarts.Items.Add(cart.Id);
            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_input_empty() == false)
                    throw new Exception("Input empty");
                int id_cart;
                if (int.TryParse(cbCarts.Text, out id_cart) == false)
                    throw new Exception("Input Error, We need number!");

                itemCartService.AddProductToCart(id_cart, cur_id_product);
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
