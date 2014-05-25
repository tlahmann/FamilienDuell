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

namespace FamilienDuell {

    public partial class Main : Form {

        int currentGameStatus = 0;
        int currentSetupStatus = 0;

        // determines if the monitor form is maximized
        Boolean maximus;

        // initialize monitor
        GameMonitor Monitor = new GameMonitor();

        // clientid for server to identify client and match question history
        string clientId;


        public Main() {
            InitializeComponent();

            this.clientId = "asd"; // TODO: switch back to Main.randString(16); (web-backend doesn't understand dynamic IDs yet)

            txtGameTitle.TextChanged += new EventHandler(this.textGameTitleChanged);
            txtTeam1.TextChanged += new EventHandler(this.textTeamsChanged);
            txtTeam2.TextChanged += new EventHandler(this.textTeamsChanged);
            this.dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewRowPostPaint);
            this.tabMainControl.SelectedIndexChanged += new EventHandler(this.checkTab);
            //tabMainControl.TabIndexChanged += new EventHandler(this.tabStateChanged);
        }

        private void Main_Load(object sender, EventArgs e) {
            Monitor.Show();

            textGameTitleChanged(null, null);

            //playSound(1);

            //tabMainControl.Enabled = false;
        }

        #region Setup
        // determine if GameTitle has been entered
        public void textGameTitleChanged(object sender, EventArgs e) {
            if (txtGameTitle.Text != "") {
                Monitor.lblQuestion.Text = txtGameTitle.Text.ToString();
                textTeamsChanged(null, null);
                txtTeam1.Enabled = true;
                txtTeam2.Enabled = true;
                tableLayoutPanel3.BackColor = SystemColors.ActiveCaption;
            } else {
                txtTeam1.Enabled = false;
                txtTeam2.Enabled = false;
                tableLayoutPanel3.BackColor = SystemColors.InactiveCaption;
                numericUpDown1.Enabled = false;
                cbSounds.Enabled = false;
                tableLayoutPanel4.BackColor = SystemColors.InactiveCaption;
            }
        }

        // determine if Teamnames have been entered
        public void textTeamsChanged(object sender, EventArgs e) {
            if (txtTeam1.Text != "") {
                Monitor.lblTeam1.Text = txtTeam1.Text.ToString();
            }

            if (txtTeam1.Text != "") {
                Monitor.lblTeam2.Text = txtTeam2.Text.ToString();
            }

            if (txtTeam1.Text != "" && txtTeam2.Text != "") {
                checkTeamNames(txtTeam1.Text, txtTeam2.Text);
                numericUpDown1.Enabled = true;
                cbSounds.Enabled = true;
                tableLayoutPanel4.BackColor = SystemColors.ActiveCaption;
            } else {
                Monitor.lblTeam2.Text = txtTeam2.Text.ToString();
                numericUpDown1.Enabled = false;
                cbSounds.Enabled = false;
                tableLayoutPanel4.BackColor = SystemColors.InactiveCaption;
            }
        }

        // check if Teamnames are to long
        private void checkTeamNames(string team1, string team2) {
            if (team1.Length > 16) {
                lblTeamCheck.Text = "Name für Team 1 möglicherweise zu lang!";
            } else if (team2.Length > 16) {
                lblTeamCheck.Text = "Name für Team 2 möglicherweise zu lang!";
            } else {
                lblTeamCheck.Text = "";
            }
            if (team1 == team2) {
                lblTeamCheck.Text = "Zwei gleiche Teamnamen sind nicht gestattet.";
            }
        }

        // check if Playernames are entered
        private bool gridCheck() {
            Boolean valid = true;

            for (int j = 0; j < dataGridView.Rows.Count; j++) {
                for (int i = 0; i < dataGridView.Columns.Count; i++) {
                    if (dataGridView.Rows[j].Cells[i].Value == null) {
                        dataGridView.Rows[j].Cells[i].Style.BackColor = SystemColors.InactiveCaption;

                        valid = false;
                    } else if (dataGridView.Rows[j].Cells[i].Value.ToString() == "") {
                        dataGridView.Rows[j].Cells[i].Style.BackColor = SystemColors.InactiveCaption;

                        valid = false;
                    } else {
                        dataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    }
                }
            }
            return valid;
        }

        // nextbutton
        public void btnNextClick(object sender, EventArgs e) {
            if (tabMainControl.SelectedIndex == 0) {
                if (cbPlayernames.Checked == true) {
                    try {
                        int nOP = Convert.ToInt32(numericUpDown1.Value);
                        if (dataGridView.RowCount != nOP) {
                            int add = nOP - dataGridView.RowCount;
                            for (int i = 0; i < add; i++) {
                                // TODO DefaultNamen raus! (?)
                                dataGridView.Rows.Add("Player Red " + (i + 1), "Player Blue " + (i + 1));
                            }
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message, "Fehler!");
                    }
                    tabMainControl.SelectedIndex = 1;
                    currentSetupStatus = 1;
                } else {
                    dataGridView.Enabled = false;
                    tabMainControl.SelectedIndex = 2;
                    currentSetupStatus = 2;
                }

            } else if (tabMainControl.SelectedIndex == 1) {
                if (gridCheck()) {
                    tabMainControl.SelectedIndex = 2;
                    currentSetupStatus = 2;
                }
            } else if (tabMainControl.SelectedIndex == 2) {
                currentSetupStatus = 3;
                tabMainControl.SelectedIndex = 3;
            } else if (tabMainControl.SelectedIndex == 3) {
                playGame();
            }
        }

        // check which tab is selected to change the text on the next-button
        public void checkTab(object sender, EventArgs e) {
            if (currentGameStatus == 0) {
                if (tabMainControl.SelectedIndex == 3 && currentSetupStatus == 3) {
                    btnNext.Text = "Start";
                } else {
                    btnNext.Text = "Weiter";
                }
            }
        }
        #endregion

        #region Gameplay
        // start functions
        public void playGame() {
            if (currentGameStatus == 0) {
                btnGetQuestion.Enabled = true;
                changePoints.Enabled = true;
                btnNext.Text = "Runde läuft...";
                btnNext.Enabled = false;
            }
            //if (currentGameStatus == 0) {
            //    lblClientId.Text = txtGameTitle.Text;
            //    btnNext.Text = "Start";
            //    currentGameStatus = 1;
            //} else if (currentGameStatus == 1) {
            //    Monitor.setHeadline("Davids Familien Duell v0.1 Alpha-RC");

            //    //Monitor.toggleWaiting();
            //    tabMainControl.Enabled = true;
            //    btnNext.Enabled = false;
            //    //btnNext.Text = "Runde starten!";
            //    currentGameStatus = 2;
            //} else if (currentGameStatus == 2) {
            //    if (txtTeam1.Text != "" & txtTeam2.Text != "") {
            //        lblTeamAlert.Text = "";
            //        //Monitor.toggleWaiting();
            //        btnNext.Text = "Nächste Runde";
            //        btnNext.Enabled = false;
            //        lblStatus.Text = "Aktives Spiel (Runde 1)";
            //        Monitor.gameStart();
            //        playSound(1);
            //        currentGameStatus = 3;
            //    } else {
            //        lblTeamAlert.Text = "Es sind keine Teams angegeben!";
            //    }
            //} else if (currentGameStatus == 3) {
            //    if (txtTeam1.Text != "" & txtTeam2.Text != "") {
            //        togglePointButtons();
            //        lblTeamAlert.Text = "";
            //        btnNext.Enabled = false;
            //        btnGetQuestion.Enabled = true;
            //        lblStatus.Text = "Aktives Spiel (Runde 2)";
            //        Monitor.nextRound(2);
            //        currentGameStatus = 4;
            //    } else {
            //        lblTeamAlert.Text = "Es sind keine Teams angegeben!";
            //    }
            //}
            //return true;
        }

        #region Buttons
        private void btnWrongClick(object sender, EventArgs e) {
            playSound(3);
            cbTeamRound.Checked = Monitor.makeWrong(cbTeamRound.Checked);
        }

        private void btnGetQuestionClick(object sender, EventArgs e) {
            getQuestion();
            btnAnswer1.Enabled = true;
            btnAnswer2.Enabled = true;
            btnAnswer3.Enabled = true;
            if (currentGameStatus < 6) {
                btnAnswer4.Enabled = true;
            }
            if (currentGameStatus < 5) {
                btnAnswer5.Enabled = true;
            }
            if (currentGameStatus == 3) {
                btnAnswer6.Enabled = true;
            }
            btnShowQuestion.Enabled = true;
            //btnTeam1.Enabled = true;
            //btnTeam2.Enabled = true;
            //btnRemi.Enabled = true;
            btnWrong.Enabled = true;
            cbTeamRound.Enabled = true;
        }

        private void btnShowQuestionClick(object sender, EventArgs e) {
            Monitor.setQuestion(lblQuestion.Text.ToString());
            btnShowQuestion.Enabled = false;
        }

        // answers
        private void btnAnswer1Click(object sender, EventArgs e) {
            playSound(2);
            btnAnswer1.Enabled = false;
            btnGetQuestion.Enabled = false;
            cbTeamRound.Checked = true;
            //togglePointButtons();
            Monitor.showResult(1, btnAnswer1.Text, lblQuantity1.Text);
            ctrlWritePoints(lblQuantity1.Text, lblCtrlRdPts.Text);
        }

        private void btnAnswer2Click(object sender, EventArgs e) {
            playSound(2);
            btnAnswer2.Enabled = false;
            btnGetQuestion.Enabled = false;
            //togglePointButtons();
            Monitor.showResult(2, btnAnswer2.Text, lblQuantity2.Text);
            ctrlWritePoints(lblQuantity2.Text, lblCtrlRdPts.Text);
        }

        private void btnAnswer3Click(object sender, EventArgs e) {
            playSound(2);
            btnGetQuestion.Enabled = false;
            btnAnswer3.Enabled = false;
            //togglePointButtons();
            Monitor.showResult(3, btnAnswer3.Text, lblQuantity3.Text);
            ctrlWritePoints(lblQuantity3.Text, lblCtrlRdPts.Text);
        }

        private void btnAnswer4Click(object sender, EventArgs e) {
            playSound(2);
            btnAnswer4.Enabled = false;
            //togglePointButtons();
            btnGetQuestion.Enabled = false;
            Monitor.showResult(4, btnAnswer4.Text, lblQuantity4.Text);
            ctrlWritePoints(lblQuantity4.Text, lblCtrlRdPts.Text);
        }

        private void btnAnswer5Click(object sender, EventArgs e) {
            playSound(2);
            btnAnswer5.Enabled = false;
            //togglePointButtons();
            btnGetQuestion.Enabled = false;
            Monitor.showResult(5, btnAnswer5.Text, lblQuantity5.Text);
            ctrlWritePoints(lblQuantity5.Text, lblCtrlRdPts.Text);
        }

        private void btnAnswer6Click(object sender, EventArgs e) {
            playSound(2);
            btnAnswer6.Enabled = false;
            //togglePointButtons();
            btnGetQuestion.Enabled = false;
            Monitor.showResult(6, btnAnswer6.Text, lblQuantity6.Text);
            ctrlWritePoints(lblQuantity6.Text, lblCtrlRdPts.Text);
        }

        private void btnTeam1Click(object sender, EventArgs e) {
            Monitor.winnerPoints(2);
            lblCtrlTm2Pts.Text += lblCtrlRdPts.Text;
            btnNext.Enabled = true;
        }

        private void btnTeam2Click(object sender, EventArgs e) {
            Monitor.winnerPoints(3);
            lblCtrlTm2Pts.Text += lblCtrlRdPts.Text;
            btnNext.Enabled = true;
        }

        private void btnRemiClick(object sender, EventArgs e) {
            btnNext.Enabled = true;
            Monitor.setPoints(1, 0);
        }

        private void btnMaximizeClick(object sender, EventArgs e) {
            if (!maximus) {
                Monitor.maximize();
                Monitor.newSize();
                maximus = true;
                btnMaximize.Text = "Minimieren";
            } else {
                Monitor.minimize();
                Monitor.newSize();
                maximus = false;
                btnMaximize.Text = "Maximieren";
            }
        }

        private void changePointsClick(object sender, EventArgs e) {

            using (ChangePoints ptChange = new ChangePoints()) {
                ptChange.injectGameMonitor(Monitor);
                ptChange.StartPosition = FormStartPosition.CenterParent;
                ptChange.ShowDialog(this);
            }
        }
        #endregion

        // sound emitter
        private void playSound(int Action) {
            if (cbSounds.Checked == true) {
                try {
                    string locationOffset = Directory.GetCurrentDirectory();
                    //System.Diagnostics.Process.Start(path + @"\sound\Bonefit_Hilfe.pdf");

                    //string locationOffset = "D:\\Dropbox\\Misc\\FamilienDuell\\FamilienDuell\\obj\\Debug\\";
                    if (Action == 1) {
                        // main theme
                        SoundPlayer simpleSound = new SoundPlayer(locationOffset + @"\sounds\ff94_main_theme.wav");
                        simpleSound.Play();
                    } else if (Action == 2) {
                        // correct answer sound
                        SoundPlayer simpleSound = new SoundPlayer(locationOffset + @"\sounds\ff-clang.wav");
                        simpleSound.Play();
                    } else if (Action == 3) {
                        // wrong answer sound
                        SoundPlayer simpleSound = new SoundPlayer(locationOffset + @"\sounds\ff-strike3.wav");
                        simpleSound.Play();
                    }
                } catch (Exception e) {
                    Debug.WriteLine("Could not play sound file: " + e.Message);
                }
            }
        }

        private bool getQuestion() {
            lblQuestion.Text = "Wartend..";
            Question question = new Question();

            try {
                XmlTextReader reader = new XmlTextReader("http://www.dbeuchert.com/Duell/" + clientId + ".xml");
                question.injectReaderObject(reader);

                if (!question.readQuestion()) {
                    MessageBox.Show("Unknown read error while reading question.");
                }
            } catch (Exception Exception) {
                MessageBox.Show("Error: " + Exception.Message + "\n" + Exception.StackTrace);
            }

            lblQuestion.Text = question.getQuestion();

            int iteration = 0;
            foreach (Answer answer in question.getAnswers()) {
                iteration++;
                ControlCollection controls = this.Controls as ControlCollection;
                Control button = this.Controls.Find("btnAnswer" + iteration.ToString(), true).Single();
                Control quantity = this.Controls.Find("lblQuantity" + iteration.ToString(), true).Single();

                if (button is Button) {
                    button.Text = answer.getTitle();
                }

                if (quantity is Label) {
                    quantity.Text = answer.getQuantityAsString();
                }
            }

            return true;
        }

        private void ctrlWritePoints(String val1, String val2) {
            int a = Convert.ToInt32(val1);
            int b = Convert.ToInt32(val2);
            int result = a + b;
            lblCtrlRdPts.Text = result.ToString();
        }

        //private void togglePointButtons() {
        //    if (btnRemi.Enabled == true) {
        //        btnTeam1.Enabled = false;
        //        btnTeam2.Enabled = false;
        //        btnRemi.Enabled = false;
        //    } else {
        //        if (btnAnswer1.Enabled == false & btnAnswer2.Enabled == false & btnAnswer3.Enabled == false & btnAnswer4.Enabled == false & btnAnswer5.Enabled == false & btnAnswer6.Enabled == false) {
        //            btnTeam1.Enabled = true;
        //            btnTeam2.Enabled = true;
        //            btnRemi.Enabled = true;
        //        }
        //    }
        //}
        #endregion

        #region Design

        // displays row numbers for dgv
        private void dataGridViewRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e) {
            using (SolidBrush b = new SolidBrush(dataGridView.RowHeadersDefaultCellStyle.ForeColor)) {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 17, e.RowBounds.Location.Y + 4);
            }
        }

        #endregion

        static string randString(Int32 len) {
            string text = "";
            System.Random random = new System.Random();
            for (Int32 i = 0; i < len; i++) {
                Int32 Number = Convert.ToInt32(Math.Floor(58 * random.NextDouble() + 65));
                char x = Convert.ToChar(Number);
                if (x > 90 && x < 97) {
                    i--;
                    continue;
                } else {
                    text += x;
                }
            }
            return text;
        }

    }

}
