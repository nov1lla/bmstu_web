namespace GUI.AppForm
{
    partial class FormItemOrder
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
            dgItemOrders = new DataGridView();
            tbProduct = new TextBox();
            labelpw = new Label();
            tbQuantity = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgItemOrders).BeginInit();
            SuspendLayout();
            // 
            // dgItemOrders
            // 
            dgItemOrders.BackgroundColor = SystemColors.Control;
            dgItemOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgItemOrders.Dock = DockStyle.Top;
            dgItemOrders.Location = new Point(0, 0);
            dgItemOrders.Name = "dgItemOrders";
            dgItemOrders.RowHeadersWidth = 51;
            dgItemOrders.RowTemplate.Height = 29;
            dgItemOrders.Size = new Size(704, 342);
            dgItemOrders.TabIndex = 66;
            dgItemOrders.CellClick += dgItemOrders_CellClick;
            // 
            // tbProduct
            // 
            tbProduct.Location = new Point(282, 385);
            tbProduct.Name = "tbProduct";
            tbProduct.Size = new Size(196, 27);
            tbProduct.TabIndex = 75;
            // 
            // labelpw
            // 
            labelpw.AutoSize = true;
            labelpw.Location = new Point(150, 388);
            labelpw.Name = "labelpw";
            labelpw.Size = new Size(60, 20);
            labelpw.TabIndex = 72;
            labelpw.Text = "Product";
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(282, 449);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(199, 27);
            tbQuantity.TabIndex = 70;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 454);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 69;
            label5.Text = "Quantity";
            // 
            // FormItemOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 627);
            Controls.Add(tbProduct);
            Controls.Add(labelpw);
            Controls.Add(tbQuantity);
            Controls.Add(label5);
            Controls.Add(dgItemOrders);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(730, 200);
            Name = "FormItemOrder";
            StartPosition = FormStartPosition.Manual;
            Text = "FormItemOrder";
            ((System.ComponentModel.ISupportInitialize)dgItemOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgItemOrders;
        private TextBox tbProduct;
        private Label labelpw;
        private TextBox tbQuantity;
        private Label label5;
    }
}