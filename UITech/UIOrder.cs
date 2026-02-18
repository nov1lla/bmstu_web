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
    internal class UIOrder
    {
        private OrderService orderService;
        private UserService userService;

        public UIOrder(OrderService orderService, UserService userService)
        {
            this.orderService = orderService;
            this.userService = userService;
        }
        public void AddOrder()
        {
            try
            {
                Status status = Status.None;
                int id_user = -1, id_promo = -1;
                DateTime date = DateTime.Now;
                Console.Write("Input ID User: ");
                id_user = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input ID Promo: ");
                id_promo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input status: ");
                status = (Status)Enum.Parse(typeof(Status), Console.ReadLine());

                if (id_promo < 0 || id_user < 0) 
                    throw new InputError(); ;
                Order order = new Order(-1, status, date, id_user, id_promo);
                this.orderService.AddOrder(order);
                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UpdateStatusOrder()
        {
            try
            {
                Status status = Status.None;
                int id = -1;
                Console.Write("Input ID Order: ");
                id = Convert.ToInt32(Console.ReadLine());
                ShowOrder(id);
                Console.Write("Input status: ");
                status = (Status)Enum.Parse(typeof(Status), Console.ReadLine());
                Order order = orderService.GetOrderById(id);
                order.Status = status;
                orderService.UpdateOrder(order);
                Console.WriteLine("Success");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void ShowOrder(int id)
        {
            try
            {
                Order order = orderService.GetOrderById(id);
                Console.WriteLine($"ID: {order.Id}, status = {order.Status}, data_created = {order.Data_created}, id_user = {order.Id_user}, id_promo = {order.Id_promo}");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void DeleteOrder()
        {
            try
            {
                int id = -1;
                string answer = "";
                Console.Write("Input id: ");
                id = Convert.ToInt32(Console.ReadLine());

                ShowOrder(id);
                Console.Write("Delete this order? (y/n): ");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "y":
                        orderService.DelOrder(orderService.GetOrderById(id));
                        Console.WriteLine("Success!");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void ViewAllOrders()
        {
            List<Order> orders = new List<Order>();
            orders = orderService.GetAllOrders();
            foreach (Order order in orders)
            {
                Console.WriteLine($"ID: {order.Id}, status = {order.Status}, data_created = {order.Data_created}, id_user = {order.Id_user}, id_promo = {order.Id_promo}");
            }
        }

        public int AddOrderWithCart(int id_user)
        {
            try
            {
                Status status = Status.Init;
                int id_promo = 1;
                Console.Write("Use promocode? (y/n): ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "y":
                        Console.Write("Input ID promo: ");
                        id_promo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Success!");
                        break;
                    default:
                        break;
                }
                //check id promo co ton tai hay khong
                DateTime date = DateTime.Today;

                if (id_user < 0)
                    throw new InputError(); ;
                Order order = new Order(-1, status, date, id_user, id_promo);
                orderService.AddOrder(order);
                int id_order = orderService.GetIdOrder(status, date, id_user, id_promo);
                return id_order;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return -1; } 
        }
    }
}
