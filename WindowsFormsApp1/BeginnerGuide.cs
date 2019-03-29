using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using DogtagCLI;  //Import the wrapper around DogtagCore.
/*
 * This is all you need to use all the classes and functions of the lib.
 * You can use the following classes :
 *
 * 	User;
 * 	LastMatch;
 * 	Season;
 *
 * To create a new instance of the class :
 * 	
 * 	User my_user = new User();/new User(String name);
 * 	LastMatch  my_lm = new LastMatch(String last_match_id, String user_name);
 * 	Season my_season = new Season(String user_id, int timeline);
 *
 * Thus, you can only create a working LastMatch/Season class if you've performed an API call on User.
 *
 * 'timeline' refers to the period you want to check out :
 *
 * 	For the current period, timeline = 0 : Season my_season = new Season(user_id, 0)
 * 	For the AllTime period, timeline = 1 : Season my_season = new Season(user_id, 1);
 *
 * Here are the threaded request functions : 
 *
 *
        void performLastMatchRequest(LastMatch lastmatch)
        {
            lastmatch.setLastMatchInfo(1);	 //Sets all the info necessary to the request
            lastmatch.setAllData();		 //Performs the API request and fills the Last Match fields
            lastmatch.displayAllData();		 //Outputs all data to the command line for debugging
        }

        void performUserRequest(User user) {
            user.setUserData(1);		 //Sets all the relevant data and performs one API call. Pass 1 to get more info
        }

        void performSeasonRequest(Season season, int time) //This one performs TWO API calls /!\
        {
            season.setAllSeasonsData(1);	 //Sets necessary data regarding ALL seasons data. Only do it ONCE for optimization.
            season.setUserSeasonData(1, time);	 //Set the relevant season data
            season.displayAllStats();		 //Outputs all stats to the command line for debugging
        }

 *
 * Don't forget to add 'async' to the functions that call the request functions !
 *
 * How to perform a request :
 * 	
 * 	await Task.Run(() => perform*****Request(arg1, arg2...));
 *
 * To get the relevant data :
 * 	
 * 	my_class.get****();
 *
 * 	This ALWAYS returns a string, so no need for a cast. Even for a 'number' like getduo_fpp_kills()
 *
 * ENJOY !
 */

namespace WindowsFormsApp1
{
    public partial class BeginnerGuide : Form
    {
        
        public BeginnerGuide()
        {
            InitializeComponent();
        }

       /*
       public class Weapon
        {
            private string m_name;
            private string m_dps;
            private string m_bulletspeed;
            private string m_magsize;
            private string m_timepershot;
            private string m_ammotype;

        };
        */
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

        void performLastMatchRequest(LastMatch lastmatch)
        {
            lastmatch.setLastMatchInfo(1);

            lastmatch.setAllData();

            lastmatch.displayAllData();
        }

        void performUserRequest(User user) {
            user.setUserData(0);
        }

        void performSeasonRequest(Season season, int timeline)
        {
            season.setAllSeasonsData(0);

            season.setUserSeasonData(0, timeline);

            season.displayAllStats();
        }

        //private async void comboBoxWeapon_SelectedIndexChanged(object sender, EventArgs e) //Add async to multithread it. IMPORTANT. NECESSARY.
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
