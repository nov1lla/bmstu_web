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
    internal class UIItemCart
    {
        private ItemCartService itemCartService;
        private CartService cartService;
        private ProductService productService;
        
        public UIItemCart(ItemCartService itemCartService, CartService cartService, ProductService productService)
        {
            this.itemCartService = itemCartService;
            this.cartService = cartService;
            this.productService = productService;
        }
        public void ShowItemByIdCart(int id_cart)
        {
            List<ItemCart> itemCarts = itemCartService.GetAllItemCartByIdCart(id_cart);
            foreach (ItemCart itemCart in itemCarts)
            {
                Console.WriteLine($"ID: {itemCart.Id}, ID Product: {itemCart.Id_product}, ID Cart: {itemCart.Id_cart}, Quantity: {itemCart.Quantity}");
            }
        }

        public void ShowItemById(int id)
        {
            ItemCart itemCart = itemCartService.GetItemCartById(id);
            Console.WriteLine($"ID: {itemCart.Id}, ID Product: {itemCart.Id_product}, ID Cart: {itemCart.Id_cart}, Quantity: {itemCart.Quantity}");
        }

        public List<ItemCart> GetItemCartByIdCart(int id_cart)
        {
            return itemCartService.GetAllItemCartByIdCart(id_cart);
        }
        public void ShowItemCart()
        {
            try
            {
                int id_cart = -1;
                Console.Write("Input id_cart: ");
                id_cart = Convert.ToInt32(Console.ReadLine());
                ShowItemByIdCart(id_cart);
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); };
        }
        public void AddItemCart()
        {
            try
            {
                int id_cart = -1, id_product = -1, quantity = -1;
                Console.Write("Input ID cart: ");
                id_cart = Convert.ToInt32(Console.ReadLine());
                ShowItemByIdCart(id_cart);

                Console.Write("Input ID product: ");
                id_product = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input quantity: ");
                quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity < 0 || id_product < 0)
                    throw new InputError();

                ItemCart tmp = itemCartService.GetItemCartByIds(id_cart, id_product);
                if (tmp == null)
                {
                    itemCartService.AddItemCart(new ItemCart(-1, id_product, id_cart, quantity));
                }
                else
                {
                    tmp.Quantity += quantity;
                    itemCartService.UpdateItemCart(tmp);
                }
                Console.WriteLine("Succes!");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void updateItemCart()
        {
            try
            {
                int id = -1, id_cart = -1, id_product = -1, quantity = -1;
                Console.Write("Input ID cart: ");
                id_cart = Convert.ToInt32(Console.ReadLine());

                ShowItemByIdCart(id_cart);

                Console.Write("Input ID itemCart: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input ID product: ");
                id_product = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input quantity: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                if (quantity < 0 || id_product < 0)
                    throw new InputError();
                ItemCart tmp = itemCartService.GetItemCartById(id);
                tmp.Quantity = quantity;
                tmp.Id_product = id_product;
                itemCartService.UpdateItemCart(new ItemCart(id, id_product, id_cart, quantity));
                Console.WriteLine("Succes!");
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
        public void DeleteItemCart()
        {
            try
            {
                int id_product_cart = -1, id_cart = -1;
                string answer = "";
                Console.Write("Input ID cart: ");
                id_cart = Convert.ToInt32(Console.ReadLine());
                ShowItemByIdCart(id_cart);
                Console.Write("Input ID itemCart: ");
                id_product_cart = Convert.ToInt32(Console.ReadLine());
                Console.Write("Delete this item? (y/n): ");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "y":
                        itemCartService.DelItemCart(itemCartService.GetItemCartById(id_product_cart));
                        Console.WriteLine("Success!");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) { Console.WriteLine (ex.ToString()); } 
        }
        public void AddItemCartByCart(int id_cart, List<Cart> carts)
        {
            //try
            //{
            //    foreach (Cart cart in carts)
            //    {
            //        itemCartService.addItemCart(new ItemCart(id_cart, cart.Id_item, cart.Number));
            //    }
            //    Console.WriteLine("Success!");
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message); }
            ;
        }
        public void DelItemCartByCart(List<ItemCart> itemCarts)
        {
            try
            {
                foreach (ItemCart itemCart in itemCarts)
                {
                    itemCartService.DelItemCart(itemCart);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            ;
        }
    }

}
