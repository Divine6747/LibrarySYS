using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmUpdateBook : Form
    {
        frmMainMenu parent;
        public frmUpdateBook()
        {
            InitializeComponent();
            this.parent = new frmMainMenu();
        }

        public frmUpdateBook(frmMainMenu parent)
        {        
            this.parent = parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenu parent = new frmMainMenu();
            parent.Show();
        }
    }
}
