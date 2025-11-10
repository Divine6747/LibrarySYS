using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmAddMember : Form
    {
        public frmAddMember()
        {
            InitializeComponent();
        }

        private void mnuAddMemberBack_MouseHover(object sender, EventArgs e)
        {
            mnuAddMemberBack.BackColor = Color.FromArgb(0xFF, 0x3A, 0x76, 0x81);
        }
    }
}
