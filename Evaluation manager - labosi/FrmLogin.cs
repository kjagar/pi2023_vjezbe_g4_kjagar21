using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_manager___labosi
{
    public partial class FrmLogin : Form
    {
        // Hard-codani korisničko ime i lozinka
        string username = "nastavnik";
        string password = "test";

        public FrmLogin()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int usernamePasswordCheck = 0;
            if (txtUsername.Text != "") usernamePasswordCheck += 2;
            if (txtPassword.Text != "") usernamePasswordCheck++;

            // Provjerava je li sve uneseno
            switch (usernamePasswordCheck)
            {
                case 0:
                {
                    MessageBox.Show("Korisničko ime i lozinka nisu uneseni!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                break;

                case 1:
                {
                    MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                break;

                case 2:
                {
                    MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                break;

                case 3:
                {
                    if ((txtUsername.Text == username) && (txtPassword.Text == password))
                    {
                        MessageBox.Show("Sve je ispravno uneseno!", "Uspješna prijava", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Neispravni podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                break;
            }
        }
    }
}
