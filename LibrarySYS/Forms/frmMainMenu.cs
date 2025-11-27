using System;
using System.Windows.Forms;
using LibrarySYS.Managers;

namespace LibrarySYS
{
    public partial class frmMainMenu : Form
    {
        private MemberManager _memberManager;
        private BookManager _bookManager;
        private LoanManager _loanManager;


        public frmMainMenu()
        {
            InitializeComponent();
            _memberManager = new MemberManager();
            _bookManager = new BookManager();
            _loanManager = new LoanManager();
        }
        private void ShowForm(Form form)
        {
            this.Hide();
            form.Show();
            form.FormClosed += (s, e) => this.Show();
        }

        private void mnuAddMember_Click(object sender, EventArgs e)
        {
            ShowForm(new frmAddMember(_memberManager));
        }

        private void mnuUpdateMember_Click(object sender, EventArgs e)
        {
            ShowForm(new frmUpdateMember(_memberManager));
        }

        private void mnuDeregisterMember_Click(object sender, EventArgs e)
        {
            ShowForm(new frmDeregisterMember(_memberManager));
        }

        private void munExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAddBook_Click(object sender, EventArgs e)
        {
            ShowForm(new frmAddBook(_bookManager));
        }

        private void mnuUpdateBook_Click(object sender, EventArgs e)
        {
            ShowForm(new frmUpdateBook(_bookManager));
        }

        private void mnuRemoveBook_Click(object sender, EventArgs e)
        {
            ShowForm(new frmRemoveBook(_bookManager));
        }

        private void mnuReserveBook_Click(object sender, EventArgs e)
        {
            ShowForm(new frmReserveBook(_memberManager, _bookManager, _loanManager));
        }

        private void mnuCollectBook_Click(object sender, EventArgs e)
        {
            ShowForm(new frmCollectBook(_loanManager, _bookManager));
        }

        private void mnuReturnBook_Click(object sender, EventArgs e)
        {
            ShowForm(new frmReturnBook(_loanManager, _bookManager));
        }
    }
}
