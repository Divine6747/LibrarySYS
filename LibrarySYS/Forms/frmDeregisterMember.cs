using LibrarySYS.Enums;
using LibrarySYS.Managers;
using LibrarySystem.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmDeregisterMember : Form
    {
        frmMainMenu parent;
        private Member memberManager;

        public frmDeregisterMember()
        {
            InitializeComponent();
            this.parent = new frmMainMenu();
        }


        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            grpDeregisterMember.Visible = false;
            btnDegeristerMemberConfirm.Visible = false;
        }

        private void btnSearchDeregisteredMember_Click(object sender, EventArgs e)
        {
            string memberID = txtSearchDegisterMemberID.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(memberID))
            {
                MessageBox.Show("Please enter a Member ID.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchDegisterMemberID.Focus();
                return;
            }

            Member found = null;

            foreach (Member m in memberManager.GetAllMembers())
            {
                if (m.GetMemberID() == memberID)
                {
                    found = m;
                    break;
                }
            }

            if (found == null)
            {
                MessageBox.Show("No member found with that ID.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearMemberDetails();
                grpDeregisterMember.Visible = false;
                btnDegeristerMemberConfirm.Enabled = false;
                return;
            }

            if (!found.GetIsActive())
            {
                MessageBox.Show("This member is already deregistered.", "Inactive Member",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpDeregisterMember.Visible = false;
                btnDegeristerMemberConfirm.Visible = false;
                return;
            }


            txtForeName.Text = found.GetForename();
            txtSurname.Text = found.GetSurname();
            txtTown.Text = found.GetTown();
            txtEircode.Text = found.GetEircode();
            txtPhone.Text = found.GetPhone();
            txtEmail.Text = found.GetEmail();


            grpDeregisterMember.Visible = true;
            btnDegeristerMemberConfirm.Visible = true;

        }
        private void ClearMemberDetails()
        {
            txtForeName.Clear();
            txtSurname.Clear();
            txtTown.Clear();
            txtEircode.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }

        private void btnDegeristerMemberConfirm_Click(object sender, EventArgs e)
        {
            string memberID = txtSearchDegisterMemberID.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(memberID))
            {
                MessageBox.Show("No member selected.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to deregister this member?",
                "Confirm Deregistration",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                memberManager.DeregisterMember(memberID);

                MessageBox.Show("Member deregistered.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearMemberDetails();
                txtSearchDegisterMemberID.Clear();
                grpDeregisterMember.Visible = false;
                btnDegeristerMemberConfirm.Visible = false;
            }

        }

        private void mnuDeregisterMemberBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
