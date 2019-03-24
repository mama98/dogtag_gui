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

        private void buttonTPP_Click(object sender, EventArgs e)
        {
            buttonTPP.BackColor = Color.FromName("WindowFrame");
            buttonTPP.FlatAppearance.BorderColor = Color.DarkOrange;
            buttonFPP.FlatAppearance.BorderColor = Color.Black;
            buttonFPP.BackColor = Color.Gray;
        }

        private void buttonFPP_Click(object sender, EventArgs e)
        {
            buttonFPP.BackColor = Color.FromName("WindowFrame");
            buttonFPP.FlatAppearance.BorderColor = Color.DarkOrange;
            buttonTPP.FlatAppearance.BorderColor = Color.Black;
            buttonTPP.BackColor = Color.Gray;
        }

        private void buttonSolo_Click(object sender, EventArgs e)
        {
            buttonSolo.BackColor = Color.FromName("WindowFrame");
            buttonSolo.FlatAppearance.BorderColor = Color.DarkOrange;
            buttonDuo.FlatAppearance.BorderColor = Color.Black;
            buttonDuo.BackColor = Color.Gray;
            buttonSquad.FlatAppearance.BorderColor = Color.Black;
            buttonSquad.BackColor = Color.Gray;
        }

        private void buttonDuo_Click(object sender, EventArgs e)
        {
            buttonDuo.BackColor = Color.FromName("WindowFrame");
            buttonDuo.FlatAppearance.BorderColor = Color.DarkOrange;
            buttonSolo.FlatAppearance.BorderColor = Color.Black;
            buttonSolo.BackColor = Color.Gray;
            buttonSquad.FlatAppearance.BorderColor = Color.Black;
            buttonSquad.BackColor = Color.Gray;
        }

        private void buttonSquad_Click(object sender, EventArgs e)
        {
            buttonSquad.BackColor = Color.FromName("WindowFrame");
            buttonSquad.FlatAppearance.BorderColor = Color.DarkOrange;
            buttonDuo.FlatAppearance.BorderColor = Color.Black;
            buttonDuo.BackColor = Color.Gray;
            buttonSolo.FlatAppearance.BorderColor = Color.Black;
            buttonSolo.BackColor = Color.Gray;
        }
    }
}
