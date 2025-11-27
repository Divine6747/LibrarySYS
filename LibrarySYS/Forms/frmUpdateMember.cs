using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmUpdateMember : Form
    {
        frmMainMenu parent;
        public frmUpdateMember()
        {
            InitializeComponent();
            this.parent = new frmMainMenu();
        }

        public frmUpdateMember(frmMainMenu parent)
        {        
            this.parent = parent;
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
        }

        private void mnuUpdateMemberBack_Click_1(object sender, EventArgs e)
        {
             this.Close();
            parent.Visible = true;
        }

        private void btMemberSearch_Click(object sender, EventArgs e)
        {
            if (lblUpdateMemerID.Text == null)
            {

            }
            else
            {
                grpRegisterMembers.Visible = true;
                btnRegisterMemberSubmit.Visible = true;
            }
        }
    }
}
