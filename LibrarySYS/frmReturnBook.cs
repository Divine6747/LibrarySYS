using System;
using System.Windows.Forms;


namespace LibrarySYS
{
    public partial class frmReturnBook : Form
    {
        frmMainMenu parent;
       

        public frmReturnBook()
        {
            InitializeComponent();
        }

        public frmReturnBook(frmMainMenu parent)
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
