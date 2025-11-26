using LibrarySYS.Entities;
using LibrarySYS.Enum;
using LibrarySYS.Helpers;
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
            this.Load += frmAddBook_Load;
        }

        private void mnuAddBookBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.Show();
        }
        private void frmAddBook_Load(object sender, EventArgs e)
        {
            cboGenre.Items.AddRange(System.Enum.GetNames(typeof(Genre)));
            MessageBox.Show($"Genres loaded: {cboGenre.Items.Count} items");
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            string error;
            string bookid = IdGenerator.GenerateBookId();
            string genre = cboGenre.SelectedItem.ToString();

            bool valid = ValidateBook.ValidateBookData(
                txtISBN.Text,
                txtTitle.Text,
                txtAuthor.Text,
                dtpPublication.Text,
                genre,
                txtDescription.Text,
                out error
            );

            if (!valid)
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Book newBook = new Book(
                    bookid,
                    txtISBN.Text,
                    txtTitle.Text,
                    txtAuthor.Text,
                    dtpPublication.Value,
                    genre,
                    txtDescription.Text
                );

                newBook.AddBook(newBook);
                txtISBN.Clear();
                txtTitle.Clear();
                txtAuthor.Clear();
                cboGenre.SelectedIndex = -1;
                dtpPublication.Value = DateTime.Now;
                txtDescription.Clear();

            }

        }
    }
}
