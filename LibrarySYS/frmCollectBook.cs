using System;
using System.Windows.Forms;


namespace LibrarySYS
{
    public partial class frmCollectBook : Form
    {
        frmMainMenu parent;

        public frmCollectBook()
        {
            InitializeComponent();
            this.parent = new frmMainMenu();
        }

        public frmCollectBook(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.Show();
        }
    }
}
