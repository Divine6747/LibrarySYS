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
            this.grpRegisterMembers = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.lblEircode = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btMemberSearch = new System.Windows.Forms.Button();
            this.txtSearchMemberID = new System.Windows.Forms.TextBox();
            this.lblUpdateMemerID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mnuBackStrip.SuspendLayout();
            this.grpRegisterMembers.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUpdateMemberBack
            // 
            this.mnuUpdateMemberBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuUpdateMemberBack.BackColor = System.Drawing.Color.SeaGreen;
            this.mnuUpdateMemberBack.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuUpdateMemberBack.Margin = new System.Windows.Forms.Padding(3);
            this.mnuUpdateMemberBack.Name = "mnuUpdateMemberBack";
            this.mnuUpdateMemberBack.Size = new System.Drawing.Size(74, 26);
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
            this.mnuBackStrip.Size = new System.Drawing.Size(793, 38);
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
            this.lblUpdateRegisterMember.Size = new System.Drawing.Size(293, 24);
            this.lblUpdateRegisterMember.TabIndex = 85;
            this.lblUpdateRegisterMember.Text = "Update Registered Member";
            // 
            // grpRegisterMembers
            // 
            this.grpRegisterMembers.Controls.Add(this.panel1);
            this.grpRegisterMembers.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegisterMembers.Location = new System.Drawing.Point(27, 135);
            this.grpRegisterMembers.Name = "grpRegisterMembers";
            this.grpRegisterMembers.Size = new System.Drawing.Size(739, 370);
            this.grpRegisterMembers.TabIndex = 98;
            this.grpRegisterMembers.TabStop = false;
            this.grpRegisterMembers.Text = "Member Details";
            this.grpRegisterMembers.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboCounty);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtForename);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEircode);
            this.panel1.Controls.Add(this.lblEircode);
            this.panel1.Controls.Add(this.lblCounty);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 341);
            this.panel1.TabIndex = 0;
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(26, 176);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(307, 29);
            this.cboCounty.TabIndex = 125;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(409, 283);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(307, 30);
            this.txtEmail.TabIndex = 124;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(405, 233);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 22);
            this.lblEmail.TabIndex = 122;
            this.lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(24, 283);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(307, 30);
            this.txtPhone.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 121;
            this.label1.Text = "Phone";
            // 
            // txtForename
            // 
            this.txtForename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtForename.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(26, 67);
            this.txtForename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtForename.MaxLength = 20;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(307, 30);
            this.txtForename.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 120;
            this.label2.Text = "Forename";
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(409, 67);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(307, 30);
            this.txtSurname.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 119;
            this.label3.Text = "Surname";
            // 
            // txtEircode
            // 
            this.txtEircode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEircode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEircode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEircode.Location = new System.Drawing.Point(409, 175);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(307, 30);
            this.txtEircode.TabIndex = 114;
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEircode.Location = new System.Drawing.Point(405, 125);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(78, 22);
            this.lblEircode.TabIndex = 118;
            this.lblEircode.Text = "Eircode";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(22, 125);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(79, 22);
            this.lblCounty.TabIndex = 117;
            this.lblCounty.Text = "County";
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnUpdateMember.Location = new System.Drawing.Point(346, 511);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(100, 43);
            this.btnUpdateMember.TabIndex = 99;
            this.btnUpdateMember.Text = "Update";
            this.btnUpdateMember.UseVisualStyleBackColor = false;
            this.btnUpdateMember.Visible = false;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // btMemberSearch
            // 
            this.btMemberSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btMemberSearch.Location = new System.Drawing.Point(269, 0);
            this.btMemberSearch.Name = "btMemberSearch";
            this.btMemberSearch.Size = new System.Drawing.Size(109, 27);
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
            this.txtSearchMemberID.Location = new System.Drawing.Point(145, 0);
            this.txtSearchMemberID.MaxLength = 7;
            this.txtSearchMemberID.Name = "txtSearchMemberID";
            this.txtSearchMemberID.Size = new System.Drawing.Size(109, 27);
            this.txtSearchMemberID.TabIndex = 96;
            // 
            // lblUpdateMemerID
            // 
            this.lblUpdateMemerID.AutoSize = true;
            this.lblUpdateMemerID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateMemerID.Location = new System.Drawing.Point(-1, 3);
            this.lblUpdateMemerID.Name = "lblUpdateMemerID";
            this.lblUpdateMemerID.Size = new System.Drawing.Size(131, 21);
            this.lblUpdateMemerID.TabIndex = 95;
            this.lblUpdateMemerID.Text = "Enter Memer ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btMemberSearch);
            this.panel2.Controls.Add(this.lblUpdateMemerID);
            this.panel2.Controls.Add(this.txtSearchMemberID);
            this.panel2.Location = new System.Drawing.Point(197, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 33);
            this.panel2.TabIndex = 102;
            // 
            // frmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(793, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grpRegisterMembers);
            this.Controls.Add(this.btnUpdateMember);
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
            this.grpRegisterMembers.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuUpdateMemberBack;
        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.Label lblUpdateRegisterMember;
        private System.Windows.Forms.GroupBox grpRegisterMembers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.Button btMemberSearch;
        private System.Windows.Forms.TextBox txtSearchMemberID;
        private System.Windows.Forms.Label lblUpdateMemerID;
        private System.Windows.Forms.Panel panel2;
    }
}