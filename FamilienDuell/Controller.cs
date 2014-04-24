using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Xml;

namespace FamilienDuell
{

    public partial class Main : Form
    {
        static string randString(Int32 len)
        {
            string text = "";
            System.Random random = new System.Random();
            for (Int32 i = 0; i < len; i++)
            {
                Int32 Number = Convert.ToInt32(Math.Floor(58 * random.NextDouble() + 65));
                char x = Convert.ToChar(Number);
                if (x > 90 && x < 97)
                {
                    i--;
                    continue;
                }
                else
                {
                    text += x;
                }
            }
            return text;
        } 
        int CurrentGameStatus = 0;
        // initialize monitor
        GameMonitor Monitor = new GameMonitor();
        // get clientid for server
        string clientId = "asd";
        

        public Main()
        {
            InitializeComponent();
            
        }

        // start functions
        public bool nextStep()
        {
            if (CurrentGameStatus == 0)
            {
                lblClientId.Text = txtGameTitle.Text;
                Monitor.Show();
                btnNext.Text = "Monitor fixieren (Vollbild)";
                CurrentGameStatus = 1;
            }
            else if (CurrentGameStatus == 1)
            {
                Monitor.SetHeadline("Davids Familien Duell v0.1 Alpha-RC");
                Monitor.maximize();
                Monitor.ToggleWaiting();
                tabMainControl.Enabled = true;
                btnNext.Enabled = false;
                btnNext.Text = "Runde starten!";
                CurrentGameStatus = 2;
            }
            else if (CurrentGameStatus == 2)
            {
                if (txtTeam1.Text != "" & txtTeam2.Text != "")
                {
                    lblTeamAlert.Text = "";
                    Monitor.ToggleWaiting();
                    btnNext.Text = "Nächste Runde";
                    btnNext.Enabled = false;
                    lblStatus.Text = "Aktives Spiel (Runde 1)";
                    Monitor.GameStart();
                    playSound(1);
                    CurrentGameStatus = 3;
                }
                else
                {
                    lblTeamAlert.Text = "Es sind keine Teams angegeben!";
                }
            }
            else if (CurrentGameStatus == 3)
            {
                if (txtTeam1.Text != "" & txtTeam2.Text != "")
                {
                    togglePointButtons();
                    lblTeamAlert.Text = "";
                    btnNext.Enabled = false;
                    btnGetQuestion.Enabled = true;
                    lblStatus.Text = "Aktives Spiel (Runde 2)";
                    Monitor.nextRound(2);
                    CurrentGameStatus = 4;
                }
                else
                {
                    lblTeamAlert.Text = "Es sind keine Teams angegeben!";
                }
            }
            return true;
        }

        private void togglePointButtons()
        {
            if (btnRemi.Enabled == true)
            {
                btnTeam1.Enabled = false;
                btnTeam2.Enabled = false;
                btnRemi.Enabled = false;
            }
            else
            {
                if (btnAnswer1.Enabled == false & btnAnswer2.Enabled == false & btnAnswer3.Enabled == false & btnAnswer4.Enabled == false & btnAnswer5.Enabled == false & btnAnswer6.Enabled == false)
                {
                    btnTeam1.Enabled = true;
                    btnTeam2.Enabled = true;
                    btnRemi.Enabled = true;
                }
            }
        }

        // sound emitter
        private bool playSound(int Action)
        {
            if (cbSounds.Checked == true)
            {
                try
                {
                    string locationOffset = "D:\\Dropbox\\Misc\\FamilienDuell\\FamilienDuell\\obj\\Debug\\";
                    if (Action == 1)
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"" + locationOffset + "sounds\\intro.wav");
                        simpleSound.Play();
                    }
                    else if (Action == 2)
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"" + locationOffset + "sounds\\right.wav");
                        simpleSound.Play();
                    }
                    else if (Action == 3)
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"" + locationOffset + "sounds\\wrong.wav");
                        simpleSound.Play();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not play sound file: " + e.Message);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool getQuestion()
        {
            lblQuestion.Text = "Wartend..";
            int getQuestion = 0;
            int currAnswer = 0;
            XmlTextReader reader = new XmlTextReader("http://www.dbeuchert.com/Duell/" + clientId + ".xml");
            while (reader.Read())
            {
                if (reader.LocalName == "question")
                {
                    if (getQuestion != 2) {
                        getQuestion = 1;
                    }
                }
                if (getQuestion == 1 & lblQuestion.Text == "Wartend..")
                {
                    if (reader.Value != "" && reader.Name == "")
                    {
                        string Question = reader.Value;
                        lblQuestion.Text = Question;
                        getQuestion = 2;
                    }
                }
                if (getQuestion == 2)
                {
                    string name = reader.Name;
                    string value = reader.Value;
                    name.Trim();
                    value.Trim();
                    if (value != "" && name == "")
                    {
                        currAnswer++;
                        if (currAnswer == 4)
                        {
                            btnAnswer1.Text = reader.Value;
                        }
                        else if (currAnswer == 6)
                        {
                            lblQuantity1.Text = reader.Value;
                        }
                        else if (currAnswer == 10)
                        {
                            btnAnswer2.Text = reader.Value;
                        }
                        else if (currAnswer == 12)
                        {
                            lblQuantity2.Text = reader.Value;
                        }
                        else if (currAnswer == 16)
                        {
                            btnAnswer3.Text = reader.Value;
                        }
                        else if (currAnswer == 18)
                        {
                            lblQuantity3.Text = reader.Value;
                        }
                        else if (currAnswer == 22)
                        {
                            btnAnswer4.Text = reader.Value;
                        }
                        else if (currAnswer == 24)
                        {
                            lblQuantity4.Text = reader.Value;
                        }
                        else if (currAnswer == 28)
                        {
                            btnAnswer5.Text = reader.Value;
                        }
                        else if (currAnswer == 30)
                        {
                            lblQuantity5.Text = reader.Value;
                        }
                        else if (currAnswer == 34)
                        {
                            btnAnswer6.Text = reader.Value;
                        }
                        else if (currAnswer == 36)
                        {
                            lblQuantity6.Text = reader.Value;
                        }
                    }
                }
            }
            return true;
        }

        // start events of buttons

        // nextbutton
        public void btnNext_Click(object sender, EventArgs e)
        {
            nextStep();
        }

        // overtake
        private void btnOvertake_Click(object sender, EventArgs e)
        {
            if (txtGameTitle.Text != "")
            {
                Monitor.SetHeadline(txtGameTitle.Text);
            }
            if (txtTeam1.Text != "" & txtTeam2.Text != "")
            {
                Monitor.SetTeams(txtTeam1.Text, txtTeam2.Text);
            }
            if (CurrentGameStatus == 2)
            {
                if (txtTeam1.Text != "" & txtTeam2.Text != "")
                {
                    btnNext.Enabled = true;
                }
                else
                {
                    lblTeamAlert.Text = "Es sind keine Teams angegeben!";
                }
            }
        }

        private void checkTeamNames(object sender, EventArgs e)
        {
            string team1 = txtTeam1.Text;
            string team2 = txtTeam2.Text;
            if (team1.Length > 16)
            {
                lblTeamAlert.Text = "Name für Team 1 möglicherweise zu lang!";
            }
            else if (team2.Length > 16)
            {
                lblTeamAlert.Text = "Name für Team 2 möglicherweise zu lang!";
            }
            else {
                lblTeamAlert.Text = "";
            }
            if (team1 == team2)
            {
                btnOvertake.Enabled = false;
                lblTeamAlert.Text = "Zwei gleiche Teamnamen sind nicht gestattet.";
            }
            else
            {
                btnOvertake.Enabled = true;
            }
        }

        private void btnWrong_Click(object sender, EventArgs e)
        {
            playSound(3);
            if (cbTeamRound.Checked == true)
            {
                Monitor.MakeWrong(1);
            }
            else
            {
                Monitor.MakeWrong(0);
            }
        }

        private void btnGetQuestion_Click(object sender, EventArgs e)
        {
            getQuestion();
            btnAnswer1.Enabled = true;
            btnAnswer2.Enabled = true;
            btnAnswer3.Enabled = true;
            if (CurrentGameStatus < 6)
            {
                btnAnswer4.Enabled = true;
            }
            if (CurrentGameStatus < 5)
            {
                btnAnswer5.Enabled = true;
            }
            if (CurrentGameStatus == 3)
            {
                btnAnswer6.Enabled = true;
            }
            btnShowQuestion.Enabled = true;
        }

        // answers
        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            playSound(2);
            btnAnswer1.Enabled = false;
            btnGetQuestion.Enabled = false;
            cbTeamRound.Checked = true;
            togglePointButtons();
            Monitor.ShowResult(1, btnAnswer1.Text, lblQuantity1.Text);
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            playSound(2);
            btnAnswer2.Enabled = false;
            btnGetQuestion.Enabled = false;
            togglePointButtons();
            Monitor.ShowResult(2, btnAnswer2.Text, lblQuantity2.Text);
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            playSound(2);
            btnGetQuestion.Enabled = false;
            btnAnswer3.Enabled = false;
            togglePointButtons();
            Monitor.ShowResult(3, btnAnswer3.Text, lblQuantity3.Text);
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            playSound(2);
            btnAnswer4.Enabled = false;
            togglePointButtons();
            btnGetQuestion.Enabled = false;
            Monitor.ShowResult(4, btnAnswer4.Text, lblQuantity4.Text);
        }

        private void btnAnswer5_Click(object sender, EventArgs e)
        {
            playSound(2);
            btnAnswer5.Enabled = false;
            togglePointButtons();
            Monitor.ShowResult(5, btnAnswer5.Text, lblQuantity5.Text);
            btnGetQuestion.Enabled = false;
        }

        private void btnAnswer6_Click(object sender, EventArgs e)
        {
            playSound(2);
            btnAnswer6.Enabled = false;
            togglePointButtons();
            btnGetQuestion.Enabled = false;
            Monitor.ShowResult(6, btnAnswer6.Text, lblQuantity6.Text);
        }

        private void cbTeamRound_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTeamRound.Checked != true)
            {
                Monitor.clearWrong();
            }
        }

        private void btnAddPoints_Click(object sender, EventArgs e)
        {
            if (drpTeam.SelectedIndex > -1 & drpTeam.SelectedIndex < 4)
            {
                if (drpTeam.Items[drpTeam.SelectedIndex].ToString() == "Team 1")
                {
                    Monitor.newPoints(2, int.Parse(tbPointsProceed.Text));
                    lblPointsWarning.Text = "";
                }
                else if (drpTeam.Items[drpTeam.SelectedIndex].ToString() == "Team 2")
                {
                    Monitor.newPoints(3, int.Parse(tbPointsProceed.Text));
                    lblPointsWarning.Text = "";
                }
                else if (drpTeam.Items[drpTeam.SelectedIndex].ToString() == "Rundenpunkte")
                {
                    lblPointsWarning.Text = "";
                    Monitor.newPoints(1, int.Parse(tbPointsProceed.Text));
                }
                else
                {
                    lblPointsWarning.Text = "Bitte existierendes Team auswählen.";
                }
            }
            else
            {
                lblPointsWarning.Text = "Bitte existierendes Team auswählen.";
            }
        }

        private void btnDelPoints_Click(object sender, EventArgs e)
        {
            if (drpTeam.SelectedIndex > -1 & drpTeam.SelectedIndex < 4)
            {
                if (drpTeam.Items[drpTeam.SelectedIndex].ToString() == "Team 1")
                {
                    Monitor.remPoints(2, int.Parse(tbPointsProceed.Text));
                    lblPointsWarning.Text = "";
                }
                else if (drpTeam.Items[drpTeam.SelectedIndex].ToString() == "Team 2")
                {
                    Monitor.remPoints(3, int.Parse(tbPointsProceed.Text));
                    lblPointsWarning.Text = "";
                }
                else if (drpTeam.Items[drpTeam.SelectedIndex].ToString() == "Rundenpunkte")
                {
                    lblPointsWarning.Text = "";
                    Monitor.remPoints(1, int.Parse(tbPointsProceed.Text));
                }
                else
                {
                    lblPointsWarning.Text = "Bitte existierendes Team auswählen.";
                }
            }
            else
            {
                lblPointsWarning.Text = "Bitte existierendes Team auswählen.";
            }
        }

        private void btnTeam1_Click(object sender, EventArgs e)
        {
            Monitor.winnerPoints(2);
            btnNext.Enabled = true;
        }

        private void btnTeam2_Click(object sender, EventArgs e)
        {
            Monitor.winnerPoints(3);
            btnNext.Enabled = true;
        }

        private void btnShowQuestion_Click(object sender, EventArgs e)
        {
            Monitor.setQuestion(lblQuestion.Text);
        }

        private void btnRemi_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            Monitor.setPoints(1, 0);
        }
    }
}
