namespace LibrarySYS
{
    partial class frmRemoveBook

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveBook));
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackStrip = new System.Windows.Forms.MenuStrip();
            this.lblBook = new System.Windows.Forms.Label();
            this.pnlUpdateRegisteredMember = new System.Windows.Forms.Panel();
            this.btnSearchBookId = new System.Windows.Forms.Button();
            this.txtSearchRemoveBookID = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.btnRemoveBookConfirm = new System.Windows.Forms.Button();
            this.grpRemoveBook = new System.Windows.Forms.GroupBox();
            this.lblBookDetails = new System.Windows.Forms.Label();
            this.mnuBackStrip.SuspendLayout();
            this.pnlUpdateRegisteredMember.SuspendLayout();
            this.grpRemoveBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.BackColor = System.Drawing.Color.SeaGreen;
            this.mnuBack.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBack.Margin = new System.Windows.Forms.Padding(3);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(74, 26);
            this.mnuBack.Text = "BACK";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuBackStrip
            // 
            this.mnuBackStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.mnuBackStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBackStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuBackStrip.Name = "mnuBackStrip";
            this.mnuBackStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnuBackStrip.Size = new System.Drawing.Size(614, 38);
            this.mnuBackStrip.TabIndex = 75;
            this.mnuBackStrip.Text = "Back";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(39, 43);
            this.lblBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(156, 24);
            this.lblBook.TabIndex = 85;
            this.lblBook.Text = "Remove Book";
            // 
            // pnlUpdateRegisteredMember
            // 
            this.pnlUpdateRegisteredMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUpdateRegisteredMember.Controls.Add(this.btnSearchBookId);
            this.pnlUpdateRegisteredMember.Controls.Add(this.txtSearchRemoveBookID);
            this.pnlUpdateRegisteredMember.Controls.Add(this.lblBookID);
            this.pnlUpdateRegisteredMember.Location = new System.Drawing.Point(112, 79);
            this.pnlUpdateRegisteredMember.Name = "pnlUpdateRegisteredMember";
            this.pnlUpdateRegisteredMember.Size = new System.Drawing.Size(390, 32);
            this.pnlUpdateRegisteredMember.TabIndex = 109;
            // 
            // btnSearchBookId
            // 
            this.btnSearchBookId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnSearchBookId.Location = new System.Drawing.Point(285, 0);
            this.btnSearchBookId.Name = "btnSearchBookId";
            this.btnSearchBookId.Size = new System.Drawing.Size(103, 30);
            this.btnSearchBookId.TabIndex = 94;
            this.btnSearchBookId.Text = "SEARCH";
            this.btnSearchBookId.UseVisualStyleBackColor = false;
            this.btnSearchBookId.Click += new System.EventHandler(this.btnSearchBookId_Click);
            // 
            // txtSearchRemoveBookID
            // 
            this.txtSearchRemoveBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchRemoveBookID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchRemoveBookID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRemoveBookID.Location = new System.Drawing.Point(149, 0);
            this.txtSearchRemoveBookID.MaxLength = 7;
            this.txtSearchRemoveBookID.Name = "txtSearchRemoveBookID";
            this.txtSearchRemoveBookID.Size = new System.Drawing.Size(103, 27);
            this.txtSearchRemoveBookID.TabIndex = 96;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(3, 3);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(113, 21);
            this.lblBookID.TabIndex = 95;
            this.lblBookID.Text = "Enter Book ID";
            // 
            // btnRemoveBookConfirm
            // 
            this.btnRemoveBookConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnRemoveBookConfirm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnRemoveBookConfirm.Location = new System.Drawing.Point(243, 409);
            this.btnRemoveBookConfirm.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnRemoveBookConfirm.Name = "btnRemoveBookConfirm";
            this.btnRemoveBookConfirm.Size = new System.Drawing.Size(135, 31);
            this.btnRemoveBookConfirm.TabIndex = 111;
            this.btnRemoveBookConfirm.Text = "Remove Book";
            this.btnRemoveBookConfirm.UseVisualStyleBackColor = false;
            this.btnRemoveBookConfirm.Visible = false;
            this.btnRemoveBookConfirm.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // grpRemoveBook
            // 
            this.grpRemoveBook.Controls.Add(this.lblBookDetails);
            this.grpRemoveBook.Location = new System.Drawing.Point(62, 131);
            this.grpRemoveBook.Name = "grpRemoveBook";
            this.grpRemoveBook.Size = new System.Drawing.Size(490, 274);
            this.grpRemoveBook.TabIndex = 112;
            this.grpRemoveBook.TabStop = false;
            this.grpRemoveBook.Text = "Remove Book Details";
            this.grpRemoveBook.Visible = false;
            // 
            // lblBookDetails
            // 
            this.lblBookDetails.AutoSize = true;
            this.lblBookDetails.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.lblBookDetails.Location = new System.Drawing.Point(53, 33);
            this.lblBookDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookDetails.Name = "lblBookDetails";
            this.lblBookDetails.Size = new System.Drawing.Size(156, 24);
            this.lblBookDetails.TabIndex = 86;
            this.lblBookDetails.Text = "Remove Book";
            // 
            // frmRemoveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(614, 455);
            this.Controls.Add(this.grpRemoveBook);
            this.Controls.Add(this.btnRemoveBookConfirm);
            this.Controls.Add(this.pnlUpdateRegisteredMember);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.mnuBackStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmRemoveBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Book";
            this.mnuBackStrip.ResumeLayout(false);
            this.mnuBackStrip.PerformLayout();
            this.pnlUpdateRegisteredMember.ResumeLayout(false);
            this.pnlUpdateRegisteredMember.PerformLayout();
            this.grpRemoveBook.ResumeLayout(false);
            this.grpRemoveBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Panel pnlUpdateRegisteredMember;
        private System.Windows.Forms.Button btnSearchBookId;
        private System.Windows.Forms.TextBox txtSearchRemoveBookID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Button btnRemoveBookConfirm;
        private System.Windows.Forms.GroupBox grpRemoveBook;
        private System.Windows.Forms.Label lblBookDetails;
    }
}