using System;
using GUI.AppForm;

namespace GUI.MVP.Main
{
    public class AdminPresenter
    {
        private readonly IMainFormView _view;
        private readonly int _userId;
        private readonly BL.Services.UserService _userService;
        private readonly BL.Services.ProductService _productService;
        private readonly BL.Services.PromoService _promoService;
        private readonly BL.Services.OrderService _orderService;
        private readonly BL.Services.CartService _cartService;
        private readonly BL.Services.ItemOrderService _itemOrderService;
        private readonly BL.Services.ItemCartService _itemCartService;

        public AdminPresenter(IMainFormView view,
                              int userId,
                              BL.Services.UserService userService,
                              BL.Services.ProductService productService,
                              BL.Services.PromoService promoService,
                              BL.Services.OrderService orderService,
                              BL.Services.CartService cartService,
                              BL.Services.ItemOrderService itemOrderService,
                              BL.Services.ItemCartService itemCartService)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _userId = userId;
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _promoService = promoService ?? throw new ArgumentNullException(nameof(promoService));
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
            _cartService = cartService ?? throw new ArgumentNullException(nameof(cartService));
            _itemOrderService = itemOrderService ?? throw new ArgumentNullException(nameof(itemOrderService));
            _itemCartService = itemCartService ?? throw new ArgumentNullException(nameof(itemCartService));

            _view.InfoRequested += OnInfoRequested;
            _view.UsersViewRequested += OnUsersViewRequested;
            _view.ProductsViewRequested += OnProductsViewRequested;
            _view.OrdersViewRequested += OnOrdersViewRequested;
            _view.PromosViewRequested += OnPromosViewRequested;
            _view.CartsViewRequested += OnCartsViewRequested;
            _view.LogoutRequested += OnLogoutRequested;
        }

        private void OnInfoRequested(object? sender, EventArgs e)
        {
            _view.DisplayChildForm(new FormInfo(_userId, _userService));
        }

        private void OnUsersViewRequested(object? sender, EventArgs e)
        {
            _view.DisplayChildForm(new FormViewUsers(_userService));
        }

        private void OnProductsViewRequested(object? sender, EventArgs e)
        {
            _view.DisplayChildForm(new FormViewProducts(_productService));
        }

        private void OnOrdersViewRequested(object? sender, EventArgs e)
        {
            _view.DisplayChildForm(new FormViewOrders(_orderService, _userService, _promoService, _productService, _itemOrderService));
        }

        private void OnPromosViewRequested(object? sender, EventArgs e)
        {
            _view.DisplayChildForm(new FormViewPromos(_promoService));
        }

        private void OnCartsViewRequested(object? sender, EventArgs e)
        {
            _view.DisplayChildForm(new FormCarts(_userId, _cartService, _promoService, _userService, _itemCartService, _productService, _orderService, _itemOrderService));
        }

        private void OnLogoutRequested(object? sender, EventArgs e)
        {
            _view.ShowLogin();
        }
    }
}
