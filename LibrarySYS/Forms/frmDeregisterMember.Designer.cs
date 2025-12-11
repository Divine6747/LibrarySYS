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
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.btnDegeristerMemberConfirm = new System.Windows.Forms.Button();
            this.lblForenameValue = new System.Windows.Forms.Label();
            this.lblCountyValue = new System.Windows.Forms.Label();
            this.lblPhoneValue = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblSurnameValue = new System.Windows.Forms.Label();
            this.lblEircodelValue = new System.Windows.Forms.Label();
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
            this.mnuBackStrip.Size = new System.Drawing.Size(826, 38);
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
            this.grpDeregisterMember.Controls.Add(this.lblEmailValue);
            this.grpDeregisterMember.Controls.Add(this.lblSurnameValue);
            this.grpDeregisterMember.Controls.Add(this.lblEircodelValue);
            this.grpDeregisterMember.Controls.Add(this.lblPhoneValue);
            this.grpDeregisterMember.Controls.Add(this.lblCountyValue);
            this.grpDeregisterMember.Controls.Add(this.lblForenameValue);
            this.grpDeregisterMember.Controls.Add(this.lblCounty);
            this.grpDeregisterMember.Controls.Add(this.lblEmail);
            this.grpDeregisterMember.Controls.Add(this.lblPhone);
            this.grpDeregisterMember.Controls.Add(this.lblForename);
            this.grpDeregisterMember.Controls.Add(this.lblSurname);
            this.grpDeregisterMember.Controls.Add(this.lblEircode);
            this.grpDeregisterMember.Location = new System.Drawing.Point(28, 130);
            this.grpDeregisterMember.Name = "grpDeregisterMember";
            this.grpDeregisterMember.Size = new System.Drawing.Size(682, 253);
            this.grpDeregisterMember.TabIndex = 86;
            this.grpDeregisterMember.TabStop = false;
            this.grpDeregisterMember.Text = "Member Information";
            this.grpDeregisterMember.Visible = false;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(26, 102);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(84, 22);
            this.lblCounty.TabIndex = 141;
            this.lblCounty.Text = "County:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(396, 169);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 22);
            this.lblEmail.TabIndex = 138;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(26, 169);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(74, 22);
            this.lblPhone.TabIndex = 137;
            this.lblPhone.Text = "Phone:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(22, 35);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(108, 22);
            this.lblForename.TabIndex = 136;
            this.lblForename.Text = "Forename:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(395, 35);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(96, 22);
            this.lblSurname.TabIndex = 135;
            this.lblSurname.Text = "Surname:";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEircode.Location = new System.Drawing.Point(395, 102);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(83, 22);
            this.lblEircode.TabIndex = 134;
            this.lblEircode.Text = "Eircode:";
            // 
            // btnDegeristerMemberConfirm
            // 
            this.btnDegeristerMemberConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnDegeristerMemberConfirm.CausesValidation = false;
            this.btnDegeristerMemberConfirm.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDegeristerMemberConfirm.Location = new System.Drawing.Point(316, 437);
            this.btnDegeristerMemberConfirm.Name = "btnDegeristerMemberConfirm";
            this.btnDegeristerMemberConfirm.Size = new System.Drawing.Size(151, 43);
            this.btnDegeristerMemberConfirm.TabIndex = 93;
            this.btnDegeristerMemberConfirm.Text = "Derigister";
            this.btnDegeristerMemberConfirm.UseVisualStyleBackColor = false;
            this.btnDegeristerMemberConfirm.Click += new System.EventHandler(this.btnDegeristerMemberConfirm_Click);
            // 
            // lblForenameValue
            // 
            this.lblForenameValue.AutoSize = true;
            this.lblForenameValue.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForenameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.lblForenameValue.Location = new System.Drawing.Point(177, 35);
            this.lblForenameValue.Name = "lblForenameValue";
            this.lblForenameValue.Size = new System.Drawing.Size(103, 22);
            this.lblForenameValue.TabIndex = 142;
            this.lblForenameValue.Text = "Forename";
            // 
            // lblCountyValue
            // 
            this.lblCountyValue.AutoSize = true;
            this.lblCountyValue.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountyValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.lblCountyValue.Location = new System.Drawing.Point(177, 102);
            this.lblCountyValue.Name = "lblCountyValue";
            this.lblCountyValue.Size = new System.Drawing.Size(79, 22);
            this.lblCountyValue.TabIndex = 143;
            this.lblCountyValue.Text = "County";
            // 
            // lblPhoneValue
            // 
            this.lblPhoneValue.AutoSize = true;
            this.lblPhoneValue.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.lblPhoneValue.Location = new System.Drawing.Point(177, 169);
            this.lblPhoneValue.Name = "lblPhoneValue";
            this.lblPhoneValue.Size = new System.Drawing.Size(69, 22);
            this.lblPhoneValue.TabIndex = 144;
            this.lblPhoneValue.Text = "Phone";
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.lblEmailValue.Location = new System.Drawing.Point(541, 169);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(56, 22);
            this.lblEmailValue.TabIndex = 147;
            this.lblEmailValue.Text = "Email";
            // 
            // lblSurnameValue
            // 
            this.lblSurnameValue.AutoSize = true;
            this.lblSurnameValue.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.lblSurnameValue.Location = new System.Drawing.Point(541, 35);
            this.lblSurnameValue.Name = "lblSurnameValue";
            this.lblSurnameValue.Size = new System.Drawing.Size(91, 22);
            this.lblSurnameValue.TabIndex = 146;
            this.lblSurnameValue.Text = "Surname";
            // 
            // lblEircodelValue
            // 
            this.lblEircodelValue.AutoSize = true;
            this.lblEircodelValue.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEircodelValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.lblEircodelValue.Location = new System.Drawing.Point(541, 102);
            this.lblEircodelValue.Name = "lblEircodelValue";
            this.lblEircodelValue.Size = new System.Drawing.Size(78, 22);
            this.lblEircodelValue.TabIndex = 145;
            this.lblEircodelValue.Text = "Eircode";
            // 
            // pnlUpdateRegisteredMember
            // 
            this.pnlUpdateRegisteredMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUpdateRegisteredMember.Controls.Add(this.btnSearchDeregisteredMember);
            this.pnlUpdateRegisteredMember.Controls.Add(this.txtSearchDegisterMemberID);
            this.pnlUpdateRegisteredMember.Controls.Add(this.lblDegesterMemerID);
            this.pnlUpdateRegisteredMember.Location = new System.Drawing.Point(220, 84);
            this.pnlUpdateRegisteredMember.Name = "pnlUpdateRegisteredMember";
            this.pnlUpdateRegisteredMember.Size = new System.Drawing.Size(457, 40);
            this.pnlUpdateRegisteredMember.TabIndex = 143;
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
            this.ClientSize = new System.Drawing.Size(826, 499);
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
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblPhoneValue;
        private System.Windows.Forms.Label lblCountyValue;
        private System.Windows.Forms.Label lblForenameValue;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblSurnameValue;
        private System.Windows.Forms.Label lblEircodelValue;
        private System.Windows.Forms.Panel pnlUpdateRegisteredMember;
        private System.Windows.Forms.Button btnSearchDeregisteredMember;
        private System.Windows.Forms.TextBox txtSearchDegisterMemberID;
        private System.Windows.Forms.Label lblDegesterMemerID;
    }
}