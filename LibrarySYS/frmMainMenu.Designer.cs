namespace LibrarySYS
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mnuMainManu = new System.Windows.Forms.MenuStrip();
            this.mnuMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeregisterMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReserveBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCollectBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.munExit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuMainManu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainManu
            // 
            this.mnuMainManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.mnuMainManu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMainManu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainManu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMember,
            this.mnuBook,
            this.mnuLoan});
            this.mnuMainManu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mnuMainManu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainManu.Name = "mnuMainManu";
            this.mnuMainManu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuMainManu.Size = new System.Drawing.Size(884, 29);
            this.mnuMainManu.TabIndex = 1;
            this.mnuMainManu.Text = "Manu";
            // 
            // mnuMember
            // 
            this.mnuMember.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddMember,
            this.mnuUpdateMember,
            this.mnuDeregisterMember});
            this.mnuMember.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMember.Name = "mnuMember";
            this.mnuMember.Padding = new System.Windows.Forms.Padding(4, 0, 60, 0);
            this.mnuMember.Size = new System.Drawing.Size(149, 25);
            this.mnuMember.Text = "Member";
            // 
            // mnuAddMember
            // 
            this.mnuAddMember.Name = "mnuAddMember";
            this.mnuAddMember.Size = new System.Drawing.Size(240, 26);
            this.mnuAddMember.Text = "Register Member";
            this.mnuAddMember.Click += new System.EventHandler(this.mnuAddMember_Click);
            // 
            // mnuUpdateMember
            // 
            this.mnuUpdateMember.Name = "mnuUpdateMember";
            this.mnuUpdateMember.Size = new System.Drawing.Size(240, 26);
            this.mnuUpdateMember.Text = "Update Member";
            this.mnuUpdateMember.Click += new System.EventHandler(this.mnuUpdateMember_Click);
            // 
            // mnuDeregisterMember
            // 
            this.mnuDeregisterMember.Name = "mnuDeregisterMember";
            this.mnuDeregisterMember.Size = new System.Drawing.Size(240, 26);
            this.mnuDeregisterMember.Text = "Deregister Member";
            this.mnuDeregisterMember.Click += new System.EventHandler(this.mnuDeregisterMember_Click);
            // 
            // mnuBook
            // 
            this.mnuBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddBook,
            this.mnuUpdateBook,
            this.mnuRemoveBook});
            this.mnuBook.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBook.Name = "mnuBook";
            this.mnuBook.Padding = new System.Windows.Forms.Padding(4, 0, 60, 0);
            this.mnuBook.Size = new System.Drawing.Size(119, 25);
            this.mnuBook.Text = "Book";
            // 
            // mnuAddBook
            // 
            this.mnuAddBook.Name = "mnuAddBook";
            this.mnuAddBook.Size = new System.Drawing.Size(195, 26);
            this.mnuAddBook.Text = "Add Book";
            this.mnuAddBook.Click += new System.EventHandler(this.mnuAddBook_Click);
            // 
            // mnuUpdateBook
            // 
            this.mnuUpdateBook.Name = "mnuUpdateBook";
            this.mnuUpdateBook.Size = new System.Drawing.Size(195, 26);
            this.mnuUpdateBook.Text = "Update Book";
            this.mnuUpdateBook.Click += new System.EventHandler(this.mnuUpdateBook_Click);
            // 
            // mnuRemoveBook
            // 
            this.mnuRemoveBook.Name = "mnuRemoveBook";
            this.mnuRemoveBook.Size = new System.Drawing.Size(195, 26);
            this.mnuRemoveBook.Text = "Remove Book";
            this.mnuRemoveBook.Click += new System.EventHandler(this.mnuRemoveBook_Click);
            // 
            // mnuLoan
            // 
            this.mnuLoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReserveBook,
            this.mnuCollectBook,
            this.mnuReturnBook});
            this.mnuLoan.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuLoan.Name = "mnuLoan";
            this.mnuLoan.Padding = new System.Windows.Forms.Padding(4, 0, 60, 0);
            this.mnuLoan.Size = new System.Drawing.Size(119, 25);
            this.mnuLoan.Text = "Loan";
            // 
            // mnuReserveBook
            // 
            this.mnuReserveBook.Name = "mnuReserveBook";
            this.mnuReserveBook.Size = new System.Drawing.Size(192, 26);
            this.mnuReserveBook.Text = "Reserve Book";
            this.mnuReserveBook.Click += new System.EventHandler(this.mnuReserveBook_Click);
            // 
            // mnuCollectBook
            // 
            this.mnuCollectBook.Name = "mnuCollectBook";
            this.mnuCollectBook.Size = new System.Drawing.Size(192, 26);
            this.mnuCollectBook.Text = "Collect Book";
            // 
            // mnuReturnBook
            // 
            this.mnuReturnBook.Name = "mnuReturnBook";
            this.mnuReturnBook.Size = new System.Drawing.Size(192, 26);
            this.mnuReturnBook.Text = "Return Book";
            // 
            // munExit
            // 
            this.munExit.AutoSize = true;
            this.munExit.BackColor = System.Drawing.Color.SeaGreen;
            this.munExit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munExit.Location = new System.Drawing.Point(828, 2);
            this.munExit.Name = "munExit";
            this.munExit.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.munExit.Size = new System.Drawing.Size(59, 26);
            this.munExit.TabIndex = 14;
            this.munExit.Text = "Exit";
            this.munExit.Click += new System.EventHandler(this.munExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LibrarySYS.Properties.Resources.Library;
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(884, 532);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.munExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuMainManu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.mnuMainManu.ResumeLayout(false);
            this.mnuMainManu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip mnuMainManu;
        private System.Windows.Forms.ToolStripMenuItem mnuMember;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMember;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateMember;
        private System.Windows.Forms.ToolStripMenuItem mnuDeregisterMember;
        private System.Windows.Forms.ToolStripMenuItem mnuBook;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBook;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveBook;
        private System.Windows.Forms.ToolStripMenuItem mnuLoan;
        private System.Windows.Forms.ToolStripMenuItem mnuReserveBook;
        private System.Windows.Forms.ToolStripMenuItem mnuCollectBook;
        private System.Windows.Forms.ToolStripMenuItem mnuReturnBook;
        private System.Windows.Forms.Label munExit;
    }
}