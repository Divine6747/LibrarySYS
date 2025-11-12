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
            this.btnDegeristerMemberConfirm = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.lblEircode = new System.Windows.Forms.Label();
            this.btnSearchDeregisteredMember = new System.Windows.Forms.Button();
            this.lblDegesterMemerID = new System.Windows.Forms.Label();
            this.txtSearchDegisterMemberID = new System.Windows.Forms.TextBox();
            this.pnlUpdateRegisteredMember = new System.Windows.Forms.Panel();
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
            this.mnuDeregisterMemberBack.Click += new System.EventHandler(this.mnuDeregisterMemberBack_Click);
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
            this.mnuBackStrip.Size = new System.Drawing.Size(1097, 38);
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
            this.grpDeregisterMember.Controls.Add(this.btnDegeristerMemberConfirm);
            this.grpDeregisterMember.Controls.Add(this.txtPhone);
            this.grpDeregisterMember.Controls.Add(this.lblPhone);
            this.grpDeregisterMember.Controls.Add(this.txtForename);
            this.grpDeregisterMember.Controls.Add(this.lblForename);
            this.grpDeregisterMember.Controls.Add(this.txtSurname);
            this.grpDeregisterMember.Controls.Add(this.lblSurname);
            this.grpDeregisterMember.Controls.Add(this.txtEircode);
            this.grpDeregisterMember.Controls.Add(this.lblEircode);
            this.grpDeregisterMember.Location = new System.Drawing.Point(76, 256);
            this.grpDeregisterMember.Name = "grpDeregisterMember";
            this.grpDeregisterMember.Size = new System.Drawing.Size(904, 344);
            this.grpDeregisterMember.TabIndex = 86;
            this.grpDeregisterMember.TabStop = false;
            this.grpDeregisterMember.Text = "Member Information";
            this.grpDeregisterMember.Visible = false;
            // 
            // btnDegeristerMemberConfirm
            // 
            this.btnDegeristerMemberConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnDegeristerMemberConfirm.CausesValidation = false;
            this.btnDegeristerMemberConfirm.Location = new System.Drawing.Point(396, 275);
            this.btnDegeristerMemberConfirm.Name = "btnDegeristerMemberConfirm";
            this.btnDegeristerMemberConfirm.Size = new System.Drawing.Size(116, 43);
            this.btnDegeristerMemberConfirm.TabIndex = 93;
            this.btnDegeristerMemberConfirm.Text = "CONFIRM";
            this.btnDegeristerMemberConfirm.UseVisualStyleBackColor = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(35, 213);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(291, 27);
            this.txtPhone.TabIndex = 88;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(35, 184);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 21);
            this.lblPhone.TabIndex = 92;
            this.lblPhone.Text = "Phone";
            // 
            // txtForename
            // 
            this.txtForename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtForename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtForename.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(35, 90);
            this.txtForename.MaxLength = 20;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(291, 27);
            this.txtForename.TabIndex = 85;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(35, 61);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(89, 21);
            this.lblForename.TabIndex = 91;
            this.lblForename.Text = "Forename";
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(573, 90);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(291, 27);
            this.txtSurname.TabIndex = 86;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(573, 61);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(79, 21);
            this.lblSurname.TabIndex = 90;
            this.lblSurname.Text = "Surname";
            // 
            // txtEircode
            // 
            this.txtEircode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEircode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEircode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEircode.Location = new System.Drawing.Point(573, 213);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(291, 27);
            this.txtEircode.TabIndex = 87;
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEircode.Location = new System.Drawing.Point(573, 184);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(72, 21);
            this.lblEircode.TabIndex = 89;
            this.lblEircode.Text = "Address";
            // 
            // btnSearchDeregisteredMember
            // 
            this.btnSearchDeregisteredMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnSearchDeregisteredMember.Location = new System.Drawing.Point(490, 15);
            this.btnSearchDeregisteredMember.Name = "btnSearchDeregisteredMember";
            this.btnSearchDeregisteredMember.Size = new System.Drawing.Size(187, 39);
            this.btnSearchDeregisteredMember.TabIndex = 94;
            this.btnSearchDeregisteredMember.Text = "SEARCH";
            this.btnSearchDeregisteredMember.UseVisualStyleBackColor = false;
            // 
            // lblDegesterMemerID
            // 
            this.lblDegesterMemerID.AutoSize = true;
            this.lblDegesterMemerID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegesterMemerID.Location = new System.Drawing.Point(7, 23);
            this.lblDegesterMemerID.Name = "lblDegesterMemerID";
            this.lblDegesterMemerID.Size = new System.Drawing.Size(142, 21);
            this.lblDegesterMemerID.TabIndex = 95;
            this.lblDegesterMemerID.Text = "Enter Member ID";
            // 
            // txtSearchDegisterMemberID
            // 
            this.txtSearchDegisterMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDegisterMemberID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchDegisterMemberID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDegisterMemberID.Location = new System.Drawing.Point(243, 18);
            this.txtSearchDegisterMemberID.MaxLength = 7;
            this.txtSearchDegisterMemberID.Name = "txtSearchDegisterMemberID";
            this.txtSearchDegisterMemberID.Size = new System.Drawing.Size(170, 27);
            this.txtSearchDegisterMemberID.TabIndex = 96;
            // 
            // pnlUpdateRegisteredMember
            // 
            this.pnlUpdateRegisteredMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUpdateRegisteredMember.Controls.Add(this.btnSearchDeregisteredMember);
            this.pnlUpdateRegisteredMember.Controls.Add(this.txtSearchDegisterMemberID);
            this.pnlUpdateRegisteredMember.Controls.Add(this.lblDegesterMemerID);
            this.pnlUpdateRegisteredMember.Location = new System.Drawing.Point(127, 122);
            this.pnlUpdateRegisteredMember.Name = "pnlUpdateRegisteredMember";
            this.pnlUpdateRegisteredMember.Size = new System.Drawing.Size(828, 80);
            this.pnlUpdateRegisteredMember.TabIndex = 97;
            // 
            // frmDeregisterMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1097, 671);
            this.Controls.Add(this.pnlUpdateRegisteredMember);
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
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.Button btnSearchDeregisteredMember;
        private System.Windows.Forms.Label lblDegesterMemerID;
        private System.Windows.Forms.TextBox txtSearchDegisterMemberID;
        private System.Windows.Forms.Panel pnlUpdateRegisteredMember;
    }
}