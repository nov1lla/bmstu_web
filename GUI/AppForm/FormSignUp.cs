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
    public partial class FormSignUp : Form
    {
        private UserService _userService;
        private ProductService _productService;
        private PromoService _promoService;
        private OrderService _orderService;
        private CartService _cartService;
        private ItemCartService _itemCartService;
        private ItemOrderService _itemOrderService;

        public FormSignUp(UserService userService, ProductService productService, PromoService promoService, OrderService orderService, CartService cartService,
                        ItemOrderService itemOrderService, ItemCartService itemCartService)
        {
            InitializeComponent();
            this._cartService = cartService;
            this._userService = userService;
            this._productService = productService;
            this._promoService = promoService;
            this._orderService = orderService;
            this._itemCartService = itemCartService;
            this._itemOrderService = itemOrderService;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin(_userService, _productService, _promoService, _orderService, _cartService, _itemOrderService, _itemCartService);
            frm.ShowDialog();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_input_empty() == false)
                    throw new Exception("Input empty");
                _userService.Register(tbUsername.Text, tbPhoneNumber.Text, tbAddress.Text, tbEmail.Text, tbLogin.Text, tbPassword.Text, (Role)Enum.Parse(typeof(Role), cbRole.Text, true));
                MessageBox.Show("Register successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private bool check_input_empty()
        {
            if (tbLogin.Text == "" || tbPassword.Text == "" || tbUsername.Text == "" || tbAddress.Text == "" || tbPhoneNumber.Text == "" || tbEmail.Text == "" || cbRole.Text == "")
                return false;
            return true;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
