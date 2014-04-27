using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FamilienDuell
{
    public partial class GameMonitor : Form
    {
        int waiting = 0;
        int wrongs = 0;

        int answerTo;
        string quantity;

        int targetVal;
        int targetTeam;
        int targetTeamDel;
        int targetValDel;

        public GameMonitor()
        {
            InitializeComponent();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.monitorClosing);
            this.ResizeEnd += new EventHandler(this.formResize);
            imgWaiting.Visible = true;
        }

        public void formResize(object sender, EventArgs e)
        {
            newSize();
        }

        public void newSize()
        {
            int hoehe = Form.ActiveForm.Bounds.Height;
            int breite = Form.ActiveForm.Bounds.Width;

            lblPlayerBlue.Visible = true;
            lblPlayerRed.Visible = true;
            lblPlayerBlue.Text = hoehe.ToString();
            lblPlayerRed.Text = breite.ToString();

            Font f0 = new Font("ISOCPEUR", 10);
            Font f1 = new Font("ISOCPEUR", 10);
            Font f2 = new Font("ISOCPEUR", 20);
            Font f3 = new Font("ISOCPEUR", 30);
            Font f4 = new Font("ISOCPEUR", 40);
            Font f5 = new Font("ISOCPEUR", 50);

            if (hoehe <= 300)
            {
                lblHeadline.Font = f1;
            }
            else if (hoehe <= 500)
            {
                lblHeadline.Font = f2;

                question.Font = f2;
                lblWrong1.Font = f2;
                lblWrong2.Font = f2;
                lblWrong3.Font = f2;
                lblTeam1.Font = f2;
                lblPointsTeam1.Font = f2;
                lblRoundPoints.Font = f2;
                lblTeam2.Font = f2;
                lblPointsTeam2.Font = f2;

                lblAnswerNo1.Font = f1;
                lblAnswer1.Font = f1;
                lblAnswerPts1.Font = f1;
                lblAnswerNo2.Font = f1;
                lblAnswer2.Font = f1;
                lblAnswerPts2.Font = f1;
                lblAnswerNo3.Font = f1;
                lblAnswer3.Font = f1;
                lblAnswerPts3.Font = f1;
                lblAnswerNo4.Font = f1;
                lblAnswer4.Font = f1;
                lblAnswerPts4.Font = f1;
                lblAnswerNo5.Font = f1;
                lblAnswer5.Font = f1;
                lblAnswerPts5.Font = f1;
                lblAnswerNo6.Font = f1;
                lblAnswer6.Font = f1;
                lblAnswerPts6.Font = f1;
            }
            else if (hoehe <= 700)
            {
                lblHeadline.Font = f3;

                question.Font = f3;
                lblWrong1.Font = f3;
                lblWrong2.Font = f3;
                lblWrong3.Font = f3;
                lblTeam1.Font = f3;
                lblPointsTeam1.Font = f3;
                lblRoundPoints.Font = f3;
                lblTeam2.Font = f3;
                lblPointsTeam2.Font = f3;

                lblAnswerNo1.Font = f2;
                lblAnswer1.Font = f2;
                lblAnswerPts1.Font = f2;
                lblAnswerNo2.Font = f2;
                lblAnswer2.Font = f2;
                lblAnswerPts2.Font = f2;
                lblAnswerNo3.Font = f2;
                lblAnswer3.Font = f2;
                lblAnswerPts3.Font = f2;
                lblAnswerNo4.Font = f2;
                lblAnswer4.Font = f2;
                lblAnswerPts4.Font = f2;
                lblAnswerNo5.Font = f2;
                lblAnswer5.Font = f2;
                lblAnswerPts5.Font = f2;
                lblAnswerNo6.Font = f2;
                lblAnswer6.Font = f2;
                lblAnswerPts6.Font = f2;
            }
            else if (hoehe <= 1000)
            {
                lblHeadline.Font = f4;

                question.Font = f4;
                lblWrong1.Font = f4;
                lblWrong2.Font = f4;
                lblWrong3.Font = f4;
                lblTeam1.Font = f4;
                lblPointsTeam1.Font = f4;
                lblRoundPoints.Font = f4;
                lblTeam2.Font = f4;
                lblPointsTeam2.Font = f4;

                lblAnswerNo1.Font = f3;
                lblAnswer1.Font = f3;
                lblAnswerPts1.Font = f3;
                lblAnswerNo2.Font = f3;
                lblAnswer2.Font = f3;
                lblAnswerPts2.Font = f3;
                lblAnswerNo3.Font = f3;
                lblAnswer3.Font = f3;
                lblAnswerPts3.Font = f3;
                lblAnswerNo4.Font = f3;
                lblAnswer4.Font = f3;
                lblAnswerPts4.Font = f3;
                lblAnswerNo5.Font = f3;
                lblAnswer5.Font = f3;
                lblAnswerPts5.Font = f3;
                lblAnswerNo6.Font = f3;
                lblAnswer6.Font = f3;
                lblAnswerPts6.Font = f3;
            }
            else if (hoehe <= 1500)
            {
                lblHeadline.Font = f5;

                question.Font = f5;
                lblWrong1.Font = f5;
                lblWrong2.Font = f5;
                lblWrong3.Font = f5;
                lblTeam1.Font = f5;
                lblPointsTeam1.Font = f5;
                lblRoundPoints.Font = f5;
                lblTeam2.Font = f5;
                lblPointsTeam2.Font = f5;

                lblAnswerNo1.Font = f4;
                lblAnswer1.Font = f4;
                lblAnswerPts1.Font = f4;
                lblAnswerNo2.Font = f4;
                lblAnswer2.Font = f4;
                lblAnswerPts2.Font = f4;
                lblAnswerNo3.Font = f4;
                lblAnswer3.Font = f4;
                lblAnswerPts3.Font = f4;
                lblAnswerNo4.Font = f4;
                lblAnswer4.Font = f4;
                lblAnswerPts4.Font = f4;
                lblAnswerNo5.Font = f4;
                lblAnswer5.Font = f4;
                lblAnswerPts5.Font = f4;
                lblAnswerNo6.Font = f4;
                lblAnswer6.Font = f4;
                lblAnswerPts6.Font = f4;
            }
        }

        private void monitorClosing(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Dieses Fenster kann nicht geschlossen werden", "Nicht möglich", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = true;
        }

        public void setHeadline(string text)
        {
            lblHeadline.Text = text;
        }

        public void maximize()
        {
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
        }

        public void minimize()
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.Sizable;
        }

        public void toggleWaiting()
        {
            if (waiting == 0)
            {
                imgWaiting.Visible = true;
                waiting = 1;
            }
            else
            {
                imgWaiting.Visible = false;
                waiting = 0;
            }
        }

        public void setTeams(string Team1, string Team2)
        {
            lblTeam1.Text = Team1;
            lblTeam2.Text = Team2;
        }

        public void setQuestion(string msg)
        {
            question.Visible = true;
            question.Text = msg;
        }

        public void gameStart()
        {
            lblWrong2.Visible = false;
            //lblTeam1.Visible = true;
            //lblTeam2.Visible = true;
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
            lblAnswer1.Text = "................................................";
            lblAnswer2.Text = "................................................";
            lblAnswer3.Text = "................................................";
            lblAnswer4.Text = "................................................";
            lblAnswer5.Text = "................................................";
            lblAnswer6.Text = "................................................";
            lblAnswerPts1.Text = "..";
            lblAnswerPts2.Text = "..";
            lblAnswerPts3.Text = "..";
            lblAnswerPts4.Text = "..";
            lblAnswerPts5.Text = "..";
            lblAnswerPts6.Text = "..";
            lblWrong2.Text = "";
            question.Text = "Runde #1";
        }

        public void nextRound(int roundNumber) {
            lblWrong2.Visible = false;
            if (roundNumber > 1)
            {
                lblAnswer6.Visible = false;
                lblAnswerPts6.Visible = false;
            }
            if (roundNumber > 2)
            {
                lblAnswer5.Visible = false;
                lblAnswerPts5.Visible = false;
            }
            if (roundNumber > 3)
            {
                lblAnswer4.Visible = false;
                lblAnswerPts4.Visible = false;
            }
            question.Text = "Runde #" + Convert.ToString(roundNumber);
            lblAnswer1.Text = "................................................";
            lblAnswer2.Text = "................................................";
            lblAnswer3.Text = "................................................";
            lblAnswer4.Text = "................................................";
            lblAnswer5.Text = "................................................";
            lblAnswerPts1.Text = "..";
            lblAnswerPts2.Text = "..";
            lblAnswerPts3.Text = "..";
            lblAnswerPts4.Text = "..";
            lblAnswerPts5.Text = "..";
            lblWrong2.Text = "";
        }

        public bool makeWrong(bool isInTeamRound)
        {
            if (isInTeamRound)
            {
                if(wrongs == 0)
                {
                    lblWrong1.Visible = true;
                    wrongs++;
                }
                else if (wrongs == 1)
                {
                    lblWrong2.Visible = true;
                    wrongs++;
                }
                else if (wrongs == 2)
                {
                    lblWrong3.Visible = true;
                    timerWrong.Enabled = true;
                    return false;
                }
  
            } else {
                lblWrong2.Visible = true;
                timerWrong.Enabled = true;
                return false;
            }

            return true;

        }

        private void toggleWrong(object sender, EventArgs e)
        {
            timerWrong.Enabled = false;
            lblWrong1.Visible = false;
            lblWrong2.Visible = false;
            lblWrong3.Visible = false;
            wrongs = 0;
        }

        // point management
        public bool newPoints(int team,int points)
        {
            if (team == 1)
            {
                targetVal = Convert.ToInt32(lblRoundPoints.Text) + points;
                //MessageBox.Show("New targetVal: " + Convert.ToString(targetVal));
            }
            else if (team == 2)
            {
                targetVal = int.Parse(lblPointsTeam1.Text) + points;
            }
            else if (team == 3)
            {
                targetVal = int.Parse(lblPointsTeam2.Text) + points;
            }
            targetTeam = team;
            timerAddPoints.Enabled = true;
            return true;
        }

        public bool remPoints(int team, int points)
        {
            if (team == 1)
            {
                targetValDel = Convert.ToInt32(lblRoundPoints.Text) - points;
            }
            else if (team == 2)
            {
                targetValDel = int.Parse(lblPointsTeam1.Text) - points;
            }
            else if (team == 3)
            {
                targetValDel = int.Parse(lblPointsTeam2.Text) - points;
            }
            targetTeamDel = team;
            timerDelPoints.Enabled = true;
            return true;
        }

        public bool winnerPoints(int team) {
            newPoints(team, int.Parse(lblRoundPoints.Text));
            setPoints(1, 0);
            return true;
        }

        public bool setPoints(int team, int points)
        {
            int currentPoints = 0;
            if (team == 1)
            {
                currentPoints = int.Parse(lblRoundPoints.Text);
            }
            else if (team == 2)
            {
                currentPoints = int.Parse(lblRoundPoints.Text);
            }
            else if (team == 3)
            {
                currentPoints = int.Parse(lblRoundPoints.Text);
            }
            if (points < currentPoints)
            {
                targetTeamDel = team;
                targetValDel = points;
                timerDelPoints.Enabled = true;
            }
            else if (points > currentPoints)
            {
                targetTeam = team;
                targetVal = points;
                timerAddPoints.Enabled = true;
            }
            return true;
                
        }

        public void showResult(int answer, string text, string people)
        {
            if (text.Length > 45)
            {
                text = text.Substring(0, 45) + "...";
            }
            if (answer == 1)
            {
                lblAnswer1.Text = text;
                lblAnswerPts1.Visible = true;
                lblAnswerPts1.Text = people;
                //lblAnswerPts1.TextAlign = StringAlignment.Center;
            }
            else if (answer == 2)
            {
                lblAnswer2.Text = text;
                lblAnswerPts2.Visible = true;
                lblAnswerPts2.Text = people;
            }
            else if (answer == 3)
            {
                lblAnswer3.Text = text;
                lblAnswerPts3.Visible = true;
                lblAnswerPts3.Text = people;
            }
            else if (answer == 4)
            {
                lblAnswer4.Text = text;
                lblAnswerPts4.Visible = true;
                lblAnswerPts4.Text = people;
            }
            else if (answer == 5)
            {
                lblAnswer5.Text = text;
                lblAnswerPts5.Visible = true;
                lblAnswerPts5.Text = people;
            }
            else if (answer == 6)
            {
                lblAnswer6.Text = text;
                lblAnswerPts6.Visible = true;
                lblAnswerPts6.Text = people;
            }
            if (answer > 0 & answer < 7)
            {
                answerTo = answer;
                quantity = people;
                timerRight.Enabled = true;
            }
        }

        private void showQuantity(object sender, EventArgs e)
        {
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

        private void addPoints(object sender, EventArgs e)
        {
            if (targetTeam == 1)
            {
                if (Convert.ToInt32(lblRoundPoints.Text) < targetVal)
                {
                    lblRoundPoints.Text = Convert.ToString(Convert.ToInt32(lblRoundPoints.Text) + 1);
                }
                else
                {
                    timerAddPoints.Enabled = false;
                }
            }
            else if (targetTeam == 2)
            {
                if (Convert.ToInt32(lblPointsTeam1.Text) < targetVal)
                {
                    lblPointsTeam1.Text = Convert.ToString(Convert.ToInt32(lblPointsTeam1.Text) + 1);
                }
                else
                {
                    timerAddPoints.Enabled = false;
                }
            }
            else if (targetTeam == 3)
            {
                if (Convert.ToInt32(lblPointsTeam2.Text) < targetVal)
                {
                    lblPointsTeam2.Text = Convert.ToString(Convert.ToInt32(lblPointsTeam2.Text) + 1);
                }
                else
                {
                    timerAddPoints.Enabled = false;
                }
            }
            
        }

        private void delPoints(object sender, EventArgs e)
        {
            if (targetTeamDel == 1)
            {
                if (Convert.ToInt32(lblRoundPoints.Text) > targetValDel)
                {
                    lblRoundPoints.Text = Convert.ToString(Convert.ToInt32(lblRoundPoints.Text) - 1);
                }
                else
                {
                    timerAddPoints.Enabled = false;
                }
            }
            else if (targetTeamDel == 2)
            {
                if (Convert.ToInt32(lblPointsTeam1.Text) > targetValDel)
                {
                    lblPointsTeam1.Text = Convert.ToString(Convert.ToInt32(lblPointsTeam1.Text) - 1);
                }
                else
                {
                    timerAddPoints.Enabled = false;
                }
            }
            else if (targetTeamDel == 3)
            {
                if (Convert.ToInt32(lblPointsTeam2.Text) > targetValDel)
                {
                    lblPointsTeam2.Text = Convert.ToString(Convert.ToInt32(lblPointsTeam2.Text) - 1);
                }
                else
                {
                    timerDelPoints.Enabled = false;
                }
            }
        }
    }
}
