using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmUpdateMember : Form
    {
        frmMainMenu parent;
        public frmUpdateMember()
        {
            InitializeComponent();
            this.parent = new frmMainMenu();
        }

        public frmUpdateMember(frmMainMenu parent)
        {
        
            this.parent = parent;
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* MessageBox.Show(txtSearchMemberID.Text.ToString(),"search text is", MessageBoxButtons.OK);*/
        }

        private void btnUpdateRegisteredMember_Click(object sender, EventArgs e)
        {

        }

        private void mnuUpdateMemberBack_Click_1(object sender, EventArgs e)
        {
             this.Close();
            parent.Visible = true;
        }
    }
}
