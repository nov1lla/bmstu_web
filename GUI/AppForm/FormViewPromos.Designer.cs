namespace GUI.AppForm
{
    partial class FormViewPromos
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
            tbStart = new TextBox();
            labelpw = new Label();
            tbCode = new TextBox();
            label1 = new Label();
            tbEnd = new TextBox();
            label5 = new Label();
            tbDiscount = new TextBox();
            label4 = new Label();
            btnUpdate = new Button();
            btnDel = new Button();
            btnAdd = new Button();
            dgPromos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgPromos).BeginInit();
            SuspendLayout();
            // 
            // tbStart
            // 
            tbStart.Location = new Point(134, 433);
            tbStart.Name = "tbStart";
            tbStart.Size = new Size(196, 27);
            tbStart.TabIndex = 60;
            // 
            // labelpw
            // 
            labelpw.AutoSize = true;
            labelpw.Location = new Point(35, 436);
            labelpw.Name = "labelpw";
            labelpw.Size = new Size(40, 20);
            labelpw.TabIndex = 59;
            labelpw.Text = "Start";
            // 
            // tbCode
            // 
            tbCode.Location = new Point(134, 388);
            tbCode.Name = "tbCode";
            tbCode.Size = new Size(196, 27);
            tbCode.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 391);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 57;
            label1.Text = "Code";
            // 
            // tbEnd
            // 
            tbEnd.Location = new Point(482, 433);
            tbEnd.Name = "tbEnd";
            tbEnd.Size = new Size(199, 27);
            tbEnd.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 436);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 55;
            label5.Text = "End";
            // 
            // tbDiscount
            // 
            tbDiscount.Location = new Point(482, 388);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(199, 27);
            tbDiscount.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 388);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 53;
            label4.Text = "Discount";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(460, 524);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 44);
            btnUpdate.TabIndex = 62;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(290, 524);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 44);
            btnDel.TabIndex = 61;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(125, 524);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 44);
            btnAdd.TabIndex = 63;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            dgPromos.TabIndex = 64;
            dgPromos.CellClick += dgPromos_CellClick;
            dgPromos.CellDoubleClick += dgPromos_CellDoubleClick;
            // 
            // FormViewPromos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 627);
            Controls.Add(dgPromos);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDel);
            Controls.Add(tbStart);
            Controls.Add(labelpw);
            Controls.Add(tbCode);
            Controls.Add(label1);
            Controls.Add(tbEnd);
            Controls.Add(label5);
            Controls.Add(tbDiscount);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormViewPromos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormViewPromos";
            Load += FormViewPromos_Load;
            ((System.ComponentModel.ISupportInitialize)dgPromos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbStart;
        private Label labelpw;
        private TextBox tbCode;
        private Label label1;
        private TextBox tbEnd;
        private Label label5;
        private TextBox tbDiscount;
        private Label label4;
        private Button btnUpdate;
        private Button btnDel;
        private Button btnAdd;
        private DataGridView dgPromos;
    }
}