namespace GUI.AppForm
{
    partial class FormSelller
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
            btnViewOrders = new Button();
            btnViewProducts = new Button();
            panel2 = new Panel();
            button2 = new Button();
            btnInfo = new Button();
            pictureBox1 = new PictureBox();
            panelMain = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnViewOrders);
            panel1.Controls.Add(btnViewProducts);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnInfo);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 627);
            panel1.TabIndex = 13;
            // 
            // btnViewOrders
            // 
            btnViewOrders.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewOrders.Location = new Point(70, 282);
            btnViewOrders.Name = "btnViewOrders";
            btnViewOrders.Size = new Size(176, 31);
            btnViewOrders.TabIndex = 14;
            btnViewOrders.Text = "View orders";
            btnViewOrders.UseVisualStyleBackColor = true;
            btnViewOrders.Click += btnViewOrders_Click;
            // 
            // btnViewProducts
            // 
            btnViewProducts.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewProducts.Location = new Point(70, 234);
            btnViewProducts.Name = "btnViewProducts";
            btnViewProducts.Size = new Size(176, 31);
            btnViewProducts.TabIndex = 12;
            btnViewProducts.Text = "View products";
            btnViewProducts.UseVisualStyleBackColor = true;
            btnViewProducts.Click += btnViewProducts_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(343, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(754, 630);
            panel2.TabIndex = 11;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.client1;
            pictureBox1.Location = new Point(104, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Right;
            panelMain.Location = new Point(337, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(704, 627);
            panelMain.TabIndex = 14;
            // 
            // FormSelller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 627);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(400, 200);
            Name = "FormSelller";
            StartPosition = FormStartPosition.Manual;
            Text = "FormSelller";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnViewOrders;
        private Button btnViewProducts;
        private Panel panel2;
        private Button button2;
        private Button btnInfo;
        private PictureBox pictureBox1;
        private Panel panelMain;
    }
}