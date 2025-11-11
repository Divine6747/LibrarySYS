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
        frmMainMenu parent;
        public frmMainMenu()
        {
            InitializeComponent();
        }
        public frmMainMenu(frmMainMenu parent)
        {
            this.parent = parent;
        }

        private void mnuAddMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddMember frmAddMember = new frmAddMember();
            frmAddMember.Show();
        }

        private void mnuUpdateMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateMember frmUpdateMember = new frmUpdateMember();
            frmUpdateMember.Show();
        }

        private void mnuDeregisterMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeregisterMember frmDeregisterMember = new frmDeregisterMember();
            frmDeregisterMember.Show();
        }

        private void munExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAddBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddBook frmAddBook = new frmAddBook();
            frmAddBook.Show();
        }
    }
}
