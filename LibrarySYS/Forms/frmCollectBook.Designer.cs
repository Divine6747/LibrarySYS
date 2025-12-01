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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtLoanID = new System.Windows.Forms.TextBox();
            this.lblLoanID = new System.Windows.Forms.Label();
            this.dgvReservedBooks = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSerachResID = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSearchTitle = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpMemberInfo = new System.Windows.Forms.GroupBox();
            this.lblMemberInfo = new System.Windows.Forms.Label();
            this.txtResId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mnuBackStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservedBooks)).BeginInit();
            this.grpMemberInfo.SuspendLayout();
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
            this.mnuBackStrip.Size = new System.Drawing.Size(884, 30);
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
            this.dgvBookCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvBookCart.Location = new System.Drawing.Point(385, 380);
            this.dgvBookCart.Name = "dgvBookCart";
            this.dgvBookCart.ReadOnly = true;
            this.dgvBookCart.RowHeadersWidth = 51;
            this.dgvBookCart.Size = new System.Drawing.Size(450, 120);
            this.dgvBookCart.TabIndex = 146;
            this.dgvBookCart.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Book Cart";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(723, 513);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(10);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 30);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtLoanID
            // 
            this.txtLoanID.Enabled = false;
            this.txtLoanID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanID.Location = new System.Drawing.Point(117, 380);
            this.txtLoanID.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoanID.MaxLength = 7;
            this.txtLoanID.Name = "txtLoanID";
            this.txtLoanID.Size = new System.Drawing.Size(200, 27);
            this.txtLoanID.TabIndex = 144;
            this.txtLoanID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLoanID.Visible = false;
            // 
            // lblLoanID
            // 
            this.lblLoanID.AutoSize = true;
            this.lblLoanID.Enabled = false;
            this.lblLoanID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanID.Location = new System.Drawing.Point(42, 383);
            this.lblLoanID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoanID.Name = "lblLoanID";
            this.lblLoanID.Size = new System.Drawing.Size(69, 21);
            this.lblLoanID.TabIndex = 145;
            this.lblLoanID.Text = "Loan ID";
            this.lblLoanID.Visible = false;
            // 
            // dgvReservedBooks
            // 
            this.dgvReservedBooks.AllowUserToAddRows = false;
            this.dgvReservedBooks.AllowUserToDeleteRows = false;
            this.dgvReservedBooks.AllowUserToResizeColumns = false;
            this.dgvReservedBooks.AllowUserToResizeRows = false;
            this.dgvReservedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTitle,
            this.colAuthor,
            this.colLocation,
            this.ColStatus});
            this.dgvReservedBooks.Location = new System.Drawing.Point(45, 220);
            this.dgvReservedBooks.Name = "dgvReservedBooks";
            this.dgvReservedBooks.ReadOnly = true;
            this.dgvReservedBooks.RowHeadersWidth = 51;
            this.dgvReservedBooks.Size = new System.Drawing.Size(790, 136);
            this.dgvReservedBooks.TabIndex = 135;
            this.dgvReservedBooks.Visible = false;
            // 
            // colId
            // 
            this.colId.Frozen = true;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 75;
            // 
            // colTitle
            // 
            this.colTitle.Frozen = true;
            this.colTitle.HeaderText = "Title";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 325;
            // 
            // colAuthor
            // 
            this.colAuthor.Frozen = true;
            this.colAuthor.HeaderText = "Author";
            this.colAuthor.MinimumWidth = 6;
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            this.colAuthor.Width = 125;
            // 
            // colLocation
            // 
            this.colLocation.Frozen = true;
            this.colLocation.HeaderText = "Location";
            this.colLocation.MinimumWidth = 6;
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            this.colLocation.Width = 150;
            // 
            // ColStatus
            // 
            this.ColStatus.Frozen = true;
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.MinimumWidth = 6;
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            this.ColStatus.Width = 50;
            // 
            // btnSerachResID
            // 
            this.btnSerachResID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnSerachResID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerachResID.Location = new System.Drawing.Point(254, -3);
            this.btnSerachResID.Margin = new System.Windows.Forms.Padding(10);
            this.btnSerachResID.Name = "btnSerachResID";
            this.btnSerachResID.Size = new System.Drawing.Size(100, 30);
            this.btnSerachResID.TabIndex = 2;
            this.btnSerachResID.Text = "SEARCH";
            this.btnSerachResID.UseVisualStyleBackColor = false;
            this.btnSerachResID.Click += new System.EventHandler(this.btnSerachResID_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(117, 173);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.MaxLength = 50;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(590, 27);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.Visible = false;
            // 
            // btnSearchTitle
            // 
            this.btnSearchTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnSearchTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTitle.Location = new System.Drawing.Point(738, 171);
            this.btnSearchTitle.Margin = new System.Windows.Forms.Padding(10);
            this.btnSearchTitle.Name = "btnSearchTitle";
            this.btnSearchTitle.Size = new System.Drawing.Size(100, 30);
            this.btnSearchTitle.TabIndex = 4;
            this.btnSearchTitle.Text = "SEARCH";
            this.btnSearchTitle.UseVisualStyleBackColor = false;
            this.btnSearchTitle.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(41, 176);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 21);
            this.lblTitle.TabIndex = 140;
            this.lblTitle.Text = "Title";
            this.lblTitle.Visible = false;
            // 
            // grpMemberInfo
            // 
            this.grpMemberInfo.Controls.Add(this.lblMemberInfo);
            this.grpMemberInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMemberInfo.Location = new System.Drawing.Point(435, 49);
            this.grpMemberInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpMemberInfo.Name = "grpMemberInfo";
            this.grpMemberInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpMemberInfo.Size = new System.Drawing.Size(400, 100);
            this.grpMemberInfo.TabIndex = 138;
            this.grpMemberInfo.TabStop = false;
            this.grpMemberInfo.Text = "Member Info";
            this.grpMemberInfo.Visible = false;
            // 
            // lblMemberInfo
            // 
            this.lblMemberInfo.AutoSize = true;
            this.lblMemberInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberInfo.Location = new System.Drawing.Point(15, 20);
            this.lblMemberInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberInfo.Name = "lblMemberInfo";
            this.lblMemberInfo.Size = new System.Drawing.Size(13, 16);
            this.lblMemberInfo.TabIndex = 102;
            this.lblMemberInfo.Text = "0";
            // 
            // txtResId
            // 
            this.txtResId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResId.Location = new System.Drawing.Point(120, -1);
            this.txtResId.Margin = new System.Windows.Forms.Padding(2);
            this.txtResId.MaxLength = 7;
            this.txtResId.Name = "txtResId";
            this.txtResId.Size = new System.Drawing.Size(114, 27);
            this.txtResId.TabIndex = 1;
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.Location = new System.Drawing.Point(3, 2);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(97, 21);
            this.lblMemberId.TabIndex = 137;
            this.lblMemberId.Text = "Member ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSerachResID);
            this.panel1.Controls.Add(this.lblMemberId);
            this.panel1.Controls.Add(this.txtResId);
            this.panel1.Location = new System.Drawing.Point(45, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 27);
            this.panel1.TabIndex = 147;
            // 
            // frmCollectBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBookCart);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtLoanID);
            this.Controls.Add(this.lblLoanID);
            this.Controls.Add(this.dgvReservedBooks);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnSearchTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpMemberInfo);
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
            this.grpMemberInfo.ResumeLayout(false);
            this.grpMemberInfo.PerformLayout();
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
        private System.Windows.Forms.TextBox txtLoanID;
        private System.Windows.Forms.Label lblLoanID;
        private System.Windows.Forms.DataGridView dgvReservedBooks;
        private System.Windows.Forms.Button btnSerachResID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnSearchTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpMemberInfo;
        private System.Windows.Forms.Label lblMemberInfo;
        private System.Windows.Forms.TextBox txtResId;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel1;
    }
}