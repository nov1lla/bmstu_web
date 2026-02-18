namespace GUI.AppForm
{
    partial class FormCarts
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
            btnDel = new Button();
            btnAdd = new Button();
            btnOrder = new Button();
            chbUsePromocode = new CheckBox();
            tbTotal = new TextBox();
            dgCarts = new DataGridView();
            cbPromo = new ComboBox();
            label1 = new Label();
            btnUse = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCarts).BeginInit();
            SuspendLayout();
            // 
            // btnDel
            // 
            btnDel.Location = new Point(424, 400);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 44);
            btnDel.TabIndex = 60;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(226, 400);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 44);
            btnAdd.TabIndex = 61;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(555, 500);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 44);
            btnOrder.TabIndex = 62;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // chbUsePromocode
            // 
            chbUsePromocode.AutoSize = true;
            chbUsePromocode.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            chbUsePromocode.Location = new Point(74, 546);
            chbUsePromocode.Name = "chbUsePromocode";
            chbUsePromocode.Size = new Size(150, 27);
            chbUsePromocode.TabIndex = 63;
            chbUsePromocode.Text = "Use Promocode";
            chbUsePromocode.UseVisualStyleBackColor = true;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(226, 493);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(151, 27);
            tbTotal.TabIndex = 64;
            // 
            // dgCarts
            // 
            dgCarts.BackgroundColor = SystemColors.Control;
            dgCarts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCarts.Dock = DockStyle.Top;
            dgCarts.Location = new Point(0, 0);
            dgCarts.Name = "dgCarts";
            dgCarts.RowHeadersWidth = 51;
            dgCarts.RowTemplate.Height = 29;
            dgCarts.Size = new Size(704, 342);
            dgCarts.TabIndex = 65;
            dgCarts.CellClick += dgCarts_CellClick;
            dgCarts.CellContentClick += dgCarts_CellContentClick;
            dgCarts.CellDoubleClick += dgCarts_CellDoubleClick;
            // 
            // cbPromo
            // 
            cbPromo.FormattingEnabled = true;
            cbPromo.Location = new Point(226, 545);
            cbPromo.Name = "cbPromo";
            cbPromo.Size = new Size(151, 28);
            cbPromo.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, 500);
            label1.Name = "label1";
            label1.Size = new Size(49, 23);
            label1.TabIndex = 67;
            label1.Text = "Total";
            // 
            // btnUse
            // 
            btnUse.Location = new Point(398, 546);
            btnUse.Name = "btnUse";
            btnUse.Size = new Size(66, 28);
            btnUse.TabIndex = 68;
            btnUse.Text = "Apply";
            btnUse.UseVisualStyleBackColor = true;
            btnUse.Click += btnUse_Click;
            // 
            // FormCarts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 627);
            Controls.Add(btnUse);
            Controls.Add(label1);
            Controls.Add(cbPromo);
            Controls.Add(dgCarts);
            Controls.Add(tbTotal);
            Controls.Add(chbUsePromocode);
            Controls.Add(btnOrder);
            Controls.Add(btnAdd);
            Controls.Add(btnDel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCarts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCarts";
            ((System.ComponentModel.ISupportInitialize)dgCarts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDel;
        private Button btnAdd;
        private Button btnOrder;
        private CheckBox chbUsePromocode;
        private TextBox tbTotal;
        private DataGridView dgCarts;
        private ComboBox cbPromo;
        private Label label1;
        private Button btnUse;
    }
}