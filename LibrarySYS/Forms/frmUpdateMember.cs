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
            cboCounty.SelectedIndex = -1;
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
                MessageBox.Show("Please enter a Member ID to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _currentMember = _memberManager.FindMemberById(memberId);

            if (_currentMember == null)
            {
                MessageBox.Show("Member not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string forename = txtForename.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string town = cboCounty.SelectedItem?.ToString() ?? "";
            string eircode = txtEircode.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (!ValidateMember.ValidateMemberData(forename, surname, town, eircode, phone, email, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _currentMember.Forename = forename;
            _currentMember.Surname = surname;
            _currentMember.Eircode = eircode;
            _currentMember.Email = email;
            _currentMember.Phone = phone;
            _currentMember.Town = (County)Enum.Parse(typeof(County), town);

            _memberManager.UpdateMember(_currentMember);

            MessageBox.Show("Member updated successfully.");

            ClearForm();
        }
        private void ClearForm()
        {
            txtSearchMemberID.Clear();
            txtForename.Clear();
            txtSurname.Clear();
            cboCounty.SelectedIndex = -1;
            txtEircode.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            grpRegisterMembers.Visible = false;
            btnUpdateMember.Visible = false;

            txtSearchMemberID.Focus();
        }
    }
}
