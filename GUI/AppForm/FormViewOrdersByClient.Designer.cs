namespace GUI.AppForm
{
    partial class FormViewOrdersByClient
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
            dgOrders = new DataGridView();
            cbStatus = new ComboBox();
            tbUserLogin = new TextBox();
            labelpw = new Label();
            label1 = new Label();
            tbPromoCode = new TextBox();
            label5 = new Label();
            tbData = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgOrders).BeginInit();
            SuspendLayout();
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
            dgOrders.TabIndex = 54;
            dgOrders.CellClick += dgOrders_CellClick;
            dgOrders.CellDoubleClick += dgOrders_CellDoubleClick;
            // 
            // cbStatus
            // 
            cbStatus.Enabled = false;
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Init", "Delivering", "Delivered" });
            cbStatus.Location = new Point(128, 390);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(196, 28);
            cbStatus.TabIndex = 64;
            // 
            // tbUserLogin
            // 
            tbUserLogin.Enabled = false;
            tbUserLogin.Location = new Point(128, 434);
            tbUserLogin.Name = "tbUserLogin";
            tbUserLogin.Size = new Size(196, 27);
            tbUserLogin.TabIndex = 63;
            // 
            // labelpw
            // 
            labelpw.AutoSize = true;
            labelpw.Location = new Point(29, 437);
            labelpw.Name = "labelpw";
            labelpw.Size = new Size(79, 20);
            labelpw.TabIndex = 60;
            labelpw.Text = "User Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 392);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 59;
            label1.Text = "Status";
            // 
            // tbPromoCode
            // 
            tbPromoCode.Enabled = false;
            tbPromoCode.Location = new Point(476, 434);
            tbPromoCode.Name = "tbPromoCode";
            tbPromoCode.Size = new Size(199, 27);
            tbPromoCode.TabIndex = 58;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 439);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 57;
            label5.Text = "PromoCode";
            // 
            // tbData
            // 
            tbData.Enabled = false;
            tbData.Location = new Point(476, 389);
            tbData.Name = "tbData";
            tbData.Size = new Size(199, 27);
            tbData.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 389);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 55;
            label4.Text = "Data";
            // 
            // FormViewOrdersByClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 627);
            Controls.Add(cbStatus);
            Controls.Add(tbUserLogin);
            Controls.Add(labelpw);
            Controls.Add(label1);
            Controls.Add(tbPromoCode);
            Controls.Add(label5);
            Controls.Add(tbData);
            Controls.Add(label4);
            Controls.Add(dgOrders);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormViewOrdersByClient";
            Text = "FormViewOrdersByClient";
            ((System.ComponentModel.ISupportInitialize)dgOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgOrders;
        private ComboBox cbStatus;
        private TextBox tbUserLogin;
        private Label labelpw;
        private Label label1;
        private TextBox tbPromoCode;
        private Label label5;
        private TextBox tbData;
        private Label label4;
    }
}