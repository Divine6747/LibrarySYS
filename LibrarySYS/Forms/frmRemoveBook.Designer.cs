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
            this.txtSearchUpdateBookID = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.lblPublication = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtUpdateISBN = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtUpdateBookAuthor = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpPublication = new System.Windows.Forms.DateTimePicker();
            this.grpUpdateBook = new System.Windows.Forms.GroupBox();
            this.mnuBackStrip.SuspendLayout();
            this.pnlUpdateRegisteredMember.SuspendLayout();
            this.grpUpdateBook.SuspendLayout();
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
            this.mnuBackStrip.Size = new System.Drawing.Size(869, 38);
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
            this.pnlUpdateRegisteredMember.Controls.Add(this.txtSearchUpdateBookID);
            this.pnlUpdateRegisteredMember.Controls.Add(this.lblBookID);
            this.pnlUpdateRegisteredMember.Location = new System.Drawing.Point(158, 79);
            this.pnlUpdateRegisteredMember.Name = "pnlUpdateRegisteredMember";
            this.pnlUpdateRegisteredMember.Size = new System.Drawing.Size(519, 37);
            this.pnlUpdateRegisteredMember.TabIndex = 109;
            // 
            // btnSearchBookId
            // 
            this.btnSearchBookId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnSearchBookId.Location = new System.Drawing.Point(331, 0);
            this.btnSearchBookId.Name = "btnSearchBookId";
            this.btnSearchBookId.Size = new System.Drawing.Size(187, 39);
            this.btnSearchBookId.TabIndex = 94;
            this.btnSearchBookId.Text = "SEARCH";
            this.btnSearchBookId.UseVisualStyleBackColor = false;
            this.btnSearchBookId.Click += new System.EventHandler(this.btnSearchBookId_Click);
            // 
            // txtSearchUpdateBookID
            // 
            this.txtSearchUpdateBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchUpdateBookID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchUpdateBookID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUpdateBookID.Location = new System.Drawing.Point(147, 3);
            this.txtSearchUpdateBookID.MaxLength = 7;
            this.txtSearchUpdateBookID.Name = "txtSearchUpdateBookID";
            this.txtSearchUpdateBookID.Size = new System.Drawing.Size(170, 27);
            this.txtSearchUpdateBookID.TabIndex = 96;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(3, 8);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(113, 21);
            this.lblBookID.TabIndex = 95;
            this.lblBookID.Text = "Enter Book ID";
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnRemoveBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBook.Location = new System.Drawing.Point(333, 586);
            this.btnRemoveBook.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(202, 40);
            this.btnRemoveBook.TabIndex = 111;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.UseVisualStyleBackColor = false;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // lblPublication
            // 
            this.lblPublication.AutoSize = true;
            this.lblPublication.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublication.Location = new System.Drawing.Point(387, 139);
            this.lblPublication.Name = "lblPublication";
            this.lblPublication.Size = new System.Drawing.Size(111, 22);
            this.lblPublication.TabIndex = 110;
            this.lblPublication.Text = "Publication";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(387, 246);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(111, 22);
            this.lblDescription.TabIndex = 109;
            this.lblDescription.Text = "Description";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(387, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(43, 22);
            this.lblTitle.TabIndex = 111;
            this.lblTitle.Text = "Title";
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateTitle.Location = new System.Drawing.Point(392, 81);
            this.txtUpdateTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateTitle.MaxLength = 25;
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(282, 30);
            this.txtUpdateTitle.TabIndex = 102;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(21, 32);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(49, 22);
            this.lblISBN.TabIndex = 112;
            this.lblISBN.Text = "ISBN";
            // 
            // txtUpdateISBN
            // 
            this.txtUpdateISBN.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateISBN.Location = new System.Drawing.Point(25, 81);
            this.txtUpdateISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateISBN.MaxLength = 10;
            this.txtUpdateISBN.Name = "txtUpdateISBN";
            this.txtUpdateISBN.Size = new System.Drawing.Size(282, 30);
            this.txtUpdateISBN.TabIndex = 101;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(21, 139);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(74, 22);
            this.lblAuthor.TabIndex = 114;
            this.lblAuthor.Text = "Author";
            // 
            // txtUpdateBookAuthor
            // 
            this.txtUpdateBookAuthor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateBookAuthor.Location = new System.Drawing.Point(21, 188);
            this.txtUpdateBookAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateBookAuthor.MaxLength = 35;
            this.txtUpdateBookAuthor.Name = "txtUpdateBookAuthor";
            this.txtUpdateBookAuthor.Size = new System.Drawing.Size(282, 30);
            this.txtUpdateBookAuthor.TabIndex = 103;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(21, 246);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(69, 22);
            this.lblGenre.TabIndex = 115;
            this.lblGenre.Text = "Genre";
            // 
            // cboGenre
            // 
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(25, 295);
            this.cboGenre.Margin = new System.Windows.Forms.Padding(4);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(282, 29);
            this.cboGenre.TabIndex = 104;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(392, 295);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(386, 122);
            this.txtDescription.TabIndex = 106;
            // 
            // dtpPublication
            // 
            this.dtpPublication.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPublication.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPublication.Location = new System.Drawing.Point(392, 188);
            this.dtpPublication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPublication.MaxDate = new System.DateTime(5000, 1, 1, 0, 0, 0, 0);
            this.dtpPublication.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtpPublication.Name = "dtpPublication";
            this.dtpPublication.Size = new System.Drawing.Size(265, 30);
            this.dtpPublication.TabIndex = 105;
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
            this.grpUpdateBook.Location = new System.Drawing.Point(42, 144);
            this.grpUpdateBook.Name = "grpUpdateBook";
            this.grpUpdateBook.Size = new System.Drawing.Size(785, 427);
            this.grpUpdateBook.TabIndex = 112;
            this.grpUpdateBook.TabStop = false;
            this.grpUpdateBook.Text = "Remove Book Details";
            // 
            // frmRemoveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(869, 635);
            this.Controls.Add(this.grpUpdateBook);
            this.Controls.Add(this.btnRemoveBook);
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
            this.grpUpdateBook.ResumeLayout(false);
            this.grpUpdateBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Panel pnlUpdateRegisteredMember;
        private System.Windows.Forms.Button btnSearchBookId;
        private System.Windows.Forms.TextBox txtSearchUpdateBookID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Label lblPublication;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtUpdateISBN;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtUpdateBookAuthor;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpPublication;
        private System.Windows.Forms.GroupBox grpUpdateBook;
    }
}