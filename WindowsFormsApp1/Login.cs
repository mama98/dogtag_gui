using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DogtagCLI;

namespace WindowsFormsApp1
{

    public partial class Login : Form
    {
        private string inputLogin = string.Empty;

        public Login()
        {
            InitializeComponent();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            inputLogin = textBoxLogin.Text;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User NewU = new User(inputLogin);
                NewU.setUserData(1);
                System.IO.File.WriteAllText(@"user.dt", inputLogin);

                UserChoice frm = new UserChoice();
                frm.Show();
                this.Hide();

            } catch
            {
                MessageBox.Show("The name you entered resulted in an error. Either you typed it wrong, or too many API Calls have been made.");
            }
            /*
            if(inputLogin== "mikumama")
            {
                UserChoice frm = new UserChoice();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("¯\\_(ツ)_/¯ Wrong Username");
            }
            */
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
