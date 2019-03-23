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

        private void comboBoxWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string caseSwitchWeapon = (string)comboBoxWeapon.SelectedItem;

            string filename = "../../Weapons images/icon_";

            filename= filename+caseSwitchWeapon+".png";

            pictureBoxWeapon.Image = Image.FromFile(filename);
 
        }

        private void comboBoxHelmetLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filename = "../../ArmorImages/";

            filename = filename + comboBoxHelmetLvl.SelectedItem + comboBoxVestLvl.SelectedItem + ".png";

           pictureBoxCharacter.Image = Image.FromFile(filename);
        }

        private void comboBoxVestLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filename = "../../ArmorImages/";

            filename = filename + comboBoxHelmetLvl.SelectedItem + comboBoxVestLvl.SelectedItem + ".png";

            pictureBoxCharacter.Image = Image.FromFile(filename);
        }
    }
}
