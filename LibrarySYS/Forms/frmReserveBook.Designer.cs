namespace LibrarySYS
{
    partial class frmReserveBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserveBook));
            this.mnuBackStrip = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lblReserveBook = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.grpMemberInfo = new System.Windows.Forms.GroupBox();
            this.lblMemberInfo = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSearchByTitle = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnSearchMemberID = new System.Windows.Forms.Button();
            this.txtLoanID = new System.Windows.Forms.TextBox();
            this.lblLoanID = new System.Windows.Forms.Label();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.dgvResCart = new System.Windows.Forms.DataGridView();
            this.mnuBackStrip.SuspendLayout();
            this.grpMemberInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResCart)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuBackStrip
            // 
            this.mnuBackStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.mnuBackStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuBackStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBackStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuBackStrip.Name = "mnuBackStrip";
            this.mnuBackStrip.Padding = new System.Windows.Forms.Padding(7, 4, 0, 4);
            this.mnuBackStrip.Size = new System.Drawing.Size(1782, 46);
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
            this.mnuBack.Size = new System.Drawing.Size(94, 32);
            this.mnuBack.Text = "BACK";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // txtMemberId
            // 
            this.txtMemberId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberId.Location = new System.Drawing.Point(275, 223);
            this.txtMemberId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemberId.MaxLength = 7;
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(206, 42);
            this.txtMemberId.TabIndex = 1;
            // 
            // lblReserveBook
            // 
            this.lblReserveBook.AutoSize = true;
            this.lblReserveBook.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserveBook.Location = new System.Drawing.Point(73, 100);
            this.lblReserveBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReserveBook.Name = "lblReserveBook";
            this.lblReserveBook.Size = new System.Drawing.Size(267, 45);
            this.lblReserveBook.TabIndex = 99;
            this.lblReserveBook.Text = "Reserve Book";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.Location = new System.Drawing.Point(82, 229);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(164, 34);
            this.lblMemberId.TabIndex = 97;
            this.lblMemberId.Text = "Member ID";
            // 
            // grpMemberInfo
            // 
            this.grpMemberInfo.Controls.Add(this.lblMemberInfo);
            this.grpMemberInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMemberInfo.Location = new System.Drawing.Point(798, 90);
            this.grpMemberInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpMemberInfo.Name = "grpMemberInfo";
            this.grpMemberInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpMemberInfo.Size = new System.Drawing.Size(733, 185);
            this.grpMemberInfo.TabIndex = 101;
            this.grpMemberInfo.TabStop = false;
            this.grpMemberInfo.Text = "Member Info";
            this.grpMemberInfo.Visible = false;
            // 
            // lblMemberInfo
            // 
            this.lblMemberInfo.AutoSize = true;
            this.lblMemberInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberInfo.Location = new System.Drawing.Point(28, 37);
            this.lblMemberInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberInfo.Name = "lblMemberInfo";
            this.lblMemberInfo.Size = new System.Drawing.Size(222, 23);
            this.lblMemberInfo.TabIndex = 102;
            this.lblMemberInfo.Text = "NO MEMBER ID GIVEN";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(209, 329);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.MaxLength = 13;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(1078, 42);
            this.txtTitle.TabIndex = 110;
            this.txtTitle.Visible = false;
            // 
            // btnSearchByTitle
            // 
            this.btnSearchByTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnSearchByTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByTitle.Location = new System.Drawing.Point(1351, 325);
            this.btnSearchByTitle.Margin = new System.Windows.Forms.Padding(18);
            this.btnSearchByTitle.Name = "btnSearchByTitle";
            this.btnSearchByTitle.Size = new System.Drawing.Size(183, 55);
            this.btnSearchByTitle.TabIndex = 108;
            this.btnSearchByTitle.Text = "SEARCH";
            this.btnSearchByTitle.UseVisualStyleBackColor = false;
            this.btnSearchByTitle.Visible = false;
            this.btnSearchByTitle.Click += new System.EventHandler(this.btnSearchByTitle_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(82, 336);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(67, 34);
            this.lblTitle.TabIndex = 109;
            this.lblTitle.Text = "Title";
            this.lblTitle.Visible = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(1542, 951);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(18);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(183, 55);
            this.btnCheckOut.TabIndex = 122;
            this.btnCheckOut.Text = "CONFIRM";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnSearchMemberID
            // 
            this.btnSearchMemberID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnSearchMemberID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMemberID.Location = new System.Drawing.Point(524, 220);
            this.btnSearchMemberID.Margin = new System.Windows.Forms.Padding(18);
            this.btnSearchMemberID.Name = "btnSearchMemberID";
            this.btnSearchMemberID.Size = new System.Drawing.Size(183, 55);
            this.btnSearchMemberID.TabIndex = 125;
            this.btnSearchMemberID.Text = "SEARCH";
            this.btnSearchMemberID.UseVisualStyleBackColor = false;
            this.btnSearchMemberID.Click += new System.EventHandler(this.btnSearchMemberID_Click);
            // 
            // txtLoanID
            // 
            this.txtLoanID.Enabled = false;
            this.txtLoanID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanID.Location = new System.Drawing.Point(209, 794);
            this.txtLoanID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoanID.MaxLength = 7;
            this.txtLoanID.Name = "txtLoanID";
            this.txtLoanID.Size = new System.Drawing.Size(363, 35);
            this.txtLoanID.TabIndex = 158;
            this.txtLoanID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLoanID.Visible = false;
            // 
            // lblLoanID
            // 
            this.lblLoanID.AutoSize = true;
            this.lblLoanID.Enabled = false;
            this.lblLoanID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanID.Location = new System.Drawing.Point(77, 799);
            this.lblLoanID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoanID.Name = "lblLoanID";
            this.lblLoanID.Size = new System.Drawing.Size(104, 28);
            this.lblLoanID.TabIndex = 159;
            this.lblLoanID.Text = "Loan ID";
            this.lblLoanID.Visible = false;
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Location = new System.Drawing.Point(91, 406);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.RowHeadersWidth = 72;
            this.dgvSearchResults.RowTemplate.Height = 31;
            this.dgvSearchResults.Size = new System.Drawing.Size(1442, 300);
            this.dgvSearchResults.TabIndex = 160;
            this.dgvSearchResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchResults_CellClick);
            // 
            // dgvResCart
            // 
            this.dgvResCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResCart.Location = new System.Drawing.Point(851, 761);
            this.dgvResCart.Name = "dgvResCart";
            this.dgvResCart.RowHeadersWidth = 72;
            this.dgvResCart.RowTemplate.Height = 31;
            this.dgvResCart.Size = new System.Drawing.Size(680, 245);
            this.dgvResCart.TabIndex = 161;
            this.dgvResCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResCart_CellClick);
            // 
            // frmReserveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 1045);
            this.Controls.Add(this.dgvResCart);
            this.Controls.Add(this.dgvSearchResults);
            this.Controls.Add(this.txtLoanID);
            this.Controls.Add(this.lblLoanID);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnSearchMemberID);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnSearchByTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpMemberInfo);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.lblReserveBook);
            this.Controls.Add(this.lblMemberId);
            this.Controls.Add(this.mnuBackStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmReserveBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserve Book";
            this.mnuBackStrip.ResumeLayout(false);
            this.mnuBackStrip.PerformLayout();
            this.grpMemberInfo.ResumeLayout(false);
            this.grpMemberInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblReserveBook;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.GroupBox grpMemberInfo;
        private System.Windows.Forms.Label lblMemberInfo;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnSearchByTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnSearchMemberID;
        private System.Windows.Forms.TextBox txtLoanID;
        private System.Windows.Forms.Label lblLoanID;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.DataGridView dgvResCart;
    }
}