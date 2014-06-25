namespace FamilienDuell
{
    partial class GameMonitor
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
            this.components = new System.ComponentModel.Container();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.lblPointsTeam1 = new System.Windows.Forms.Label();
            this.lblPointsTeam2 = new System.Windows.Forms.Label();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.lblRoundPoints = new System.Windows.Forms.Label();
            this.lblWrong2 = new System.Windows.Forms.Label();
            this.timerWrong = new System.Windows.Forms.Timer(this.components);
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.lblAnswer6 = new System.Windows.Forms.Label();
            this.lblAnswer5 = new System.Windows.Forms.Label();
            this.timerRight = new System.Windows.Forms.Timer(this.components);
            this.lblAnswerPts1 = new System.Windows.Forms.Label();
            this.lblAnswerPts6 = new System.Windows.Forms.Label();
            this.lblAnswerPts5 = new System.Windows.Forms.Label();
            this.lblAnswerPts4 = new System.Windows.Forms.Label();
            this.lblAnswerPts3 = new System.Windows.Forms.Label();
            this.lblAnswerPts2 = new System.Windows.Forms.Label();
            this.timerAddPoints = new System.Windows.Forms.Timer(this.components);
            this.timerDelPoints = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAnswerNo6 = new System.Windows.Forms.Label();
            this.lblAnswerNo5 = new System.Windows.Forms.Label();
            this.lblAnswerNo4 = new System.Windows.Forms.Label();
            this.lblAnswerNo3 = new System.Windows.Forms.Label();
            this.lblAnswerNo2 = new System.Windows.Forms.Label();
            this.lblAnswerNo1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWrong3 = new System.Windows.Forms.Label();
            this.lblWrong1 = new System.Windows.Forms.Label();
            this.lblPlayerBlue = new System.Windows.Forms.Label();
            this.lblPlayerRed = new System.Windows.Forms.Label();
            this.resultWriter = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Lime;
            this.lblQuestion.Location = new System.Drawing.Point(4, 0);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(1076, 88);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "DefaultGameName";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeam1
            // 
            this.lblTeam1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeam1.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1.ForeColor = System.Drawing.Color.Blue;
            this.lblTeam1.Location = new System.Drawing.Point(3, 0);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTeam1.Size = new System.Drawing.Size(236, 42);
            this.lblTeam1.TabIndex = 2;
            this.lblTeam1.Text = "Team Blau";
            // 
            // lblPointsTeam1
            // 
            this.lblPointsTeam1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPointsTeam1.BackColor = System.Drawing.Color.Transparent;
            this.lblPointsTeam1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsTeam1.ForeColor = System.Drawing.Color.Blue;
            this.lblPointsTeam1.Location = new System.Drawing.Point(245, 0);
            this.lblPointsTeam1.Name = "lblPointsTeam1";
            this.lblPointsTeam1.Size = new System.Drawing.Size(194, 42);
            this.lblPointsTeam1.TabIndex = 3;
            this.lblPointsTeam1.Text = "0";
            // 
            // lblPointsTeam2
            // 
            this.lblPointsTeam2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPointsTeam2.BackColor = System.Drawing.Color.Transparent;
            this.lblPointsTeam2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsTeam2.ForeColor = System.Drawing.Color.Red;
            this.lblPointsTeam2.Location = new System.Drawing.Point(645, 0);
            this.lblPointsTeam2.Name = "lblPointsTeam2";
            this.lblPointsTeam2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPointsTeam2.Size = new System.Drawing.Size(194, 42);
            this.lblPointsTeam2.TabIndex = 4;
            this.lblPointsTeam2.Text = "0";
            // 
            // lblTeam2
            // 
            this.lblTeam2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeam2.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2.ForeColor = System.Drawing.Color.Red;
            this.lblTeam2.Location = new System.Drawing.Point(845, 0);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(236, 42);
            this.lblTeam2.TabIndex = 5;
            this.lblTeam2.Text = "Team Rot";
            // 
            // lblRoundPoints
            // 
            this.lblRoundPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoundPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundPoints.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundPoints.ForeColor = System.Drawing.Color.Lime;
            this.lblRoundPoints.Location = new System.Drawing.Point(445, 0);
            this.lblRoundPoints.Name = "lblRoundPoints";
            this.lblRoundPoints.Size = new System.Drawing.Size(194, 42);
            this.lblRoundPoints.TabIndex = 6;
            this.lblRoundPoints.Text = "0";
            this.lblRoundPoints.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWrong2
            // 
            this.lblWrong2.BackColor = System.Drawing.Color.Transparent;
            this.lblWrong2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWrong2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong2.ForeColor = System.Drawing.Color.Red;
            this.lblWrong2.Location = new System.Drawing.Point(3, 0);
            this.lblWrong2.Name = "lblWrong2";
            this.lblWrong2.Size = new System.Drawing.Size(63, 48);
            this.lblWrong2.TabIndex = 8;
            this.lblWrong2.Text = "X";
            this.lblWrong2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWrong2.Visible = false;
            // 
            // timerWrong
            // 
            this.timerWrong.Interval = 1050;
            this.timerWrong.Tick += new System.EventHandler(this.toggleWrong);
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer1.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer1.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswer1.Location = new System.Drawing.Point(203, 0);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(678, 65);
            this.lblAnswer1.TabIndex = 9;
            this.lblAnswer1.Text = "............";
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer2.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer2.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswer2.Location = new System.Drawing.Point(203, 65);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(678, 65);
            this.lblAnswer2.TabIndex = 10;
            this.lblAnswer2.Text = "............";
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer3.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer3.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswer3.Location = new System.Drawing.Point(203, 130);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(678, 67);
            this.lblAnswer3.TabIndex = 11;
            this.lblAnswer3.Text = "............";
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer4.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer4.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswer4.Location = new System.Drawing.Point(203, 197);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(678, 57);
            this.lblAnswer4.TabIndex = 13;
            this.lblAnswer4.Text = "............";
            // 
            // lblAnswer6
            // 
            this.lblAnswer6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer6.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer6.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer6.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswer6.Location = new System.Drawing.Point(203, 319);
            this.lblAnswer6.Name = "lblAnswer6";
            this.lblAnswer6.Size = new System.Drawing.Size(678, 67);
            this.lblAnswer6.TabIndex = 14;
            this.lblAnswer6.Text = "............";
            // 
            // lblAnswer5
            // 
            this.lblAnswer5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer5.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer5.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswer5.Location = new System.Drawing.Point(203, 254);
            this.lblAnswer5.Name = "lblAnswer5";
            this.lblAnswer5.Size = new System.Drawing.Size(678, 65);
            this.lblAnswer5.TabIndex = 15;
            this.lblAnswer5.Text = "............";
            // 
            // timerRight
            // 
            this.timerRight.Interval = 2050;
            this.timerRight.Tick += new System.EventHandler(this.showQuantity);
            // 
            // lblAnswerPts1
            // 
            this.lblAnswerPts1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerPts1.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerPts1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPts1.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswerPts1.Location = new System.Drawing.Point(887, 0);
            this.lblAnswerPts1.Name = "lblAnswerPts1";
            this.lblAnswerPts1.Size = new System.Drawing.Size(194, 65);
            this.lblAnswerPts1.TabIndex = 16;
            this.lblAnswerPts1.Text = "###";
            this.lblAnswerPts1.Visible = false;
            // 
            // lblAnswerPts6
            // 
            this.lblAnswerPts6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerPts6.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerPts6.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPts6.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswerPts6.Location = new System.Drawing.Point(887, 319);
            this.lblAnswerPts6.Name = "lblAnswerPts6";
            this.lblAnswerPts6.Size = new System.Drawing.Size(194, 67);
            this.lblAnswerPts6.TabIndex = 18;
            this.lblAnswerPts6.Text = "###";
            this.lblAnswerPts6.Visible = false;
            // 
            // lblAnswerPts5
            // 
            this.lblAnswerPts5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerPts5.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerPts5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPts5.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswerPts5.Location = new System.Drawing.Point(887, 254);
            this.lblAnswerPts5.Name = "lblAnswerPts5";
            this.lblAnswerPts5.Size = new System.Drawing.Size(194, 65);
            this.lblAnswerPts5.TabIndex = 19;
            this.lblAnswerPts5.Text = "###";
            this.lblAnswerPts5.Visible = false;
            // 
            // lblAnswerPts4
            // 
            this.lblAnswerPts4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerPts4.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerPts4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPts4.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswerPts4.Location = new System.Drawing.Point(887, 197);
            this.lblAnswerPts4.Name = "lblAnswerPts4";
            this.lblAnswerPts4.Size = new System.Drawing.Size(194, 57);
            this.lblAnswerPts4.TabIndex = 20;
            this.lblAnswerPts4.Text = "###";
            this.lblAnswerPts4.Visible = false;
            // 
            // lblAnswerPts3
            // 
            this.lblAnswerPts3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerPts3.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerPts3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPts3.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswerPts3.Location = new System.Drawing.Point(887, 130);
            this.lblAnswerPts3.Name = "lblAnswerPts3";
            this.lblAnswerPts3.Size = new System.Drawing.Size(194, 67);
            this.lblAnswerPts3.TabIndex = 21;
            this.lblAnswerPts3.Text = "###";
            this.lblAnswerPts3.Visible = false;
            // 
            // lblAnswerPts2
            // 
            this.lblAnswerPts2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerPts2.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerPts2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPts2.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswerPts2.Location = new System.Drawing.Point(887, 65);
            this.lblAnswerPts2.Name = "lblAnswerPts2";
            this.lblAnswerPts2.Size = new System.Drawing.Size(194, 65);
            this.lblAnswerPts2.TabIndex = 22;
            this.lblAnswerPts2.Text = "###";
            this.lblAnswerPts2.Visible = false;
            // 
            // timerAddPoints
            // 
            this.timerAddPoints.Interval = 5;
            this.timerAddPoints.Tick += new System.EventHandler(this.addPoints);
            // 
            // timerDelPoints
            // 
            this.timerDelPoints.Interval = 5;
            this.timerDelPoints.Tick += new System.EventHandler(this.delPoints);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1090, 594);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblTeam1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblPointsTeam1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblPointsTeam2, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblRoundPoints, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblTeam2, 4, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 549);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1084, 42);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerNo6, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswer1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerNo5, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerNo4, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerNo3, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerNo2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerNo1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerPts1, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswer6, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswer5, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerPts5, 2, 4);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswer4, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerPts4, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswer3, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerPts2, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswer2, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerPts3, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerPts6, 2, 5);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 157);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.89189F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.89189F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.56757F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.86486F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.89189F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.89189F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1084, 386);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // lblAnswerNo6
            // 
            this.lblAnswerNo6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerNo6.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerNo6.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerNo6.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswerNo6.Location = new System.Drawing.Point(3, 319);
            this.lblAnswerNo6.Name = "lblAnswerNo6";
            this.lblAnswerNo6.Size = new System.Drawing.Size(194, 67);
            this.lblAnswerNo6.TabIndex = 28;
            this.lblAnswerNo6.Text = "06.";
            this.lblAnswerNo6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAnswerNo5
            // 
            this.lblAnswerNo5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerNo5.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerNo5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerNo5.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswerNo5.Location = new System.Drawing.Point(3, 254);
            this.lblAnswerNo5.Name = "lblAnswerNo5";
            this.lblAnswerNo5.Size = new System.Drawing.Size(194, 65);
            this.lblAnswerNo5.TabIndex = 27;
            this.lblAnswerNo5.Text = "05.";
            this.lblAnswerNo5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAnswerNo4
            // 
            this.lblAnswerNo4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerNo4.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerNo4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerNo4.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswerNo4.Location = new System.Drawing.Point(3, 197);
            this.lblAnswerNo4.Name = "lblAnswerNo4";
            this.lblAnswerNo4.Size = new System.Drawing.Size(194, 57);
            this.lblAnswerNo4.TabIndex = 26;
            this.lblAnswerNo4.Text = "04.";
            this.lblAnswerNo4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAnswerNo3
            // 
            this.lblAnswerNo3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerNo3.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerNo3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerNo3.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswerNo3.Location = new System.Drawing.Point(3, 130);
            this.lblAnswerNo3.Name = "lblAnswerNo3";
            this.lblAnswerNo3.Size = new System.Drawing.Size(194, 67);
            this.lblAnswerNo3.TabIndex = 25;
            this.lblAnswerNo3.Text = "03.";
            this.lblAnswerNo3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAnswerNo2
            // 
            this.lblAnswerNo2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerNo2.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerNo2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerNo2.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswerNo2.Location = new System.Drawing.Point(3, 65);
            this.lblAnswerNo2.Name = "lblAnswerNo2";
            this.lblAnswerNo2.Size = new System.Drawing.Size(194, 65);
            this.lblAnswerNo2.TabIndex = 24;
            this.lblAnswerNo2.Text = "02.";
            this.lblAnswerNo2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAnswerNo1
            // 
            this.lblAnswerNo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerNo1.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerNo1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerNo1.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswerNo1.Location = new System.Drawing.Point(3, 0);
            this.lblAnswerNo1.Name = "lblAnswerNo1";
            this.lblAnswerNo1.Size = new System.Drawing.Size(194, 65);
            this.lblAnswerNo1.TabIndex = 23;
            this.lblAnswerNo1.Text = "01.";
            this.lblAnswerNo1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblQuestion, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1084, 148);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblPlayerBlue, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblPlayerRed, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 91);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1078, 54);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.lblWrong3, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblWrong1, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblWrong2, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(434, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(209, 48);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // lblWrong3
            // 
            this.lblWrong3.BackColor = System.Drawing.Color.Transparent;
            this.lblWrong3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWrong3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong3.ForeColor = System.Drawing.Color.Red;
            this.lblWrong3.Location = new System.Drawing.Point(141, 0);
            this.lblWrong3.Name = "lblWrong3";
            this.lblWrong3.Size = new System.Drawing.Size(65, 48);
            this.lblWrong3.TabIndex = 10;
            this.lblWrong3.Text = "X";
            this.lblWrong3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWrong3.Visible = false;
            // 
            // lblWrong1
            // 
            this.lblWrong1.BackColor = System.Drawing.Color.Transparent;
            this.lblWrong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWrong1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong1.ForeColor = System.Drawing.Color.Red;
            this.lblWrong1.Location = new System.Drawing.Point(72, 0);
            this.lblWrong1.Name = "lblWrong1";
            this.lblWrong1.Size = new System.Drawing.Size(63, 48);
            this.lblWrong1.TabIndex = 9;
            this.lblWrong1.Text = "X";
            this.lblWrong1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWrong1.Visible = false;
            // 
            // lblPlayerBlue
            // 
            this.lblPlayerBlue.AutoSize = true;
            this.lblPlayerBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayerBlue.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerBlue.Location = new System.Drawing.Point(3, 0);
            this.lblPlayerBlue.Name = "lblPlayerBlue";
            this.lblPlayerBlue.Size = new System.Drawing.Size(425, 54);
            this.lblPlayerBlue.TabIndex = 3;
            this.lblPlayerBlue.Text = "Spieler Blau";
            this.lblPlayerBlue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPlayerBlue.Visible = false;
            // 
            // lblPlayerRed
            // 
            this.lblPlayerRed.AutoSize = true;
            this.lblPlayerRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayerRed.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerRed.Location = new System.Drawing.Point(649, 0);
            this.lblPlayerRed.Name = "lblPlayerRed";
            this.lblPlayerRed.Size = new System.Drawing.Size(426, 54);
            this.lblPlayerRed.TabIndex = 4;
            this.lblPlayerRed.Text = "Spieler Rot";
            this.lblPlayerRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlayerRed.Visible = false;
            // 
            // resultWriter
            // 
            this.resultWriter.Tick += new System.EventHandler(this.resultWriter_Tick);
            // 
            // GameMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1090, 594);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 610);
            this.Name = "GameMonitor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPointsTeam1;
        private System.Windows.Forms.Label lblPointsTeam2;
        private System.Windows.Forms.Label lblRoundPoints;
        private System.Windows.Forms.Label lblWrong2;
        private System.Windows.Forms.Timer timerWrong;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.Label lblAnswer4;
        private System.Windows.Forms.Label lblAnswer6;
        private System.Windows.Forms.Label lblAnswer5;
        public System.Windows.Forms.Timer timerRight;
        private System.Windows.Forms.Label lblAnswerPts1;
        private System.Windows.Forms.Label lblAnswerPts6;
        private System.Windows.Forms.Label lblAnswerPts5;
        private System.Windows.Forms.Label lblAnswerPts4;
        private System.Windows.Forms.Label lblAnswerPts3;
        private System.Windows.Forms.Label lblAnswerPts2;
        private System.Windows.Forms.Timer timerAddPoints;
        private System.Windows.Forms.Timer timerDelPoints;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblAnswerNo6;
        private System.Windows.Forms.Label lblAnswerNo5;
        private System.Windows.Forms.Label lblAnswerNo4;
        private System.Windows.Forms.Label lblAnswerNo3;
        private System.Windows.Forms.Label lblAnswerNo2;
        private System.Windows.Forms.Label lblAnswerNo1;
        protected internal System.Windows.Forms.Label lblTeam1;
        protected internal System.Windows.Forms.Label lblTeam2;
        protected internal System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblWrong3;
        private System.Windows.Forms.Label lblWrong1;
        private System.Windows.Forms.Label lblPlayerBlue;
        private System.Windows.Forms.Label lblPlayerRed;
        private System.Windows.Forms.Timer resultWriter;
    }
}