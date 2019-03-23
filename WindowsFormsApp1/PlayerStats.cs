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
    public partial class PlayerStats : Form
    {
        public PlayerStats()
        {
            InitializeComponent();
        }

        private void PlayerStats_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            UserChoice frm = new UserChoice();
            frm.Show();
            this.Hide();
        }

        private void buttonLastGame_Click(object sender, EventArgs e)
        {
            buttonLastGame.BackColor = Color.FromName("WindowFrame");
            buttonSeason.BackColor = Color.Gray;
            buttonAllTime.BackColor = Color.Gray;

        }

        private void buttonSeason_Click(object sender, EventArgs e)
        {
            buttonSeason.BackColor = Color.FromName("WindowFrame");
            buttonLastGame.BackColor = Color.Gray;
            buttonAllTime.BackColor = Color.Gray;
        }

        private void buttonAllTime_Click(object sender, EventArgs e)
        {
            buttonAllTime.BackColor = Color.FromName("WindowFrame");
            buttonSeason.BackColor = Color.Gray;
            buttonLastGame.BackColor = Color.Gray;
        }

        private void PlayerStats_Load(object sender, EventArgs e)
        {

        }
    }
}
