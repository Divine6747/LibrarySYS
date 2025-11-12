namespace LibrarySYS
{
    partial class frmUpdateBook

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateBook));
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackStrip = new System.Windows.Forms.MenuStrip();
            this.lblUpdateBook = new System.Windows.Forms.Label();
            this.grpUpdateBook = new System.Windows.Forms.GroupBox();
            this.dtpPublication = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtUpdateBookAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtUpdateISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPublication = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlUpdateRegisteredMember = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchUpdateMemberID = new System.Windows.Forms.TextBox();
            this.lblUpdateBookID = new System.Windows.Forms.Label();
            this.mnuBackStrip.SuspendLayout();
            this.grpUpdateBook.SuspendLayout();
            this.pnlUpdateRegisteredMember.SuspendLayout();
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
            this.mnuBackStrip.Size = new System.Drawing.Size(1196, 38);
            this.mnuBackStrip.TabIndex = 75;
            this.mnuBackStrip.Text = "Back";
            // 
            // lblUpdateBook
            // 
            this.lblUpdateBook.AutoSize = true;
            this.lblUpdateBook.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateBook.Location = new System.Drawing.Point(30, 74);
            this.lblUpdateBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateBook.Name = "lblUpdateBook";
            this.lblUpdateBook.Size = new System.Drawing.Size(143, 24);
            this.lblUpdateBook.TabIndex = 85;
            this.lblUpdateBook.Text = "Update Book";
            // 
            // grpUpdateBook
            // 
            this.grpUpdateBook.Controls.Add(this.dtpPublication);
            this.grpUpdateBook.Controls.Add(this.txtDescription);
            this.grpUpdateBook.Controls.Add(this.cboGenre);
            this.grpUpdateBook.Controls.Add(this.lblGenre);
            this.grpUpdateBook.Controls.Add(this.txtUpdateBookAuthor);
            this.grpUpdateBook.Controls.Add(this.lblAuthor);
            this.grpUpdateBook.Controls.Add(this.txtUpdateISBN);
            this.grpUpdateBook.Controls.Add(this.lblISBN);
            this.grpUpdateBook.Controls.Add(this.txtUpdateTitle);
            this.grpUpdateBook.Controls.Add(this.lblTitle);
            this.grpUpdateBook.Controls.Add(this.lblDescription);
            this.grpUpdateBook.Controls.Add(this.lblPublication);
            this.grpUpdateBook.Location = new System.Drawing.Point(71, 129);
            this.grpUpdateBook.Name = "grpUpdateBook";
            this.grpUpdateBook.Size = new System.Drawing.Size(1053, 505);
            this.grpUpdateBook.TabIndex = 86;
            this.grpUpdateBook.TabStop = false;
            this.grpUpdateBook.Text = "Update BookDetails";
            this.grpUpdateBook.Visible = false;
            // 
            // dtpPublication
            // 
            this.dtpPublication.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPublication.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPublication.Location = new System.Drawing.Point(670, 220);
            this.dtpPublication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPublication.MaxDate = new System.DateTime(5000, 1, 1, 0, 0, 0, 0);
            this.dtpPublication.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtpPublication.Name = "dtpPublication";
            this.dtpPublication.Size = new System.Drawing.Size(265, 30);
            this.dtpPublication.TabIndex = 105;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(670, 361);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(356, 122);
            this.txtDescription.TabIndex = 106;
            // 
            // cboGenre
            // 
            this.cboGenre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(50, 361);
            this.cboGenre.Margin = new System.Windows.Forms.Padding(4);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(284, 29);
            this.cboGenre.TabIndex = 104;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(45, 325);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(69, 22);
            this.lblGenre.TabIndex = 115;
            this.lblGenre.Text = "Genre";
            // 
            // txtUpdateBookAuthor
            // 
            this.txtUpdateBookAuthor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateBookAuthor.Location = new System.Drawing.Point(46, 220);
            this.txtUpdateBookAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateBookAuthor.MaxLength = 35;
            this.txtUpdateBookAuthor.Name = "txtUpdateBookAuthor";
            this.txtUpdateBookAuthor.Size = new System.Drawing.Size(284, 30);
            this.txtUpdateBookAuthor.TabIndex = 103;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(45, 184);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(74, 22);
            this.lblAuthor.TabIndex = 114;
            this.lblAuthor.Text = "Author";
            // 
            // txtUpdateISBN
            // 
            this.txtUpdateISBN.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateISBN.Location = new System.Drawing.Point(50, 79);
            this.txtUpdateISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateISBN.MaxLength = 10;
            this.txtUpdateISBN.Name = "txtUpdateISBN";
            this.txtUpdateISBN.Size = new System.Drawing.Size(284, 30);
            this.txtUpdateISBN.TabIndex = 101;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(45, 43);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(49, 22);
            this.lblISBN.TabIndex = 112;
            this.lblISBN.Text = "ISBN";
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateTitle.Location = new System.Drawing.Point(670, 79);
            this.txtUpdateTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateTitle.MaxLength = 25;
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(284, 30);
            this.txtUpdateTitle.TabIndex = 102;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(665, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(43, 22);
            this.lblTitle.TabIndex = 111;
            this.lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(667, 325);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(111, 22);
            this.lblDescription.TabIndex = 109;
            this.lblDescription.Text = "Description";
            // 
            // lblPublication
            // 
            this.lblPublication.AutoSize = true;
            this.lblPublication.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublication.Location = new System.Drawing.Point(665, 184);
            this.lblPublication.Name = "lblPublication";
            this.lblPublication.Size = new System.Drawing.Size(111, 22);
            this.lblPublication.TabIndex = 110;
            this.lblPublication.Text = "Publication";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(484, 649);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(133, 49);
            this.btnSubmit.TabIndex = 108;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // pnlUpdateRegisteredMember
            // 
            this.pnlUpdateRegisteredMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUpdateRegisteredMember.Controls.Add(this.btnSearch);
            this.pnlUpdateRegisteredMember.Controls.Add(this.txtSearchUpdateMemberID);
            this.pnlUpdateRegisteredMember.Controls.Add(this.lblUpdateBookID);
            this.pnlUpdateRegisteredMember.Location = new System.Drawing.Point(237, 58);
            this.pnlUpdateRegisteredMember.Name = "pnlUpdateRegisteredMember";
            this.pnlUpdateRegisteredMember.Size = new System.Drawing.Size(720, 65);
            this.pnlUpdateRegisteredMember.TabIndex = 110;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnSearch.Location = new System.Drawing.Point(490, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(187, 39);
            this.btnSearch.TabIndex = 94;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearchUpdateMemberID
            // 
            this.txtSearchUpdateMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchUpdateMemberID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchUpdateMemberID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUpdateMemberID.Location = new System.Drawing.Point(243, 18);
            this.txtSearchUpdateMemberID.MaxLength = 7;
            this.txtSearchUpdateMemberID.Name = "txtSearchUpdateMemberID";
            this.txtSearchUpdateMemberID.Size = new System.Drawing.Size(170, 27);
            this.txtSearchUpdateMemberID.TabIndex = 96;
            // 
            // lblUpdateBookID
            // 
            this.lblUpdateBookID.AutoSize = true;
            this.lblUpdateBookID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateBookID.Location = new System.Drawing.Point(7, 23);
            this.lblUpdateBookID.Name = "lblUpdateBookID";
            this.lblUpdateBookID.Size = new System.Drawing.Size(113, 21);
            this.lblUpdateBookID.TabIndex = 95;
            this.lblUpdateBookID.Text = "Enter Book ID";
            // 
            // frmUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1196, 713);
            this.Controls.Add(this.pnlUpdateRegisteredMember);
            this.Controls.Add(this.grpUpdateBook);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblUpdateBook);
            this.Controls.Add(this.mnuBackStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmUpdateBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Book";
            this.mnuBackStrip.ResumeLayout(false);
            this.mnuBackStrip.PerformLayout();
            this.grpUpdateBook.ResumeLayout(false);
            this.grpUpdateBook.PerformLayout();
            this.pnlUpdateRegisteredMember.ResumeLayout(false);
            this.pnlUpdateRegisteredMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.Label lblUpdateBook;
        private System.Windows.Forms.GroupBox grpUpdateBook;
        private System.Windows.Forms.DateTimePicker dtpPublication;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtUpdateBookAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtUpdateISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPublication;
        private System.Windows.Forms.Panel pnlUpdateRegisteredMember;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchUpdateMemberID;
        private System.Windows.Forms.Label lblUpdateBookID;
    }
}