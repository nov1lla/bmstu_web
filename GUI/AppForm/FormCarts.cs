using BL.Models;
using BL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI.AppForm
{
    public partial class FormCarts : Form
    {
        private int id_user;
        private int cur_id_cart;
        private UserService userService;
        private PromoService promoService;
        private CartService cartService;
        private ItemCartService itemCartService;
        private ProductService productService;
        private OrderService orderService;
        private ItemOrderService itemOrderService;
        private bool used_promo = false;
        private int total_prevous = 0;
        public FormCarts(int id_user, CartService cartService, PromoService promoService, UserService userService, ItemCartService itemCartService, ProductService productService, OrderService orderService, ItemOrderService itemOrderService)
        {
            this.id_user = id_user;
            this.cartService = cartService;
            this.promoService = promoService;
            this.userService = userService;
            this.itemCartService = itemCartService;
            this.productService = productService;
            this.orderService = orderService;
            this.itemOrderService = itemOrderService;
            InitializeComponent();
            updateDataTable();
            setValueComboBox();
            this.itemOrderService = itemOrderService;
        }

        public void setValueComboBox()
        {
            List<Promo> promos = promoService.GetPromoByIdUser(id_user);
            foreach (Promo promo in promos)
            {
                cbPromo.Items.Add(promo.Code);
            }
        }
        public void updateDataTable()
        {
            dgCarts.DataSource = cartService.GetCartByIdUser(id_user);
            tbTotal.Text = string.Empty;
            cbPromo.Text = string.Empty;
        }
        private void dgCarts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cartService.AddCart(new Cart(-1, DateTime.Now, id_user));
            updateDataTable();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            cartService.DelCart(new Cart(cur_id_cart, DateTime.Now, id_user));
            updateDataTable();
        }

        private void dgCarts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId < 0) { rowId = 0; }
            DataGridViewRow row = dgCarts.Rows[rowId];
            cur_id_cart = Convert.ToInt32(row.Cells[0].Value.ToString());
            int total = 0;
            List<ItemCart> all = itemCartService.GetAllItemCartByIdCart(cur_id_cart);
            foreach (ItemCart item in all)
            {
                total += productService.GetProductById(item.Id_product).Price * item.Quantity;
            }

            total_prevous = total;
            tbTotal.Text = total.ToString();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int id_promo;
                UserPromo userPromo;
                if (chbUsePromocode.Checked == false)
                {
                    id_promo = 1; // trong database se de 1 la default
                    userPromo = new UserPromo(0, id_user, id_promo);
                }
                else
                {
                    if (cbPromo.Text == "")
                        throw new Exception("Please choose promocode");
                    id_promo = promoService.GetPromoByCode(cbPromo.Text).Id;
                    userPromo = new UserPromo(-1, id_user, id_promo);
                }
                orderService.AddOrder(new Order(-1, Status.Init, DateTime.Now, id_user, id_promo));
                int id_order = orderService.GetIdOrder(Status.Init, DateTime.Now, id_user, id_promo);
                List<ItemCart> itemCarts = itemCartService.GetAllItemCartByIdCart(cur_id_cart);
                foreach (ItemCart itemCart in itemCarts)
                {
                    itemOrderService.AddItemOrder(new ItemOrder(-1, itemCart.Id_product, id_order, itemCart.Quantity));
                }
                promoService.DelUserPromo(userPromo);
                cartService.DelCart(cartService.GetCartById(cur_id_cart));
                updateDataTable();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbTotal.Text == "" || cbPromo.Text == "")
                    throw new Exception("Please choose promocode");
                if (chbUsePromocode.Checked && tbTotal.Text != "")
                {
                    if (used_promo == false)
                    {
                        tbTotal.Text = (Convert.ToInt32(tbTotal.Text) * promoService.GetPromoByCode(cbPromo.Text).Discount / 100).ToString();
                        used_promo = true;
                        btnUse.Text = "Cancel";
                        cbPromo.Enabled = false;
                    }
                    else
                    {
                        cbPromo.Enabled = true;
                        btnUse.Text = "Apply";
                        used_promo = false;
                        tbTotal.Text = total_prevous.ToString();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void dgCarts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) { rowID = 0; }
            DataGridViewRow row = dgCarts.Rows[rowID];
            cur_id_cart = Convert.ToInt32(row.Cells[0].Value.ToString());

            FormItemCart formItemCart = new FormItemCart(cur_id_cart, itemCartService, cartService, productService);
            formItemCart.Show();
        }
    }
}
