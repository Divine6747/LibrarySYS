using LibrarySYS.Entities;
using LibrarySYS.Managers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmRemoveBook : Form
    {
        private readonly BookManager _bookManager;
        private Book _currentBook;
        public frmRemoveBook(BookManager bookManager)
        {
            InitializeComponent();
            _bookManager = bookManager;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchBookId_Click(object sender, EventArgs e)
        {

        }
    }
}
