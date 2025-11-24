using LibrarySYS.Entities;
using System;
using System.Drawing;
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

            
            ValidateMember.validateName(txtForeName.Text,txtSurname.Text);
            ValidateMember.validateTown(txtTown.Text);
            ValidateMember.validateEircode(txtEircode.Text);
            ValidateMember.validatePhone(txtPhone.Text);
            ValidateMember.validateEmail(txtEmail.Text);

            /*
            Member newMember = new Member(
                txtMemberID.Text,
                txtForeName.Text,
                txtSurname.Text,
                txtTown.Text,
                txtEircode.Text,
                txtPhone.Text,
                txtEmail.Text
            );*/
           


            newMember.AddMember(newMember);

        }
    }
}
