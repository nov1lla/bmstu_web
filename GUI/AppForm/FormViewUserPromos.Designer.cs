namespace GUI.AppForm
{
    partial class FormViewUserPromos
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
            dgUserPromos = new DataGridView();
            tbIdPromo = new TextBox();
            btnDel = new Button();
            labelpw = new Label();
            tbIdUser = new TextBox();
            label4 = new Label();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgUserPromos).BeginInit();
            SuspendLayout();
            // 
            // dgUserPromos
            // 
            dgUserPromos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUserPromos.Dock = DockStyle.Top;
            dgUserPromos.Location = new Point(0, 0);
            dgUserPromos.Name = "dgUserPromos";
            dgUserPromos.RowHeadersWidth = 51;
            dgUserPromos.RowTemplate.Height = 29;
            dgUserPromos.Size = new Size(704, 382);
            dgUserPromos.TabIndex = 54;
            dgUserPromos.CellClick += dgUserPromos_CellClick;
            // 
            // tbIdPromo
            // 
            tbIdPromo.Enabled = false;
            tbIdPromo.Location = new Point(120, 417);
            tbIdPromo.Name = "tbIdPromo";
            tbIdPromo.Size = new Size(196, 27);
            tbIdPromo.TabIndex = 63;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(446, 525);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 44);
            btnDel.TabIndex = 61;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // labelpw
            // 
            labelpw.AutoSize = true;
            labelpw.Location = new Point(21, 420);
            labelpw.Name = "labelpw";
            labelpw.Size = new Size(70, 20);
            labelpw.TabIndex = 60;
            labelpw.Text = "Id Promo";
            // 
            // tbIdUser
            // 
            tbIdUser.Location = new Point(478, 417);
            tbIdUser.Name = "tbIdUser";
            tbIdUser.Size = new Size(199, 27);
            tbIdUser.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(379, 419);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 55;
            label4.Text = "Id User";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(222, 525);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 44);
            btnAdd.TabIndex = 64;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // FormViewUserPromos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 627);
            Controls.Add(btnAdd);
            Controls.Add(tbIdPromo);
            Controls.Add(btnDel);
            Controls.Add(labelpw);
            Controls.Add(tbIdUser);
            Controls.Add(label4);
            Controls.Add(dgUserPromos);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(730, 200);
            Name = "FormViewUserPromos";
            StartPosition = FormStartPosition.Manual;
            Text = "FormViewUserPromos";
            ((System.ComponentModel.ISupportInitialize)dgUserPromos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgUserPromos;
        private TextBox tbIdPromo;
        private Button btnDel;
        private Label labelpw;
        private TextBox tbIdUser;
        private Label label4;
        private Button btnAdd;
    }
}