using LibrarySYS.Entities;
using LibrarySYS.Enums;
using LibrarySYS.Helpers;
using LibrarySYS.Managers;
using System;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmAddBook : Form
    {
        private BookManager _bookManager;
        public frmAddBook(BookManager bookManager)
        {
            InitializeComponent();
            _bookManager = bookManager;
        }
        private void mnuAddBookBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAddBook_Load(object sender, EventArgs e)
        {
            cboGenre.Items.AddRange(System.Enum.GetNames(typeof(Genre)));
            cboGenre.SelectedIndex = -1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            bool valid = ValidateBook.ValidateBookData(
                txtISBN.Text,
                txtTitle.Text,
                txtAuthor.Text,
                dtpPublication.Text,
                cboGenre,
                txtDescription.Text
            );

            if (!valid)
            {
                MessageBox.Show("Validation Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Genre genreEnum = (Genre)Enum.Parse(typeof(Genre), cboGenre.SelectedIndex.ToString());
            string bookId = IdGenerator.GenerateBookId();

            Book newBook = new Book(
                bookId,
                txtISBN.Text,
                txtTitle.Text,
                txtAuthor.Text,
                dtpPublication.Value,
                genreEnum,
                txtDescription.Text,
                true
            );

            _bookManager.AddBook(newBook);
            MessageBox.Show("Book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            cboGenre.SelectedIndex = -1;
            dtpPublication.Value = DateTime.Now;
            txtDescription.Clear();           
        }
    }
}
