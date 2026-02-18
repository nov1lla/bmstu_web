using BL.Services;
using BL.Models;
using BL.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyException;
using DA;
using UITech;
namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Connector con = new Connector("postgres", "anhyeuem", "localhost", "postgres", 5432);
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

            UICart ucart = new UICart(cartService, userService, productService);
            UIPromo upromo = new UIPromo(promoService, userService);
            UIItemOrder uitemorder = new UIItemOrder(itemOrderService, orderService, productService);
            UIItemCart uitemcart = new UIItemCart(itemCartService, cartService, productService);
            UIProduct uproduct = new UIProduct(productService);
            UIOrder uorder = new UIOrder(orderService, userService);
            UIUser uuser = new UIUser(userService);

            ConsoleApp app = new ConsoleApp(ucart, upromo, uitemorder, uitemcart, uproduct, uorder, uuser);
            while (true)
            {
                app.menu();
            }
        }
    }
}