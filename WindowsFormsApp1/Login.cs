using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //TODO add API request
            if(inputLogin== "mikumama")
            {
                UserChoice frm = new UserChoice();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
