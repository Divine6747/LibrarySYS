using LibrarySYS.Entities;
using LibrarySYS.Enums;
using LibrarySYS.Helpers;
using LibrarySYS.Interfaces;
using LibrarySYS.Managers;
using LibrarySystem.Entities;
using System;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmAddMember : Form
    {
        private MemberManager _memberManager;
        public frmAddMember(MemberManager memberManager)
        {
            InitializeComponent();
            _memberManager = memberManager;

            cboCounty.DataSource = Enum.GetValues(typeof(County));
            cboCounty.SelectedIndex = -1;
        }

        private void mnuAddMemberBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRegisterMemberSubmit_Click(object sender, EventArgs e)
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

            Member newMember = new Member
            {
                Forename = forename,
                Surname = surname,
                Town = (County)Enum.Parse(typeof(County), town),
                Eircode =  eircode,
                Email = email,
                Phone = phone,
                IsActive = true
            };

            _memberManager.AddMember(newMember);

            MessageBox.Show($"Member {newMember.Forename} {newMember.Surname} added successfully.\nID: {newMember.MemberId}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
        }
        private void ClearForm()
        {
            txtForename.Clear();
            txtSurname.Clear();
            cboCounty.SelectedIndex = -1;
            txtEircode.Clear();
            txtEmail.Clear();
            txtPhone.Clear();

            txtForename.Focus();
        }
    }
}
