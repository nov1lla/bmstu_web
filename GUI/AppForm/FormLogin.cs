using System;
using System.Windows.Forms;
using BL.Models;
using BL.Services;
using GUI.MVP.Login;

namespace GUI.AppForm
{
    public partial class FormLogin : Form, ILoginView
    {
        private readonly UserService _userService;
        private readonly ProductService _productService;
        private readonly PromoService _promoService;
        private readonly OrderService _orderService;
        private readonly CartService _cartService;
        private readonly ItemCartService _itemCartService;
        private readonly ItemOrderService _itemOrderService;
        private readonly LoginPresenter _presenter;

        public FormLogin(UserService userService, ProductService productService, PromoService promoService, OrderService orderService, CartService cartService,
                        ItemOrderService itemOrderService, ItemCartService itemCartService)
        {
            InitializeComponent();
            _cartService = cartService;
            _userService = userService;
            _productService = productService;
            _promoService = promoService;
            _orderService = orderService;
            _itemCartService = itemCartService;
            _itemOrderService = itemOrderService;

            _presenter = new LoginPresenter(this, _userService);
        }

        public string Username => tbUsername.Text;
        public string Password => tbPassword.Text;

        public event EventHandler? SignInRequested;
        public event EventHandler? SignUpRequested;

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignInRequested?.Invoke(this, EventArgs.Empty);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void OpenSignUp()
        {
            Hide();
            using (var signUp = new FormSignUp(_userService, _productService, _promoService, _orderService, _cartService, _itemOrderService, _itemCartService))
            {
                signUp.ShowDialog(this);
            }
            Show();
        }

        public void NavigateToRole(Role role, int userId)
        {
            Form? form = role switch
            {
                Role.Admin => new FormAdmin(userId, _userService, _productService, _promoService, _orderService, _cartService, _itemOrderService, _itemCartService),
                Role.Seller => new FormSelller(userId, _userService, _productService, _promoService, _orderService, _cartService, _itemOrderService, _itemCartService),
                Role.Client => new FormClient(userId, _userService, _productService, _promoService, _orderService, _cartService, _itemOrderService, _itemCartService),
                _ => null
            };

            if (form == null)
            {
                ShowError("Unsupported role");
                return;
            }

            using (form)
            {
                form.ShowDialog(this);
            }
        }

        public void CloseView()
        {
            Close();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';
        }
    }
}
