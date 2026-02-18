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
    internal class ConsoleApp
    {
        private UICart uCart;
        private UIPromo uPromo;
        private UIItemOrder uItemOrder;
        private UIItemCart uItemCart;
        private UIProduct uProduct;
        private UIOrder uOrder;
        private UIUser uUser;
        private int id_user;
        private Role role;
        string MENU_LOGIN = "\n0. Exit Program\n1. Login To Program\n2. Register\n>>Cmd: ";
        string MENU_ADMIN = "\n0. Logout\n1. List all users\n2. Add user\n3. Update info user\n4. Delete user\n5. Change password\n>>Cmd: ";
        string MENU_SELLER = "\n0. Logout\n1. List all item\n2. Add item\n3. Update info item\n4. Delete item\n5. List all order\n6. Update status order\n7. Delete order\n" +
            "8. List items in order\n9. Delete item in orde\n10. Update info user\n11. Change password\n>>Cmd: ";
        string MENU_CLIENT = "\n0. Logout\n1. List all items\n2. Add new cart\n3. Update number of item\n4. Delete cart\n5. View cart\n6. List all items of cart \n7. Add item to cart\n8. Delete item from cart\n" +
            "9. List promocode\n10. Order\n11. Update info user\n12. Change password\n>>Cmd: ";
        public ConsoleApp(UICart UCart, UIPromo UPromo, UIItemOrder UItemOrder, UIItemCart UItemCart, UIProduct UProduct, UIOrder UOrder, UIUser UUser)
        {
            this.uCart = UCart;
            this.uPromo = UPromo;
            this.uItemOrder = UItemOrder;
            this.uItemCart = UItemCart;
            this.uProduct = UProduct;
            this.uOrder = UOrder;
            this.uUser = UUser;
            this.id_user = -1;
            this.role = Role.None;
        }

        public void menu()
        {
            if (this.role == Role.None)
            {
                Console.Write(MENU_LOGIN);
                int cmd = Convert.ToInt32(Console.ReadLine());
                switch (cmd)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        try
                        {
                            User user = this.uUser.Login();
                            if (user != null)
                            {
                                this.role = user.Role;
                                this.id_user = user.Id;
                                Console.WriteLine("Login success!");
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        break;
                    case 2:
                        this.uUser.Register();
                        break;
                }
            }
            else if (this.role == Role.Admin)
            {
                Console.Write(MENU_ADMIN);
                int cmd = Convert.ToInt32(Console.ReadLine());
                switch (cmd)
                {
                    case 0:
                        role = Role.None;
                        id_user = -1;
                        break;
                    case 1:
                        uUser.ViewAllUsers();
                        break;
                    case 2:
                        uUser.Register();
                        break;
                    case 3:
                        uUser.UpdateUserByAdmin();
                        break;
                    case 4:
                        uUser.DeleteUser();
                        break;
                    case 5:
                        uUser.ChangePassword(id_user);
                        break;
                }
            }
            else if (this.role == Role.Seller)
            {
                Console.Write(MENU_SELLER);
                int cmd = Convert.ToInt32(Console.ReadLine());
                switch (cmd)
                {
                    case 0:
                        role = Role.None;
                        id_user = -1;
                        break;
                    case 1:
                        uProduct.ViewAllProducts();
                        break;
                    case 2:
                        uProduct.AddProduct();
                        break;
                    case 3:
                        uProduct.UpdateProduct();
                        break;
                    case 4:
                        uProduct.DeleteProduct();
                        break;
                    case 5:
                        uOrder.ViewAllOrders();
                        break;
                    case 6:
                        uOrder.UpdateStatusOrder();
                        break;
                    case 7:
                        uOrder.DeleteOrder();
                        break;
                    case 8:
                        uItemOrder.ShowItemOrder();
                        break;
                    case 9:
                        uItemOrder.DeleteItemOrder();
                        break;
                    case 11:
                        uUser.UpdateUser(id_user);
                        break;
                    case 12:
                        uUser.ChangePassword(id_user);
                        break;
                }
            }
            else if (this.role == Role.Client)
            {
                Console.Write(MENU_CLIENT);
                int cmd = Convert.ToInt32(Console.ReadLine());
                switch (cmd)
                {
                    case 0:
                        role = Role.None;
                        id_user = -1;
                        break;
                    case 1:
                        uProduct.ViewAllProducts();
                        break;
                    case 2:
                        uCart.AddCart(id_user);
                        break;
                    case 3:
                        uCart.UpdateCart(id_user);
                        break;
                    case 4:
                        uCart.DeleteCart(id_user);
                        break;
                    case 5:
                        uCart.ViewCartByUser(id_user);
                        break;
                    case 6:
                        uItemCart.ShowItemCart();
                        break;
                    case 7:
                        uItemCart.AddItemCart();
                        break;
                    case 8:
                        uItemCart.DeleteItemCart();
                        break;
                    case 9:
                        uPromo.ViewAllPromos(id_user);
                        break;
                    case 10:
                        int id_order = -1;
                        int id_cart = -1;
                        id_order = uOrder.AddOrderWithCart(id_user);
                        if (id_order == -1) { Console.WriteLine("Error!"); return; }
                        try
                        {
                            Console.Write("Input id_cart: ");
                            id_cart = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception ex) { Console.WriteLine(ex.ToString());};
                        //check id_cart owner
                        List<ItemCart> itemCarts = uItemCart.GetItemCartByIdCart(id_cart);
                        uItemOrder.AddItemOrderByCart(id_order, itemCarts);
                        //When created order, cart will destroy
                        uItemCart.DelItemCartByCart(itemCarts);
                        uCart.DelCartByIdCart(id_cart);
                        //giam product
                        break;
                    case 11:
                        uUser.UpdateUser(id_user);
                        break;
                    case 12:
                        uUser.ChangePassword(id_user);
                        break;
                }
            }
            else
            { Console.WriteLine("Unexpected Behaviour!"); }
        }
    }
}
