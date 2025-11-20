namespace LibrarySYS
{
    partial class frmDeregisterMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeregisterMember));
            this.mnuDeregisterMemberBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackStrip = new System.Windows.Forms.MenuStrip();
            this.lblDeregisterMember = new System.Windows.Forms.Label();
            this.grpDeregisterMember = new System.Windows.Forms.GroupBox();
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
            this.btnDegeristerMemberConfirm = new System.Windows.Forms.Button();
            this.pnlUpdateRegisteredMember = new System.Windows.Forms.Panel();
            this.btnSearchDeregisteredMember = new System.Windows.Forms.Button();
            this.txtSearchDegisterMemberID = new System.Windows.Forms.TextBox();
            this.lblDegesterMemerID = new System.Windows.Forms.Label();
            this.mnuBackStrip.SuspendLayout();
            this.grpDeregisterMember.SuspendLayout();
            this.pnlUpdateRegisteredMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuDeregisterMemberBack
            // 
            this.mnuDeregisterMemberBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuDeregisterMemberBack.BackColor = System.Drawing.Color.SeaGreen;
            this.mnuDeregisterMemberBack.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDeregisterMemberBack.Margin = new System.Windows.Forms.Padding(3);
            this.mnuDeregisterMemberBack.Name = "mnuDeregisterMemberBack";
            this.mnuDeregisterMemberBack.Size = new System.Drawing.Size(74, 26);
            this.mnuDeregisterMemberBack.Text = "BACK";
            // 
            // mnuBackStrip
            // 
            this.mnuBackStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.mnuBackStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBackStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeregisterMemberBack});
            this.mnuBackStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuBackStrip.Name = "mnuBackStrip";
            this.mnuBackStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnuBackStrip.Size = new System.Drawing.Size(893, 38);
            this.mnuBackStrip.TabIndex = 75;
            this.mnuBackStrip.Text = "Back";
            // 
            // lblDeregisterMember
            // 
            this.lblDeregisterMember.AutoSize = true;
            this.lblDeregisterMember.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeregisterMember.Location = new System.Drawing.Point(27, 49);
            this.lblDeregisterMember.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeregisterMember.Name = "lblDeregisterMember";
            this.lblDeregisterMember.Size = new System.Drawing.Size(212, 24);
            this.lblDeregisterMember.TabIndex = 85;
            this.lblDeregisterMember.Text = " Deregister Member";
            // 
            // grpDeregisterMember
            // 
            this.grpDeregisterMember.Controls.Add(this.txtEmail);
            this.grpDeregisterMember.Controls.Add(this.lblEmail);
            this.grpDeregisterMember.Controls.Add(this.txtPhone);
            this.grpDeregisterMember.Controls.Add(this.label1);
            this.grpDeregisterMember.Controls.Add(this.txtForeName);
            this.grpDeregisterMember.Controls.Add(this.label2);
            this.grpDeregisterMember.Controls.Add(this.txtSurname);
            this.grpDeregisterMember.Controls.Add(this.label3);
            this.grpDeregisterMember.Controls.Add(this.txtEircode);
            this.grpDeregisterMember.Controls.Add(this.lblEircode);
            this.grpDeregisterMember.Controls.Add(this.txtTown);
            this.grpDeregisterMember.Controls.Add(this.lblTown);
            this.grpDeregisterMember.Location = new System.Drawing.Point(28, 130);
            this.grpDeregisterMember.Name = "grpDeregisterMember";
            this.grpDeregisterMember.Size = new System.Drawing.Size(832, 370);
            this.grpDeregisterMember.TabIndex = 86;
            this.grpDeregisterMember.TabStop = false;
            this.grpDeregisterMember.Text = "Member Information";
            this.grpDeregisterMember.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(444, 300);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(344, 30);
            this.txtEmail.TabIndex = 140;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(438, 259);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 22);
            this.lblEmail.TabIndex = 138;
            this.lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(25, 300);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(344, 30);
            this.txtPhone.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 137;
            this.label1.Text = "Phone";
            // 
            // txtForeName
            // 
            this.txtForeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtForeName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForeName.Location = new System.Drawing.Point(28, 76);
            this.txtForeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtForeName.MaxLength = 20;
            this.txtForeName.Name = "txtForeName";
            this.txtForeName.Size = new System.Drawing.Size(344, 30);
            this.txtForeName.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 136;
            this.label2.Text = "Forename";
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(446, 76);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(344, 30);
            this.txtSurname.TabIndex = 127;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 135;
            this.label3.Text = "Surname";
            // 
            // txtEircode
            // 
            this.txtEircode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEircode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEircode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEircode.Location = new System.Drawing.Point(444, 185);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(344, 30);
            this.txtEircode.TabIndex = 130;
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEircode.Location = new System.Drawing.Point(438, 144);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(78, 22);
            this.lblEircode.TabIndex = 134;
            this.lblEircode.Text = "Eircode";
            // 
            // txtTown
            // 
            this.txtTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTown.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.Location = new System.Drawing.Point(25, 185);
            this.txtTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTown.MaxLength = 15;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(344, 30);
            this.txtTown.TabIndex = 129;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(20, 144);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(58, 22);
            this.lblTown.TabIndex = 133;
            this.lblTown.Text = "Town";
            // 
            // btnDegeristerMemberConfirm
            // 
            this.btnDegeristerMemberConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnDegeristerMemberConfirm.CausesValidation = false;
            this.btnDegeristerMemberConfirm.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDegeristerMemberConfirm.Location = new System.Drawing.Point(371, 517);
            this.btnDegeristerMemberConfirm.Name = "btnDegeristerMemberConfirm";
            this.btnDegeristerMemberConfirm.Size = new System.Drawing.Size(151, 43);
            this.btnDegeristerMemberConfirm.TabIndex = 93;
            this.btnDegeristerMemberConfirm.Text = "Derigister";
            this.btnDegeristerMemberConfirm.UseVisualStyleBackColor = false;
            // 
            // pnlUpdateRegisteredMember
            // 
            this.pnlUpdateRegisteredMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUpdateRegisteredMember.Controls.Add(this.btnSearchDeregisteredMember);
            this.pnlUpdateRegisteredMember.Controls.Add(this.txtSearchDegisterMemberID);
            this.pnlUpdateRegisteredMember.Controls.Add(this.lblDegesterMemerID);
            this.pnlUpdateRegisteredMember.Location = new System.Drawing.Point(218, 86);
            this.pnlUpdateRegisteredMember.Name = "pnlUpdateRegisteredMember";
            this.pnlUpdateRegisteredMember.Size = new System.Drawing.Size(457, 38);
            this.pnlUpdateRegisteredMember.TabIndex = 142;
            // 
            // btnSearchDeregisteredMember
            // 
            this.btnSearchDeregisteredMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnSearchDeregisteredMember.Location = new System.Drawing.Point(317, 5);
            this.btnSearchDeregisteredMember.Name = "btnSearchDeregisteredMember";
            this.btnSearchDeregisteredMember.Size = new System.Drawing.Size(122, 29);
            this.btnSearchDeregisteredMember.TabIndex = 94;
            this.btnSearchDeregisteredMember.Text = "SEARCH";
            this.btnSearchDeregisteredMember.UseVisualStyleBackColor = false;
            // 
            // txtSearchDegisterMemberID
            // 
            this.txtSearchDegisterMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDegisterMemberID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchDegisterMemberID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDegisterMemberID.Location = new System.Drawing.Point(151, 6);
            this.txtSearchDegisterMemberID.MaxLength = 7;
            this.txtSearchDegisterMemberID.Name = "txtSearchDegisterMemberID";
            this.txtSearchDegisterMemberID.Size = new System.Drawing.Size(122, 27);
            this.txtSearchDegisterMemberID.TabIndex = 96;
            // 
            // lblDegesterMemerID
            // 
            this.lblDegesterMemerID.AutoSize = true;
            this.lblDegesterMemerID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegesterMemerID.Location = new System.Drawing.Point(3, 9);
            this.lblDegesterMemerID.Name = "lblDegesterMemerID";
            this.lblDegesterMemerID.Size = new System.Drawing.Size(142, 21);
            this.lblDegesterMemerID.TabIndex = 95;
            this.lblDegesterMemerID.Text = "Enter Member ID";
            // 
            // frmDeregisterMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(893, 576);
            this.Controls.Add(this.pnlUpdateRegisteredMember);
            this.Controls.Add(this.btnDegeristerMemberConfirm);
            this.Controls.Add(this.grpDeregisterMember);
            this.Controls.Add(this.lblDeregisterMember);
            this.Controls.Add(this.mnuBackStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDeregisterMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deregister Member";
            this.Load += new System.EventHandler(this.frmUpdateMember_Load);
            this.mnuBackStrip.ResumeLayout(false);
            this.mnuBackStrip.PerformLayout();
            this.grpDeregisterMember.ResumeLayout(false);
            this.grpDeregisterMember.PerformLayout();
            this.pnlUpdateRegisteredMember.ResumeLayout(false);
            this.pnlUpdateRegisteredMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuDeregisterMemberBack;
        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.Label lblDeregisterMember;
        private System.Windows.Forms.GroupBox grpDeregisterMember;
        private System.Windows.Forms.Button btnDegeristerMemberConfirm;
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
        private System.Windows.Forms.Panel pnlUpdateRegisteredMember;
        private System.Windows.Forms.Button btnSearchDeregisteredMember;
        private System.Windows.Forms.TextBox txtSearchDegisterMemberID;
        private System.Windows.Forms.Label lblDegesterMemerID;
    }
}