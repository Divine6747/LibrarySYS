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
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
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
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.btnDegeristerMemberConfirm = new System.Windows.Forms.Button();
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
            this.mnuDeregisterMemberBack.Size = new System.Drawing.Size(89, 31);
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
            this.mnuBackStrip.Size = new System.Drawing.Size(960, 43);
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
            this.lblDeregisterMember.Size = new System.Drawing.Size(276, 33);
            this.lblDeregisterMember.TabIndex = 85;
            this.lblDeregisterMember.Text = " Deregister Member";
            // 
            // grpDeregisterMember
            // 
            this.grpDeregisterMember.Controls.Add(this.cboCounty);
            this.grpDeregisterMember.Controls.Add(this.txtEmail);
            this.grpDeregisterMember.Controls.Add(this.lblCounty);
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
            this.grpDeregisterMember.Controls.Add(this.txtStreet);
            this.grpDeregisterMember.Controls.Add(this.lblStreet);
            this.grpDeregisterMember.Location = new System.Drawing.Point(28, 130);
            this.grpDeregisterMember.Name = "grpDeregisterMember";
            this.grpDeregisterMember.Size = new System.Drawing.Size(904, 495);
            this.grpDeregisterMember.TabIndex = 86;
            this.grpDeregisterMember.TabStop = false;
            this.grpDeregisterMember.Text = "Member Information";
            this.grpDeregisterMember.Visible = false;
            // 
            // cboCounty
            // 
            this.cboCounty.BackColor = System.Drawing.SystemColors.Window;
            this.cboCounty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCounty.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(502, 189);
            this.cboCounty.Margin = new System.Windows.Forms.Padding(4);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(344, 37);
            this.cboCounty.TabIndex = 141;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(502, 420);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(344, 36);
            this.txtEmail.TabIndex = 140;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(496, 149);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(95, 27);
            this.lblCounty.TabIndex = 139;
            this.lblCounty.Text = "County";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(496, 379);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 27);
            this.lblEmail.TabIndex = 138;
            this.lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(63, 420);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(344, 36);
            this.txtPhone.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 137;
            this.label1.Text = "Phone";
            // 
            // txtForeName
            // 
            this.txtForeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtForeName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForeName.Location = new System.Drawing.Point(64, 79);
            this.txtForeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtForeName.MaxLength = 20;
            this.txtForeName.Name = "txtForeName";
            this.txtForeName.Size = new System.Drawing.Size(344, 36);
            this.txtForeName.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 27);
            this.label2.TabIndex = 136;
            this.label2.Text = "Forename";
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(502, 79);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(344, 36);
            this.txtSurname.TabIndex = 127;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(496, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 27);
            this.label3.TabIndex = 135;
            this.label3.Text = "Surname";
            // 
            // txtEircode
            // 
            this.txtEircode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEircode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEircode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEircode.Location = new System.Drawing.Point(502, 305);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(344, 36);
            this.txtEircode.TabIndex = 130;
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEircode.Location = new System.Drawing.Point(496, 264);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(98, 27);
            this.lblEircode.TabIndex = 134;
            this.lblEircode.Text = "Eircode";
            // 
            // txtTown
            // 
            this.txtTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTown.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.Location = new System.Drawing.Point(63, 305);
            this.txtTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTown.MaxLength = 15;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(344, 36);
            this.txtTown.TabIndex = 129;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(58, 264);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(72, 27);
            this.lblTown.TabIndex = 133;
            this.lblTown.Text = "Town";
            // 
            // txtStreet
            // 
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStreet.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(63, 190);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStreet.MaxLength = 25;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(344, 36);
            this.txtStreet.TabIndex = 128;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(58, 149);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(76, 27);
            this.lblStreet.TabIndex = 132;
            this.lblStreet.Text = "Street";
            // 
            // btnDegeristerMemberConfirm
            // 
            this.btnDegeristerMemberConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnDegeristerMemberConfirm.CausesValidation = false;
            this.btnDegeristerMemberConfirm.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDegeristerMemberConfirm.Location = new System.Drawing.Point(405, 631);
            this.btnDegeristerMemberConfirm.Name = "btnDegeristerMemberConfirm";
            this.btnDegeristerMemberConfirm.Size = new System.Drawing.Size(151, 43);
            this.btnDegeristerMemberConfirm.TabIndex = 93;
            this.btnDegeristerMemberConfirm.Text = "Derigister";
            this.btnDegeristerMemberConfirm.UseVisualStyleBackColor = false;
            // 
            // btnSearchDeregisteredMember
            // 
            this.btnSearchDeregisteredMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnSearchDeregisteredMember.Location = new System.Drawing.Point(433, 0);
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
            this.lblDegesterMemerID.Location = new System.Drawing.Point(-2, 8);
            this.lblDegesterMemerID.Name = "lblDegesterMemerID";
            this.lblDegesterMemerID.Size = new System.Drawing.Size(173, 23);
            this.lblDegesterMemerID.TabIndex = 95;
            this.lblDegesterMemerID.Text = "Enter Member ID";
            // 
            // txtSearchDegisterMemberID
            // 
            this.txtSearchDegisterMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDegisterMemberID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchDegisterMemberID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDegisterMemberID.Location = new System.Drawing.Point(217, 3);
            this.txtSearchDegisterMemberID.MaxLength = 7;
            this.txtSearchDegisterMemberID.Name = "txtSearchDegisterMemberID";
            this.txtSearchDegisterMemberID.Size = new System.Drawing.Size(170, 32);
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
            this.pnlUpdateRegisteredMember.Location = new System.Drawing.Point(163, 85);
            this.pnlUpdateRegisteredMember.Name = "pnlUpdateRegisteredMember";
            this.pnlUpdateRegisteredMember.Size = new System.Drawing.Size(635, 46);
            this.pnlUpdateRegisteredMember.TabIndex = 97;
            // 
            // frmDeregisterMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(960, 686);
            this.Controls.Add(this.btnDegeristerMemberConfirm);
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
        private System.Windows.Forms.Button btnSearchDeregisteredMember;
        private System.Windows.Forms.Label lblDegesterMemerID;
        private System.Windows.Forms.TextBox txtSearchDegisterMemberID;
        private System.Windows.Forms.Panel pnlUpdateRegisteredMember;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCounty;
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
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
    }
}