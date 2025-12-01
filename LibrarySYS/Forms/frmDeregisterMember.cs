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
            cboCounty.DataSource = Enum.GetValues(typeof(County));
            cboCounty.SelectedIndex = -1;
        }

        private void btnSearchDeregisteredMember_Click(object sender, EventArgs e)
        {
            string memberID = txtSearchDegisterMemberID.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(memberID))
            {
                MessageBox.Show("Please enter a Member ID to search.");
                return;
            }

            // Find the member
            _currentMember = _memberManager.FindMemberById(memberID);

            if (_currentMember == null)
            {
                MessageBox.Show("Member not found.");
                grpDeregisterMember.Visible = false;
                btnDegeristerMemberConfirm.Visible = false;
            }
            else
            {
                txtForename.Text = _currentMember.Forename;
                txtSurname.Text = _currentMember.Surname;
                txtEircode.Text = _currentMember.Eircode;
                txtEmail.Text = _currentMember.Email;
                cboCounty.SelectedItem = _currentMember.Town;
                txtPhone.Text = _currentMember.Phone;

                grpDeregisterMember.Visible = true;
                btnDegeristerMemberConfirm.Visible = true;
            }
        }

        private void btnDegeristerMemberConfirm_Click(object sender, EventArgs e)
        {
            string memberID = txtSearchDegisterMemberID.Text.Trim().ToUpper();

            if (_currentMember == null)
            {
                MessageBox.Show("Please search for a member first.");
                return;
            }

            _memberManager.DeregisterMember(_currentMember.MemberId);
            MessageBox.Show($"Member {_currentMember.Forename} {_currentMember.Surname} has been deactivated.");

            txtForename.Clear();
            txtSurname.Clear();
            cboCounty.SelectedIndex = -1;
            txtEircode.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }

        private void mnuDeregisterMemberBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
