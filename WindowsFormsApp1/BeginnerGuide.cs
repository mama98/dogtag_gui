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
    public partial class BeginnerGuide : Form
    {

        public BeginnerGuide()
        {
            InitializeComponent();
        }

        private void buttonErangel_Click(object sender, EventArgs e)
        {
            pictureboxMap.Image = Image.FromFile("../../Resources/erangel.jpg");
        }

        private void buttonMiramar_Click(object sender, EventArgs e)
        {
            pictureboxMap.Image = Image.FromFile("../../Resources/miramar.jpg");
        }

        private void buttonSanhok_Click(object sender, EventArgs e)
        {
            pictureboxMap.Image = Image.FromFile("../../Resources/sanhok.jpg");
        }

        private void buttonVikendi_Click(object sender, EventArgs e)
        {
            pictureboxMap.Image = Image.FromFile("../../Resources/vikendi.jpg");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            UserChoice frm = new UserChoice();
            frm.Show();
            this.Hide();
        }

        private void BeginnerGuide_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void BeginnerGuide_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread(); // Closes the page 
        }
    }
}
