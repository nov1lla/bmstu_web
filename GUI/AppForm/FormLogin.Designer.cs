namespace GUI.AppForm
{
    partial class FormLogin
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
            btnSignUp = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            tbUsername = new TextBox();
            btnSignIn = new Button();
            label6 = new Label();
            tbPassword = new TextBox();
            label5 = new Label();
            cbShowPassword = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 450);
            panel1.TabIndex = 0;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.Highlight;
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(57, 402);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(203, 36);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 356);
            label1.Name = "label1";
            label1.Size = new Size(213, 28);
            label1.TabIndex = 3;
            label1.Text = "Welcome to Testchovui";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(57, 251);
            label2.Name = "label2";
            label2.Size = new Size(213, 28);
            label2.TabIndex = 2;
            label2.Text = "Welcome to Testchovui";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_laptop_100;
            pictureBox1.Location = new Point(92, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 113);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(426, 55);
            label3.Name = "label3";
            label3.Size = new Size(195, 31);
            label3.TabIndex = 1;
            label3.Text = "Login to account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(426, 130);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 2;
            label4.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(426, 170);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(272, 27);
            tbUsername.TabIndex = 3;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.Highlight;
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(425, 332);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(94, 36);
            btnSignIn.TabIndex = 7;
            btnSignIn.Text = "SIGN IN";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(774, 7);
            label6.Name = "label6";
            label6.Size = new Size(21, 19);
            label6.TabIndex = 8;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(426, 259);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(272, 27);
            tbPassword.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(426, 219);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Location = new Point(566, 292);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(132, 24);
            cbShowPassword.TabIndex = 9;
            cbShowPassword.Text = "Show Password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbShowPassword);
            Controls.Add(label6);
            Controls.Add(btnSignIn);
            Controls.Add(tbPassword);
            Controls.Add(label5);
            Controls.Add(tbUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSignUp;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private TextBox tbUsername;
        private Button btnSignIn;
        private Label label6;
        private TextBox tbPassword;
        private Label label5;
        private CheckBox cbShowPassword;
    }
}