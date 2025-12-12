using LibrarySYS.Enums;
using LibrarySYS.Interfaces;
using LibrarySYS.Managers;
using LibrarySystem.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmDeregisterMember : Form
    {
        private MemberManager _memberManager;
        private Member _currentMember;

        public frmDeregisterMember(MemberManager memberManager)
        {
            InitializeComponent();
            _memberManager = memberManager;
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            grpDeregisterMember.Visible = false;
            btnDegeristerMemberConfirm.Visible = false;
        }
        

        private void btnDegeristerMemberConfirm_Click(object sender, EventArgs e)
        {
            if (_currentMember == null)
            {
                MessageBox.Show("Please search for a member first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to deregister this member?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _memberManager.DeregisterMember(_currentMember.MemberId);
                MessageBox.Show("Member has been deregistered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSearchDegisterMemberID.Clear();
                lblDeregisterMemberDetails.Text = "NO MEMBER ID PROVIDED";
                grpDeregisterMember.Visible = false;
                btnDegeristerMemberConfirm.Visible = false;
                _currentMember = null;
            }
        }

        private void mnuDeregisterMemberBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchDeregisteredMember_Click_1(object sender, EventArgs e)
        {
            string memberID = txtSearchDegisterMemberID.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(memberID))
            {
                MessageBox.Show("Please enter a Member ID to search.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _currentMember = _memberManager.FindMemberById(memberID);

            if (_currentMember == null)
            {
                MessageBox.Show("Member not found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string memberDetails = "Member ID: " + _currentMember.MemberId + "      \t\t\n" +
                                   "Forename: " + _currentMember.Forename + "        \n\n" +
                                   "Surname: " + _currentMember.Surname + "           \t\t\n" +
                                   "Eircode: " + _currentMember.Eircode + "            \n\n" +
                                   "Email: " + _currentMember.Email + "                 \t\t\n" +
                                   "County: " + _currentMember.Town.ToString() + "        \n\n" +
                                   "Phone: " + _currentMember.Phone + "                    \t\t\n" +
                                   "Status: " + (_currentMember.IsActive ? "Active" : "Inactive");

            lblDeregisterMemberDetails.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            lblDeregisterMemberDetails.Text = memberDetails;
            grpDeregisterMember.Visible = true;
            btnDegeristerMemberConfirm.Visible = true;
        }
    }
}