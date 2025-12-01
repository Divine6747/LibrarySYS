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
        private string _generatedMemId;
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
            if (string.IsNullOrWhiteSpace(txtForename.Text) ||
                string.IsNullOrWhiteSpace(txtSurname.Text) ||
                cboCounty.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Member newMember = new Member
            {
                Forename = txtForename.Text.Trim(),
                Surname = txtSurname.Text.Trim(),
                Town = (County)cboCounty.SelectedItem,
                Eircode = txtEircode.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                IsActive = true
            };

            _memberManager.AddMember(newMember);

            MessageBox.Show($"Member {newMember.Forename} {newMember.Surname} added successfully.\nID: {newMember.MemberId}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtForename.Clear();
            txtSurname.Clear();
            cboCounty.SelectedIndex = -1;
            txtEircode.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }
    }
}
