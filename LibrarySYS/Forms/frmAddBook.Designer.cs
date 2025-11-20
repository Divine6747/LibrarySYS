namespace LibrarySYS
{
    partial class frmAddBook

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBook));
            this.mnuAddBookBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackStrip = new System.Windows.Forms.MenuStrip();
            this.lblAddBook = new System.Windows.Forms.Label();
            this.grpAddBook = new System.Windows.Forms.GroupBox();
            this.dtpPublication = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPublication = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.mnuBackStrip.SuspendLayout();
            this.grpAddBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAddBookBack
            // 
            this.mnuAddBookBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuAddBookBack.BackColor = System.Drawing.Color.SeaGreen;
            this.mnuAddBookBack.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAddBookBack.Margin = new System.Windows.Forms.Padding(3);
            this.mnuAddBookBack.Name = "mnuAddBookBack";
            this.mnuAddBookBack.Size = new System.Drawing.Size(89, 31);
            this.mnuAddBookBack.Text = "BACK";
            this.mnuAddBookBack.Click += new System.EventHandler(this.mnuAddBookBack_Click);
            // 
            // mnuBackStrip
            // 
            this.mnuBackStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.mnuBackStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBackStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddBookBack});
            this.mnuBackStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuBackStrip.Name = "mnuBackStrip";
            this.mnuBackStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnuBackStrip.Size = new System.Drawing.Size(917, 43);
            this.mnuBackStrip.TabIndex = 75;
            this.mnuBackStrip.Text = "Back";
            // 
            // lblAddBook
            // 
            this.lblAddBook.AutoSize = true;
            this.lblAddBook.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBook.Location = new System.Drawing.Point(29, 43);
            this.lblAddBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddBook.Name = "lblAddBook";
            this.lblAddBook.Size = new System.Drawing.Size(145, 33);
            this.lblAddBook.TabIndex = 85;
            this.lblAddBook.Text = "Add Book";
            // 
            // grpAddBook
            // 
            this.grpAddBook.Controls.Add(this.dtpPublication);
            this.grpAddBook.Controls.Add(this.txtDescription);
            this.grpAddBook.Controls.Add(this.cboGenre);
            this.grpAddBook.Controls.Add(this.lblGenre);
            this.grpAddBook.Controls.Add(this.txtAuthor);
            this.grpAddBook.Controls.Add(this.lblAuthor);
            this.grpAddBook.Controls.Add(this.txtISBN);
            this.grpAddBook.Controls.Add(this.lblISBN);
            this.grpAddBook.Controls.Add(this.txtTitle);
            this.grpAddBook.Controls.Add(this.lblTitle);
            this.grpAddBook.Controls.Add(this.lblDescription);
            this.grpAddBook.Controls.Add(this.lblPublication);
            this.grpAddBook.Location = new System.Drawing.Point(35, 96);
            this.grpAddBook.Name = "grpAddBook";
            this.grpAddBook.Size = new System.Drawing.Size(846, 456);
            this.grpAddBook.TabIndex = 86;
            this.grpAddBook.TabStop = false;
            this.grpAddBook.Text = "Book Details";
            // 
            // dtpPublication
            // 
            this.dtpPublication.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPublication.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPublication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpPublication.Location = new System.Drawing.Point(442, 211);
            this.dtpPublication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPublication.MaxDate = new System.DateTime(5000, 1, 1, 0, 0, 0, 0);
            this.dtpPublication.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtpPublication.Name = "dtpPublication";
            this.dtpPublication.Size = new System.Drawing.Size(309, 36);
            this.dtpPublication.TabIndex = 105;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(442, 322);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.MaxLength = 1000;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(386, 122);
            this.txtDescription.TabIndex = 106;
            // 
            // cboGenre
            // 
            this.cboGenre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(50, 322);
            this.cboGenre.Margin = new System.Windows.Forms.Padding(4);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(309, 37);
            this.cboGenre.TabIndex = 104;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(45, 271);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(83, 27);
            this.lblGenre.TabIndex = 115;
            this.lblGenre.Text = "Genre";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(46, 211);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAuthor.MaxLength = 35;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(309, 36);
            this.txtAuthor.TabIndex = 103;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(45, 160);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(87, 27);
            this.lblAuthor.TabIndex = 114;
            this.lblAuthor.Text = "Author";
            // 
            // txtISBN
            // 
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISBN.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(50, 100);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtISBN.MaxLength = 10;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(309, 36);
            this.txtISBN.TabIndex = 101;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(45, 49);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(59, 27);
            this.lblISBN.TabIndex = 112;
            this.lblISBN.Text = "ISBN";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(442, 100);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.MaxLength = 25;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(309, 36);
            this.txtTitle.TabIndex = 102;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(437, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 27);
            this.lblTitle.TabIndex = 111;
            this.lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(437, 271);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(140, 27);
            this.lblDescription.TabIndex = 109;
            this.lblDescription.Text = "Description";
            // 
            // lblPublication
            // 
            this.lblPublication.AutoSize = true;
            this.lblPublication.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublication.Location = new System.Drawing.Point(437, 160);
            this.lblPublication.Name = "lblPublication";
            this.lblPublication.Size = new System.Drawing.Size(142, 27);
            this.lblPublication.TabIndex = 110;
            this.lblPublication.Text = "Publication";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(397, 567);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(133, 40);
            this.btnSubmit.TabIndex = 108;
            this.btnSubmit.Text = "Add Book";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(917, 619);
            this.Controls.Add(this.grpAddBook);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAddBook);
            this.Controls.Add(this.mnuBackStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            this.mnuBackStrip.ResumeLayout(false);
            this.mnuBackStrip.PerformLayout();
            this.grpAddBook.ResumeLayout(false);
            this.grpAddBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuAddBookBack;
        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.Label lblAddBook;
        private System.Windows.Forms.GroupBox grpAddBook;
        private System.Windows.Forms.DateTimePicker dtpPublication;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPublication;
    }
}