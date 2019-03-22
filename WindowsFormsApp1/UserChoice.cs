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
    public partial class UserChoice : Form
    {
        public UserChoice()
        {
            InitializeComponent();
        }

        private void buttonWorkbench_Click(object sender, EventArgs e)
        {
            BeginnerGuide frm = new BeginnerGuide();
            frm.Show();
            this.Hide();
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            PlayerStats frm = new PlayerStats();
            frm.Show();
            this.Hide();
        }

        private void UserChoice_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void UserChoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
