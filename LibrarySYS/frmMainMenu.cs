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

        private void mnuUpdateBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateBook frmUpdateBook = new frmUpdateBook();
            frmUpdateBook.Show();
        }

        private void mnuRemoveBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveBook frmRemoveBook = new frmRemoveBook();
            frmRemoveBook.Show();
        }

        private void mnuReserveBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReserveBook frmReserveBook = new frmReserveBook();
            frmReserveBook.Show();
        }

        private void mnuCollectBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCollectBook frmCollectBook = new frmCollectBook();
            frmCollectBook.Show();
        }

        private void mnuReturnBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnBook frmReturnBook = new frmReturnBook();
            frmReturnBook.Show();
        }
    }
}
