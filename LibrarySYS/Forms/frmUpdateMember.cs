using LibrarySYS.Entities;
using LibrarySYS.Enums;
using LibrarySYS.Managers;
using LibrarySystem.Entities;
using System;
using System.Windows.Forms;


namespace LibrarySYS
{
    public partial class frmUpdateMember : Form
    {
        private MemberManager _memberManager;
        private Member _currentMember;
        public frmUpdateMember(MemberManager memberManager)
        {
            InitializeComponent();
            _memberManager = memberManager;
        }


        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            cboCounty.DataSource = Enum.GetValues(typeof(County));
            cboCounty.SelectedIndex = 0;
        }

        private void mnuUpdateMemberBack_Click_1(object sender, EventArgs e)
        {
             this.Close();
        }

        private void btMemberSearch_Click(object sender, EventArgs e)
        {
            string memberId = txtSearchMemberID.Text.Trim();
            if (string.IsNullOrWhiteSpace(memberId))
            {
                MessageBox.Show("Please enter a Member ID to search.");
                return;
            }

            _currentMember = _memberManager.FindMemberById(memberId);

            if (_currentMember == null)
            {
                MessageBox.Show("Member not found.");
                grpRegisterMembers.Visible = false;
                btnUpdateMember.Visible = false;
            }
            else
            {
                txtForename.Text = _currentMember.Forename;
                txtSurname.Text = _currentMember.Surname;
                txtEircode.Text = _currentMember.Eircode;
                txtEmail.Text = _currentMember.Email;
                txtPhone.Text = _currentMember.Phone;
                cboCounty.SelectedItem = _currentMember.Town;

                grpRegisterMembers.Visible = true;
                btnUpdateMember.Visible = true;
            }
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtForename.Text) ||
                string.IsNullOrWhiteSpace(txtSurname.Text) ||
                cboCounty.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            _currentMember.Forename = txtForename.Text.Trim();
            _currentMember.Surname = txtSurname.Text.Trim();
            _currentMember.Eircode = txtEircode.Text.Trim();
            _currentMember.Email = txtEmail.Text.Trim();
            _currentMember.Phone = txtPhone.Text.Trim();
            _currentMember.Town = (County)cboCounty.SelectedItem;

            _memberManager.UpdateMember(_currentMember);

            MessageBox.Show("Member updated successfully.");
        }
    }
}
