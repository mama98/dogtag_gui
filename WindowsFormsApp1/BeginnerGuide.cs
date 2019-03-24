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

       public class Weapon
        {
            private string m_name;
            private string m_dps;
            private string m_bulletspeed;
            private string m_magsize;
            private string m_timepershot;
            private string m_ammotype;

        };
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

            switch(comboBoxHelmetLvl.SelectedItem)
            {
                case "0":
                    labelHelmetSTK.Text ="1";
                    break;
                case "1":
                    labelHelmetSTK.Text = "2";
                    break;
                case "2":
                    labelHelmetSTK.Text = "2";
                    break;
                case "3":
                    labelHelmetSTK.Text = "3";
                    break;
                default:
                    break;
            }
        }

        private void comboBoxVestLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filename = "../../ArmorImages/";

            filename = filename + comboBoxHelmetLvl.SelectedItem + comboBoxVestLvl.SelectedItem + ".png";

            pictureBoxCharacter.Image = Image.FromFile(filename);

            switch (comboBoxVestLvl.SelectedItem)
            {
                case "0":
                    labelVestSTK.Text = "3";
                    break;
                case "1":
                    labelVestSTK.Text = "4";
                    break;
                case "2":
                    labelVestSTK.Text = "5";
                    break;
                case "3":
                    labelVestSTK.Text = "6";
                    break;
                default:
                    break;
            }
        }
        private void comboBoxHelmetLvl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void comboBoxVestLvl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
