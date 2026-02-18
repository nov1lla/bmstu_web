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
    public partial class FormViewOrders : Form
    {
        private OrderService _orderService;
        private UserService _userService;
        private PromoService _promoService;
        private ProductService _productService;
        private ItemOrderService _itemOrderService;
        private int cur_id_order;
        private int cur_id_user;
        private int cur_id_promo;
        public FormViewOrders(OrderService orderService, UserService userService, PromoService promoService, ProductService productService, ItemOrderService itemOrderService)
        {
            this._orderService = orderService;
            this._userService = userService;
            this._promoService = promoService;
            InitializeComponent();
            updateDataTable();
            _productService = productService;
            _itemOrderService = itemOrderService;
        }
        public void updateDataTable()
        {
            dgOrders.DataSource = _orderService.viewAllUsers();
            tbData.Text = "";
            tbUserLogin.Text = "";
            tbPromoCode.Text = "";
            cbStatus.Text = "";
        }
        private void FormViewOrders_Load(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (check_input_empty() == false)
                throw new Exception("Input empty");
            try
            {
                _orderService.DelOrder(new Order(cur_id_order, (Status)Enum.Parse(typeof(Status), cbStatus.Text, true), DateTime.Parse(tbData.Text), 1, 1));
                updateDataTable();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId < 0) { rowId = 0; }
            DataGridViewRow row = dgOrders.Rows[rowId];
            cur_id_order = Convert.ToInt32(row.Cells[0].Value.ToString());
            cur_id_user = Convert.ToInt32(row.Cells[2].Value.ToString());
            cur_id_promo = Convert.ToInt32(row.Cells[3].Value.ToString());
            tbData.Text = row.Cells[1].Value.ToString();
            tbUserLogin.Text = _userService.GetUser(cur_id_user).Login;
            tbPromoCode.Text = _promoService.GetPromo(cur_id_promo).Code;
            cbStatus.Text = row.Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_input_empty() == false)
                    throw new Exception("Input empty");
                _orderService.UpdateOrder(new Order(cur_id_order, (Status)Enum.Parse(typeof(Status), cbStatus.Text, true), DateTime.Parse(tbData.Text), cur_id_user, cur_id_promo));
                updateDataTable();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) { rowID = 0; }
            DataGridViewRow row = dgOrders.Rows[rowID];
            cur_id_order = Convert.ToInt32(row.Cells[0].Value.ToString());

            FormItemOrder frmItemOrder = new FormItemOrder(cur_id_order, _itemOrderService, _orderService, _productService);
            frmItemOrder.Show();
        }
        private bool check_input_empty()
        {
            if (tbUserLogin.Text == "" || tbData.Text == "" || tbPromoCode.Text == "" || cbStatus.Text == "")
                return false;
            return true;
        }
    }
}
