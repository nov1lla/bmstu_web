using System;
using System.Windows.Forms;
using BL.Services;
using GUI.MVP.Main;

namespace GUI.AppForm
{
    public partial class FormClient : Form, IMainFormView
    {
        private readonly UserService _userService;
        private readonly ProductService _productService;
        private readonly PromoService _promoService;
        private readonly OrderService _orderService;
        private readonly CartService _cartService;
        private readonly ItemCartService _itemCartService;
        private readonly ItemOrderService _itemOrderService;
        private readonly int _userId;
        private readonly ClientPresenter _presenter;
        private Form? _activeForm;

        public event EventHandler? InfoRequested;
        public event EventHandler? UsersViewRequested;
        public event EventHandler? ProductsViewRequested;
        public event EventHandler? OrdersViewRequested;
        public event EventHandler? PromosViewRequested;
        public event EventHandler? CartsViewRequested;
        public event EventHandler? LogoutRequested;

        public FormClient(int id_user, UserService userService, ProductService productService,
                        PromoService promoService, OrderService orderService, CartService cartService,
                        ItemOrderService itemOrderService, ItemCartService itemCartService)
        {
            _userId = id_user;
            _cartService = cartService;
            _userService = userService;
            _productService = productService;
            _promoService = promoService;
            _orderService = orderService;
            _itemCartService = itemCartService;
            _itemOrderService = itemOrderService;

            InitializeComponent();
            _presenter = new ClientPresenter(this, _userId, _userService, _productService, _promoService, _orderService, _cartService, _itemOrderService, _itemCartService);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            InfoRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            ProductsViewRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnViewCarts_Click(object sender, EventArgs e)
        {
            CartsViewRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            OrdersViewRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnViewPromos_Click(object sender, EventArgs e)
        {
            PromosViewRequested?.Invoke(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogoutRequested?.Invoke(this, EventArgs.Empty);
        }

        private void openChildForm(Form form)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }

            _activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.AutoScaleMode = AutoScaleMode.None;
            form.Size = panelMain.ClientSize;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(_activeForm);
            panelMain.Tag = form;
            form.BringToFront();
            form.Show();
        }

        public void DisplayChildForm(Form form)
        {
            openChildForm(form);
        }

        public void ShowLogin()
        {
            Hide();
            using (var login = new FormLogin(_userService, _productService, _promoService, _orderService, _cartService, _itemOrderService, _itemCartService))
            {
                login.ShowDialog(this);
            }
            Close();
        }
    }
}
