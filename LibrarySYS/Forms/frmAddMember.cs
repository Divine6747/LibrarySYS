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
    }
}
