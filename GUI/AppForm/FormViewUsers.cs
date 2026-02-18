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
using BL.Models;
using System.Runtime.CompilerServices;

namespace GUI.AppForm
{
    public partial class FormViewUsers : Form
    {
        private UserService _userService;
        private int cur_id_user;
        public FormViewUsers(UserService userService)
        {
            this._userService = userService;
            InitializeComponent();
            updateDataTable();
        }

        public void updateDataTable()
        {
            dgUsers.DataSource = _userService.viewAllUsers();
            tbLogin.Text = "";
            tbPassword.Text = "";
            tbName.Text = "";
            tbAddress.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
            cbRole.Text = "";
        }

        private void dgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId < 0) { rowId = 0; }
            DataGridViewRow row = dgUsers.Rows[rowId];
            cur_id_user = Convert.ToInt32(row.Cells[0].Value.ToString());
            tbLogin.Text = row.Cells[1].Value.ToString();
            tbPassword.Text = row.Cells[2].Value.ToString();
            tbName.Text = row.Cells[3].Value.ToString();
            tbAddress.Text = row.Cells[4].Value.ToString();
            tbPhone.Text = row.Cells[5].Value.ToString();
            tbEmail.Text = row.Cells[6].Value.ToString();
            cbRole.Text = row.Cells[7].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_input_empty() == false)
                    throw new Exception("Input error");
                _userService.AddUser(new User(tbName.Text, tbPhone.Text, tbAddress.Text, tbEmail.Text, tbLogin.Text, tbPassword.Text,
                                        (Role)Enum.Parse(typeof(Role), cbRole.Text, true)));
                updateDataTable();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_input_empty() == false)
                    throw new Exception("Input error");
                _userService.DeleteUser(new User(cur_id_user, tbName.Text, tbPhone.Text, tbAddress.Text, tbEmail.Text, tbLogin.Text, tbPassword.Text,
                                        (Role)Enum.Parse(typeof(Role), cbRole.Text, true)));
                updateDataTable();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_input_empty() == false)
                    throw new Exception("Input error");
                _userService.UpdateUser(new User(cur_id_user, tbName.Text, tbPhone.Text, tbAddress.Text, tbEmail.Text, tbLogin.Text, tbPassword.Text,
                                        (Role)Enum.Parse(typeof(Role), cbRole.Text, true)));
                updateDataTable();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private bool check_input_empty()
        {
            if (tbLogin.Text == "" || tbPassword.Text == "" || tbName.Text == "" || tbPhone.Text == "" || tbEmail.Text == "" || cbRole.Text == "")
                return false;
            return true;
        }
    }
}
