namespace GUI.AppForm
{
    partial class FormAdmin
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
            label6 = new Label();
            panelMain = new Panel();
            pictureBox1 = new PictureBox();
            btnInfo = new Button();
            btnViewUsers = new Button();
            button2 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            btnViewOrders = new Button();
            btnViewProducts = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(1076, 5);
            label6.Name = "label6";
            label6.Size = new Size(21, 19);
            label6.TabIndex = 9;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Right;
            panelMain.Location = new Point(330, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(708, 627);
            panelMain.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.client1;
            pictureBox1.Location = new Point(104, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnInfo
            // 
            btnInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnInfo.Location = new Point(70, 187);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(176, 31);
            btnInfo.TabIndex = 1;
            btnInfo.Text = "Infomation";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnViewUsers
            // 
            btnViewUsers.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewUsers.Location = new Point(70, 259);
            btnViewUsers.Name = "btnViewUsers";
            btnViewUsers.Size = new Size(176, 31);
            btnViewUsers.TabIndex = 5;
            btnViewUsers.Text = "View users";
            btnViewUsers.UseVisualStyleBackColor = true;
            btnViewUsers.Click += btnViewAllUsers_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(70, 571);
            button2.Name = "button2";
            button2.Size = new Size(176, 31);
            button2.TabIndex = 7;
            button2.Text = "Log out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(343, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(754, 630);
            panel2.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnViewOrders);
            panel1.Controls.Add(btnViewProducts);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnViewUsers);
            panel1.Controls.Add(btnInfo);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 627);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(70, 399);
            button1.Name = "button1";
            button1.Size = new Size(176, 31);
            button1.TabIndex = 14;
            button1.Text = "View promocodes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnViewOrders
            // 
            btnViewOrders.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewOrders.Location = new Point(70, 354);
            btnViewOrders.Name = "btnViewOrders";
            btnViewOrders.Size = new Size(176, 31);
            btnViewOrders.TabIndex = 13;
            btnViewOrders.Text = "View orders";
            btnViewOrders.UseVisualStyleBackColor = true;
            btnViewOrders.Click += btnViewOrders_Click;
            // 
            // btnViewProducts
            // 
            btnViewProducts.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewProducts.Location = new Point(70, 308);
            btnViewProducts.Name = "btnViewProducts";
            btnViewProducts.Size = new Size(176, 31);
            btnViewProducts.TabIndex = 12;
            btnViewProducts.Text = "View products";
            btnViewProducts.UseVisualStyleBackColor = true;
            btnViewProducts.Click += btnViewProducts_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 627);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Controls.Add(label6);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(400, 200);
            Margin = new Padding(4);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.Manual;
            Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Panel panelMain;
        private PictureBox pictureBox1;
        private Button btnInfo;
        private Button btnViewUsers;
        private Button button2;
        private Panel panel2;
        private Panel panel1;
        private Button btnViewOrders;
        private Button btnViewProducts;
        private Button button1;
    }
}