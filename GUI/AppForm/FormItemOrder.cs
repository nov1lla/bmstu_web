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

namespace GUI.AppForm
{
    public partial class FormItemOrder : Form
    {
        ItemOrderService itemOrderService;
        OrderService orderService;
        ProductService productService;
        private int id_order;
        public FormItemOrder(int id_order, ItemOrderService itemOrderService, OrderService orderService, ProductService productService)
        {
            this.id_order = id_order;
            this.itemOrderService = itemOrderService;
            this.orderService = orderService;
            this.productService = productService;
            InitializeComponent();
            updateDataTable();
        }
        public void updateDataTable()
        {
            dgItemOrders.DataSource = itemOrderService.GetItemOrderByIdOrder(id_order);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgItemOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId < 0) { rowId = 0; }
            DataGridViewRow row = dgItemOrders.Rows[rowId];
            tbProduct.Text = productService.GetProductById(Convert.ToInt32(row.Cells[1].Value.ToString())).Name;
            tbQuantity.Text = row.Cells[3].Value.ToString();
        }
    }
}
