using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void mnuAddMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddMember frmAddMember = new frmAddMember();
            frmAddMember.Show();
        }
    }
}
