using BL.Services;
using BL.Models;
using BL.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyException;

namespace UITech
{
    internal class UIProduct
    {
        private ProductService productService;
        public UIProduct(ProductService productService)
        {
            this.productService = productService;
        }
        public void ViewAllProducts()
        {
            List<Product> items = productService.GetAllProducts();
            foreach (var item in items)
            {
                Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Price: {item.Price}, Quantity: {item.Quantity}, Manufacturer: {item.Manufacturer}, Description: {item.Description}\n");
            }
        }
        public void AddProduct() 
        {
            try
            {
                string name = "", description = "", manufacturer = "";
                int price = -1, quantity = -1;
                Console.Write("Input name: ");
                name = Console.ReadLine();

                Console.Write("Input description: ");
                description = Console.ReadLine();

                Console.Write("Input manufacturer: ");
                manufacturer = Console.ReadLine();

                Console.Write("Input price: ");
                price = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input quantity: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                if (name == "" || description == "" || manufacturer == "" || price < 0 || quantity < 0)
                    throw new InputError();

                Product item = new Product(-1, name, price, quantity, manufacturer, description);
                productService.AddProduct(item);
                Console.WriteLine("Success!");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void UpdateProduct()
        {
            try
            {
                string name = "", manufacturer = "", description = "";
                int price = -1, quantity = -1, id = -1;
                Console.Write("Input ID: ");
                id = Convert.ToInt32(Console.ReadLine());
                ShowProduct(id);
                Console.Write("Input name: ");
                name = Console.ReadLine();

                Console.Write("Input price: ");
                price = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Input quantity: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input description: ");
                description = Console.ReadLine();

                Console.Write("Input manufacturer: ");
                manufacturer = Console.ReadLine();

                if (name == "" || description == "" || manufacturer == "" || price < 0 || quantity < 0)
                    throw new InputError();

                Product item = new Product(id, name, price, quantity, manufacturer, description);
                productService.UpdateProduct(item);
                Console.WriteLine("Success!");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void ShowProduct(int id)
        {
            try
            {
                Product item = productService.GetProductById(id);
                Console.WriteLine($"ID: {item.Id}, Name = {item.Name}, Price = {item.Price}, Quantity = {item.Quantity}, Manufacturer = {item.Manufacturer}, Description = {item.Description}");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void DeleteProduct()
        {
            //khong kiem tra seller
            try
            {
                int id = -1;
                string answer = "";

                Console.Write("Input id: ");
                id = Convert.ToInt32(Console.ReadLine());

                ShowProduct(id);
                Console.Write("Delete this item? (y/n): ");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "y":
                        productService.DelProduct(productService.GetProductById(id));
                        Console.WriteLine("Success!");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
