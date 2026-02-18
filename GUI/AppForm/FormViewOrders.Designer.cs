namespace GUI.AppForm
{
    partial class FormViewOrders
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
            labelpw = new Label();
            tbPromoCode = new TextBox();
            label5 = new Label();
            tbData = new TextBox();
            label4 = new Label();
            tbUserLogin = new TextBox();
            dgOrders = new DataGridView();
            cbStatus = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgOrders).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(380, 481);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 44);
            btnUpdate.TabIndex = 51;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(213, 481);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 44);
            btnDel.TabIndex = 50;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // labelpw
            // 
            labelpw.AutoSize = true;
            labelpw.Location = new Point(12, 421);
            labelpw.Name = "labelpw";
            labelpw.Size = new Size(79, 20);
            labelpw.TabIndex = 47;
            labelpw.Text = "User Login";
            // 
            // tbPromoCode
            // 
            tbPromoCode.Enabled = false;
            tbPromoCode.Location = new Point(459, 418);
            tbPromoCode.Name = "tbPromoCode";
            tbPromoCode.Size = new Size(199, 27);
            tbPromoCode.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 423);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 41;
            label5.Text = "PromoCode";
            // 
            // tbData
            // 
            tbData.Enabled = false;
            tbData.Location = new Point(459, 373);
            tbData.Name = "tbData";
            tbData.Size = new Size(199, 27);
            tbData.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 373);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 39;
            label4.Text = "Data";
            // 
            // tbUserLogin
            // 
            tbUserLogin.Enabled = false;
            tbUserLogin.Location = new Point(111, 418);
            tbUserLogin.Name = "tbUserLogin";
            tbUserLogin.Size = new Size(196, 27);
            tbUserLogin.TabIndex = 52;
            // 
            // dgOrders
            // 
            dgOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrders.Dock = DockStyle.Top;
            dgOrders.Location = new Point(0, 0);
            dgOrders.Name = "dgOrders";
            dgOrders.RowHeadersWidth = 51;
            dgOrders.RowTemplate.Height = 29;
            dgOrders.Size = new Size(704, 349);
            dgOrders.TabIndex = 53;
            dgOrders.CellClick += dgOrders_CellClick;
            dgOrders.CellDoubleClick += dgOrders_CellDoubleClick;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Init", "Delivering", "Delivered" });
            cbStatus.Location = new Point(111, 374);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(196, 28);
            cbStatus.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 376);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 45;
            label1.Text = "Status";
            // 
            // FormViewOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 627);
            Controls.Add(cbStatus);
            Controls.Add(dgOrders);
            Controls.Add(tbUserLogin);
            Controls.Add(btnUpdate);
            Controls.Add(btnDel);
            Controls.Add(labelpw);
            Controls.Add(label1);
            Controls.Add(tbPromoCode);
            Controls.Add(label5);
            Controls.Add(tbData);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormViewOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormViewOrders";
            Load += FormViewOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnUpdate;
        private Button btnDel;
        private Label labelpw;
        private TextBox tbPromoCode;
        private Label label5;
        private TextBox tbData;
        private Label label4;
        private TextBox tbUserLogin;
        private DataGridView dgOrders;
        private ComboBox cbStatus;
        private Label label1;
    }
}