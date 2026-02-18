namespace GUI.AppForm
{
    partial class FormViewPromosByClient
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
            dgPromos = new DataGridView();
            tbStart = new TextBox();
            labelpw = new Label();
            tbCode = new TextBox();
            label1 = new Label();
            tbEnd = new TextBox();
            label5 = new Label();
            tbDiscount = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgPromos).BeginInit();
            SuspendLayout();
            // 
            // dgPromos
            // 
            dgPromos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPromos.Dock = DockStyle.Top;
            dgPromos.Location = new Point(0, 0);
            dgPromos.Name = "dgPromos";
            dgPromos.RowHeadersWidth = 51;
            dgPromos.RowTemplate.Height = 29;
            dgPromos.Size = new Size(704, 361);
            dgPromos.TabIndex = 76;
            dgPromos.CellClick += dgPromos_CellClick;
            // 
            // tbStart
            // 
            tbStart.Enabled = false;
            tbStart.Location = new Point(134, 462);
            tbStart.Name = "tbStart";
            tbStart.Size = new Size(196, 27);
            tbStart.TabIndex = 72;
            // 
            // labelpw
            // 
            labelpw.AutoSize = true;
            labelpw.Location = new Point(35, 465);
            labelpw.Name = "labelpw";
            labelpw.Size = new Size(40, 20);
            labelpw.TabIndex = 71;
            labelpw.Text = "Start";
            // 
            // tbCode
            // 
            tbCode.Enabled = false;
            tbCode.Location = new Point(134, 417);
            tbCode.Name = "tbCode";
            tbCode.Size = new Size(196, 27);
            tbCode.TabIndex = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 420);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 69;
            label1.Text = "Code";
            // 
            // tbEnd
            // 
            tbEnd.Enabled = false;
            tbEnd.Location = new Point(482, 462);
            tbEnd.Name = "tbEnd";
            tbEnd.Size = new Size(199, 27);
            tbEnd.TabIndex = 68;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 465);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 67;
            label5.Text = "End";
            // 
            // tbDiscount
            // 
            tbDiscount.Enabled = false;
            tbDiscount.Location = new Point(482, 417);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(199, 27);
            tbDiscount.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 417);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 65;
            label4.Text = "Discount";
            // 
            // FormViewPromosByClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 627);
            Controls.Add(dgPromos);
            Controls.Add(tbStart);
            Controls.Add(labelpw);
            Controls.Add(tbCode);
            Controls.Add(label1);
            Controls.Add(tbEnd);
            Controls.Add(label5);
            Controls.Add(tbDiscount);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormViewPromosByClient";
            Text = "FormViewPromosByClient";
            ((System.ComponentModel.ISupportInitialize)dgPromos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPromos;
        private TextBox tbStart;
        private Label labelpw;
        private TextBox tbCode;
        private Label label1;
        private TextBox tbEnd;
        private Label label5;
        private TextBox tbDiscount;
        private Label label4;
    }
}