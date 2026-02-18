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
using System.Xml.Linq;

namespace GUI.AppForm
{
    public partial class FormItemCart : Form
    {
        ItemCartService itemCartService;
        CartService cartService;
        ProductService productService;
        private int id_cart;
        private int cur_id_itemCart;
        private int cur_id_product;
        public FormItemCart(int id_cart, ItemCartService itemCartService, CartService cartService, ProductService productService)
        {
            this.id_cart = id_cart;
            this.itemCartService = itemCartService;
            this.cartService = cartService;
            this.productService = productService;
            InitializeComponent();
            updateDataTable();
        }
        public void updateDataTable()
        {
            dgItemCarts.DataSource = itemCartService.GetAllItemCartByIdCart(id_cart);
        }

        private void dgItemCarts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId < 0) { rowId = 0; }
            DataGridViewRow row = dgItemCarts.Rows[rowId];
            cur_id_itemCart = Convert.ToInt32(row.Cells[0].Value.ToString());
            cur_id_product = Convert.ToInt32(row.Cells[1].Value.ToString());
            tbProduct.Text = productService.GetProductById(cur_id_product).Name;
            tbQuantity.Text = row.Cells[3].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_input_empty() == false)
                    throw new Exception("Input empty");
                itemCartService.DelItemCart(new ItemCart(cur_id_itemCart, cur_id_product, id_cart, Convert.ToInt32(tbQuantity.Text)));
                updateDataTable();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgItemCarts_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId < 0) { rowId = 0; }
            DataGridViewRow row = dgItemCarts.Rows[rowId];
            cur_id_itemCart = Convert.ToInt32(row.Cells[0].Value.ToString());
            cur_id_product = Convert.ToInt32(row.Cells[1].Value.ToString());
            tbProduct.Text = productService.GetProductById(cur_id_product).Name;
            tbQuantity.Text = row.Cells[3].Value.ToString();
        }
        private bool check_input_empty()
        {
            if (tbProduct.Text == "" || tbQuantity.Text == "")
                return false;
            return true;
        }
    }
}
