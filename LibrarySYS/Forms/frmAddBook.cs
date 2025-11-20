using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmAddBook : Form
    {
        frmMainMenu parent;
        public frmAddBook()
        {
            InitializeComponent();
            this.parent = new frmMainMenu();
        }

        public frmAddBook(frmMainMenu parent)
        {        
            this.parent = parent;
        }

        private void mnuAddBookBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.Show();
        }
    }
}
