namespace GUI.AppForm
{
    partial class FormViewProducts
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
            btnUpdate = new Button();
            btnDel = new Button();
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
            dgProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(484, 548);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 44);
            btnUpdate.TabIndex = 64;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(317, 548);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 44);
            btnDel.TabIndex = 63;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(149, 548);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 44);
            btnAdd.TabIndex = 62;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbManufacturer
            // 
            tbManufacturer.Location = new Point(138, 416);
            tbManufacturer.Name = "tbManufacturer";
            tbManufacturer.Size = new Size(201, 27);
            tbManufacturer.TabIndex = 61;
            // 
            // labelpw
            // 
            labelpw.AutoSize = true;
            labelpw.Location = new Point(9, 419);
            labelpw.Name = "labelpw";
            labelpw.Size = new Size(97, 20);
            labelpw.TabIndex = 60;
            labelpw.Text = "Manufacturer";
            // 
            // tbName
            // 
            tbName.Location = new Point(138, 371);
            tbName.Name = "tbName";
            tbName.Size = new Size(201, 27);
            tbName.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 374);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 58;
            label1.Text = "Name";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(138, 462);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(533, 27);
            tbDescription.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 465);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 56;
            label6.Text = "Description";
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(455, 416);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(216, 27);
            tbQuantity.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 416);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 54;
            label5.Text = "Quantity";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(455, 371);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(216, 27);
            tbPrice.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 371);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 52;
            label4.Text = "Price";
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
            dgProducts.TabIndex = 65;
            dgProducts.CellClick += dgProducts_CellClick;
            // 
            // FormViewProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 627);
            Controls.Add(dgProducts);
            Controls.Add(btnUpdate);
            Controls.Add(btnDel);
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
            Name = "FormViewProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormViewProducts";
            Load += FormViewProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnUpdate;
        private Button btnDel;
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
        private DataGridView dgProducts;
    }
}