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
    public partial class PlayerStats : Form
    {
        int FlagTimeline = -1; //Set to 0 for Current, 1 for Lifetime
        int FlagMatchType = -1; //Set to 0 for Solo, 1 for Duo, 2 for Squad;
        int FlagView = -1; //Set to 0 for TPP, 1 for FPP;

        User NewU;
        LastMatch LM;
        Season Current;
        Season Life;

        void performUserRequest(User user)
        {
            try
            {
                user.setUserData(1);         //Sets all the relevant data and performs one API call. Pass 1 to get more info
            } catch {
                MessageBox.Show("Too many API Calls ! Please try again in a bit.");
            }
            
        }
        void performLastMatchRequest(LastMatch lastmatch)
        {
            try
            {
                lastmatch.setLastMatchInfo(1);   //Sets all the info necessary to the request
                lastmatch.setAllData();      //Performs the API request and fills the Last Match fields
                lastmatch.displayAllData();      //Outputs all data to the command line for debugging} catch
            } catch {
                MessageBox.Show("Too many API Calls ! Please try again in a bit.");
            }
        }
        void performSeasonRequest(Season season, int time) //This one performs TWO API calls /!\
        {
            try
            { 
            season.setAllSeasonsData(1);	 //Sets necessary data regarding ALL seasons data. Only do it ONCE for optimization.
            season.setUserSeasonData(1, time);	 //Set the relevant season data
            season.displayAllStats();        //Outputs all stats to the command line for debugging
            } catch {
                  MessageBox.Show("Too many API Calls ! Please try again in a bit.");
            }
        }

        public PlayerStats()
        {
            InitializeComponent();

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

            NewU = new User("Mikumama");
            NewU.setUserData(1); 

            LM = new LastMatch(NewU.getLastMatchId(), NewU.getName());
            LM.setLastMatchInfo(1);
            LM.setAllData();

            labelRank.Text = LM.getrank();
            labelKillRank.Text = LM.getkillRank();
            labelDBNO.Text = LM.getdbnos();
            labelHeadshots.Text = LM.getheadshotKills(); //CHANGE LABEL
            labelDamage.Text = LM.getdamageDealt(); //CHANGE LABEL
            labelTimeSec.Text = LM.gettimeSurvived(); //CHECK
            labelDistance.Text = LM.getwalkDistance();
            labelTeamKills.Text = LM.getteamKills();
            labelHeals.Text = LM.getheals();
            //REMOVE OTHER MED LABELS
            labelBoosts.Text = LM.getboosts();
            //REMOVE OTHER BOOST LABELS

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
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

        private async void buttonLastGame_Click(object sender, EventArgs e)
        {
            buttonLastGame.BackColor = Color.FromName("WindowFrame");
            buttonSeason.BackColor = Color.Gray;
            buttonAllTime.BackColor = Color.Gray;

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

            labelRankKey.Text = "Rank";

            NewU = new User("Mikumama");
            await Task.Run(() => performUserRequest(NewU));

            LM = new LastMatch(NewU.getLastMatchId(), NewU.getName());
            await Task.Run(() => performLastMatchRequest(LM));

            labelRank.Text = LM.getrank();
            labelKillRank.Text = LM.getkillRank();
            labelDBNO.Text = LM.getdbnos();
            labelHeadshots.Text = LM.getheadshotKills(); //CHANGE LABEL
            labelDamage.Text = LM.getdamageDealt(); //CHANGE LABEL
            labelTimeSec.Text = LM.gettimeSurvived(); //CHECK
            labelDistance.Text = LM.getwalkDistance();
            labelTeamKills.Text = LM.getteamKills();
            labelHeals.Text = LM.getheals();
            //REMOVE OTHER MED LABELS
            labelBoosts.Text = LM.getboosts();
            //REMOVE OTHER BOOST LABELS

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;

        }

        private async void buttonSeason_Click(object sender, EventArgs e)
        {
            buttonSeason.BackColor = Color.FromName("WindowFrame");
            buttonLastGame.BackColor = Color.Gray;
            buttonAllTime.BackColor = Color.Gray;

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            
            buttonSolo.FlatAppearance.BorderColor = Color.DarkOrange;
            buttonTPP.FlatAppearance.BorderColor = Color.DarkOrange;

            buttonDuo.FlatAppearance.BorderColor = Color.Black;
            buttonSquad.FlatAppearance.BorderColor = Color.Black;
            buttonFPP.FlatAppearance.BorderColor = Color.Black;

            FlagTimeline = 0;

            NewU = new User("Mikumama");
            await Task.Run(() => performUserRequest(NewU));

            Current = new Season(NewU.getId(), 0);
            await Task.Run(() => performSeasonRequest(Current, 0));

            labelRankKey.Text = "Rank Points";
            labelRank.Text = "Sample";
            labelKills.Text = Current.getsolo_tpp_kills();
            labelKillRank.Text = "Sample";
            labelDBNO.Text = Current.getsolo_tpp_dBNOs();
            labelHeadshots.Text = Current.getsolo_tpp_headshotKills();
            labelDamage.Text = "Sample";
            labelTimeSec.Text = "Sample";
            labelDistance.Text = "Sample";
            labelTeamKills.Text = Current.getsolo_tpp_teamKills();
            labelTeamDamage.Text = "Sample";
            labelHeals.Text = Current.getsolo_tpp_heals();
            labelBoosts.Text = Current.getsolo_tpp_boosts();

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        private async void buttonAllTime_Click(object sender, EventArgs e)
        {
            buttonAllTime.BackColor = Color.FromName("WindowFrame");
            buttonSeason.BackColor = Color.Gray;
            buttonLastGame.BackColor = Color.Gray;

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

            buttonSolo.FlatAppearance.BorderColor = Color.DarkOrange;
            buttonTPP.FlatAppearance.BorderColor = Color.DarkOrange;

            FlagTimeline = 1;

            NewU = new User("Mikumama");
            await Task.Run(() => performUserRequest(NewU));

            Life = new Season(NewU.getId(), 1);
            await Task.Run(() => performSeasonRequest(Life, 1));

            labelRankKey.Text = "Rank Points";
            labelRank.Text = "Sample";
            labelKills.Text = Life.getsolo_tpp_kills();
            labelKillRank.Text = "Sample";
            labelDBNO.Text = Life.getsolo_tpp_dBNOs();
            labelHeadshots.Text = Life.getsolo_tpp_headshotKills();
            labelDamage.Text = "Sample";
            labelTimeSec.Text = "Sample";
            labelDistance.Text = "Sample";
            labelTeamKills.Text = Life.getsolo_tpp_teamKills();
            labelTeamDamage.Text = "Sample";
            labelHeals.Text = Life.getsolo_tpp_heals();
            labelBoosts.Text = Life.getsolo_tpp_boosts();

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
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

            FlagView = 0;

            switch (FlagMatchType)
            {
                case 0:
                    switch (FlagTimeline)
                    {
                        case 1:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Life.getsolo_tpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Life.getsolo_tpp_dBNOs();
                            labelHeadshots.Text = Life.getsolo_tpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Life.getsolo_tpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Life.getsolo_tpp_heals();
                            labelBoosts.Text = Life.getsolo_tpp_boosts();
                            break;
                        case 0:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Current.getsolo_tpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Current.getsolo_tpp_dBNOs();
                            labelHeadshots.Text = Current.getsolo_tpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Current.getsolo_tpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Current.getsolo_tpp_heals();
                            labelBoosts.Text = Current.getsolo_tpp_boosts();
                            break;
                        default:
                            break;
                    }
                    break;
                case 1:
                    switch (FlagTimeline)
                    {
                        case 1:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Life.getduo_tpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Life.getduo_tpp_dBNOs();
                            labelHeadshots.Text = Life.getduo_tpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Life.getduo_tpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Life.getduo_tpp_heals();
                            labelBoosts.Text = Life.getduo_tpp_boosts();
                            break;
                        case 0:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Current.getduo_tpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Current.getduo_tpp_dBNOs();
                            labelHeadshots.Text = Current.getduo_tpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Current.getduo_tpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Current.getduo_tpp_heals();
                            labelBoosts.Text = Current.getduo_tpp_boosts();
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (FlagTimeline)
                    {
                        case 1:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Life.getsquad_tpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Life.getsquad_tpp_dBNOs();
                            labelHeadshots.Text = Life.getsquad_tpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Life.getsquad_tpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Life.getsquad_tpp_heals();
                            labelBoosts.Text = Life.getsquad_tpp_boosts();
                            break;
                        case 0:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Current.getsquad_tpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Current.getsquad_tpp_dBNOs();
                            labelHeadshots.Text = Current.getsquad_tpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Current.getsquad_tpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Current.getsquad_tpp_heals();
                            labelBoosts.Text = Current.getsquad_tpp_boosts();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void buttonFPP_Click(object sender, EventArgs e)
        {
            buttonFPP.BackColor = Color.FromName("WindowFrame");
            buttonFPP.FlatAppearance.BorderColor = Color.DarkOrange;
            buttonTPP.FlatAppearance.BorderColor = Color.Black;
            buttonTPP.BackColor = Color.Gray;

            FlagView = 1;

            switch (FlagMatchType)
            {
                case 0:
                    switch (FlagTimeline)
                    {
                        case 0:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Current.getsolo_fpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Current.getsolo_fpp_dBNOs();
                            labelHeadshots.Text = Current.getsolo_fpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Current.getsolo_fpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Current.getsolo_fpp_heals();
                            labelBoosts.Text = Current.getsolo_fpp_boosts();
                            break;
                        case 1:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Life.getsolo_fpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Life.getsolo_fpp_dBNOs();
                            labelHeadshots.Text = Life.getsolo_fpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Life.getsolo_fpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Life.getsolo_fpp_heals();
                            labelBoosts.Text = Life.getsolo_fpp_boosts();
                            break;
                        default:
                            break;
                    }
                    break;
                case 1:
                    switch (FlagTimeline)
                    {
                        case 1:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Life.getduo_fpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Life.getduo_fpp_dBNOs();
                            labelHeadshots.Text = Life.getduo_fpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Life.getduo_fpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Life.getduo_fpp_heals();
                            labelBoosts.Text = Life.getduo_fpp_boosts();
                            break;
                        case 0:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Current.getduo_fpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Current.getduo_fpp_dBNOs();
                            labelHeadshots.Text = Current.getduo_fpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Current.getduo_fpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Current.getduo_fpp_heals();
                            labelBoosts.Text = Current.getduo_fpp_boosts();
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (FlagTimeline)
                    {
                        case 1:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Life.getsquad_fpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Life.getsquad_fpp_dBNOs();
                            labelHeadshots.Text = Life.getsquad_fpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Life.getsquad_fpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Life.getsquad_fpp_heals();
                            labelBoosts.Text = Life.getsquad_fpp_boosts();
                            break;
                        case 0:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Current.getsquad_fpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Current.getsquad_fpp_dBNOs();
                            labelHeadshots.Text = Current.getsquad_fpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Current.getsquad_fpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Current.getsquad_fpp_heals();
                            labelBoosts.Text = Current.getsquad_fpp_boosts();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void buttonSolo_Click(object sender, EventArgs e)
        {
            buttonSolo.BackColor = Color.FromName("WindowFrame");
            buttonSolo.FlatAppearance.BorderColor = Color.DarkOrange;
            buttonDuo.FlatAppearance.BorderColor = Color.Black;
            buttonDuo.BackColor = Color.Gray;
            buttonSquad.FlatAppearance.BorderColor = Color.Black;
            buttonSquad.BackColor = Color.Gray;

            FlagMatchType = 0;

            switch (FlagView)
            {
                case 0:
                    switch (FlagTimeline)
                    {
                        case 1:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Life.getsolo_tpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Life.getsolo_tpp_dBNOs();
                            labelHeadshots.Text = Life.getsolo_tpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Life.getsolo_tpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Life.getsolo_tpp_heals();
                            labelBoosts.Text = Life.getsolo_tpp_boosts();
                            break;
                        case 0:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Current.getsolo_tpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Current.getsolo_tpp_dBNOs();
                            labelHeadshots.Text = Current.getsolo_tpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Current.getsolo_tpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Current.getsolo_tpp_heals();
                            labelBoosts.Text = Current.getsolo_tpp_boosts();
                            break;
                        default:
                            break;
                    }
                    break;
                case 1:
                    switch (FlagTimeline)
                    {
                        case 1:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Life.getsolo_fpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Life.getsolo_fpp_dBNOs();
                            labelHeadshots.Text = Life.getsolo_fpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Life.getsolo_fpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Life.getsolo_fpp_heals();
                            labelBoosts.Text = Life.getsolo_fpp_boosts();
                            break;
                        case 0:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Current.getsolo_fpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Current.getsolo_fpp_dBNOs();
                            labelHeadshots.Text = Current.getsolo_fpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Current.getsolo_fpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Current.getsolo_fpp_heals();
                            labelBoosts.Text = Current.getsolo_fpp_boosts();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void buttonDuo_Click(object sender, EventArgs e)
        {
            buttonDuo.BackColor = Color.FromName("WindowFrame");
            buttonDuo.FlatAppearance.BorderColor = Color.DarkOrange;
            buttonSolo.FlatAppearance.BorderColor = Color.Black;
            buttonSolo.BackColor = Color.Gray;
            buttonSquad.FlatAppearance.BorderColor = Color.Black;
            buttonSquad.BackColor = Color.Gray;

            FlagMatchType = 1;

            switch (FlagView)
            {
                case 0:
                    switch (FlagTimeline)
                    {
                        case 1:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Life.getduo_tpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Life.getduo_tpp_dBNOs();
                            labelHeadshots.Text = Life.getduo_tpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Life.getduo_tpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Life.getduo_tpp_heals();
                            labelBoosts.Text = Life.getduo_tpp_boosts();
                            break;
                        case 0:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Current.getduo_tpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Current.getduo_tpp_dBNOs();
                            labelHeadshots.Text = Current.getduo_tpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Current.getduo_tpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Current.getduo_tpp_heals();
                            labelBoosts.Text = Current.getduo_tpp_boosts();
                            break;
                        default:
                            break;
                    }
                    break;
                case 1:
                    switch (FlagTimeline)
                    {
                        case 1:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Life.getduo_fpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Life.getduo_fpp_dBNOs();
                            labelHeadshots.Text = Life.getduo_fpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Life.getduo_fpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Life.getduo_fpp_heals();
                            labelBoosts.Text = Life.getduo_fpp_boosts();
                            break;
                        case 0:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Current.getduo_fpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Current.getduo_fpp_dBNOs();
                            labelHeadshots.Text = Current.getduo_fpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Current.getduo_fpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Current.getduo_fpp_heals();
                            labelBoosts.Text = Current.getduo_fpp_boosts();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void buttonSquad_Click(object sender, EventArgs e)
        {
            buttonSquad.BackColor = Color.FromName("WindowFrame");
            buttonSquad.FlatAppearance.BorderColor = Color.DarkOrange;
            buttonDuo.FlatAppearance.BorderColor = Color.Black;
            buttonDuo.BackColor = Color.Gray;
            buttonSolo.FlatAppearance.BorderColor = Color.Black;
            buttonSolo.BackColor = Color.Gray;

            FlagMatchType = 2;


            switch (FlagView)
            {
                case 0:
                    switch (FlagTimeline)
                    {
                        case 1:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Life.getsquad_tpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Life.getsquad_tpp_dBNOs();
                            labelHeadshots.Text = Life.getsquad_tpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Life.getsquad_tpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Life.getsquad_tpp_heals();
                            labelBoosts.Text = Life.getsquad_tpp_boosts();
                            break;
                        case 0:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Current.getsquad_tpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Current.getsquad_tpp_dBNOs();
                            labelHeadshots.Text = Current.getsquad_tpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Current.getsquad_tpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Current.getsquad_tpp_heals();
                            labelBoosts.Text = Current.getsquad_tpp_boosts();
                            break;
                        default:
                            break;
                    }
                    break;
                case 1:
                    switch (FlagTimeline)
                    {
                        case 1:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Life.getsquad_fpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Life.getsquad_fpp_dBNOs();
                            labelHeadshots.Text = Life.getsquad_fpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Life.getsquad_fpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Life.getsquad_fpp_heals();
                            labelBoosts.Text = Life.getsquad_fpp_boosts();
                            break;
                        case 0:
                            labelRankKey.Text = "Rank Points";
                            labelRank.Text = "Sample";
                            labelKills.Text = Current.getsquad_fpp_kills();
                            labelKillRank.Text = "Sample";
                            labelDBNO.Text = Current.getsquad_fpp_dBNOs();
                            labelHeadshots.Text = Current.getsquad_fpp_headshotKills();
                            labelDamage.Text = "Sample";
                            labelTimeSec.Text = "Sample";
                            labelDistance.Text = "Sample";
                            labelTeamKills.Text = Current.getsquad_fpp_teamKills();
                            labelTeamDamage.Text = "Sample";
                            labelHeals.Text = Current.getsquad_fpp_heals();
                            labelBoosts.Text = Current.getsquad_fpp_boosts();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
