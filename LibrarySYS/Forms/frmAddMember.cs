
using LibrarySYS.Helpers;
using System;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmAddMember : Form
    {
        frmMainMenu parent;
        public frmAddMember()
        {
            InitializeComponent();
            this.parent = new frmMainMenu();
        }

        public frmAddMember(frmMainMenu parent)
        {
            this.parent = parent;
        }
        

        private void mnuAddMemberBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
        private void btnRegisterMemberSubmit_Click(object sender, EventArgs e)
        {
            string error;

            string memberid = IdGenerator.GenerateMemberId();

            bool valid = ValidateMember.ValidateMemberData(
                txtForeName.Text,
                txtSurname.Text,
                txtTown.Text,
                txtEircode.Text,
                txtPhone.Text,
                txtEmail.Text,
                out error
            );

            if (!valid)
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                Member newMember = new Member(
                   memberid,
                   txtForeName.Text,
                   txtSurname.Text,
                   txtTown.Text,
                   txtEircode.Text,
                   txtPhone.Text,
                   txtEmail.Text
               );

                newMember.AddMember(newMember);

            }
            txtForeName.Clear();
            txtSurname.Clear();
            txtTown.Clear();
            txtEircode.Clear();
            txtPhone.Clear();
            txtEmail.Clear();



        }

        private void frmAddMember_Load(object sender, EventArgs e)
        {

        }
    }
}
