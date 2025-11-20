namespace LibrarySYS
{
    partial class frmReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnBook));
            this.mnuBackStrip = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblReturnBook = new System.Windows.Forms.Label();
            this.dgvReturnCart = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtLoanID = new System.Windows.Forms.TextBox();
            this.lblLoanID = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMemberID = new System.Windows.Forms.Button();
            this.grpMemberInfo = new System.Windows.Forms.GroupBox();
            this.lblMemberInfo = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.mnuBackStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.grpMemberInfo.SuspendLayout();
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
            // lblReturnBook
            // 
            this.lblReturnBook.AutoSize = true;
            this.lblReturnBook.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnBook.Location = new System.Drawing.Point(46, 61);
            this.lblReturnBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturnBook.Name = "lblReturnBook";
            this.lblReturnBook.Size = new System.Drawing.Size(172, 33);
            this.lblReturnBook.TabIndex = 142;
            this.lblReturnBook.Text = "Return Book";
            // 
            // dgvReturnCart
            // 
            this.dgvReturnCart.AllowUserToAddRows = false;
            this.dgvReturnCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvReturnCart.Location = new System.Drawing.Point(388, 372);
            this.dgvReturnCart.Name = "dgvReturnCart";
            this.dgvReturnCart.ReadOnly = true;
            this.dgvReturnCart.RowHeadersWidth = 51;
            this.dgvReturnCart.Size = new System.Drawing.Size(450, 120);
            this.dgvReturnCart.TabIndex = 158;
            this.dgvReturnCart.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "ReturnCart";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnConfirm.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(739, 504);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(10);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            // 
            // txtLoanID
            // 
            this.txtLoanID.Enabled = false;
            this.txtLoanID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanID.Location = new System.Drawing.Point(121, 372);
            this.txtLoanID.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoanID.MaxLength = 7;
            this.txtLoanID.Name = "txtLoanID";
            this.txtLoanID.Size = new System.Drawing.Size(200, 23);
            this.txtLoanID.TabIndex = 156;
            this.txtLoanID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLoanID.Visible = false;
            // 
            // lblLoanID
            // 
            this.lblLoanID.AutoSize = true;
            this.lblLoanID.Enabled = false;
            this.lblLoanID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanID.Location = new System.Drawing.Point(46, 375);
            this.lblLoanID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoanID.Name = "lblLoanID";
            this.lblLoanID.Size = new System.Drawing.Size(57, 17);
            this.lblLoanID.TabIndex = 157;
            this.lblLoanID.Text = "Loan ID";
            this.lblLoanID.Visible = false;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToResizeColumns = false;
            this.dgvResults.AllowUserToResizeRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTitle,
            this.colAuthor,
            this.colLocation});
            this.dgvResults.Location = new System.Drawing.Point(49, 196);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.Size = new System.Drawing.Size(790, 136);
            this.dgvResults.TabIndex = 147;
            this.dgvResults.Visible = false;
            // 
            // colId
            // 
            this.colId.Frozen = true;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 125;
            // 
            // colTitle
            // 
            this.colTitle.Frozen = true;
            this.colTitle.HeaderText = "Title";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 210;
            // 
            // colAuthor
            // 
            this.colAuthor.Frozen = true;
            this.colAuthor.HeaderText = "Author";
            this.colAuthor.MinimumWidth = 6;
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            this.colAuthor.Width = 200;
            // 
            // colLocation
            // 
            this.colLocation.Frozen = true;
            this.colLocation.HeaderText = "Location";
            this.colLocation.MinimumWidth = 6;
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            this.colLocation.Width = 200;
            // 
            // btnMemberID
            // 
            this.btnMemberID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnMemberID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberID.Location = new System.Drawing.Point(284, 125);
            this.btnMemberID.Margin = new System.Windows.Forms.Padding(10);
            this.btnMemberID.Name = "btnMemberID";
            this.btnMemberID.Size = new System.Drawing.Size(100, 30);
            this.btnMemberID.TabIndex = 2;
            this.btnMemberID.Text = "SEARCH";
            this.btnMemberID.UseVisualStyleBackColor = false;
            // 
            // grpMemberInfo
            // 
            this.grpMemberInfo.Controls.Add(this.lblMemberInfo);
            this.grpMemberInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMemberInfo.Location = new System.Drawing.Point(439, 57);
            this.grpMemberInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpMemberInfo.Name = "grpMemberInfo";
            this.grpMemberInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpMemberInfo.Size = new System.Drawing.Size(400, 100);
            this.grpMemberInfo.TabIndex = 150;
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
            // txtMemberId
            // 
            this.txtMemberId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberId.Location = new System.Drawing.Point(158, 127);
            this.txtMemberId.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberId.MaxLength = 7;
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(114, 27);
            this.txtMemberId.TabIndex = 1;
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.Location = new System.Drawing.Point(49, 130);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(97, 21);
            this.lblMemberId.TabIndex = 149;
            this.lblMemberId.Text = "Member ID";
            // 
            // frmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dgvReturnCart);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtLoanID);
            this.Controls.Add(this.lblLoanID);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnMemberID);
            this.Controls.Add(this.grpMemberInfo);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.lblMemberId);
            this.Controls.Add(this.lblReturnBook);
            this.Controls.Add(this.mnuBackStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Book";
            this.mnuBackStrip.ResumeLayout(false);
            this.mnuBackStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.grpMemberInfo.ResumeLayout(false);
            this.grpMemberInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblReturnBook;
        private System.Windows.Forms.DataGridView dgvReturnCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtLoanID;
        private System.Windows.Forms.Label lblLoanID;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.Button btnMemberID;
        private System.Windows.Forms.GroupBox grpMemberInfo;
        private System.Windows.Forms.Label lblMemberInfo;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblMemberId;
    }
}