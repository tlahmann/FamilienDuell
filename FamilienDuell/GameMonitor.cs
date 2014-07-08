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

            lblPlayerRed.Visible = false;
            lblPlayerBlue.Visible = false;

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
                //lblPlayerBlue.Visible = true;
                //lblPlayerRed.Visible = true;
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
                lblQuestion.Padding = new Padding((((Form.ActiveForm.Bounds.Width) - 1200) / 2), 0, (((Form.ActiveForm.Bounds.Width) - 1200) / 2), 0);
            }

            public void minimize() {
                WindowState = FormWindowState.Normal;
                newSize(Form.ActiveForm.Bounds.Width, Form.ActiveForm.Bounds.Height);
                FormBorderStyle = FormBorderStyle.Sizable;
                lblQuestion.Padding = new Padding((((Form.ActiveForm.Bounds.Width) - 1200) / 2), 0, (((Form.ActiveForm.Bounds.Width) - 1200) / 2), 0);
            }

            public void setFont(int i) {
                fontNumber = i;
                formResize(null, null);
            }

            public void setBgColorPD(int i) {
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

                setTextColorRGB(-1, -1, -1);
            }

            public void setBgColorRGB(int r, int g, int b) {
                this.BackColor = Color.FromArgb(r, g, b);
            }

            public void setBackground(Bitmap bmp) {
                this.BackgroundImage = bmp;
            }

            public void setTextBgQuestion(int i) {
                Bitmap bmpQuestion = null;

                try {
                    string path = Application.StartupPath;

                    if (i == 0) {
                        // do nothing
                    }
                    else if (i == 1) {
                        bmpQuestion = (Bitmap)Image.FromFile(path + @"\\resources\\background\\bgTextfieldXXLargeRed.gif");
                    }
                    else if (i == 2) {
                        bmpQuestion = (Bitmap)Image.FromFile(path + @"\\resources\\background\\bgTextfieldXXLargeBlue.gif");
                    }
                    else if (i == 3) {
                        bmpQuestion = (Bitmap)Image.FromFile(path + @"\\resources\\background\\bgTextfieldXXLargeGreen.gif");
                    }
                }
                catch (Exception e) {
                    MessageBox.Show("Error loading Bitmap: " + e.Message);
                    return;
                }

                lblQuestion.Image = bmpQuestion;

                setTextColorRGB(-1, -1, -1);
            }

            public void setTextBgAnswer(int i) {
                Bitmap bmpLarge = null;
                Bitmap bmpSmall = null;

                try {
                    string path = Application.StartupPath;

                    if (i == 0) {
                        // do nothing
                    }
                    else if (i == 1) {
                        bmpLarge = (Bitmap)Image.FromFile(path + @"\\resources\\background\\bgTextfieldXLargeRed.gif");
                        bmpSmall = (Bitmap)Image.FromFile(path + @"\\resources\\background\\bgTextfieldSmallRed.gif");
                    }
                    else if (i == 2) {
                        bmpLarge = (Bitmap)Image.FromFile(path + @"\\resources\\background\\bgTextfieldXLargeBlue.gif");
                        bmpSmall = (Bitmap)Image.FromFile(path + @"\\resources\\background\\bgTextfieldSmallBlue.gif");
                    }
                    else if (i == 3) {
                        bmpLarge = (Bitmap)Image.FromFile(path + @"\\resources\\background\\bgTextfieldXLargeGreen.gif");
                        bmpSmall = (Bitmap)Image.FromFile(path + @"\\resources\\background\\bgTextfieldSmallGreen.gif");
                    }
                }
                catch (Exception e) {
                    MessageBox.Show("Error loading Bitmap: " + e.Message);
                    return;
                }

                lblAnswer1.Image = bmpLarge;
                lblAnswerNo1.Image = bmpSmall;
                lblAnswerPts1.Image = bmpSmall;
                lblAnswer2.Image = bmpLarge;
                lblAnswerNo2.Image = bmpSmall;
                lblAnswerPts2.Image = bmpSmall;
                lblAnswer3.Image = bmpLarge;
                lblAnswerNo3.Image = bmpSmall;
                lblAnswerPts3.Image = bmpSmall;
                lblAnswer4.Image = bmpLarge;
                lblAnswerNo4.Image = bmpSmall;
                lblAnswerPts4.Image = bmpSmall;
                lblAnswer5.Image = bmpLarge;
                lblAnswerNo5.Image = bmpSmall;
                lblAnswerPts5.Image = bmpSmall;
                lblAnswer6.Image = bmpLarge;
                lblAnswerNo6.Image = bmpSmall;
                lblAnswerPts6.Image = bmpSmall;

                setTextColorRGB(-1, -1, -1);
            }

            public void setTextBgTeams(int i) {
                Bitmap bmpTeam = null;

                try {
                    string path = Application.StartupPath;

                    if (i == 0) {
                        // do nothing
                    }
                    else if (i == 1) {
                        bmpTeam = (Bitmap)Image.FromFile(path + @"\\resources\\background\\bgTextfieldRegularRed.gif");
                    }
                    else if (i == 2) {
                        bmpTeam = (Bitmap)Image.FromFile(path + @"\\resources\\background\\bgTextfieldRegularBlue.gif");
                    }
                    else if (i == 3) {
                        bmpTeam = (Bitmap)Image.FromFile(path + @"\\resources\\background\\bgTextfieldRegularGreen.gif");
                    }
                }
                catch (Exception e) {
                    MessageBox.Show("Error loading Bitmap: " + e.Message);
                    return;
                }

                lblTeam1.Image = bmpTeam;
                lblTeam2.Image = bmpTeam;

                setTextColorRGB(-1, -1, -1);
            }

            public void setTextBgPoints(int i) {
                Bitmap bmpSmall = null;

                try {
                    string path = Application.StartupPath;

                    if (i == 0) {
                        // do nothing
                    }
                    else if (i == 1) {
                        bmpSmall = (Bitmap)Image.FromFile(path + @"\\resources\\background\\bgTextfieldSmallRed.gif");
                    }
                    else if (i == 2) {
                        bmpSmall = (Bitmap)Image.FromFile(path + @"\\resources\\background\\bgTextfieldSmallBlue.gif");
                    }
                    else if (i == 3) {
                        bmpSmall = (Bitmap)Image.FromFile(path + @"\\resources\\background\\bgTextfieldSmallGreen.gif");
                    }
                }
                catch (Exception e) {
                    MessageBox.Show("Error loading Bitmap: " + e.Message);
                    return;
                }

                lblPointsTeam1.Image = bmpSmall;
                lblPointsTeam2.Image = bmpSmall;
                lblRoundPoints.Image = bmpSmall;

                setTextColorRGB(-1, -1, -1);
            }

            public void setTextColorPD(int i) {
                Color clr = Color.Black;
                if (i == 0) {
                    clr = Color.Black;
                }
                else if (i == 1) {
                    clr = Color.White;
                }
                else if (i == 2) {
                    clr = Color.DimGray;
                }
                else if (i == 3) {
                    clr = Color.MidnightBlue;
                }
                else if (i == 4) {
                    clr = Color.Maroon;
                }

                lblQuestion.ForeColor = clr;
                lblAnswer1.ForeColor = clr;
                lblAnswerNo1.ForeColor = clr;
                lblAnswerPts1.ForeColor = clr;
                lblAnswer2.ForeColor = clr;
                lblAnswerNo2.ForeColor = clr;
                lblAnswerPts2.ForeColor = clr;
                lblAnswer3.ForeColor = clr;
                lblAnswerNo3.ForeColor = clr;
                lblAnswerPts3.ForeColor = clr;
                lblAnswer4.ForeColor = clr;
                lblAnswerNo4.ForeColor = clr;
                lblAnswerPts4.ForeColor = clr;
                lblAnswer5.ForeColor = clr;
                lblAnswerNo5.ForeColor = clr;
                lblAnswerPts5.ForeColor = clr;
                lblAnswer6.ForeColor = clr;
                lblAnswerNo6.ForeColor = clr;
                lblAnswerPts6.ForeColor = clr;
                lblTeam1.ForeColor = clr;
                lblPointsTeam1.ForeColor = clr;
                lblTeam2.ForeColor = clr;
                lblPointsTeam2.ForeColor = clr;
                lblRoundPoints.ForeColor = clr;
            }

            public void setTextColorRGB(int r, int g, int b) {
                Color cl = Color.Black;
                if (r == -1 && g == -1 && b == -1) {
                    if (lblQuestion.Image == null && this.BackColor == Color.Black) {
                        cl = Color.White;
                    }
                    else if (lblQuestion.Image == null && this.BackColor != Color.Black) {
                        cl = Color.Black;
                    }
                }
                else {
                    cl = Color.FromArgb(r, g, b);
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
            int i = 70;
            if (msg.Length > i) {
                FontFamily fam = myFonts.Families[fontNumber];
                lblQuestion.Font = new Font(fam, 30);
            }
            else if (msg.Length > i / 2) {
                FontFamily fam = myFonts.Families[fontNumber];
                lblQuestion.Font = new Font(fam, 36);
            }
            else {
                newSize(Form.ActiveForm.Bounds.Width, Form.ActiveForm.Bounds.Height);
            }
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

            if (isInTeamRound) {
                if (wrongs == 0) {
                    lblWrong2.Visible = true;
                    wrongs++;
                }
                else if (wrongs == 1) {
                    lblWrong1.Visible = true;
                    wrongs++;
                }
                else if (wrongs == 2) {
                    lblWrong3.Visible = true;
                    timerWrong.Enabled = true;
                    return false;
                }

            }
            else {
                lblWrong2.Visible = true;
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
