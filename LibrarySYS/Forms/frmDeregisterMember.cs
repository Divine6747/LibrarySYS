using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmDeregisterMember : Form
    {
        frmMainMenu parent;
        Member memberManager = new Member("", "", "", "", "", "", "");
        public frmDeregisterMember()
        {
            InitializeComponent();
            this.parent = new frmMainMenu();
        }

        public frmDeregisterMember(frmMainMenu parent)
        {        
            this.parent = parent;
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

            Member found = memberManager.FindMemberByID(memberID);

            if (found == null)
            {
                MessageBox.Show("No member found with that ID.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearMemberDetails();
                grpDeregisterMember.Visible = false;
                btnDegeristerMemberConfirm.Enabled = false;
                return;
            }


            txtForeName.Text = found.forename;
            txtSurname.Text = found.surname;
            txtTown.Text = found.town;
            txtEircode.Text = found.eircode;
            txtPhone.Text = found.phone;
            txtEmail.Text = found.email;

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
                memberManager.DeRegisterMember(memberID);

                MessageBox.Show("Member deregistered.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearMemberDetails();
                txtSearchDegisterMemberID.Clear();
            }

        }
    }
}
