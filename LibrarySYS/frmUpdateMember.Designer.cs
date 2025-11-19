namespace LibrarySYS
{
    partial class frmUpdateMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateMember));
            this.mnuUpdateMemberBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackStrip = new System.Windows.Forms.MenuStrip();
            this.lblUpdateRegisterMember = new System.Windows.Forms.Label();
            this.pnlUpdateRegisteredMember = new System.Windows.Forms.Panel();
            this.btMemberSearch = new System.Windows.Forms.Button();
            this.txtSearchMemberID = new System.Windows.Forms.TextBox();
            this.lblUpdateMemerID = new System.Windows.Forms.Label();
            this.grpRegisterMembers = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.lblEircode = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.btnRegisterMemberSubmit = new System.Windows.Forms.Button();
            this.mnuBackStrip.SuspendLayout();
            this.pnlUpdateRegisteredMember.SuspendLayout();
            this.grpRegisterMembers.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUpdateMemberBack
            // 
            this.mnuUpdateMemberBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuUpdateMemberBack.BackColor = System.Drawing.Color.SeaGreen;
            this.mnuUpdateMemberBack.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuUpdateMemberBack.Margin = new System.Windows.Forms.Padding(3);
            this.mnuUpdateMemberBack.Name = "mnuUpdateMemberBack";
            this.mnuUpdateMemberBack.Size = new System.Drawing.Size(89, 31);
            this.mnuUpdateMemberBack.Text = "BACK";
            this.mnuUpdateMemberBack.Click += new System.EventHandler(this.mnuUpdateMemberBack_Click_1);
            // 
            // mnuBackStrip
            // 
            this.mnuBackStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.mnuBackStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBackStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdateMemberBack});
            this.mnuBackStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuBackStrip.Name = "mnuBackStrip";
            this.mnuBackStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnuBackStrip.Size = new System.Drawing.Size(916, 43);
            this.mnuBackStrip.TabIndex = 75;
            this.mnuBackStrip.Text = "Back";
            // 
            // lblUpdateRegisterMember
            // 
            this.lblUpdateRegisterMember.AutoSize = true;
            this.lblUpdateRegisterMember.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateRegisterMember.Location = new System.Drawing.Point(48, 43);
            this.lblUpdateRegisterMember.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateRegisterMember.Name = "lblUpdateRegisterMember";
            this.lblUpdateRegisterMember.Size = new System.Drawing.Size(383, 33);
            this.lblUpdateRegisterMember.TabIndex = 85;
            this.lblUpdateRegisterMember.Text = "Update Registered Member";
            // 
            // pnlUpdateRegisteredMember
            // 
            this.pnlUpdateRegisteredMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUpdateRegisteredMember.Controls.Add(this.btMemberSearch);
            this.pnlUpdateRegisteredMember.Controls.Add(this.txtSearchMemberID);
            this.pnlUpdateRegisteredMember.Controls.Add(this.lblUpdateMemerID);
            this.pnlUpdateRegisteredMember.Location = new System.Drawing.Point(163, 94);
            this.pnlUpdateRegisteredMember.Name = "pnlUpdateRegisteredMember";
            this.pnlUpdateRegisteredMember.Size = new System.Drawing.Size(591, 44);
            this.pnlUpdateRegisteredMember.TabIndex = 97;
            // 
            // btMemberSearch
            // 
            this.btMemberSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btMemberSearch.Location = new System.Drawing.Point(400, 0);
            this.btMemberSearch.Name = "btMemberSearch";
            this.btMemberSearch.Size = new System.Drawing.Size(187, 39);
            this.btMemberSearch.TabIndex = 94;
            this.btMemberSearch.Text = "SEARCH";
            this.btMemberSearch.UseVisualStyleBackColor = false;
            this.btMemberSearch.Click += new System.EventHandler(this.btMemberSearch_Click);
            // 
            // txtSearchMemberID
            // 
            this.txtSearchMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchMemberID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchMemberID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMemberID.Location = new System.Drawing.Point(175, 3);
            this.txtSearchMemberID.MaxLength = 7;
            this.txtSearchMemberID.Name = "txtSearchMemberID";
            this.txtSearchMemberID.Size = new System.Drawing.Size(210, 32);
            this.txtSearchMemberID.TabIndex = 96;
            // 
            // lblUpdateMemerID
            // 
            this.lblUpdateMemerID.AutoSize = true;
            this.lblUpdateMemerID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateMemerID.Location = new System.Drawing.Point(1, 8);
            this.lblUpdateMemerID.Name = "lblUpdateMemerID";
            this.lblUpdateMemerID.Size = new System.Drawing.Size(159, 23);
            this.lblUpdateMemerID.TabIndex = 95;
            this.lblUpdateMemerID.Text = "Enter Memer ID";
            // 
            // grpRegisterMembers
            // 
            this.grpRegisterMembers.Controls.Add(this.panel1);
            this.grpRegisterMembers.Controls.Add(this.btnRegisterMemberSubmit);
            this.grpRegisterMembers.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegisterMembers.Location = new System.Drawing.Point(35, 144);
            this.grpRegisterMembers.Name = "grpRegisterMembers";
            this.grpRegisterMembers.Size = new System.Drawing.Size(847, 532);
            this.grpRegisterMembers.TabIndex = 98;
            this.grpRegisterMembers.TabStop = false;
            this.grpRegisterMembers.Text = "Member Details";
            this.grpRegisterMembers.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboCounty);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblCounty);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEircode);
            this.panel1.Controls.Add(this.lblEircode);
            this.panel1.Controls.Add(this.txtTown);
            this.panel1.Controls.Add(this.lblTown);
            this.panel1.Controls.Add(this.txtStreet);
            this.panel1.Controls.Add(this.lblStreet);
            this.panel1.Location = new System.Drawing.Point(3, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 445);
            this.panel1.TabIndex = 0;
            // 
            // cboCounty
            // 
            this.cboCounty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCounty.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboCounty.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(490, 175);
            this.cboCounty.Margin = new System.Windows.Forms.Padding(4);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(307, 37);
            this.cboCounty.TabIndex = 125;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(490, 392);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(307, 36);
            this.txtEmail.TabIndex = 124;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(484, 125);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(95, 27);
            this.lblCounty.TabIndex = 123;
            this.lblCounty.Text = "County";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(484, 342);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 27);
            this.lblEmail.TabIndex = 122;
            this.lblEmail.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(49, 393);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 36);
            this.textBox1.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 121;
            this.label1.Text = "Phone";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(50, 66);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(307, 36);
            this.textBox2.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 27);
            this.label2.TabIndex = 120;
            this.label2.Text = "Forename";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(490, 66);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.MaxLength = 20;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(307, 36);
            this.textBox3.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 27);
            this.label3.TabIndex = 119;
            this.label3.Text = "Surname";
            // 
            // txtEircode
            // 
            this.txtEircode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEircode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEircode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEircode.Location = new System.Drawing.Point(490, 283);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(307, 36);
            this.txtEircode.TabIndex = 114;
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEircode.Location = new System.Drawing.Point(484, 233);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(98, 27);
            this.lblEircode.TabIndex = 118;
            this.lblEircode.Text = "Eircode";
            // 
            // txtTown
            // 
            this.txtTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTown.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.Location = new System.Drawing.Point(49, 284);
            this.txtTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTown.MaxLength = 15;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(307, 36);
            this.txtTown.TabIndex = 113;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(44, 234);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(72, 27);
            this.lblTown.TabIndex = 117;
            this.lblTown.Text = "Town";
            // 
            // txtStreet
            // 
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStreet.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(49, 175);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStreet.MaxLength = 25;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(307, 36);
            this.txtStreet.TabIndex = 112;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(44, 125);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(76, 27);
            this.lblStreet.TabIndex = 116;
            this.lblStreet.Text = "Street";
            // 
            // btnRegisterMemberSubmit
            // 
            this.btnRegisterMemberSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnRegisterMemberSubmit.Location = new System.Drawing.Point(400, 483);
            this.btnRegisterMemberSubmit.Name = "btnRegisterMemberSubmit";
            this.btnRegisterMemberSubmit.Size = new System.Drawing.Size(100, 43);
            this.btnRegisterMemberSubmit.TabIndex = 99;
            this.btnRegisterMemberSubmit.Text = "SUBMIT";
            this.btnRegisterMemberSubmit.UseVisualStyleBackColor = false;
            this.btnRegisterMemberSubmit.Visible = false;
            // 
            // frmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(916, 677);
            this.Controls.Add(this.grpRegisterMembers);
            this.Controls.Add(this.pnlUpdateRegisteredMember);
            this.Controls.Add(this.lblUpdateRegisterMember);
            this.Controls.Add(this.mnuBackStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmUpdateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Member";
            this.Load += new System.EventHandler(this.frmUpdateMember_Load);
            this.mnuBackStrip.ResumeLayout(false);
            this.mnuBackStrip.PerformLayout();
            this.pnlUpdateRegisteredMember.ResumeLayout(false);
            this.pnlUpdateRegisteredMember.PerformLayout();
            this.grpRegisterMembers.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuUpdateMemberBack;
        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.Label lblUpdateRegisterMember;
        private System.Windows.Forms.Panel pnlUpdateRegisteredMember;
        private System.Windows.Forms.Button btMemberSearch;
        private System.Windows.Forms.TextBox txtSearchMemberID;
        private System.Windows.Forms.Label lblUpdateMemerID;
        private System.Windows.Forms.GroupBox grpRegisterMembers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Button btnRegisterMemberSubmit;
    }
}