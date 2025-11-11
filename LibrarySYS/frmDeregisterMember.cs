using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmDeregisterMember : Form
    {
        frmMainMenu parent;
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

        }

        private void mnuDeregisterMemberBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
