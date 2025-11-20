using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmRemoveBook : Form
    {
        frmMainMenu parent;
        public frmRemoveBook()
        {
            InitializeComponent();
            this.parent = new frmMainMenu();
        }

        public frmRemoveBook(frmMainMenu parent)
        {        
            this.parent = parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenu parent = new frmMainMenu();
            parent.Show();
        }

        private void frmRemoveBook_Load(object sender, EventArgs e)
        {

        }
    }
}
