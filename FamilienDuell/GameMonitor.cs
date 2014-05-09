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
            //imgWaiting.Visible = true;
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

            String famName = "Press Start 2P";

            Font f10 = new Font(famName, 10);
            Font f15 = new Font(famName, 15);
            Font f18 = new Font(famName, 18);
            Font f22 = new Font(famName, 22);
            Font f30 = new Font(famName, 30);
            Font f40 = new Font(famName, 40);

            if (hoehe <= 300)
            {
                lblQuestion.Font = f15;
            }
            else if (hoehe <= 500)
            {
                setSize(f15, f18);
            }
            else if (hoehe <= 700)
            {
                setSize(f18, f22);
            }
            else if (hoehe <= 1000)
            {
                setSize(f22, f30);
            }
            else if (hoehe <= 1500)
            {
                setSize(f30, f40);
            }
        }

        public void setSize(Font smallF, Font bigF)
        {
            lblQuestion.Font = bigF;

            lblWrong1.Font = bigF;
            lblWrong2.Font = bigF;
            lblWrong3.Font = bigF;

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

        private void monitorClosing(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Dieses Fenster kann nicht geschlossen werden", "Nicht möglich", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = true;
        }

        public void setHeadline(string text)
        {
            lblQuestion.Text = text;
        }

        public void maximize()
        {
            WindowState = FormWindowState.Maximized;
            newSize();
            FormBorderStyle = FormBorderStyle.None;
        }

        public void minimize()
        {
            WindowState = FormWindowState.Normal;
            newSize();
            FormBorderStyle = FormBorderStyle.Sizable;
        }

        public void toggleWaiting()
        {
            if (waiting == 0)
            {
                //imgWaiting.Visible = true;
                waiting = 1;
            }
            else
            {
                //imgWaiting.Visible = false;
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
            lblQuestion.Visible = true;
            lblQuestion.Text = msg;
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
            lblQuestion.Text = "Runde #1";
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
            lblQuestion.Text = "Runde #" + Convert.ToString(roundNumber);
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
        public bool newPoints(int team, int points)
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
