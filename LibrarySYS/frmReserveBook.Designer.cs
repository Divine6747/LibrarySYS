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
            this.btnSearchTitle = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnMemberID = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.dgvResCart = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuBackStrip.SuspendLayout();
            this.grpMemberInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResCart)).BeginInit();
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
            this.mnuBackStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuBackStrip.Size = new System.Drawing.Size(1296, 34);
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
            this.mnuBack.Size = new System.Drawing.Size(71, 24);
            this.mnuBack.Text = "BACK";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // txtMemberId
            // 
            this.txtMemberId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberId.Location = new System.Drawing.Point(200, 150);
            this.txtMemberId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberId.MaxLength = 7;
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(151, 32);
            this.txtMemberId.TabIndex = 1;
            // 
            // lblReserveBook
            // 
            this.lblReserveBook.AutoSize = true;
            this.lblReserveBook.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserveBook.Location = new System.Drawing.Point(53, 66);
            this.lblReserveBook.Name = "lblReserveBook";
            this.lblReserveBook.Size = new System.Drawing.Size(196, 34);
            this.lblReserveBook.TabIndex = 99;
            this.lblReserveBook.Text = "Reserve Book";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.Location = new System.Drawing.Point(60, 151);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(118, 23);
            this.lblMemberId.TabIndex = 97;
            this.lblMemberId.Text = "Member ID";
            // 
            // grpMemberInfo
            // 
            this.grpMemberInfo.Controls.Add(this.lblMemberInfo);
            this.grpMemberInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMemberInfo.Location = new System.Drawing.Point(580, 60);
            this.grpMemberInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMemberInfo.Name = "grpMemberInfo";
            this.grpMemberInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMemberInfo.Size = new System.Drawing.Size(533, 123);
            this.grpMemberInfo.TabIndex = 101;
            this.grpMemberInfo.TabStop = false;
            this.grpMemberInfo.Text = "Member Info";
            this.grpMemberInfo.Visible = false;
            // 
            // lblMemberInfo
            // 
            this.lblMemberInfo.AutoSize = true;
            this.lblMemberInfo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberInfo.Location = new System.Drawing.Point(20, 25);
            this.lblMemberInfo.Name = "lblMemberInfo";
            this.lblMemberInfo.Size = new System.Drawing.Size(17, 17);
            this.lblMemberInfo.TabIndex = 102;
            this.lblMemberInfo.Text = "0";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(152, 219);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.MaxLength = 13;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(785, 32);
            this.txtTitle.TabIndex = 110;
            this.txtTitle.Visible = false;
            // 
            // btnSearchTitle
            // 
            this.btnSearchTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnSearchTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTitle.Location = new System.Drawing.Point(983, 217);
            this.btnSearchTitle.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnSearchTitle.Name = "btnSearchTitle";
            this.btnSearchTitle.Size = new System.Drawing.Size(133, 37);
            this.btnSearchTitle.TabIndex = 108;
            this.btnSearchTitle.Text = "SEARCH";
            this.btnSearchTitle.UseVisualStyleBackColor = false;
            this.btnSearchTitle.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(60, 224);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 23);
            this.lblTitle.TabIndex = 109;
            this.lblTitle.Text = "Title";
            this.lblTitle.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(944, 608);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(133, 37);
            this.btnConfirm.TabIndex = 122;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnMemberID
            // 
            this.btnMemberID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnMemberID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberID.Location = new System.Drawing.Point(373, 144);
            this.btnMemberID.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnMemberID.Name = "btnMemberID";
            this.btnMemberID.Size = new System.Drawing.Size(133, 37);
            this.btnMemberID.TabIndex = 125;
            this.btnMemberID.Text = "SEARCH";
            this.btnMemberID.UseVisualStyleBackColor = false;
            this.btnMemberID.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.colTitle,
            this.colAuthor,
            this.Status});
            this.dgvResults.Enabled = false;
            this.dgvResults.Location = new System.Drawing.Point(60, 283);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.Size = new System.Drawing.Size(1081, 167);
            this.dgvResults.StandardTab = true;
            this.dgvResults.TabIndex = 0;
            this.dgvResults.Visible = false;
            // 
            // dgvResCart
            // 
            this.dgvResCart.AllowUserToAddRows = false;
            this.dgvResCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvResCart.Location = new System.Drawing.Point(489, 539);
            this.dgvResCart.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResCart.Name = "dgvResCart";
            this.dgvResCart.ReadOnly = true;
            this.dgvResCart.RowHeadersWidth = 51;
            this.dgvResCart.Size = new System.Drawing.Size(600, 117);
            this.dgvResCart.TabIndex = 134;
            this.dgvResCart.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Reservation Cart";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // ISBN
            // 
            this.ISBN.Frozen = true;
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.Width = 125;
            // 
            // colTitle
            // 
            this.colTitle.Frozen = true;
            this.colTitle.HeaderText = "Title";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 200;
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
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // frmReserveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 697);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgvResCart);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnMemberID);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnSearchTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpMemberInfo);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.lblReserveBook);
            this.Controls.Add(this.lblMemberId);
            this.Controls.Add(this.mnuBackStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReserveBook";
            this.Text = "Reserve Book";
            this.mnuBackStrip.ResumeLayout(false);
            this.mnuBackStrip.PerformLayout();
            this.grpMemberInfo.ResumeLayout(false);
            this.grpMemberInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
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
        private System.Windows.Forms.Button btnSearchTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnMemberID;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridView dgvResCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}