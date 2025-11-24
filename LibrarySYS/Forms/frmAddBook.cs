using LibrarySYS.Entities;
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string error;
            string dateString = dtpPublication.Value.ToString("yyyy-MM-dd");

            

            bool valid = ValidateBook.ValidateBookData(
                txtISBN.Text,
                txtTitle.Text,
                txtAuthor.Text,
                dtpPublication.Text,
                cboGenre.Text,
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
                    "",                   
                    txtISBN.Text,           
                    txtTitle.Text,         
                    txtAuthor.Text,         
                    dtpPublication.Value,   
                    cboGenre.Text,          
                    txtDescription.Text     
                );


                /*                Book newBook = new Book(
                  //Kesken BookID.Text
                   txtISBN.Text,
                   txtTitle.Text,
                   txtAuthor.Text,
                   dateString,
                   cboGenre.SelectedIndex.ToString,
                   txtDescription.Text
               );

                */

                newBook.AddBook(newBook);

            }
        }
    }
}
