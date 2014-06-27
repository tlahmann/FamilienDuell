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
        int currentPointsMultiplier = 1;

        // determines if the monitor form is maximized
        Boolean maximus;

        // initialize monitor
        GameMonitor Monitor = new GameMonitor();

        // clientid for server to identify client and match question history
        string clientId;

        // the current question object
        Question question;


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
            Screen[] screens = Screen.AllScreens;
            setFormLocation(Monitor, screens[0]);
            Monitor.Show();

            textGameTitleChanged(null, null);

            //playSound(1);

            //tabMainControl.Enabled = false;
        }

        private void setFormLocation(Form form, Screen screen) {
            // first method
            form.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Rectangle bounds = screen.Bounds;
            form.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);

            if (form is GameMonitor) {
                this.Monitor.newSize(bounds.Width, bounds.Height);
            }
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
            }
            else {
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
                Monitor.setTeams(txtTeam1.Text.ToString() + " ", null);
            }

            if (txtTeam2.Text != "") {
                Monitor.setTeams(null, " " + txtTeam2.Text.ToString());
            }

            if (txtTeam1.Text != "" && txtTeam2.Text != "") {
                checkTeamNames(txtTeam1.Text.ToString() + " ", " " + txtTeam2.Text.ToString());
                numericUpDown1.Enabled = true;
                cbSounds.Enabled = true;
                tableLayoutPanel4.BackColor = SystemColors.ActiveCaption;
            }
            else {
                Monitor.setTeams("Team Blau", "Team Rot");
                numericUpDown1.Enabled = false;
                cbSounds.Enabled = false;
                tableLayoutPanel4.BackColor = SystemColors.InactiveCaption;
            }
        }

        // check if Teamnames are to long
        private void checkTeamNames(string team1, string team2) {
            if (team1.Length > 16) {
                lblTeamCheck.Text = "Name für Team 1 möglicherweise zu lang!";
            }
            else if (team2.Length > 16) {
                lblTeamCheck.Text = "Name für Team 2 möglicherweise zu lang!";
            }
            else {
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
                    }
                    else if (dataGridView.Rows[j].Cells[i].Value.ToString() == "") {
                        dataGridView.Rows[j].Cells[i].Style.BackColor = SystemColors.InactiveCaption;

                        valid = false;
                    }
                    else {
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
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message, "Fehler!");
                    }
                    tabMainControl.SelectedIndex = 1;
                    currentSetupStatus = 1;
                }
                else {
                    dataGridView.Enabled = false;
                    tabMainControl.SelectedIndex = 2;
                    currentSetupStatus = 2;
                }

            }
            else if (tabMainControl.SelectedIndex == 1) {
                if (gridCheck()) {
                    tabMainControl.SelectedIndex = 2;
                    currentSetupStatus = 2;
                }
            }
            else if (tabMainControl.SelectedIndex == 2) {
                currentSetupStatus = 3;
                tabMainControl.SelectedIndex = 3;
            }
            else if (tabMainControl.SelectedIndex == 3) {
                playGame();
            }
        }

        // check which tab is selected to change the text on the next-button
        public void checkTab(object sender, EventArgs e) {
            if (currentGameStatus == 0) {
                if (tabMainControl.SelectedIndex == 3 && currentSetupStatus == 3) {
                    btnNext.Text = "Start";
                }
                else {
                    btnNext.Text = "Weiter";
                }
            }
        }
        #endregion

        #region Gameplay
        // start functions
        public void playGame() {

            btnGetQuestion.Enabled = true;
            changePoints.Enabled = true;
            btnNext.Text = "Nächste Runde";
            btnNext.Enabled = false;
            cbTeamRound.Checked = false;

            btnTeam1.Enabled = false;
            btnTeam2.Enabled = false;
            btnRemi.Enabled = false;

            switch (this.currentGameStatus) {
                case 0:
                    this.currentGameStatus = 1;
                    break;

                case 1:
                    this.Monitor.nextRound(2);
                    this.currentGameStatus = 2;
                    break;

                case 2:
                    this.Monitor.nextRound(3);
                    this.currentGameStatus = 3;
                    this.currentPointsMultiplier = 2;
                    break;

                case 3:
                    this.Monitor.nextRound(4);
                    this.currentGameStatus = 4;
                    this.currentPointsMultiplier = 3;
                    break;
            }
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
            if (currentGameStatus < 4) {
                btnAnswer4.Enabled = true;
            }
            if (currentGameStatus < 3) {
                btnAnswer5.Enabled = true;
            }
            if (currentGameStatus == 1) {
                btnAnswer6.Enabled = true;
            }
            btnShowQuestion.Enabled = true;
            btnWrong.Enabled = true;
            cbTeamRound.Enabled = true;
        }

        private void btnShowQuestionClick(object sender, EventArgs e) {
            Monitor.setQuestion(lblQuestion.Text.ToString());
            btnShowQuestion.Enabled = false;
        }

        private void btnResolveClick(object sender, EventArgs e) {

            Button button = (Button)sender;
            if (button.Tag.GetType() != typeof(Answer)) {
                throw new Exception("Answer button has been tagged with '" + button.Tag.GetType().Name + "', expected instance of Answer");
            }

            Answer answer = (Answer)button.Tag;
            btnGetQuestion.Enabled = false;
            button.Enabled = false;

            if (answer.isTopAnswer()) {
                cbTeamRound.Checked = true;
            }

            ctrlWritePoints(answer.getQuantity() * this.currentPointsMultiplier, this.getTeamPointsFromControl(1));
            Monitor.showResult(answer.getIndex(), answer.getTitle(), answer.getQuantityAsString(), this.currentPointsMultiplier);
            playSound(2);

            answer.markAsResolved();

            if (this.question.isResolved(currentGameStatus - 1)) {
                this.enablePointDistribution();
            }

        }


        private void btnTeam1Click(object sender, EventArgs e) {
            this.winnerPoints(2);
            btnNext.Enabled = true;
        }

        private void btnTeam2Click(object sender, EventArgs e) {
            this.winnerPoints(3);
            btnNext.Enabled = true;
        }

        private void btnRemiClick(object sender, EventArgs e) {
            btnNext.Enabled = true;
            this.setPoints(1, 0);
        }

        private void btnMaximizeClick(object sender, EventArgs e) {
            if (!maximus) {
                Monitor.maximize();
                maximus = true;
                btnMaximize.Text = "Verkleinern";
            }
            else {
                Monitor.minimize();
                maximus = false;
                btnMaximize.Text = "Maximieren";
            }
        }

        private void changePointsClick(object sender, EventArgs e) {
            using (ChangePoints ptChange = new ChangePoints()) {
                ptChange.injectController(this);
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
                    }
                    else if (Action == 2) {
                        // correct answer sound
                        SoundPlayer simpleSound = new SoundPlayer(locationOffset + @"\sounds\ff-clang.wav");
                        simpleSound.Play();
                    }
                    else if (Action == 3) {
                        // wrong answer sound
                        SoundPlayer simpleSound = new SoundPlayer(locationOffset + @"\sounds\ff-strike3.wav");
                        simpleSound.Play();
                    }
                }
                catch (Exception e) {
                    Debug.WriteLine("Could not play sound file: " + e.Message);
                }
            }
        }

        protected void enablePointDistribution() {
            btnTeam1.Enabled = true;
            btnTeam2.Enabled = true;
            btnRemi.Enabled = true;
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
            }
            catch (Exception Exception) {
                MessageBox.Show("Error: " + Exception.Message + "\n" + Exception.StackTrace);
            }

            lblQuestion.Text = question.getQuestion();

            int iteration = 0;
            ControlCollection controls = this.Controls as ControlCollection;

            foreach (Answer answer in question.getAnswers()) {

                iteration++;
                answer.setIndex(iteration);

                Control button = this.Controls.Find("btnAnswer" + iteration.ToString(), true).Single();
                Control quantity = this.Controls.Find("lblQuantity" + iteration.ToString(), true).Single();

                if (button is Button) {
                    button.Text = answer.getTitle();
                    button.Tag = answer;
                }

                if (quantity is Label) {
                    quantity.Text = answer.getQuantityAsString();
                }
            }

            this.question = question;
            return true;
        }

        private void ctrlWritePoints(int a, int b) {
            lblCtrlRdPts.Text = (a + b).ToString();
        }

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
                }
                else {
                    text += x;
                }
            }
            return text;
        }

        #region Pointstuff
        public void newPoints(int team, int points) {
            this.Monitor.newPoints(team, points);
            this.getPointControlLabelByTeam(team).Text = (this.getTeamPointsFromControl(team) + points).ToString();
        }

        public void remPoints(int team, int points) {
            this.Monitor.remPoints(team, points);
            this.getPointControlLabelByTeam(team).Text = (this.getTeamPointsFromControl(team) - points).ToString();
        }

        public void setPoints(int team, int points) {
            this.Monitor.setPoints(team, points);
            this.getPointControlLabelByTeam(team).Text = points.ToString();
        }

        public void winnerPoints(int team) {
            this.newPoints(team, this.getTeamPointsFromControl(1));
            this.setPoints(1, 0);
        }
        #endregion

        protected Label getPointControlLabelByTeam(int team) {
            switch (team) {
                case 2:
                    return lblCtrlTm1Pts;

                case 3:
                    return lblCtrlTm2Pts;

                default:
                    return lblCtrlRdPts;
            }
        }

        protected int getTeamPointsFromControl(int team) {
            return int.Parse(this.getPointControlLabelByTeam(team).Text);
        }

    }

}
