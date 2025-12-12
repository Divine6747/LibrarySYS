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
            this.lblDeregisterMemberDetails = new System.Windows.Forms.Label();
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
            this.mnuDeregisterMemberBack.Click += new System.EventHandler(this.mnuDeregisterMemberBack_Click);
            // 
            // mnuBackStrip
            // 
            this.mnuBackStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.mnuBackStrip.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBackStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBackStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeregisterMemberBack});
            this.mnuBackStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuBackStrip.Name = "mnuBackStrip";
            this.mnuBackStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnuBackStrip.Size = new System.Drawing.Size(585, 38);
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
            this.grpDeregisterMember.Controls.Add(this.lblDeregisterMemberDetails);
            this.grpDeregisterMember.Location = new System.Drawing.Point(35, 130);
            this.grpDeregisterMember.Name = "grpDeregisterMember";
            this.grpDeregisterMember.Size = new System.Drawing.Size(515, 275);
            this.grpDeregisterMember.TabIndex = 86;
            this.grpDeregisterMember.TabStop = false;
            this.grpDeregisterMember.Text = "Member Information";
            this.grpDeregisterMember.Visible = false;
            // 
            // lblDeregisterMemberDetails
            // 
            this.lblDeregisterMemberDetails.AutoSize = true;
            this.lblDeregisterMemberDetails.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeregisterMemberDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.lblDeregisterMemberDetails.Location = new System.Drawing.Point(167, 23);
            this.lblDeregisterMemberDetails.Name = "lblDeregisterMemberDetails";
            this.lblDeregisterMemberDetails.Size = new System.Drawing.Size(250, 22);
            this.lblDeregisterMemberDetails.TabIndex = 142;
            this.lblDeregisterMemberDetails.Text = "NO MEMBER ID PROVIDED";
            // 
            // btnDegeristerMemberConfirm
            // 
            this.btnDegeristerMemberConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.btnDegeristerMemberConfirm.CausesValidation = false;
            this.btnDegeristerMemberConfirm.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDegeristerMemberConfirm.Location = new System.Drawing.Point(231, 411);
            this.btnDegeristerMemberConfirm.Name = "btnDegeristerMemberConfirm";
            this.btnDegeristerMemberConfirm.Size = new System.Drawing.Size(120, 36);
            this.btnDegeristerMemberConfirm.TabIndex = 93;
            this.btnDegeristerMemberConfirm.Text = "Derigister";
            this.btnDegeristerMemberConfirm.UseVisualStyleBackColor = false;
            this.btnDegeristerMemberConfirm.Click += new System.EventHandler(this.btnDegeristerMemberConfirm_Click);
            // 
            // pnlUpdateRegisteredMember
            // 
            this.pnlUpdateRegisteredMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUpdateRegisteredMember.Controls.Add(this.btnSearchDeregisteredMember);
            this.pnlUpdateRegisteredMember.Controls.Add(this.txtSearchDegisterMemberID);
            this.pnlUpdateRegisteredMember.Controls.Add(this.lblDegesterMemerID);
            this.pnlUpdateRegisteredMember.Location = new System.Drawing.Point(72, 76);
            this.pnlUpdateRegisteredMember.Name = "pnlUpdateRegisteredMember";
            this.pnlUpdateRegisteredMember.Size = new System.Drawing.Size(441, 36);
            this.pnlUpdateRegisteredMember.TabIndex = 145;
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
            this.btnSearchDeregisteredMember.Click += new System.EventHandler(this.btnSearchDeregisteredMember_Click_1);
            // 
            // txtSearchDegisterMemberID
            // 
            this.txtSearchDegisterMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDegisterMemberID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchDegisterMemberID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDegisterMemberID.Location = new System.Drawing.Point(170, 6);
            this.txtSearchDegisterMemberID.MaxLength = 5;
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
            this.ClientSize = new System.Drawing.Size(585, 457);
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
        private System.Windows.Forms.Label lblDeregisterMemberDetails;
        private System.Windows.Forms.Panel pnlUpdateRegisteredMember;
        private System.Windows.Forms.Button btnSearchDeregisteredMember;
        private System.Windows.Forms.TextBox txtSearchDegisterMemberID;
        private System.Windows.Forms.Label lblDegesterMemerID;
    }
}