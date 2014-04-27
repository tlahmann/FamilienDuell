using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Data.SqlClient;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
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
        int currentSetupStatus = 0;
        Boolean maximus;
        // initialize monitor
        GameMonitor Monitor = new GameMonitor();
        // get clientid for server
        string clientId = "asd";
        

        public Main()
        {
            InitializeComponent();

            txtGameTitle.TextChanged += new EventHandler(this.textGameTitleChanged);
            txtTeam1.TextChanged += new EventHandler(this.textTeamsChanged);
            txtTeam2.TextChanged += new EventHandler(this.textTeamsChanged);
            radioButton1.CheckedChanged += new EventHandler(this.stateOptionsChanged);
            radioButton2.CheckedChanged += new EventHandler(this.stateOptionsChanged);
            numericUpDown1.ValueChanged += new EventHandler(this.stateOptionsChanged);
            cbSounds.CheckedChanged += new EventHandler(this.stateOptionsChanged);
            this.dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewRowPostPaint);
            //tabMainControl.TabIndexChanged += new EventHandler(this.tabStateChanged);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            showMonitor();

            textGameTitleChanged(null, null);

            //playSound(1);

            //tabMainControl.Enabled = false;
        }
        
        #region Setup
        // determine if GameTitle has been entered
        public void textGameTitleChanged(object sender, EventArgs e)
        {
            if (txtGameTitle.Text != "")
            {
                Monitor.lblHeadline.Text = txtGameTitle.Text.ToString();
                textTeamsChanged(null, null);
                txtTeam1.Enabled = true;
                txtTeam2.Enabled = true;
                tableLayoutPanel3.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                txtTeam1.Enabled = false;
                txtTeam2.Enabled = false;
                tableLayoutPanel3.BackColor = SystemColors.InactiveCaption;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                numericUpDown1.Enabled = false;
                cbSounds.Enabled = false;
                tableLayoutPanel4.BackColor = SystemColors.InactiveCaption;
            }
        }

        // determine if Teamnames have been entered
        public void textTeamsChanged(object sender, EventArgs e)
        {
            if (txtTeam1.Text != "")
            {
                Monitor.lblTeam1.Text = txtTeam1.Text.ToString();
            }

            if (txtTeam1.Text != "")
            {
                Monitor.lblTeam2.Text = txtTeam2.Text.ToString();
            }

            if (txtTeam1.Text != "" && txtTeam2.Text != "")
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                numericUpDown1.Enabled = true;
                cbSounds.Enabled = true;
                tableLayoutPanel4.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                Monitor.lblTeam2.Text = txtTeam2.Text.ToString();
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                numericUpDown1.Enabled = false;
                cbSounds.Enabled = false;
                tableLayoutPanel4.BackColor = SystemColors.InactiveCaption;
            }
        }

        public void stateOptionsChanged(object sender, EventArgs e)
        {
            if((radioButton1.Checked == true || radioButton2.Checked == true))
            {
                btnNext.Enabled = true;
            }
        }
        #endregion

        #region gameplay

        private void btnWrongClick(object sender, EventArgs e)
        {
            playSound(3);
            cbTeamRound.Checked = Monitor.makeWrong(cbTeamRound.Checked);
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
        private void btnAnswer1Click(object sender, EventArgs e)
        {
            playSound(2);
            btnAnswer1.Enabled = false;
            btnGetQuestion.Enabled = false;
            cbTeamRound.Checked = true;
            togglePointButtons();
            Monitor.showResult(1, btnAnswer1.Text, lblQuantity1.Text);
        }

        private void btnAnswer2Click(object sender, EventArgs e)
        {
            playSound(2);
            btnAnswer2.Enabled = false;
            btnGetQuestion.Enabled = false;
            togglePointButtons();
            Monitor.showResult(2, btnAnswer2.Text, lblQuantity2.Text);
        }

        private void btnAnswer3Click(object sender, EventArgs e)
        {
            playSound(2);
            btnGetQuestion.Enabled = false;
            btnAnswer3.Enabled = false;
            togglePointButtons();
            Monitor.showResult(3, btnAnswer3.Text, lblQuantity3.Text);
        }

        private void btnAnswer4Click(object sender, EventArgs e)
        {
            playSound(2);
            btnAnswer4.Enabled = false;
            togglePointButtons();
            btnGetQuestion.Enabled = false;
            Monitor.showResult(4, btnAnswer4.Text, lblQuantity4.Text);
        }

        private void btnAnswer5Click(object sender, EventArgs e)
        {
            playSound(2);
            btnAnswer5.Enabled = false;
            togglePointButtons();
            Monitor.showResult(5, btnAnswer5.Text, lblQuantity5.Text);
            btnGetQuestion.Enabled = false;
        }

        private void btnAnswer6Click(object sender, EventArgs e)
        {
            playSound(2);
            btnAnswer6.Enabled = false;
            togglePointButtons();
            btnGetQuestion.Enabled = false;
            Monitor.showResult(6, btnAnswer6.Text, lblQuantity6.Text);
        }

        private void btnTeam1Click(object sender, EventArgs e)
        {
            Monitor.winnerPoints(2);
            btnNext.Enabled = true;
        }

        private void btnTeam2Click(object sender, EventArgs e)
        {
            Monitor.winnerPoints(3);
            btnNext.Enabled = true;
        }

        private void btnRemiClick(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            Monitor.setPoints(1, 0);
        }
        #endregion

        public void showMonitor()
        {
            Monitor.Show();
        }

        // start functions
        public bool playGame()
        {
            if (CurrentGameStatus == 0)
            {
                lblClientId.Text = txtGameTitle.Text;

                btnNext.Text = "Start";
                CurrentGameStatus = 1;
            }
            else if (CurrentGameStatus == 1)
            {
                Monitor.setHeadline("Davids Familien Duell v0.1 Alpha-RC");
                
                //Monitor.toggleWaiting();
                tabMainControl.Enabled = true;
                btnNext.Enabled = false;
                //btnNext.Text = "Runde starten!";
                CurrentGameStatus = 2;
            }
            else if (CurrentGameStatus == 2)
            {
                if (txtTeam1.Text != "" & txtTeam2.Text != "")
                {
                    lblTeamAlert.Text = "";
                    Monitor.toggleWaiting();
                    btnNext.Text = "Nächste Runde";
                    btnNext.Enabled = false;
                    lblStatus.Text = "Aktives Spiel (Runde 1)";
                    Monitor.gameStart();
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
                    string locationOffset = Directory.GetCurrentDirectory();
                    //System.Diagnostics.Process.Start(path + @"\sound\Bonefit_Hilfe.pdf");

                    //string locationOffset = "D:\\Dropbox\\Misc\\FamilienDuell\\FamilienDuell\\obj\\Debug\\";
                    if (Action == 1)
                    {
                        // main theme
                        SoundPlayer simpleSound = new SoundPlayer(locationOffset + @"\sounds\ff94_main_theme.wav");
                        simpleSound.Play();
                    }
                    else if (Action == 2)
                    {
                        // correct answer sound
                        SoundPlayer simpleSound = new SoundPlayer(locationOffset + @"\sounds\ff-clang.wav");
                        simpleSound.Play();
                    }
                    else if (Action == 3)
                    {
                        // wrong answer sound
                        SoundPlayer simpleSound = new SoundPlayer(locationOffset + @"\sounds\ff-strike3.wav");
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

        // nextbutton
        public void btnNextClick(object sender, EventArgs e)
        {
            if (tabMainControl.SelectedIndex == 0)
            {
                try
                {
                    int nOP = Convert.ToInt32(numericUpDown1.Value);
                    if(dataGridView.RowCount != nOP)
                    {
                        int add = nOP - dataGridView.RowCount;
                        for (int i = 0; i < add; i++)
                        {
                            // TODO DefaultNamen raus!
                            dataGridView.Rows.Add("Player Red " + (i + 1), "Player Blue " + (i + 1));
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler!");
                }
                
                tabMainControl.SelectedIndex = 1;
                currentSetupStatus++;
            }
            else if (tabMainControl.SelectedIndex == 1)
            {
                if (gridCheck())
                {
                    tabMainControl.SelectedIndex = 2;
                    currentSetupStatus++;
                }
            }
            else if (tabMainControl.SelectedIndex == 2)
            {
                tabMainControl.SelectedIndex = 3;
                currentSetupStatus++;
                readyToPlay();
                playGame();
            }
            else if (tabMainControl.SelectedIndex == 3)
            {
                playGame();
            }
        }

        // displays row numbers for dgv
        private void dataGridViewRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 17, e.RowBounds.Location.Y + 4);
            }
        }

        private bool gridCheck()
        {
            Boolean valid = true;

            for (int j = 0; j < dataGridView.Rows.Count; j++)
            {
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    if (dataGridView.Rows[j].Cells[i].Value == null)
                    {
                        dataGridView.Rows[j].Cells[i].Style.BackColor = SystemColors.InactiveCaption;

                        valid = false;
                    }
                    else if (dataGridView.Rows[j].Cells[i].Value == "")
                    {
                        dataGridView.Rows[j].Cells[i].Style.BackColor = SystemColors.InactiveCaption;

                        valid = false;
                    }
                    else
                    {
                            dataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    }
                }
            }
            return valid;
        }

        private void readyToPlay()
        {
            if(currentSetupStatus == 3)
            {
                btnAnswer1.Enabled = true;
                btnAnswer2.Enabled = true;
                btnAnswer3.Enabled = true;
                btnAnswer4.Enabled = true;
                btnAnswer5.Enabled = true;
                btnAnswer6.Enabled = true;
                btnGetQuestion.Enabled = true;
                btnShowQuestion.Enabled = true;
                btnTeam1.Enabled = true;
                btnTeam2.Enabled = true;
                btnRemi.Enabled = true;
                btnWrong.Enabled = true;
                cbTeamRound.Enabled = true;
            }
        }

        //// overtake
        //private void btnOvertakeClick(object sender, EventArgs e)
        //{
        //    if (txtGameTitle.Text != "")
        //    {
        //        Monitor.setHeadline(txtGameTitle.Text);
        //    }
        //    if (txtTeam1.Text != "" & txtTeam2.Text != "")
        //    {
        //        //Monitor.SetTeams(txtTeam1.Text, txtTeam2.Text);
        //    }
        //    if (CurrentGameStatus == 2)
        //    {
        //        if (txtTeam1.Text != "" & txtTeam2.Text != "")
        //        {
        //            btnNext.Enabled = true;
        //        }
        //        else
        //        {
        //            lblTeamAlert.Text = "Es sind keine Teams angegeben!";
        //        }
        //    }
        //}

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
                //btnOvertake.Enabled = false;
                lblTeamAlert.Text = "Zwei gleiche Teamnamen sind nicht gestattet.";
            }
            else
            {
                //btnOvertake.Enabled = true;
            }
        }

        private void btnAddPointsClick(object sender, EventArgs e)
        {
            //if (drpTeam.SelectedIndex > -1 & drpTeam.SelectedIndex < 4)
            //{
            //    if (drpTeam.Items[drpTeam.SelectedIndex].ToString() == "Team 1")
            //    {
            //        Monitor.newPoints(2, int.Parse(tbPointsProceed.Text));
            //        lblPointsWarning.Text = "";
            //    }
            //    else if (drpTeam.Items[drpTeam.SelectedIndex].ToString() == "Team 2")
            //    {
            //        Monitor.newPoints(3, int.Parse(tbPointsProceed.Text));
            //        lblPointsWarning.Text = "";
            //    }
            //    else if (drpTeam.Items[drpTeam.SelectedIndex].ToString() == "Rundenpunkte")
            //    {
            //        lblPointsWarning.Text = "";
            //        Monitor.newPoints(1, int.Parse(tbPointsProceed.Text));
            //    }
            //    else
            //    {
            //        lblPointsWarning.Text = "Bitte existierendes Team auswählen.";
            //    }
            //}
            //else
            //{
            //    lblPointsWarning.Text = "Bitte existierendes Team auswählen.";
            //}
        }

        private void btnDelPointsClick(object sender, EventArgs e)
        {
            //if (drpTeam.SelectedIndex > -1 & drpTeam.SelectedIndex < 4)
            //{
            //    if (drpTeam.Items[drpTeam.SelectedIndex].ToString() == "Team 1")
            //    {
            //        Monitor.remPoints(2, int.Parse(tbPointsProceed.Text));
            //        lblPointsWarning.Text = "";
            //    }
            //    else if (drpTeam.Items[drpTeam.SelectedIndex].ToString() == "Team 2")
            //    {
            //        Monitor.remPoints(3, int.Parse(tbPointsProceed.Text));
            //        lblPointsWarning.Text = "";
            //    }
            //    else if (drpTeam.Items[drpTeam.SelectedIndex].ToString() == "Rundenpunkte")
            //    {
            //        lblPointsWarning.Text = "";
            //        Monitor.remPoints(1, int.Parse(tbPointsProceed.Text));
            //    }
            //    else
            //    {
            //        lblPointsWarning.Text = "Bitte existierendes Team auswählen.";
            //    }
            //}
            //else
            //{
            //    lblPointsWarning.Text = "Bitte existierendes Team auswählen.";
            //}
        }

        private void btnShowQuestionClick(object sender, EventArgs e)
        {
            Monitor.setQuestion(lblQuestion.Text.ToString());
        }

        private void btnMaximizeClick(object sender, EventArgs e)
        {
            if(!maximus)
            {
                Monitor.maximize();
                maximus = true;
                btnMaximize.Text = "Minimieren";
            }
            else
            {
                Monitor.minimize();
                maximus = false;
                btnMaximize.Text = "Maximieren";
            }   
        }
    }
}
