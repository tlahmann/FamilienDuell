using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.IO;


namespace FamilienDuell {
    public partial class GameMonitor : Form {
        int wrongs = 0;

        int answerTo;
        string quantity;

        int targetVal;
        int targetTeam;
        int targetTeamDel;
        int targetValDel;
        int fontNumber = 0;

        private static PrivateFontCollection myFonts;

        public GameMonitor() {
            InitializeComponent();

            if (myFonts == null) {
                myFonts = new PrivateFontCollection();
            }

            try {
                string path = Application.StartupPath;
                myFonts.AddFontFile(path + @"\\resources\\PressStart2P.ttf");
                myFonts.AddFontFile(path + @"\\resources\\SECRCODE.ttf");
                myFonts.AddFontFile(path + @"\\resources\\PLANE___.ttf");
                myFonts.AddFontFile(path + @"\\resources\\Prototype.ttf");
                myFonts.AddFontFile(path + @"\\resources\\GOODTIME.ttf");
            }
            catch (Exception e) {
                MessageBox.Show("Error loading font: " + e.Message);
                return;
            }

            lblWrong1.Visible = false;
            lblWrong2.Visible = false;
            lblWrong3.Visible = false;

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.monitorClosing);
            this.ResizeEnd += new EventHandler(this.formResize);
            this.Size = new System.Drawing.Size(800, 700);
            newSize(800, 700);
        }

        #region Responsive Action

            public void formResize(object sender, EventArgs e) {
                newSize(Form.ActiveForm.Bounds.Width, Form.ActiveForm.Bounds.Height);
            }

            public void newSize(int breite, int hoehe) {
                lblPlayerBlue.Visible = true;
                lblPlayerRed.Visible = true;
                lblPlayerBlue.Text = hoehe.ToString();
                lblPlayerRed.Text = breite.ToString();

                try {
                    FontFamily fam = myFonts.Families[fontNumber]; // arrayindex ändern um andere Font anzusehen
                    if (hoehe <= 300) {
                        using (Font f15 = new Font(fam, 15)) {
                            lblQuestion.Font = f15;
                        }
                    }
                    else if (hoehe <= 500) {
                        using (Font f15 = new Font(fam, 20))
                        using (Font f18 = new Font(fam, 22)) {
                            setSize(f15, f18);
                        }
                    }
                    else if (hoehe <= 700) {
                        using (Font f18 = new Font(fam, 22))
                        using (Font f22 = new Font(fam, 20)) {
                            setSize(f18, f22);
                        }
                    }
                    else if (hoehe <= 1000) {
                        using (Font f22 = new Font(fam, 20))
                        using (Font f30 = new Font(fam, 38)) {
                            setSize(f22, f30);
                        }
                    }
                    else if (hoehe <= 1500) {
                        using (Font f30 = new Font(fam, 40))
                        using (Font f40 = new Font(fam, 45)) {
                            setSize(f30, f40);
                        }
                    }
                }
                catch (Exception) {
                }

            }

            public void setSize(Font smallF, Font bigF) {
                lblQuestion.Font = bigF;

                //lblWrong1.Font = bigF;
                //lblWrong2.Font = bigF;
                //lblWrong3.Font = bigF;

                lblTeam1.Font = smallF;
                lblPointsTeam1.Font = smallF;
                lblRoundPoints.Font = smallF;
                lblTeam2.Font = smallF;
                lblPointsTeam2.Font = smallF;
                lblAnswerNo1.Font = smallF;
                lblAnswer1.Font = smallF;
                lblAnswerPts1.Font = smallF;
                lblAnswerNo2.Font = smallF;
                lblAnswer2.Font = smallF;
                lblAnswerPts2.Font = smallF;
                lblAnswerNo3.Font = smallF;
                lblAnswer3.Font = smallF;
                lblAnswerPts3.Font = smallF;
                lblAnswerNo4.Font = smallF;
                lblAnswer4.Font = smallF;
                lblAnswerPts4.Font = smallF;
                lblAnswerNo5.Font = smallF;
                lblAnswer5.Font = smallF;
                lblAnswerPts5.Font = smallF;
                lblAnswerNo6.Font = smallF;
                lblAnswer6.Font = smallF;
                lblAnswerPts6.Font = smallF;
            }

            private void monitorClosing(object sender, CancelEventArgs e) {
                //MessageBox.Show("Dieses Fenster kann nicht geschlossen werden", "Nicht möglich", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // TODO Auskommentiert weil es geschört hat...
                e.Cancel = true;
            }

            public void setHeadline(string text) {
                lblQuestion.Text = text;
            }

            public void maximize() {
                WindowState = FormWindowState.Maximized;
                newSize(Form.ActiveForm.Bounds.Width, Form.ActiveForm.Bounds.Height);
                FormBorderStyle = FormBorderStyle.None;
            }

            public void minimize() {
                WindowState = FormWindowState.Normal;
                newSize(Form.ActiveForm.Bounds.Width, Form.ActiveForm.Bounds.Height);
                FormBorderStyle = FormBorderStyle.Sizable;
            }

            public void setBgColor(int i) {
                if (i == 0) {
                    this.BackColor = Color.Black;
                }
                else if (i == 1) {
                    this.BackColor = Color.White;
                }
                else if (i == 2) {
                    this.BackColor = Color.DimGray;
                }
                else if (i == 3) {
                    this.BackColor = Color.MidnightBlue;
                }
                else if (i == 4) {
                    this.BackColor = Color.Maroon;
                }

                setTextColor();
            }

            public void setFont(int i) {
                fontNumber = i;
                formResize(null, null);
            }

            public void setTextBg(int i) {
                if (i == 0) {
                    lblQuestion.Image = null;
                    lblAnswer1.Image = null;
                    lblAnswerNo1.Image = null;
                    lblAnswerPts1.Image = null;
                    lblAnswer2.Image = null;
                    lblAnswerNo2.Image = null;
                    lblAnswerPts2.Image = null;
                    lblAnswer3.Image = null;
                    lblAnswerNo3.Image = null;
                    lblAnswerPts3.Image = null;
                    lblAnswer4.Image = null;
                    lblAnswerNo4.Image = null;
                    lblAnswerPts4.Image = null;
                    lblAnswer5.Image = null;
                    lblAnswerNo5.Image = null;
                    lblAnswerPts5.Image = null;
                    lblAnswer6.Image = null;
                    lblAnswerNo6.Image = null;
                    lblAnswerPts6.Image = null;
                    lblTeam1.Image = null;
                    lblPointsTeam1.Image = null;
                    lblTeam2.Image = null;
                    lblPointsTeam2.Image = null;
                    lblRoundPoints.Image = null;
                }
                else if (i == 1) {
                    lblQuestion.Image = Properties.Resources.bgTextfieldXLarge;
                    lblAnswer1.Image = Properties.Resources.bgTextfieldXLarge;
                    lblAnswerNo1.Image = Properties.Resources.bgTextfieldSmall;
                    lblAnswerPts1.Image = Properties.Resources.bgTextfieldSmall;
                    lblAnswer2.Image = Properties.Resources.bgTextfieldXLarge;
                    lblAnswerNo2.Image = Properties.Resources.bgTextfieldSmall;
                    lblAnswerPts2.Image = Properties.Resources.bgTextfieldSmall;
                    lblAnswer3.Image = Properties.Resources.bgTextfieldXLarge;
                    lblAnswerNo3.Image = Properties.Resources.bgTextfieldSmall;
                    lblAnswerPts3.Image = Properties.Resources.bgTextfieldSmall;
                    lblAnswer4.Image = Properties.Resources.bgTextfieldXLarge;
                    lblAnswerNo4.Image = Properties.Resources.bgTextfieldSmall;
                    lblAnswerPts4.Image = Properties.Resources.bgTextfieldSmall;
                    lblAnswer5.Image = Properties.Resources.bgTextfieldXLarge;
                    lblAnswerNo5.Image = Properties.Resources.bgTextfieldSmall;
                    lblAnswerPts5.Image = Properties.Resources.bgTextfieldSmall;
                    lblAnswer6.Image = Properties.Resources.bgTextfieldXLarge;
                    lblAnswerNo6.Image = Properties.Resources.bgTextfieldSmall;
                    lblAnswerPts6.Image = Properties.Resources.bgTextfieldSmall;
                    lblTeam1.Image = Properties.Resources.bgTextfieldGreen;
                    lblPointsTeam1.Image = Properties.Resources.bgTextfieldSmall;
                    lblTeam2.Image = Properties.Resources.bgTextfieldGreen;
                    lblPointsTeam2.Image = Properties.Resources.bgTextfieldSmall;
                    lblRoundPoints.Image = Properties.Resources.bgTextfieldSmall;
                }

                setTextColor();
            }

            private void setTextColor() {
                Color cl = Color.Black;
                if (lblQuestion.Image == null && this.BackColor == Color.Black) {
                    cl = Color.White;
                }
                else if (lblQuestion.Image == null && this.BackColor != Color.Black) {
                    cl = Color.Black;
                }

                lblQuestion.ForeColor = cl;
                lblAnswer1.ForeColor = cl;
                lblAnswerNo1.ForeColor = cl;
                lblAnswerPts1.ForeColor = cl;
                lblAnswer2.ForeColor = cl;
                lblAnswerNo2.ForeColor = cl;
                lblAnswerPts2.ForeColor = cl;
                lblAnswer3.ForeColor = cl;
                lblAnswerNo3.ForeColor = cl;
                lblAnswerPts3.ForeColor = cl;
                lblAnswer4.ForeColor = cl;
                lblAnswerNo4.ForeColor = cl;
                lblAnswerPts4.ForeColor = cl;
                lblAnswer5.ForeColor = cl;
                lblAnswerNo5.ForeColor = cl;
                lblAnswerPts5.ForeColor = cl;
                lblAnswer6.ForeColor = cl;
                lblAnswerNo6.ForeColor = cl;
                lblAnswerPts6.ForeColor = cl;
                lblTeam1.ForeColor = cl;
                lblPointsTeam1.ForeColor = cl;
                lblTeam2.ForeColor = cl;
                lblPointsTeam2.ForeColor = cl;
                lblRoundPoints.ForeColor = cl;
            }

            public void setBackground(Bitmap bmp) {
                this.BackgroundImage = bmp;
            }

        #endregion

        public void setTeams(string team1, string team2) {
            if (team1 == null) {
                lblTeam2.Text = team2;
            }
            else if (team2 == null) {
                lblTeam1.Text = team1;
            }
            else {
                lblTeam1.Text = team1;
                lblTeam2.Text = team2;
            }
        }

        public void setQuestion(string msg) {
            lblQuestion.Visible = true;
            lblQuestion.Text = msg;
        }

        public void gameStart() {
            this.resetMonitor();
            lblQuestion.Text = "Runde #1";
        }

        public void resetMonitor() {
            lblPointsTeam1.Visible = true;
            lblPointsTeam2.Visible = true;
            lblRoundPoints.Visible = true;
            lblAnswer1.Visible = true;
            lblAnswer2.Visible = true;
            lblAnswer3.Visible = true;
            lblAnswer4.Visible = true;
            lblAnswer5.Visible = true;
            lblAnswer6.Visible = true;
            lblAnswerPts1.Visible = true;
            lblAnswerPts2.Visible = true;
            lblAnswerPts3.Visible = true;
            lblAnswerPts4.Visible = true;
            lblAnswerPts5.Visible = true;
            lblAnswerPts6.Visible = true;
            lblAnswer1.Text = "............";
            lblAnswer2.Text = "............";
            lblAnswer3.Text = "............";
            lblAnswer4.Text = "............";
            lblAnswer5.Text = "............";
            lblAnswer6.Text = "............";
            lblAnswerPts1.Text = "..";
            lblAnswerPts2.Text = "..";
            lblAnswerPts3.Text = "..";
            lblAnswerPts4.Text = "..";
            lblAnswerPts5.Text = "..";
            lblAnswerPts6.Text = "..";
        }

        public void nextRound(int roundNumber) {

            this.resetMonitor();

            lblQuestion.Text = "Runde #" + Convert.ToString(roundNumber);
            if (roundNumber > 1) {
                lblAnswer6.Visible = false;
                lblAnswerPts6.Visible = false;
                lblAnswerNo6.Visible = false;
            }
            if (roundNumber > 2) {
                lblAnswer5.Visible = false;
                lblAnswerPts5.Visible = false;
                lblAnswerNo5.Visible = false;
            }
            if (roundNumber > 3) {
                lblAnswer4.Visible = false;
                lblAnswerPts4.Visible = false;
                lblAnswerNo4.Visible = false;
            }

        }

        public bool makeWrong(bool isInTeamRound) {

            MessageBox.Show(wrongs.ToString());

            if (isInTeamRound) {
                if (wrongs == 0) {
                    lblWrong1.Visible = true;
                    wrongs++;
                }
                else if (wrongs == 1) {
                    lblWrong2.Visible = true;
                    wrongs++;
                }
                else if (wrongs == 2) {
                    lblWrong3.Visible = true;
                    timerWrong.Enabled = true;
                    return false;
                }

            }
            else {
                lblWrong1.Visible = true;
                timerWrong.Enabled = true;
                return false;
            }

            return true;

        }

        private void toggleWrong(object sender, EventArgs e) {
            timerWrong.Enabled = false;
            lblWrong1.Visible = false;
            lblWrong2.Visible = false;
            lblWrong3.Visible = false;
            wrongs = 0;
        }

        #region Point Management
        public bool newPoints(int team, int points) {
            if (team == 1) {
                targetVal = Convert.ToInt32(lblRoundPoints.Text) + points;
            }
            else if (team == 2) {
                targetVal = int.Parse(lblPointsTeam1.Text) + points;
            }
            else if (team == 3) {
                targetVal = int.Parse(lblPointsTeam2.Text) + points;
            }

            targetTeam = team;
            timerAddPoints.Enabled = true;
            return true;
        }

        public bool remPoints(int team, int points) {
            if (team == 1) {
                targetValDel = Convert.ToInt32(lblRoundPoints.Text) - points;
            }
            else if (team == 2) {
                targetValDel = int.Parse(lblPointsTeam1.Text) - points;
            }
            else if (team == 3) {
                targetValDel = int.Parse(lblPointsTeam2.Text) - points;
            }
            targetTeamDel = team;
            timerDelPoints.Enabled = true;
            return true;
        }

        public bool setPoints(int team, int points) {
            int currentPoints = 0;
            if (team == 1) {
                currentPoints = int.Parse(lblRoundPoints.Text);
            }
            else if (team == 2) {
                currentPoints = int.Parse(lblRoundPoints.Text);
            }
            else if (team == 3) {
                currentPoints = int.Parse(lblRoundPoints.Text);
            }
            if (points < currentPoints) {
                targetTeamDel = team;
                targetValDel = points;
                timerDelPoints.Enabled = true;
            }
            else if (points > currentPoints) {
                targetTeam = team;
                targetVal = points;
                timerAddPoints.Enabled = true;
            }
            return true;

        }

        private void addPoints(object sender, EventArgs e) {

            if (targetTeam == 1) {
                if (Convert.ToInt16(lblRoundPoints.Text) < targetVal) {
                    lblRoundPoints.Text = Convert.ToString(Convert.ToInt16(lblRoundPoints.Text) + 1);
                }
                else {
                    timerAddPoints.Enabled = false;
                }
            }
            else if (targetTeam == 2) {
                if (Convert.ToInt32(lblPointsTeam1.Text) < targetVal) {
                    lblPointsTeam1.Text = Convert.ToString(Convert.ToInt32(lblPointsTeam1.Text) + 1);
                }
                else {
                    timerAddPoints.Enabled = false;
                }
            }
            else if (targetTeam == 3) {
                if (Convert.ToInt32(lblPointsTeam2.Text) < targetVal) {
                    lblPointsTeam2.Text = Convert.ToString(Convert.ToInt32(lblPointsTeam2.Text) + 1);
                }
                else {
                    timerAddPoints.Enabled = false;
                }
            }
        }

        private void delPoints(object sender, EventArgs e) {
            if (targetTeamDel == 1) {
                if (Convert.ToInt32(lblRoundPoints.Text) > targetValDel) {
                    lblRoundPoints.Text = Convert.ToString(Convert.ToInt32(lblRoundPoints.Text) - 1);
                }
                else {
                    timerDelPoints.Enabled = false;
                }
            }
            else if (targetTeamDel == 2) {
                if (Convert.ToInt32(lblPointsTeam1.Text) > targetValDel) {
                    lblPointsTeam1.Text = Convert.ToString(Convert.ToInt32(lblPointsTeam1.Text) - 1);
                }
                else {
                    timerDelPoints.Enabled = false;
                }
            }
            else if (targetTeamDel == 3) {
                if (Convert.ToInt32(lblPointsTeam2.Text) > targetValDel) {
                    lblPointsTeam2.Text = Convert.ToString(Convert.ToInt32(lblPointsTeam2.Text) - 1);
                }
                else {
                    timerDelPoints.Enabled = false;
                }
            }
        }
        #endregion

        #region Resolve Things
        public void showResult(int answer, string text, string people, int pointsMultiplier) {
            if (text.Length > 30) {
                text = text.Substring(0, 30) + "...";
            }

            if (answer == 1) {
                lblAnswer1.Text = text;
                lblAnswerPts1.Visible = true;
                lblAnswerPts1.Text = people;
            }
            else if (answer == 2) {
                lblAnswer2.Text = text;
                lblAnswerPts2.Visible = true;
                lblAnswerPts2.Text = people;
            }
            else if (answer == 3) {
                lblAnswer3.Text = text;
                lblAnswerPts3.Visible = true;
                lblAnswerPts3.Text = people;
            }
            else if (answer == 4) {
                lblAnswer4.Text = text;
                lblAnswerPts4.Visible = true;
                lblAnswerPts4.Text = people;
            }
            else if (answer == 5) {
                lblAnswer5.Text = text;
                lblAnswerPts5.Visible = true;
                lblAnswerPts5.Text = people;
            }
            else if (answer == 6) {
                lblAnswer6.Text = text;
                lblAnswerPts6.Visible = true;
                lblAnswerPts6.Text = people;
            }

            if (answer > 0 & answer < 7) {
                answerTo = answer;
                quantity = (int.Parse(people) * pointsMultiplier).ToString();
                timerRight.Enabled = true;
            }
        }

        private void showQuantity(object sender, EventArgs e) {
            if (answerTo == 1) {
                lblAnswerPts1.Text = quantity;
            }
            if (answerTo == 2) {
                lblAnswerPts2.Text = quantity;
            }
            if (answerTo == 3) {
                lblAnswerPts3.Text = quantity;
            }
            if (answerTo == 4) {
                lblAnswerPts4.Text = quantity;
            }
            if (answerTo == 5) {
                lblAnswerPts5.Text = quantity;
            }
            if (answerTo == 6) {
                lblAnswerPts6.Text = quantity;
            }
            timerRight.Enabled = false;
            newPoints(1, int.Parse(quantity));
        }

        public void writeResult(String[] text) {
            Debug.WriteLine(text.Length);
            for (int i = 0; i < text.Length; i++) {
                Debug.WriteLine("Wurst!");
                lblAnswer1.Text += text[i];
                System.Threading.Thread.Sleep(200);
            }
        }

        private void resultWriter_Tick(object sender, EventArgs e) {
            //writeResult();
        }
        #endregion
    }
}
