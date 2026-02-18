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
    internal class UIUser
    {
        private UserService userService;
        public UIUser(UserService userService)
        { 
            this.userService = userService;
        }
        public User Login()
        {
            try
            {
                Console.Write("Login: ");
                string login = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                if (login == null || password == null) return null;
                User user = this.userService.LogIn(login, password);
                return user;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return null; }
        }
        public void Register()
        {
            string login = string.Empty, password = string.Empty, address = string.Empty, name = string.Empty, email = string.Empty, phone = string.Empty;
            try
            {
                Console.Write("Input login: ");
                login = Console.ReadLine();

                Console.Write("Input password: ");
                password = Console.ReadLine();

                Console.Write("Input name: ");
                name = Console.ReadLine();

                Console.Write("Input address: ");
                address = Console.ReadLine();

                Console.Write("Input email: ");
                email = Console.ReadLine();

                Console.Write("Input phone: ");
                phone = Console.ReadLine();

                if (login == "" || password == "" || name == "" || address == "" || email == "" || phone == "")
                    throw new InputError("Info user input wrong!!!");
                User user = userService.Register(name, phone, address, email, login, password, Role.Client);
                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ViewAllUsers()
        {
            List<User> users = userService.getAllUsers();
            foreach (User user in users)
            {
                Console.WriteLine($"ID: {user.Id}, Login: {user.Login}, Password: {user.Password}, Name: {user.Name}, Address: {user.Address}, Email: {user.Email}, Phone: {user.Phone}, Role: {user.Role}\n");
            }
        }

        public void UpdateUserByAdmin()
        {
            string password = string.Empty, address = string.Empty, name = string.Empty, email = string.Empty, phone = string.Empty;
            int id;
            try
            {
                Console.Write("Input id: ");
                id = Convert.ToInt32(Console.ReadLine());

                showUser(id);

                Console.Write("Input name: ");
                name = Console.ReadLine();

                Console.Write("Input password: ");
                password = Console.ReadLine();

                Console.Write("Input address: ");
                address = Console.ReadLine();

                Console.Write("Input email: ");
                email = Console.ReadLine();

                Console.Write("Input phone: ");
                phone = Console.ReadLine();



                if (password == "" || address == "" || name == "" || email == "" || phone == "")
                {
                    throw new InputError();
                }
                User user_tmp = userService.GetUser(id);
                user_tmp.Name = name;
                user_tmp.Password = password;
                user_tmp.Address = address;
                user_tmp.Phone = phone;
                user_tmp.Email = email;
                userService.UpdateUser(user_tmp);
                Console.WriteLine("Update success!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UpdateUser(int id)
        {
            string address = string.Empty, name = string.Empty, email = string.Empty, phone = string.Empty;
            try
            {
                showUserWithoutID(id);
                
                Console.Write("Input name: ");
                name = Console.ReadLine();
                
                Console.Write("Input address: ");
                address = Console.ReadLine();

                Console.Write("Input email: ");
                email = Console.ReadLine();

                Console.Write("Input phone: ");
                phone = Console.ReadLine();



                if (address == "" || name == "" || email == "" || phone == "")
                {
                    throw new InputError();
                }
                User user_tmp = userService.GetUser(id);
                user_tmp.Name = name;
                user_tmp.Address = address;
                user_tmp.Phone = phone;
                user_tmp.Email = email;
                userService.UpdateUser(user_tmp);
                Console.WriteLine("Update success!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ChangePassword(int id)
        {
            try
            {
                User cur_user = userService.GetUser(id);
                string password = "";
                Console.Write("Input old password: ");
                password = Console.ReadLine();
                if (password != cur_user.Password)
                {
                    Console.WriteLine("Wrong password!");
                    return;
                }
                string new_password = "";
                Console.Write("Input new password: ");
                new_password = Console.ReadLine();
                if (new_password == "")
                    throw new InputError();
                cur_user.Password = new_password;
                userService.UpdateUser(cur_user);
                Console.WriteLine("Change success!");
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        public void showUser(int id)
        {
            try
            {
                User user = userService.GetUser(id);
                Console.WriteLine($"ID: {user.Id}, Login: {user.Login}, Password: {user.Password}, Address: {user.Address}, Name: {user.Name}, Email: {user.Email}, Phone: {user.Phone}, Role: {user.Role}\n");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void showUserWithoutID(int id)
        {
            try
            {
                User user = userService.GetUser(id);
                Console.WriteLine($"Name: {user.Name}, Address: {user.Address},  Email: {user.Email}, Phone: {user.Phone}\n");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void DeleteUser()
        {
            try
            {
                int id = -1;
                string answer = "";
                Console.Write("Input id: ");
                id = Convert.ToInt32(Console.ReadLine());

                showUser(id);
                Console.Write("Delete this user? (y/n): ");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "y":
                        userService.DeleteUser(userService.GetUser(id));
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
