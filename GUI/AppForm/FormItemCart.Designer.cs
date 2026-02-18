namespace GUI.AppForm
{
    partial class FormItemCart
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
            tbProduct = new TextBox();
            labelpw = new Label();
            tbQuantity = new TextBox();
            label5 = new Label();
            dgItemCarts = new DataGridView();
            btnDel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgItemCarts).BeginInit();
            SuspendLayout();
            // 
            // tbProduct
            // 
            tbProduct.Location = new Point(285, 399);
            tbProduct.Name = "tbProduct";
            tbProduct.Size = new Size(196, 27);
            tbProduct.TabIndex = 80;
            // 
            // labelpw
            // 
            labelpw.AutoSize = true;
            labelpw.Location = new Point(153, 402);
            labelpw.Name = "labelpw";
            labelpw.Size = new Size(60, 20);
            labelpw.TabIndex = 79;
            labelpw.Text = "Product";
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(285, 463);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(199, 27);
            tbQuantity.TabIndex = 78;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 468);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 77;
            label5.Text = "Quantity";
            // 
            // dgItemCarts
            // 
            dgItemCarts.BackgroundColor = SystemColors.Control;
            dgItemCarts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgItemCarts.Dock = DockStyle.Top;
            dgItemCarts.Location = new Point(0, 0);
            dgItemCarts.Name = "dgItemCarts";
            dgItemCarts.RowHeadersWidth = 51;
            dgItemCarts.RowTemplate.Height = 29;
            dgItemCarts.Size = new Size(704, 342);
            dgItemCarts.TabIndex = 76;
            dgItemCarts.CellClick += dgItemCarts_CellClick_1;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(285, 523);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(196, 37);
            btnDel.TabIndex = 81;
            btnDel.Text = "Delete item";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // FormItemCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 627);
            Controls.Add(btnDel);
            Controls.Add(tbProduct);
            Controls.Add(labelpw);
            Controls.Add(tbQuantity);
            Controls.Add(label5);
            Controls.Add(dgItemCarts);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(730, 200);
            Name = "FormItemCart";
            StartPosition = FormStartPosition.Manual;
            Text = "FormItemCart";
            ((System.ComponentModel.ISupportInitialize)dgItemCarts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbProduct;
        private Label labelpw;
        private TextBox tbQuantity;
        private Label label5;
        private DataGridView dgItemCarts;
        private Button btnDel;
    }
}