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

namespace GUI.AppForm
{
    public partial class FormInfo : Form
    {
        private int id_user;
        private UserService userService;
        public FormInfo(int id_user, UserService userService)
        {
            this.userService = userService;
            this.id_user = id_user;
            InitializeComponent();
            User user = userService.GetUser(id_user);
            tbLogin.Text = user.Login;
            tbPassword.Text = user.Password;
            tbName.Text = user.Name;
            tbEmail.Text = user.Email;
            tbPhone.Text = user.Phone;
            tbAddress.Text = user.Address;
            tbRole.Text = user.Role.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                userService.UpdateUser(new User(id_user, tbName.Text, tbPhone.Text, tbAddress.Text, tbEmail.Text, tbLogin.Text, tbPassword.Text,
                                        (Role)Enum.Parse(typeof(Role), tbRole.Text, true)));
                MessageBox.Show("Info, Infomation saved");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
