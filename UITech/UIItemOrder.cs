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
    internal class UIItemOrder
    {
        private ItemOrderService itemOrderService;
        private OrderService orderService;
        private ProductService productService;
        
        public UIItemOrder(ItemOrderService itemOrderService, OrderService orderService, ProductService productService)
        {
            this.itemOrderService = itemOrderService;
            this.orderService = orderService;
            this.productService = productService;
        }
        public void ShowItemByIdOrder(int id_order)
        {
            List<ItemOrder> itemOrders = itemOrderService.GetItemOrderByIdOrder(id_order);
            foreach (ItemOrder itemOrder in itemOrders)
            {
                Console.WriteLine($"ID: {itemOrder.Id}, ID Product: {itemOrder.Id_product}, ID Order: {itemOrder.Id_order}, Quantity: {itemOrder.Quantity}");
            }
        }

        public void ShowItemById(int id)
        {
            ItemOrder itemOrder = itemOrderService.GetItemOrderById(id);
            Console.WriteLine($"ID: {itemOrder.Id}, ID Product: {itemOrder.Id_product}, ID Order: {itemOrder.Id_order}, Quantity: {itemOrder.Quantity}");
        }

        public void ShowItemOrder()
        {
            try
            {
                int id_order = -1;
                Console.Write("Input id_order: ");
                id_order = Convert.ToInt32(Console.ReadLine());
                ShowItemByIdOrder(id_order);
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); };
        }
        public void AddItemOrder()
        {
            try
            {
                int id_order = -1, id_product = -1, quantity = -1;
                Console.Write("Input ID order: ");
                id_order = Convert.ToInt32(Console.ReadLine());
                ShowItemByIdOrder(id_order);

                Console.Write("Input ID product: ");
                id_product = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input quantity: ");
                quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity < 0 || id_product < 0)
                    throw new InputError();

                ItemOrder tmp = itemOrderService.GetItemOrderByIds(id_order, id_product);
                if (tmp == null)
                {
                    itemOrderService.AddItemOrder(new ItemOrder(-1, id_product, id_order, quantity));
                }
                else
                {
                    tmp.Quantity += quantity;
                    itemOrderService.UpdateItemOrder(tmp);
                }
                Console.WriteLine("Succes!");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void AddItemOrder(int id_order)
        {
            try
            {
                int id_product = -1, quantity = -1;
                
                Console.Write("Input ID product: ");
                id_product = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input quantity: ");
                quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity < 0 || id_product < 0)
                    throw new InputError();

                ItemOrder tmp = itemOrderService.GetItemOrderByIds(id_order, id_product);
                if (tmp == null)
                {
                    itemOrderService.AddItemOrder(new ItemOrder(-1, id_product, id_order, quantity));
                }
                else
                {
                    tmp.Quantity += quantity;
                    itemOrderService.UpdateItemOrder(tmp);
                }
                Console.WriteLine("Succes!");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void UpdateItemOrder()
        {
            try
            {
                int id = -1, id_order = -1, id_product = -1, quantity = -1;
                Console.Write("Input ID order: ");
                id_order = Convert.ToInt32(Console.ReadLine());

                ShowItemByIdOrder(id_order);

                Console.Write("Input ID itemOrder: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input ID product: ");
                id_product = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input quantity: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                if (quantity < 0 || id_product < 0)
                    throw new InputError();
                ItemOrder tmp = itemOrderService.GetItemOrderById(id);
                tmp.Quantity = quantity;
                tmp.Id_product = id_product;
                itemOrderService.UpdateItemOrder(new ItemOrder(id, id_product, id_order, quantity));
                Console.WriteLine("Succes!");
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
        public void DeleteItemOrder()
        {
            try
            {
                int id_product_order = -1, id_order = -1;
                string answer = "";
                Console.Write("Input ID order: ");
                id_order = Convert.ToInt32(Console.ReadLine());
                ShowItemByIdOrder(id_order);
                Console.Write("Input ID itemOrder: ");
                id_product_order = Convert.ToInt32(Console.ReadLine());
                Console.Write("Delete this item? (y/n): ");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "y":
                        itemOrderService.DelItemOrder(itemOrderService.GetItemOrderById(id_product_order));
                        Console.WriteLine("Success!");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) { Console.WriteLine (ex.ToString()); } 
        }
        public void AddItemOrderByCart(int id_order, List<ItemCart> itemCarts)
        {
            try
            {
                foreach (var itemCart in itemCarts)
                {
                    itemOrderService.AddItemOrder(new ItemOrder(-1, itemCart.Id_product, id_order, itemCart.Quantity));
                }
                Console.WriteLine("Success!");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            ;
        }
    }

}
