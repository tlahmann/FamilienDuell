namespace FamilienDuell
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabMainControl = new System.Windows.Forms.TabControl();
            this.tabMainSettings = new System.Windows.Forms.TabPage();
            this.cbSounds = new System.Windows.Forms.CheckBox();
            this.lblTeamAlert = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGameType = new System.Windows.Forms.ComboBox();
            this.txtGameTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOvertake = new System.Windows.Forms.Button();
            this.txtTeam2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTeam1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabQuests = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPlay = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.btnRemi = new System.Windows.Forms.Button();
            this.btnShowQuestion = new System.Windows.Forms.Button();
            this.btnTeam2 = new System.Windows.Forms.Button();
            this.btnTeam1 = new System.Windows.Forms.Button();
            this.lblQuantity3 = new System.Windows.Forms.Label();
            this.lblQuantity4 = new System.Windows.Forms.Label();
            this.lblQuantity5 = new System.Windows.Forms.Label();
            this.lblQuantity1 = new System.Windows.Forms.Label();
            this.lblQuantity6 = new System.Windows.Forms.Label();
            this.lblQuantity2 = new System.Windows.Forms.Label();
            this.cbTeamRound = new System.Windows.Forms.CheckBox();
            this.btnGetQuestion = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.btnAnswer5 = new System.Windows.Forms.Button();
            this.btnAnswer6 = new System.Windows.Forms.Button();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnWrong = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPoints = new System.Windows.Forms.TabPage();
            this.drpTeam = new System.Windows.Forms.ComboBox();
            this.lblPointsWarning = new System.Windows.Forms.Label();
            this.btnDelPoints = new System.Windows.Forms.Button();
            this.btnAddPoints = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPointsProceed = new System.Windows.Forms.TextBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblClientId = new System.Windows.Forms.Label();
            this.tabMainControl.SuspendLayout();
            this.tabMainSettings.SuspendLayout();
            this.tabQuests.SuspendLayout();
            this.tabPlay.SuspendLayout();
            this.tabPoints.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblStatus.Location = new System.Drawing.Point(12, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(542, 29);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "FamilienDuell befindet sich derzeit im StdBy.";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNext.Location = new System.Drawing.Point(391, 350);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(163, 46);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "System initialisieren";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tabMainControl
            // 
            this.tabMainControl.Controls.Add(this.tabMainSettings);
            this.tabMainControl.Controls.Add(this.tabQuests);
            this.tabMainControl.Controls.Add(this.tabPlay);
            this.tabMainControl.Controls.Add(this.tabPoints);
            this.tabMainControl.Location = new System.Drawing.Point(12, 42);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(542, 302);
            this.tabMainControl.TabIndex = 2;
            // 
            // tabMainSettings
            // 
            this.tabMainSettings.Controls.Add(this.cbSounds);
            this.tabMainSettings.Controls.Add(this.lblTeamAlert);
            this.tabMainSettings.Controls.Add(this.label4);
            this.tabMainSettings.Controls.Add(this.cbGameType);
            this.tabMainSettings.Controls.Add(this.txtGameTitle);
            this.tabMainSettings.Controls.Add(this.label3);
            this.tabMainSettings.Controls.Add(this.btnOvertake);
            this.tabMainSettings.Controls.Add(this.txtTeam2);
            this.tabMainSettings.Controls.Add(this.label2);
            this.tabMainSettings.Controls.Add(this.txtTeam1);
            this.tabMainSettings.Controls.Add(this.label1);
            this.tabMainSettings.Location = new System.Drawing.Point(4, 22);
            this.tabMainSettings.Name = "tabMainSettings";
            this.tabMainSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainSettings.Size = new System.Drawing.Size(534, 276);
            this.tabMainSettings.TabIndex = 0;
            this.tabMainSettings.Text = "Spieleinstellungen";
            this.tabMainSettings.UseVisualStyleBackColor = true;
            // 
            // cbSounds
            // 
            this.cbSounds.AutoSize = true;
            this.cbSounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSounds.Location = new System.Drawing.Point(6, 191);
            this.cbSounds.Name = "cbSounds";
            this.cbSounds.Size = new System.Drawing.Size(126, 17);
            this.cbSounds.TabIndex = 5;
            this.cbSounds.Text = "Sounds abspielen";
            this.cbSounds.UseVisualStyleBackColor = true;
            // 
            // lblTeamAlert
            // 
            this.lblTeamAlert.AutoSize = true;
            this.lblTeamAlert.ForeColor = System.Drawing.Color.Red;
            this.lblTeamAlert.Location = new System.Drawing.Point(245, 93);
            this.lblTeamAlert.Name = "lblTeamAlert";
            this.lblTeamAlert.Size = new System.Drawing.Size(0, 13);
            this.lblTeamAlert.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Spieltyp";
            // 
            // cbGameType
            // 
            this.cbGameType.FormattingEnabled = true;
            this.cbGameType.Items.AddRange(new object[] {
            "Normal"});
            this.cbGameType.Location = new System.Drawing.Point(6, 149);
            this.cbGameType.Name = "cbGameType";
            this.cbGameType.Size = new System.Drawing.Size(121, 21);
            this.cbGameType.TabIndex = 4;
            this.cbGameType.Text = "Normal";
            // 
            // txtGameTitle
            // 
            this.txtGameTitle.AutoCompleteCustomSource.AddRange(new string[] {
            "FamilienDuell",
            "Chaos Familien Duell",
            "SchülerDuell",
            "PartyDuell"});
            this.txtGameTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGameTitle.Location = new System.Drawing.Point(6, 28);
            this.txtGameTitle.Name = "txtGameTitle";
            this.txtGameTitle.Size = new System.Drawing.Size(259, 20);
            this.txtGameTitle.TabIndex = 1;
            this.txtGameTitle.Text = "Davids Familien Duell v0.1 Alpha-RC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Spieltitel";
            // 
            // btnOvertake
            // 
            this.btnOvertake.Location = new System.Drawing.Point(443, 247);
            this.btnOvertake.Name = "btnOvertake";
            this.btnOvertake.Size = new System.Drawing.Size(85, 23);
            this.btnOvertake.TabIndex = 6;
            this.btnOvertake.Text = "Übernehmen";
            this.btnOvertake.UseVisualStyleBackColor = true;
            this.btnOvertake.Click += new System.EventHandler(this.btnOvertake_Click);
            // 
            // txtTeam2
            // 
            this.txtTeam2.Location = new System.Drawing.Point(137, 90);
            this.txtTeam2.Name = "txtTeam2";
            this.txtTeam2.Size = new System.Drawing.Size(102, 20);
            this.txtTeam2.TabIndex = 3;
            this.txtTeam2.Text = "Team Frankreich";
            this.txtTeam2.Leave += new System.EventHandler(this.checkTeamNames);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "vs.";
            // 
            // txtTeam1
            // 
            this.txtTeam1.Location = new System.Drawing.Point(6, 90);
            this.txtTeam1.Name = "txtTeam1";
            this.txtTeam1.Size = new System.Drawing.Size(102, 20);
            this.txtTeam1.TabIndex = 2;
            this.txtTeam1.Text = "Team Deutschland";
            this.txtTeam1.Leave += new System.EventHandler(this.checkTeamNames);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teamnamen";
            // 
            // tabQuests
            // 
            this.tabQuests.Controls.Add(this.checkBox1);
            this.tabQuests.Location = new System.Drawing.Point(4, 22);
            this.tabQuests.Name = "tabQuests";
            this.tabQuests.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuests.Size = new System.Drawing.Size(534, 276);
            this.tabQuests.TabIndex = 1;
            this.tabQuests.Text = "Fragen";
            this.tabQuests.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(6, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(255, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Beziehe Fragen automatisch von dbeuchert.com";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPlay
            // 
            this.tabPlay.Controls.Add(this.label15);
            this.tabPlay.Controls.Add(this.btnRemi);
            this.tabPlay.Controls.Add(this.btnShowQuestion);
            this.tabPlay.Controls.Add(this.btnTeam2);
            this.tabPlay.Controls.Add(this.btnTeam1);
            this.tabPlay.Controls.Add(this.lblQuantity3);
            this.tabPlay.Controls.Add(this.lblQuantity4);
            this.tabPlay.Controls.Add(this.lblQuantity5);
            this.tabPlay.Controls.Add(this.lblQuantity1);
            this.tabPlay.Controls.Add(this.lblQuantity6);
            this.tabPlay.Controls.Add(this.lblQuantity2);
            this.tabPlay.Controls.Add(this.cbTeamRound);
            this.tabPlay.Controls.Add(this.btnGetQuestion);
            this.tabPlay.Controls.Add(this.btnAnswer2);
            this.tabPlay.Controls.Add(this.btnAnswer3);
            this.tabPlay.Controls.Add(this.btnAnswer4);
            this.tabPlay.Controls.Add(this.btnAnswer5);
            this.tabPlay.Controls.Add(this.btnAnswer6);
            this.tabPlay.Controls.Add(this.btnAnswer1);
            this.tabPlay.Controls.Add(this.label12);
            this.tabPlay.Controls.Add(this.label11);
            this.tabPlay.Controls.Add(this.label10);
            this.tabPlay.Controls.Add(this.label9);
            this.tabPlay.Controls.Add(this.label8);
            this.tabPlay.Controls.Add(this.label7);
            this.tabPlay.Controls.Add(this.btnWrong);
            this.tabPlay.Controls.Add(this.label6);
            this.tabPlay.Controls.Add(this.lblQuestion);
            this.tabPlay.Controls.Add(this.label5);
            this.tabPlay.Location = new System.Drawing.Point(4, 22);
            this.tabPlay.Name = "tabPlay";
            this.tabPlay.Size = new System.Drawing.Size(534, 276);
            this.tabPlay.TabIndex = 2;
            this.tabPlay.Text = "Spielen";
            this.tabPlay.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Punkte abgeben an";
            // 
            // btnRemi
            // 
            this.btnRemi.Enabled = false;
            this.btnRemi.Location = new System.Drawing.Point(183, 246);
            this.btnRemi.Name = "btnRemi";
            this.btnRemi.Size = new System.Drawing.Size(75, 23);
            this.btnRemi.TabIndex = 39;
            this.btnRemi.Text = "niemand";
            this.btnRemi.UseVisualStyleBackColor = true;
            this.btnRemi.Click += new System.EventHandler(this.btnRemi_Click);
            // 
            // btnShowQuestion
            // 
            this.btnShowQuestion.Enabled = false;
            this.btnShowQuestion.Location = new System.Drawing.Point(441, 36);
            this.btnShowQuestion.Name = "btnShowQuestion";
            this.btnShowQuestion.Size = new System.Drawing.Size(90, 23);
            this.btnShowQuestion.TabIndex = 38;
            this.btnShowQuestion.Text = "Frage anzeigen";
            this.btnShowQuestion.UseVisualStyleBackColor = true;
            this.btnShowQuestion.Click += new System.EventHandler(this.btnShowQuestion_Click);
            // 
            // btnTeam2
            // 
            this.btnTeam2.Enabled = false;
            this.btnTeam2.Location = new System.Drawing.Point(101, 246);
            this.btnTeam2.Name = "btnTeam2";
            this.btnTeam2.Size = new System.Drawing.Size(75, 23);
            this.btnTeam2.TabIndex = 37;
            this.btnTeam2.Text = "Team 2";
            this.btnTeam2.UseVisualStyleBackColor = true;
            this.btnTeam2.Click += new System.EventHandler(this.btnTeam2_Click);
            // 
            // btnTeam1
            // 
            this.btnTeam1.Enabled = false;
            this.btnTeam1.Location = new System.Drawing.Point(20, 245);
            this.btnTeam1.Name = "btnTeam1";
            this.btnTeam1.Size = new System.Drawing.Size(75, 23);
            this.btnTeam1.TabIndex = 36;
            this.btnTeam1.Text = "Team 1";
            this.btnTeam1.UseVisualStyleBackColor = true;
            this.btnTeam1.Click += new System.EventHandler(this.btnTeam1_Click);
            // 
            // lblQuantity3
            // 
            this.lblQuantity3.Location = new System.Drawing.Point(486, 121);
            this.lblQuantity3.Name = "lblQuantity3";
            this.lblQuantity3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblQuantity3.Size = new System.Drawing.Size(36, 12);
            this.lblQuantity3.TabIndex = 35;
            this.lblQuantity3.Text = "123";
            // 
            // lblQuantity4
            // 
            this.lblQuantity4.Location = new System.Drawing.Point(486, 150);
            this.lblQuantity4.Name = "lblQuantity4";
            this.lblQuantity4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblQuantity4.Size = new System.Drawing.Size(36, 13);
            this.lblQuantity4.TabIndex = 34;
            this.lblQuantity4.Text = "123";
            // 
            // lblQuantity5
            // 
            this.lblQuantity5.Location = new System.Drawing.Point(486, 179);
            this.lblQuantity5.Name = "lblQuantity5";
            this.lblQuantity5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblQuantity5.Size = new System.Drawing.Size(36, 13);
            this.lblQuantity5.TabIndex = 33;
            this.lblQuantity5.Text = "123";
            // 
            // lblQuantity1
            // 
            this.lblQuantity1.Location = new System.Drawing.Point(486, 63);
            this.lblQuantity1.Name = "lblQuantity1";
            this.lblQuantity1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblQuantity1.Size = new System.Drawing.Size(36, 23);
            this.lblQuantity1.TabIndex = 32;
            this.lblQuantity1.Text = "123";
            // 
            // lblQuantity6
            // 
            this.lblQuantity6.Location = new System.Drawing.Point(486, 208);
            this.lblQuantity6.Name = "lblQuantity6";
            this.lblQuantity6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblQuantity6.Size = new System.Drawing.Size(36, 13);
            this.lblQuantity6.TabIndex = 31;
            this.lblQuantity6.Text = "123";
            // 
            // lblQuantity2
            // 
            this.lblQuantity2.Location = new System.Drawing.Point(486, 90);
            this.lblQuantity2.Name = "lblQuantity2";
            this.lblQuantity2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblQuantity2.Size = new System.Drawing.Size(36, 13);
            this.lblQuantity2.TabIndex = 26;
            this.lblQuantity2.Text = "123";
            // 
            // cbTeamRound
            // 
            this.cbTeamRound.AutoSize = true;
            this.cbTeamRound.Location = new System.Drawing.Point(281, 249);
            this.cbTeamRound.Name = "cbTeamRound";
            this.cbTeamRound.Size = new System.Drawing.Size(88, 17);
            this.cbTeamRound.TabIndex = 24;
            this.cbTeamRound.Text = "Team-Runde";
            this.cbTeamRound.UseVisualStyleBackColor = true;
            this.cbTeamRound.CheckedChanged += new System.EventHandler(this.cbTeamRound_CheckedChanged);
            // 
            // btnGetQuestion
            // 
            this.btnGetQuestion.Location = new System.Drawing.Point(441, 9);
            this.btnGetQuestion.Name = "btnGetQuestion";
            this.btnGetQuestion.Size = new System.Drawing.Size(90, 23);
            this.btnGetQuestion.TabIndex = 23;
            this.btnGetQuestion.Text = "Frage abrufen";
            this.btnGetQuestion.UseVisualStyleBackColor = true;
            this.btnGetQuestion.Click += new System.EventHandler(this.btnGetQuestion_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.AutoSize = true;
            this.btnAnswer2.Enabled = false;
            this.btnAnswer2.Location = new System.Drawing.Point(54, 85);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(112, 23);
            this.btnAnswer2.TabIndex = 22;
            this.btnAnswer2.UseVisualStyleBackColor = true;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer2_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.AutoSize = true;
            this.btnAnswer3.Enabled = false;
            this.btnAnswer3.Location = new System.Drawing.Point(54, 116);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(112, 23);
            this.btnAnswer3.TabIndex = 21;
            this.btnAnswer3.UseVisualStyleBackColor = true;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer3_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.AutoSize = true;
            this.btnAnswer4.Enabled = false;
            this.btnAnswer4.Location = new System.Drawing.Point(54, 145);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(112, 23);
            this.btnAnswer4.TabIndex = 20;
            this.btnAnswer4.UseVisualStyleBackColor = true;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer4_Click);
            // 
            // btnAnswer5
            // 
            this.btnAnswer5.AutoSize = true;
            this.btnAnswer5.Enabled = false;
            this.btnAnswer5.Location = new System.Drawing.Point(54, 174);
            this.btnAnswer5.Name = "btnAnswer5";
            this.btnAnswer5.Size = new System.Drawing.Size(112, 23);
            this.btnAnswer5.TabIndex = 19;
            this.btnAnswer5.UseVisualStyleBackColor = true;
            this.btnAnswer5.Click += new System.EventHandler(this.btnAnswer5_Click);
            // 
            // btnAnswer6
            // 
            this.btnAnswer6.AutoSize = true;
            this.btnAnswer6.Enabled = false;
            this.btnAnswer6.Location = new System.Drawing.Point(54, 203);
            this.btnAnswer6.Name = "btnAnswer6";
            this.btnAnswer6.Size = new System.Drawing.Size(112, 23);
            this.btnAnswer6.TabIndex = 18;
            this.btnAnswer6.UseVisualStyleBackColor = true;
            this.btnAnswer6.Click += new System.EventHandler(this.btnAnswer6_Click);
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.AutoSize = true;
            this.btnAnswer1.Enabled = false;
            this.btnAnswer1.Location = new System.Drawing.Point(54, 58);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(112, 23);
            this.btnAnswer1.TabIndex = 16;
            this.btnAnswer1.UseVisualStyleBackColor = true;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "6.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "5.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "3.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "4.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "2.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "1.";
            // 
            // btnWrong
            // 
            this.btnWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrong.Location = new System.Drawing.Point(375, 229);
            this.btnWrong.Name = "btnWrong";
            this.btnWrong.Size = new System.Drawing.Size(145, 40);
            this.btnWrong.TabIndex = 3;
            this.btnWrong.Text = "FALSCH!";
            this.btnWrong.UseVisualStyleBackColor = true;
            this.btnWrong.Click += new System.EventHandler(this.btnWrong_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Antworten:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(112, 14);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(146, 13);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Noch keine Frage abgerufen.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Frage:";
            // 
            // tabPoints
            // 
            this.tabPoints.Controls.Add(this.drpTeam);
            this.tabPoints.Controls.Add(this.lblPointsWarning);
            this.tabPoints.Controls.Add(this.btnDelPoints);
            this.tabPoints.Controls.Add(this.btnAddPoints);
            this.tabPoints.Controls.Add(this.label13);
            this.tabPoints.Controls.Add(this.tbPointsProceed);
            this.tabPoints.Location = new System.Drawing.Point(4, 22);
            this.tabPoints.Name = "tabPoints";
            this.tabPoints.Size = new System.Drawing.Size(534, 276);
            this.tabPoints.TabIndex = 3;
            this.tabPoints.Text = "Punkte korrigieren";
            this.tabPoints.UseVisualStyleBackColor = true;
            // 
            // drpTeam
            // 
            this.drpTeam.FormattingEnabled = true;
            this.drpTeam.Items.AddRange(new object[] {
            "Rundenpunkte",
            "Team 1",
            "Team 2"});
            this.drpTeam.Location = new System.Drawing.Point(177, 35);
            this.drpTeam.Name = "drpTeam";
            this.drpTeam.Size = new System.Drawing.Size(121, 21);
            this.drpTeam.Sorted = true;
            this.drpTeam.TabIndex = 2;
            this.drpTeam.Text = "Team auswählen";
            // 
            // lblPointsWarning
            // 
            this.lblPointsWarning.AutoSize = true;
            this.lblPointsWarning.ForeColor = System.Drawing.Color.Red;
            this.lblPointsWarning.Location = new System.Drawing.Point(21, 77);
            this.lblPointsWarning.Name = "lblPointsWarning";
            this.lblPointsWarning.Size = new System.Drawing.Size(0, 13);
            this.lblPointsWarning.TabIndex = 5;
            // 
            // btnDelPoints
            // 
            this.btnDelPoints.AutoSize = true;
            this.btnDelPoints.Location = new System.Drawing.Point(349, 35);
            this.btnDelPoints.Name = "btnDelPoints";
            this.btnDelPoints.Size = new System.Drawing.Size(23, 23);
            this.btnDelPoints.TabIndex = 4;
            this.btnDelPoints.Text = "-";
            this.btnDelPoints.UseVisualStyleBackColor = true;
            this.btnDelPoints.Click += new System.EventHandler(this.btnDelPoints_Click);
            // 
            // btnAddPoints
            // 
            this.btnAddPoints.AutoSize = true;
            this.btnAddPoints.Location = new System.Drawing.Point(320, 34);
            this.btnAddPoints.Name = "btnAddPoints";
            this.btnAddPoints.Size = new System.Drawing.Size(23, 23);
            this.btnAddPoints.TabIndex = 3;
            this.btnAddPoints.Text = "+";
            this.btnAddPoints.UseVisualStyleBackColor = true;
            this.btnAddPoints.Click += new System.EventHandler(this.btnAddPoints_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(130, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Punkte";
            // 
            // tbPointsProceed
            // 
            this.tbPointsProceed.Location = new System.Drawing.Point(24, 37);
            this.tbPointsProceed.MaxLength = 4;
            this.tbPointsProceed.Name = "tbPointsProceed";
            this.tbPointsProceed.ShortcutsEnabled = false;
            this.tbPointsProceed.Size = new System.Drawing.Size(100, 20);
            this.tbPointsProceed.TabIndex = 0;
            this.tbPointsProceed.WordWrap = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(9, 386);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(131, 13);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "© 2010 by dbeuchert.com";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 359);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "ClientId:";
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(69, 359);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(162, 13);
            this.lblClientId.TabIndex = 9;
            this.lblClientId.Text = "Zum Erstellen System initialiseren";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 408);
            this.Controls.Add(this.lblClientId);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.tabMainControl);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "FamilienDuell Controller";
            this.TopMost = true;
            this.tabMainControl.ResumeLayout(false);
            this.tabMainSettings.ResumeLayout(false);
            this.tabMainSettings.PerformLayout();
            this.tabQuests.ResumeLayout(false);
            this.tabQuests.PerformLayout();
            this.tabPlay.ResumeLayout(false);
            this.tabPlay.PerformLayout();
            this.tabPoints.ResumeLayout(false);
            this.tabPoints.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TabControl tabMainControl;
        private System.Windows.Forms.TabPage tabMainSettings;
        private System.Windows.Forms.TabPage tabQuests;
        private System.Windows.Forms.TabPage tabPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeam2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTeam1;
        private System.Windows.Forms.Button btnOvertake;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtGameTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGameType;
        private System.Windows.Forms.Label lblTeamAlert;
        private System.Windows.Forms.CheckBox cbSounds;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnWrong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Button btnAnswer5;
        private System.Windows.Forms.Button btnAnswer6;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGetQuestion;
        private System.Windows.Forms.CheckBox cbTeamRound;
        private System.Windows.Forms.Label lblQuantity3;
        private System.Windows.Forms.Label lblQuantity4;
        private System.Windows.Forms.Label lblQuantity5;
        private System.Windows.Forms.Label lblQuantity1;
        private System.Windows.Forms.Label lblQuantity6;
        private System.Windows.Forms.Label lblQuantity2;
        private System.Windows.Forms.TabPage tabPoints;
        private System.Windows.Forms.Button btnAddPoints;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbPointsProceed;
        private System.Windows.Forms.Button btnDelPoints;
        private System.Windows.Forms.Label lblPointsWarning;
        private System.Windows.Forms.ComboBox drpTeam;
        private System.Windows.Forms.Button btnTeam2;
        private System.Windows.Forms.Button btnTeam1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Button btnShowQuestion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRemi;
    }
}

