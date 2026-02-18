namespace GUI.AppForm
{
    partial class FormViewProductsByClient
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
            dgProducts = new DataGridView();
            btnAdd = new Button();
            tbManufacturer = new TextBox();
            labelpw = new Label();
            tbName = new TextBox();
            label1 = new Label();
            tbDescription = new TextBox();
            label6 = new Label();
            tbQuantity = new TextBox();
            label5 = new Label();
            tbPrice = new TextBox();
            label4 = new Label();
            label2 = new Label();
            cbCarts = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            SuspendLayout();
            // 
            // dgProducts
            // 
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Dock = DockStyle.Top;
            dgProducts.Location = new Point(0, 0);
            dgProducts.Name = "dgProducts";
            dgProducts.RowHeadersWidth = 51;
            dgProducts.RowTemplate.Height = 29;
            dgProducts.Size = new Size(704, 350);
            dgProducts.TabIndex = 79;
            dgProducts.CellClick += dgProducts_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(427, 543);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 44);
            btnAdd.TabIndex = 76;
            btnAdd.Text = "Add to Cart";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbManufacturer
            // 
            tbManufacturer.Enabled = false;
            tbManufacturer.Location = new Point(129, 416);
            tbManufacturer.Name = "tbManufacturer";
            tbManufacturer.Size = new Size(201, 27);
            tbManufacturer.TabIndex = 75;
            // 
            // labelpw
            // 
            labelpw.AutoSize = true;
            labelpw.Location = new Point(0, 419);
            labelpw.Name = "labelpw";
            labelpw.Size = new Size(97, 20);
            labelpw.TabIndex = 74;
            labelpw.Text = "Manufacturer";
            // 
            // tbName
            // 
            tbName.Enabled = false;
            tbName.Location = new Point(129, 371);
            tbName.Name = "tbName";
            tbName.Size = new Size(201, 27);
            tbName.TabIndex = 73;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 374);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 72;
            label1.Text = "Name";
            // 
            // tbDescription
            // 
            tbDescription.Enabled = false;
            tbDescription.Location = new Point(129, 462);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(533, 27);
            tbDescription.TabIndex = 71;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 465);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 70;
            label6.Text = "Description";
            // 
            // tbQuantity
            // 
            tbQuantity.Enabled = false;
            tbQuantity.Location = new Point(446, 416);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(216, 27);
            tbQuantity.TabIndex = 69;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(351, 416);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 68;
            label5.Text = "Quantity";
            // 
            // tbPrice
            // 
            tbPrice.Enabled = false;
            tbPrice.Location = new Point(446, 371);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(216, 27);
            tbPrice.TabIndex = 67;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 371);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 66;
            label4.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 555);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 80;
            label2.Text = "Choose Cart";
            // 
            // cbCarts
            // 
            cbCarts.FormattingEnabled = true;
            cbCarts.Location = new Point(237, 550);
            cbCarts.Name = "cbCarts";
            cbCarts.Size = new Size(93, 28);
            cbCarts.TabIndex = 81;
            // 
            // FormViewProductsByClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 627);
            Controls.Add(cbCarts);
            Controls.Add(label2);
            Controls.Add(dgProducts);
            Controls.Add(btnAdd);
            Controls.Add(tbManufacturer);
            Controls.Add(labelpw);
            Controls.Add(tbName);
            Controls.Add(label1);
            Controls.Add(tbDescription);
            Controls.Add(label6);
            Controls.Add(tbQuantity);
            Controls.Add(label5);
            Controls.Add(tbPrice);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormViewProductsByClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormViewProductsByClient";
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProducts;
        private Button btnAdd;
        private TextBox tbManufacturer;
        private Label labelpw;
        private TextBox tbName;
        private Label label1;
        private TextBox tbDescription;
        private Label label6;
        private TextBox tbQuantity;
        private Label label5;
        private TextBox tbPrice;
        private Label label4;
        private Label label2;
        private ComboBox cbCarts;
    }
}