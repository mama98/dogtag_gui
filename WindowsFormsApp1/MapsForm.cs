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
    public partial class MapsForm : Form
    {
        public MapsForm()
        {
            InitializeComponent();
        }

        private void MapsForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void MapsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread(); // Closes the page 
        }

        private void MapsForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            UserChoice frm = new UserChoice();
            frm.Show();
            this.Hide();
        }

        private void buttonErangel_Click(object sender, EventArgs e)
        {
            pictureboxMap.Image = Image.FromFile("../../Resources/Erangel.png");
            buttonErangel.BackColor = Color.FromName("WindowFrame");
            buttonMiramar.BackColor = Color.Gray;
            buttonSanhok.BackColor = Color.Gray;
            buttonVikendi.BackColor = Color.Gray;
        }

        private void buttonMiramar_Click(object sender, EventArgs e)
        {
            pictureboxMap.Image = Image.FromFile("../../Resources/Miramar.png");
            buttonMiramar.BackColor = Color.FromName("WindowFrame");
            buttonErangel.BackColor = Color.Gray;
            buttonSanhok.BackColor = Color.Gray;
            buttonVikendi.BackColor = Color.Gray;
        }

        private void buttonSanhok_Click(object sender, EventArgs e)
        {
            pictureboxMap.Image = Image.FromFile("../../Resources/Sanhok.png");
            buttonSanhok.BackColor = Color.FromName("WindowFrame");
            buttonMiramar.BackColor = Color.Gray;
            buttonErangel.BackColor = Color.Gray;
            buttonVikendi.BackColor = Color.Gray;
        }

        private void buttonVikendi_Click(object sender, EventArgs e)
        {
            pictureboxMap.Image = Image.FromFile("../../Resources/Vikendi.png");
            buttonVikendi.BackColor = Color.FromName("WindowFrame");
            buttonMiramar.BackColor = Color.Gray;
            buttonSanhok.BackColor = Color.Gray;
            buttonErangel.BackColor = Color.Gray;
        }
    }
}
