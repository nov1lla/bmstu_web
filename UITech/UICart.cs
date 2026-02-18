using BL.Services;
using BL.Models;
using BL.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MyException;

namespace UITech
{
    internal class UICart
    {
        private CartService cartService;
        private UserService userService;
        private ProductService productService;

        public UICart(CartService cartService, UserService userService, ProductService productService)
        {
            this.cartService = cartService;
            this.userService = userService;
            this.productService = productService;
        }

        public void AddCart(int id_user)
        {
            try
            {
                ViewCartByUser(id_user);
                
                DateTime date = DateTime.Now;
                Cart cart = new Cart(-1, date, id_user);
                cartService.AddCart(cart);
                
                Console.WriteLine("Success!");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void DeleteCart(int id_user)
        {
            try
            {
                ViewCartByUser(id_user);
                int id = -1;
                Console.Write("Input ID: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Delete this cart? (y/n): ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "y":
                        cartService.DelCart(cartService.GetCartById(id));
                        Console.WriteLine("Success!");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void DelCartByIdCart(int ID)
        {
            cartService.DelCart(cartService.GetCartById(ID));
        }

        public void UpdateCart(int id_user)
        {
            //try
            //{
            //    ViewCartByUser(id_user);
            //    int id = -1;
            //    Console.Write("Input ID: ");
            //    id = Convert.ToInt32(Console.ReadLine());
                
            //    Cart tmp = cartService.GetCartById(id);
            //    cartService.updateCart(id, tmp);
            //    Console.WriteLine("Success!");
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void ViewCartByUser(int id_user)
        {
            List<Cart> carts = new List<Cart>();
            carts = cartService.GetCartByIdUser(id_user);
            foreach (Cart cart in carts)
            {
                Console.WriteLine($"ID: {cart.Id}, ID User = {cart.Id_user}, Data_created = {cart.Data_create}");
            }
        }
    }
}
