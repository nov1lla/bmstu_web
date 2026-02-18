namespace GUI.AppForm
{
    partial class FormViewUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbPhone = new TextBox();
            label4 = new Label();
            tbAddress = new TextBox();
            label5 = new Label();
            tbEmail = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cbRole = new ComboBox();
            btnAdd = new Button();
            btnDel = new Button();
            btnUpdate = new Button();
            tbName = new TextBox();
            labelName = new Label();
            tbPassword = new TextBox();
            labelpw = new Label();
            tbLogin = new TextBox();
            label1 = new Label();
            dgUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgUsers).BeginInit();
            SuspendLayout();
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(441, 380);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(216, 27);
            tbPhone.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(361, 383);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Phone";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(441, 425);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(216, 27);
            tbAddress.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(361, 428);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 9;
            label5.Text = "Address";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(441, 471);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(216, 27);
            tbEmail.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(361, 473);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 11;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 520);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 13;
            label7.Text = "Role";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Client", "Seller" });
            cbRole.Location = new Point(110, 517);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(215, 28);
            cbRole.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(161, 557);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 44);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(329, 557);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 44);
            btnDel.TabIndex = 16;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(496, 557);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 44);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(110, 470);
            tbName.Name = "tbName";
            tbName.Size = new Size(215, 27);
            tbName.TabIndex = 23;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(11, 474);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 22;
            labelName.Text = "Name";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(110, 425);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(215, 27);
            tbPassword.TabIndex = 21;
            // 
            // labelpw
            // 
            labelpw.AutoSize = true;
            labelpw.Location = new Point(11, 428);
            labelpw.Name = "labelpw";
            labelpw.Size = new Size(70, 20);
            labelpw.TabIndex = 20;
            labelpw.Text = "Password";
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(110, 380);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(215, 27);
            tbLogin.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 383);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 18;
            label1.Text = "Login";
            // 
            // dgUsers
            // 
            dgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsers.Dock = DockStyle.Top;
            dgUsers.Location = new Point(0, 0);
            dgUsers.Name = "dgUsers";
            dgUsers.RowHeadersWidth = 51;
            dgUsers.RowTemplate.Height = 29;
            dgUsers.Size = new Size(704, 355);
            dgUsers.TabIndex = 24;
            dgUsers.CellClick += dgUsers_CellClick;
            // 
            // FormViewUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(704, 627);
            Controls.Add(dgUsers);
            Controls.Add(tbName);
            Controls.Add(labelName);
            Controls.Add(tbPassword);
            Controls.Add(labelpw);
            Controls.Add(tbLogin);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(cbRole);
            Controls.Add(label7);
            Controls.Add(tbEmail);
            Controls.Add(label6);
            Controls.Add(tbAddress);
            Controls.Add(label5);
            Controls.Add(tbPhone);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormViewUsers";
            StartPosition = FormStartPosition.Manual;
            Text = "FormViewUsers";
            ((System.ComponentModel.ISupportInitialize)dgUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbPhone;
        private Label label4;
        private TextBox tbAddress;
        private Label label5;
        private TextBox tbEmail;
        private Label label6;
        private Label label7;
        private ComboBox cbRole;
        private Button btnAdd;
        private Button btnDel;
        private Button btnUpdate;
        private TextBox tbName;
        private Label labelName;
        private TextBox tbPassword;
        private Label labelpw;
        private TextBox tbLogin;
        private Label label1;
        private DataGridView dgUsers;
    }
}