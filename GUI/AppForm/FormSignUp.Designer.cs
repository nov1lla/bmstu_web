namespace GUI.AppForm
{
    partial class FormSignUp
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
            panel1 = new Panel();
            btnSignIn = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnSignUp = new Button();
            tbLogin = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tbPassword = new TextBox();
            label5 = new Label();
            tbAddress = new TextBox();
            label6 = new Label();
            tbPhoneNumber = new TextBox();
            label7 = new Label();
            tbEmail = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tbUsername = new TextBox();
            cbRole = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 562);
            panel1.TabIndex = 1;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.Highlight;
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(71, 502);
            btnSignIn.Margin = new Padding(4, 4, 4, 4);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(254, 45);
            btnSignIn.TabIndex = 8;
            btnSignIn.Text = "SIGN IN";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 445);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(262, 32);
            label1.TabIndex = 3;
            label1.Text = "Welcome to Testchovui";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(71, 314);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(262, 32);
            label2.TabIndex = 2;
            label2.Text = "Welcome to Testchovui";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_laptop_100;
            pictureBox1.Location = new Point(115, 138);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 141);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.Highlight;
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(510, 479);
            btnSignUp.Margin = new Padding(4, 4, 4, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(118, 45);
            btnSignUp.TabIndex = 11;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(641, 102);
            tbLogin.Margin = new Padding(4, 4, 4, 4);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(260, 31);
            tbLogin.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(510, 102);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 32);
            label4.TabIndex = 9;
            label4.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(510, 39);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(302, 38);
            label3.TabIndex = 8;
            label3.Text = "Register your account";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(641, 155);
            tbPassword.Margin = new Padding(4, 4, 4, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(260, 31);
            tbPassword.TabIndex = 13;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(510, 155);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 12;
            label5.Text = "Password";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(641, 262);
            tbAddress.Margin = new Padding(4, 4, 4, 4);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(260, 31);
            tbAddress.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(510, 262);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 32);
            label6.TabIndex = 14;
            label6.Text = "Address";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(641, 314);
            tbPhoneNumber.Margin = new Padding(4, 4, 4, 4);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(258, 31);
            tbPhoneNumber.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(508, 312);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 32);
            label7.TabIndex = 16;
            label7.Text = "Phone";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(641, 365);
            tbEmail.Margin = new Padding(4, 4, 4, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(260, 31);
            tbEmail.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(510, 365);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 32);
            label8.TabIndex = 18;
            label8.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(964, 10);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(24, 23);
            label9.TabIndex = 20;
            label9.Text = "X";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(508, 415);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(60, 32);
            label10.TabIndex = 21;
            label10.Text = "Role";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(510, 209);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(121, 32);
            label11.TabIndex = 21;
            label11.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(641, 209);
            tbUsername.Margin = new Padding(4, 4, 4, 4);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(260, 31);
            tbUsername.TabIndex = 22;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Seller", "Client" });
            cbRole.Location = new Point(641, 415);
            cbRole.Margin = new Padding(4, 4, 4, 4);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(260, 33);
            cbRole.TabIndex = 23;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(cbRole);
            Controls.Add(tbUsername);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(tbEmail);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(tbPhoneNumber);
            Controls.Add(label7);
            Controls.Add(tbAddress);
            Controls.Add(label6);
            Controls.Add(tbPassword);
            Controls.Add(label5);
            Controls.Add(btnSignUp);
            Controls.Add(tbLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSignUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSignIn;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnSignUp;
        private TextBox tbLogin;
        private Label label4;
        private Label label3;
        private TextBox tbPassword;
        private Label label5;
        private TextBox tbAddress;
        private Label label6;
        private TextBox tbPhoneNumber;
        private Label label7;
        private TextBox tbEmail;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tbUsername;
        private ComboBox cbRole;
    }
}