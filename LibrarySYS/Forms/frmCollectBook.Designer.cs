namespace LibrarySYS
{
    partial class frmCollectBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCollectBook));
            this.mnuBackStrip = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCollectBook = new System.Windows.Forms.Label();
            this.dgvBookCart = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dgvReservedBooks = new System.Windows.Forms.DataGridView();
            this.btnSerachResID = new System.Windows.Forms.Button();
            this.txtResId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mnuBackStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservedBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBackStrip
            // 
            this.mnuBackStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.mnuBackStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBackStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuBackStrip.Name = "mnuBackStrip";
            this.mnuBackStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuBackStrip.Size = new System.Drawing.Size(681, 30);
            this.mnuBackStrip.TabIndex = 77;
            this.mnuBackStrip.Text = "Back";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.BackColor = System.Drawing.Color.SeaGreen;
            this.mnuBack.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBack.Margin = new System.Windows.Forms.Padding(3);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(53, 20);
            this.mnuBack.Text = "BACK";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // lblCollectBook
            // 
            this.lblCollectBook.AutoSize = true;
            this.lblCollectBook.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollectBook.Location = new System.Drawing.Point(42, 49);
            this.lblCollectBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCollectBook.Name = "lblCollectBook";
            this.lblCollectBook.Size = new System.Drawing.Size(143, 24);
            this.lblCollectBook.TabIndex = 134;
            this.lblCollectBook.Text = "Collect Book";
            // 
            // dgvBookCart
            // 
            this.dgvBookCart.AllowUserToAddRows = false;
            this.dgvBookCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookCart.Location = new System.Drawing.Point(45, 342);
            this.dgvBookCart.Name = "dgvBookCart";
            this.dgvBookCart.ReadOnly = true;
            this.dgvBookCart.RowHeadersWidth = 51;
            this.dgvBookCart.Size = new System.Drawing.Size(339, 145);
            this.dgvBookCart.TabIndex = 146;
            this.dgvBookCart.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(409, 432);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(10);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 30);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dgvReservedBooks
            // 
            this.dgvReservedBooks.AllowUserToAddRows = false;
            this.dgvReservedBooks.AllowUserToDeleteRows = false;
            this.dgvReservedBooks.AllowUserToResizeColumns = false;
            this.dgvReservedBooks.AllowUserToResizeRows = false;
            this.dgvReservedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservedBooks.Location = new System.Drawing.Point(45, 179);
            this.dgvReservedBooks.Name = "dgvReservedBooks";
            this.dgvReservedBooks.ReadOnly = true;
            this.dgvReservedBooks.RowHeadersWidth = 51;
            this.dgvReservedBooks.Size = new System.Drawing.Size(560, 136);
            this.dgvReservedBooks.TabIndex = 135;
            this.dgvReservedBooks.Visible = false;
            // 
            // btnSerachResID
            // 
            this.btnSerachResID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnSerachResID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerachResID.Location = new System.Drawing.Point(254, -1);
            this.btnSerachResID.Margin = new System.Windows.Forms.Padding(10);
            this.btnSerachResID.Name = "btnSerachResID";
            this.btnSerachResID.Size = new System.Drawing.Size(100, 30);
            this.btnSerachResID.TabIndex = 2;
            this.btnSerachResID.Text = "SEARCH";
            this.btnSerachResID.UseVisualStyleBackColor = false;
            this.btnSerachResID.Click += new System.EventHandler(this.btnSerachResID_Click);
            // 
            // txtResId
            // 
            this.txtResId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtResId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResId.Location = new System.Drawing.Point(140, 3);
            this.txtResId.Margin = new System.Windows.Forms.Padding(2);
            this.txtResId.MaxLength = 5;
            this.txtResId.Name = "txtResId";
            this.txtResId.Size = new System.Drawing.Size(100, 27);
            this.txtResId.TabIndex = 1;
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.Location = new System.Drawing.Point(3, 4);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(123, 21);
            this.lblMemberId.TabIndex = 137;
            this.lblMemberId.Text = "Reservation ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSerachResID);
            this.panel1.Controls.Add(this.lblMemberId);
            this.panel1.Controls.Add(this.txtResId);
            this.panel1.Location = new System.Drawing.Point(45, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 35);
            this.panel1.TabIndex = 147;
            // 
            // frmCollectBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBookCart);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgvReservedBooks);
            this.Controls.Add(this.lblCollectBook);
            this.Controls.Add(this.mnuBackStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCollectBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collect Book";
            this.mnuBackStrip.ResumeLayout(false);
            this.mnuBackStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservedBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblCollectBook;
        private System.Windows.Forms.DataGridView dgvBookCart;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView dgvReservedBooks;
        private System.Windows.Forms.Button btnSerachResID;
        private System.Windows.Forms.TextBox txtResId;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Panel panel1;
    }
}