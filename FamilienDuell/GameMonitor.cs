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
        int Waiting = 0;

        int AnswerTo;
        string Quantity;

        int targetVal;
        int targetTeam;
        int targetTeamDel;
        int targetValDel;

        public GameMonitor()
        {
            InitializeComponent();
        }

        public bool SetHeadline(string text) {
            lblHeadline.Text = text;
            return true;
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

        public bool ToggleWaiting()
        {
            if (Waiting == 0)
            {
                imgWaiting.Visible = true;
                Waiting = 1;
            }
            else
            {
                imgWaiting.Visible = false;
                Waiting = 0;
            }
            return true;
        }

        public bool SetTeams(string Team1, string Team2)
        {
            lblTeam1.Text = Team1;
            lblTeam2.Text = Team2;
            return true;
        }

        public void setQuestion(string msg)
        {
            lblQuestion.Text += ": " + msg;
        }

        public bool GameStart()
        {
            lblWrong.Visible = false;
            lblTeam1.Visible = true;
            lblTeam2.Visible = true;
            lblPointsTeam1.Visible = true;
            lblPointsTeam2.Visible = true;
            lblRoundPoints.Visible = true;
            lblAnswer1.Visible = true;
            lblAnswer2.Visible = true;
            lblAnswer3.Visible = true;
            lblAnswer4.Visible = true;
            lblAnswer5.Visible = true;
            lblAnswer6.Visible = true;
            lblAnswers1.Visible = true;
            lblAnswers2.Visible = true;
            lblAnswers3.Visible = true;
            lblAnswers4.Visible = true;
            lblAnswers5.Visible = true;
            lblAnswers6.Visible = true;
            lblAnswer1.Text = "................................................";
            lblAnswer2.Text = "................................................";
            lblAnswer3.Text = "................................................";
            lblAnswer4.Text = "................................................";
            lblAnswer5.Text = "................................................";
            lblAnswer6.Text = "................................................";
            lblAnswers1.Text = "..";
            lblAnswers2.Text = "..";
            lblAnswers3.Text = "..";
            lblAnswers4.Text = "..";
            lblAnswers5.Text = "..";
            lblAnswers6.Text = "..";
            lblWrong.Text = "";
            lblQuestion.Text = "Runde #1";
            return true;
        }

        public bool nextRound(int roundNumber) {
            lblWrong.Visible = false;
            if (roundNumber > 1)
            {
                lblAnswer6.Visible = false;
                lblAnswers6.Visible = false;
            }
            if (roundNumber > 2)
            {
                lblAnswer5.Visible = false;
                lblAnswers5.Visible = false;
            }
            if (roundNumber > 3)
            {
                lblAnswer4.Visible = false;
                lblAnswers4.Visible = false;
            }
            lblQuestion.Text = "Runde #" + Convert.ToString(roundNumber);
            lblAnswer1.Text = "................................................";
            lblAnswer2.Text = "................................................";
            lblAnswer3.Text = "................................................";
            lblAnswer4.Text = "................................................";
            lblAnswer5.Text = "................................................";
            lblAnswers1.Text = "..";
            lblAnswers2.Text = "..";
            lblAnswers3.Text = "..";
            lblAnswers4.Text = "..";
            lblAnswers5.Text = "..";
            lblWrong.Text = "";
            return true;
        }

        public bool MakeWrong(bool isInTeamRound)
        {
            lblWrong.Visible = true;
            if (isInTeamRound)
            {
                if (lblWrong.Text.Length < 3)
                {
                    lblWrong.Text += "X";
                    if (lblWrong.Text.Length >= 3)
                    {
                        timerWrong.Enabled = true;
                        return false;
                    }

                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                lblWrong.Text = "X";
                timerWrong.Enabled = true;
                return false;
            }

        }

        public bool clearWrong() {
            lblWrong.Text = "";
            lblWrong.Visible = false;
            return true;
        }

        private void toggleWrong(object sender, EventArgs e)
        {
            if (lblWrong.Visible == true)
            {
                lblWrong.Visible = false;
                timerWrong.Enabled = false;
                lblWrong.Text = "";
            }
        }

        // point management
        public bool newPoints(int team,int points)
        {
            if (team == 1)
            {
                targetVal = Convert.ToInt32(lblRoundPoints.Text) + points;
                MessageBox.Show("New targetVal: " + Convert.ToString( targetVal ) );
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

        public bool ShowResult(int Answer, string Text, string People)
        {
            if (Text.Length > 45)
            {
                Text = Text.Substring(0, 45) + "...";
            }
            if (Answer == 1)
            {
                lblAnswer1.Text = Text;
            }
            else if (Answer == 2)
            {
                lblAnswer2.Text = Text;
            }
            else if (Answer == 3)
            {
                lblAnswer3.Text = Text;
            }
            else if (Answer == 4)
            {
                lblAnswer4.Text = Text;
            }
            else if (Answer == 5)
            {
                lblAnswer5.Text = Text;
            }
            else if (Answer == 6)
            {
                lblAnswer6.Text = Text;
            }
            if (Answer > 0 & Answer < 7)
            {
                AnswerTo = Answer;
                Quantity = People;
                timerRight.Enabled = true;
            }
            return true;
        }

        private void showQuantity(object sender, EventArgs e)
        {
            if (AnswerTo == 1) {
            lblAnswers1.Text = Quantity;
            }
            if (AnswerTo == 2) {
            lblAnswers2.Text = Quantity;
            }
            if (AnswerTo == 3) {
            lblAnswers3.Text = Quantity;
            }
            if (AnswerTo == 4) {
            lblAnswers4.Text = Quantity;
            }
            if (AnswerTo == 5) {
            lblAnswers5.Text = Quantity;
            }
            if (AnswerTo == 6) {
            lblAnswers6.Text = Quantity;
            }
            timerRight.Enabled = false;
            newPoints(1, int.Parse(Quantity));
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
