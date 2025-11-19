using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibrarySYS
{
    public partial class frmReserveBook : Form
    {
        frmMainMenu parent;

        public frmReserveBook()
        {
            InitializeComponent();
            this.parent = new frmMainMenu();
        }

        public frmReserveBook(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtMemberId.Text == "A000000" || txtMemberId.Text == "A000001" ||
                txtMemberId.Text == "A000002")
            {
                // Enable text boxes
                grpMemberInfo.Visible = true;
                lblTitle.Visible = true;
                txtTitle.Visible = true;
                btnSearchTitle.Visible = true;

                if (txtMemberId.Text == "A000000")
                {
                    lblMemberInfo.Text = "Name: Sophia Loren        Phone: 0612345678" +
                        "\n\nAddress:  Galway Street 1, A65F4E2, Galway, Galway City" +
                        "\n\nEmail: not.sophia.loren@gmail.it";
                }
                else if (txtMemberId.Text == "A000001")
                {
                    lblMemberInfo.Text = "Name: Mario Rossi         Phone: 0687654321" +
                        "\n\nAddress: Tenth Street 2, A65F4E1, Limerick, Munster" +
                        "\n\nEmail: mariorossin1@gmail.com";
                }
                else if (txtMemberId.Text == "A000002")
                {
                    lblMemberInfo.Text = "Name: Luigi Bros          Phone: 0611223344" +
                        "\n\nAddress: Bros Street 3, A65F4E3, Shannon, Munster" +
                        "\n\nEmail: luigibros@yahoo.com";
                }

            }
            else if (txtMemberId.Text == "A000003")
            {
                MessageBox.Show("This Member's Status is currently Inactive!\n" +
                                "Unfortunately they cannot Reserve a Book!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtMemberId.Focus();
                grpMemberInfo.Visible = false;
                lblTitle.Visible = false;
                txtTitle.Visible = false;
                btnSearchTitle.Visible = false;
                return;
            }
            else
            {
                MessageBox.Show("Invalid MemberId!",
                                 "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                txtMemberId.Focus();
                grpMemberInfo.Visible = false;
                lblTitle.Visible = false;
                txtTitle.Visible = false;
                btnSearchTitle.Visible = false;
                return;
            }
        }
    }
}
