namespace LibrarySYS
{
    partial class frmAddMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMember));
            this.mnuAddMemberBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackStrip = new System.Windows.Forms.MenuStrip();
            this.lblRegisterMember = new System.Windows.Forms.Label();
            this.btnRegisterMemberSubmit = new System.Windows.Forms.Button();
            this.grpRegisterMembers = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtForeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.lblEircode = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.Label();
            this.mnuBackStrip.SuspendLayout();
            this.grpRegisterMembers.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAddMemberBack
            // 
            this.mnuAddMemberBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuAddMemberBack.BackColor = System.Drawing.Color.SeaGreen;
            this.mnuAddMemberBack.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.mnuAddMemberBack.Margin = new System.Windows.Forms.Padding(3);
            this.mnuAddMemberBack.Name = "mnuAddMemberBack";
            this.mnuAddMemberBack.Size = new System.Drawing.Size(74, 26);
            this.mnuAddMemberBack.Text = "BACK";
            this.mnuAddMemberBack.Click += new System.EventHandler(this.mnuAddMemberBack_Click);
            // 
            // mnuBackStrip
            // 
            this.mnuBackStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.mnuBackStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBackStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddMemberBack});
            this.mnuBackStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuBackStrip.Name = "mnuBackStrip";
            this.mnuBackStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnuBackStrip.Size = new System.Drawing.Size(918, 38);
            this.mnuBackStrip.TabIndex = 75;
            this.mnuBackStrip.Text = "Back";
            // 
            // lblRegisterMember
            // 
            this.lblRegisterMember.AutoSize = true;
            this.lblRegisterMember.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterMember.Location = new System.Drawing.Point(34, 43);
            this.lblRegisterMember.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegisterMember.Name = "lblRegisterMember";
            this.lblRegisterMember.Size = new System.Drawing.Size(183, 24);
            this.lblRegisterMember.TabIndex = 85;
            this.lblRegisterMember.Text = "Register Member";
            // 
            // btnRegisterMemberSubmit
            // 
            this.btnRegisterMemberSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnRegisterMemberSubmit.Location = new System.Drawing.Point(381, 476);
            this.btnRegisterMemberSubmit.Name = "btnRegisterMemberSubmit";
            this.btnRegisterMemberSubmit.Size = new System.Drawing.Size(157, 43);
            this.btnRegisterMemberSubmit.TabIndex = 93;
            this.btnRegisterMemberSubmit.Text = "Add Member";
            this.btnRegisterMemberSubmit.UseVisualStyleBackColor = false;
            this.btnRegisterMemberSubmit.Click += new System.EventHandler(this.btnRegisterMemberSubmit_Click);
            // 
            // grpRegisterMembers
            // 
            this.grpRegisterMembers.Controls.Add(this.panel1);
            this.grpRegisterMembers.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegisterMembers.Location = new System.Drawing.Point(31, 106);
            this.grpRegisterMembers.Name = "grpRegisterMembers";
            this.grpRegisterMembers.Size = new System.Drawing.Size(856, 364);
            this.grpRegisterMembers.TabIndex = 86;
            this.grpRegisterMembers.TabStop = false;
            this.grpRegisterMembers.Text = "Member Details";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtForeName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEircode);
            this.panel1.Controls.Add(this.lblEircode);
            this.panel1.Controls.Add(this.txtTown);
            this.panel1.Controls.Add(this.lblTown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 335);
            this.panel1.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(462, 271);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(344, 30);
            this.txtEmail.TabIndex = 124;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(456, 230);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 22);
            this.lblEmail.TabIndex = 122;
            this.lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(49, 271);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(344, 30);
            this.txtPhone.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 121;
            this.label1.Text = "Phone";
            // 
            // txtForeName
            // 
            this.txtForeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtForeName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForeName.Location = new System.Drawing.Point(50, 57);
            this.txtForeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtForeName.MaxLength = 20;
            this.txtForeName.Name = "txtForeName";
            this.txtForeName.Size = new System.Drawing.Size(344, 30);
            this.txtForeName.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 120;
            this.label2.Text = "Forename";
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(462, 57);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(344, 30);
            this.txtSurname.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 16);
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
            this.txtEircode.Location = new System.Drawing.Point(462, 156);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(344, 30);
            this.txtEircode.TabIndex = 114;
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEircode.Location = new System.Drawing.Point(456, 115);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(78, 22);
            this.lblEircode.TabIndex = 118;
            this.lblEircode.Text = "Eircode";
            // 
            // txtTown
            // 
            this.txtTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTown.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.Location = new System.Drawing.Point(49, 156);
            this.txtTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTown.MaxLength = 15;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(344, 30);
            this.txtTown.TabIndex = 113;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(44, 115);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(58, 22);
            this.lblTown.TabIndex = 117;
            this.lblTown.Text = "Town";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(721, 71);
            this.lblMemberID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(116, 22);
            this.lblMemberID.TabIndex = 94;
            this.lblMemberID.Tag = " ";
            this.lblMemberID.Text = "Member ID:";
            // 
            // txtMemberID
            // 
            this.txtMemberID.AutoSize = true;
            this.txtMemberID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.txtMemberID.Location = new System.Drawing.Point(841, 71);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(43, 22);
            this.txtMemberID.TabIndex = 95;
            this.txtMemberID.Text = "000";
            // 
            // frmAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(918, 538);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.grpRegisterMembers);
            this.Controls.Add(this.lblRegisterMember);
            this.Controls.Add(this.mnuBackStrip);
            this.Controls.Add(this.btnRegisterMemberSubmit);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Member";
            this.Load += new System.EventHandler(this.frmAddMember_Load);
            this.mnuBackStrip.ResumeLayout(false);
            this.mnuBackStrip.PerformLayout();
            this.grpRegisterMembers.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuAddMemberBack;
        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.Label lblRegisterMember;
        private System.Windows.Forms.Button btnRegisterMemberSubmit;
        private System.Windows.Forms.GroupBox grpRegisterMembers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtForeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label txtMemberID;
    }
}