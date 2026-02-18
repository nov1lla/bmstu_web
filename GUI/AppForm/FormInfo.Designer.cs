namespace GUI.AppForm
{
    partial class FormInfo
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
            tbName = new TextBox();
            labelName = new Label();
            tbPassword = new TextBox();
            lbPassword = new Label();
            tbLogin = new TextBox();
            label1 = new Label();
            label7 = new Label();
            tbEmail = new TextBox();
            label6 = new Label();
            tbAddress = new TextBox();
            label5 = new Label();
            tbPhone = new TextBox();
            label4 = new Label();
            label2 = new Label();
            button1 = new Button();
            tbRole = new TextBox();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.ForeColor = Color.Black;
            tbName.Location = new Point(221, 205);
            tbName.Name = "tbName";
            tbName.Size = new Size(215, 27);
            tbName.TabIndex = 37;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.ForeColor = Color.Black;
            labelName.Location = new Point(122, 209);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 36;
            labelName.Text = "Name";
            // 
            // tbPassword
            // 
            tbPassword.ForeColor = Color.Black;
            tbPassword.Location = new Point(221, 160);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(215, 27);
            tbPassword.TabIndex = 35;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.ForeColor = Color.Black;
            lbPassword.Location = new Point(122, 163);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 34;
            lbPassword.Text = "Password";
            // 
            // tbLogin
            // 
            tbLogin.ForeColor = Color.Black;
            tbLogin.Location = new Point(221, 115);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(215, 27);
            tbLogin.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(122, 118);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 32;
            label1.Text = "Login";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(122, 255);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 30;
            label7.Text = "Role";
            // 
            // tbEmail
            // 
            tbEmail.ForeColor = Color.Black;
            tbEmail.Location = new Point(221, 387);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(216, 27);
            tbEmail.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(122, 389);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 28;
            label6.Text = "Email";
            // 
            // tbAddress
            // 
            tbAddress.ForeColor = Color.Black;
            tbAddress.Location = new Point(221, 341);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(216, 27);
            tbAddress.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(122, 344);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 26;
            label5.Text = "Address";
            // 
            // tbPhone
            // 
            tbPhone.ForeColor = Color.Black;
            tbPhone.Location = new Point(221, 296);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(216, 27);
            tbPhone.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(122, 299);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 24;
            label4.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(257, 30);
            label2.Name = "label2";
            label2.Size = new Size(150, 31);
            label2.TabIndex = 38;
            label2.Text = "Information ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(284, 454);
            button1.Name = "button1";
            button1.Size = new Size(94, 41);
            button1.TabIndex = 39;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbRole
            // 
            tbRole.Enabled = false;
            tbRole.ForeColor = Color.Black;
            tbRole.Location = new Point(222, 252);
            tbRole.Name = "tbRole";
            tbRole.Size = new Size(215, 27);
            tbRole.TabIndex = 40;
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(704, 627);
            Controls.Add(tbRole);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(labelName);
            Controls.Add(tbPassword);
            Controls.Add(lbPassword);
            Controls.Add(tbLogin);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(tbEmail);
            Controls.Add(label6);
            Controls.Add(tbAddress);
            Controls.Add(label5);
            Controls.Add(tbPhone);
            Controls.Add(label4);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInfo";
            Text = "FormViewAllUsers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private Label labelName;
        private TextBox tbPassword;
        private Label lbPassword;
        private TextBox tbLogin;
        private Label label1;
        private Label label7;
        private TextBox tbEmail;
        private Label label6;
        private TextBox tbAddress;
        private Label label5;
        private TextBox tbPhone;
        private Label label4;
        private Label label2;
        private Button button1;
        private TextBox tbRole;
    }
}