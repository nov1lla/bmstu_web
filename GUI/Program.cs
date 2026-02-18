using BL.Models;
using BL.Services;
using DA;
using GUI.AppForm;
using System.Text;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Connector con = new Connector("postgres", "Qazedctgb13", "localhost", "db_ppo", 5432);
            CartRepository cartRepository = new CartRepository(con);
            PromoRepository promoRepository = new PromoRepository(con);
            ItemOrderRepository itemOrderRepository = new ItemOrderRepository(con);
            ItemCartRepository itemCartRepository = new ItemCartRepository(con);
            ProductRepository productRepository = new ProductRepository(con);
            OrderRepository orderRepository = new OrderRepository(con);
            UserRepository userRepository = new UserRepository(con);
            UserPromoRepository userPromoRepository = new UserPromoRepository(con);

            CartService cartService = new CartService(cartRepository);
            PromoService promoService = new PromoService(promoRepository, userRepository, userPromoRepository);
            ItemOrderService itemOrderService = new ItemOrderService(itemOrderRepository);
            ItemCartService itemCartService = new ItemCartService(itemCartRepository);
            ProductService productService = new ProductService(productRepository);
            OrderService orderService = new OrderService(orderRepository);
            UserService userService = new UserService(userRepository);


            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin(userService, productService, promoService, orderService, cartService, itemOrderService, itemCartService));
        }
    }
}