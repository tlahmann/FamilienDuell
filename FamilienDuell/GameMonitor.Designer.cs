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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMonitor));
            this.timerWrong = new System.Windows.Forms.Timer(this.components);
            this.timerRight = new System.Windows.Forms.Timer(this.components);
            this.timerAddPoints = new System.Windows.Forms.Timer(this.components);
            this.timerDelPoints = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.lblPointsTeam2 = new System.Windows.Forms.Label();
            this.lblRoundPoints = new System.Windows.Forms.Label();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.lblPointsTeam1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAnswerNo6 = new System.Windows.Forms.Label();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswerNo5 = new System.Windows.Forms.Label();
            this.lblAnswerNo4 = new System.Windows.Forms.Label();
            this.lblAnswerNo3 = new System.Windows.Forms.Label();
            this.lblAnswerNo2 = new System.Windows.Forms.Label();
            this.lblAnswerPts1 = new System.Windows.Forms.Label();
            this.lblAnswer6 = new System.Windows.Forms.Label();
            this.lblAnswer5 = new System.Windows.Forms.Label();
            this.lblAnswerPts5 = new System.Windows.Forms.Label();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.lblAnswerPts4 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblAnswerPts2 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswerPts3 = new System.Windows.Forms.Label();
            this.lblAnswerPts6 = new System.Windows.Forms.Label();
            this.lblAnswerNo1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWrong1 = new System.Windows.Forms.PictureBox();
            this.lblWrong2 = new System.Windows.Forms.PictureBox();
            this.lblWrong3 = new System.Windows.Forms.PictureBox();
            this.lblPlayerBlue = new System.Windows.Forms.Label();
            this.lblPlayerRed = new System.Windows.Forms.Label();
            this.resultWriter = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblWrong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblWrong2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblWrong3)).BeginInit();
            this.SuspendLayout();
            // 
            // timerWrong
            // 
            this.timerWrong.Interval = 1050;
            this.timerWrong.Tick += new System.EventHandler(this.toggleWrong);
            // 
            // timerRight
            // 
            this.timerRight.Interval = 2050;
            this.timerRight.Tick += new System.EventHandler(this.showQuantity);
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
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1335, 918);
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
            this.tableLayoutPanel3.Controls.Add(this.lblPointsTeam2, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblRoundPoints, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblTeam2, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblPointsTeam1, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 816);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1319, 94);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lblTeam1
            // 
            this.lblTeam1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeam1.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1.ForeColor = System.Drawing.Color.Black;
            this.lblTeam1.Image = ((System.Drawing.Image)(resources.GetObject("lblTeam1.Image")));
            this.lblTeam1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTeam1.Location = new System.Drawing.Point(3, 0);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblTeam1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTeam1.Size = new System.Drawing.Size(353, 94);
            this.lblTeam1.TabIndex = 2;
            this.lblTeam1.Text = "Team Blau";
            this.lblTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPointsTeam2
            // 
            this.lblPointsTeam2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPointsTeam2.BackColor = System.Drawing.Color.Transparent;
            this.lblPointsTeam2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsTeam2.ForeColor = System.Drawing.Color.Black;
            this.lblPointsTeam2.Image = ((System.Drawing.Image)(resources.GetObject("lblPointsTeam2.Image")));
            this.lblPointsTeam2.Location = new System.Drawing.Point(762, 0);
            this.lblPointsTeam2.Name = "lblPointsTeam2";
            this.lblPointsTeam2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPointsTeam2.Size = new System.Drawing.Size(194, 94);
            this.lblPointsTeam2.TabIndex = 4;
            this.lblPointsTeam2.Text = "0";
            this.lblPointsTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoundPoints
            // 
            this.lblRoundPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoundPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundPoints.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundPoints.ForeColor = System.Drawing.Color.Black;
            this.lblRoundPoints.Image = ((System.Drawing.Image)(resources.GetObject("lblRoundPoints.Image")));
            this.lblRoundPoints.Location = new System.Drawing.Point(562, 0);
            this.lblRoundPoints.Name = "lblRoundPoints";
            this.lblRoundPoints.Size = new System.Drawing.Size(194, 94);
            this.lblRoundPoints.TabIndex = 6;
            this.lblRoundPoints.Text = "0";
            this.lblRoundPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeam2
            // 
            this.lblTeam2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeam2.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2.ForeColor = System.Drawing.Color.Black;
            this.lblTeam2.Image = ((System.Drawing.Image)(resources.GetObject("lblTeam2.Image")));
            this.lblTeam2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTeam2.Location = new System.Drawing.Point(962, 0);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTeam2.Size = new System.Drawing.Size(354, 94);
            this.lblTeam2.TabIndex = 5;
            this.lblTeam2.Text = "Team Rot";
            this.lblTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPointsTeam1
            // 
            this.lblPointsTeam1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPointsTeam1.BackColor = System.Drawing.Color.Transparent;
            this.lblPointsTeam1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsTeam1.ForeColor = System.Drawing.Color.Black;
            this.lblPointsTeam1.Image = ((System.Drawing.Image)(resources.GetObject("lblPointsTeam1.Image")));
            this.lblPointsTeam1.Location = new System.Drawing.Point(362, 0);
            this.lblPointsTeam1.Name = "lblPointsTeam1";
            this.lblPointsTeam1.Size = new System.Drawing.Size(194, 94);
            this.lblPointsTeam1.TabIndex = 3;
            this.lblPointsTeam1.Text = "0";
            this.lblPointsTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerNo6, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswer1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerNo5, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerNo4, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerNo3, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerNo2, 0, 1);
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
            this.tableLayoutPanel5.Controls.Add(this.lblAnswerNo1, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(8, 273);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1319, 537);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // lblAnswerNo6
            // 
            this.lblAnswerNo6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerNo6.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerNo6.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerNo6.ForeColor = System.Drawing.Color.Black;
            this.lblAnswerNo6.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswerNo6.Image")));
            this.lblAnswerNo6.Location = new System.Drawing.Point(0, 445);
            this.lblAnswerNo6.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswerNo6.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswerNo6.Name = "lblAnswerNo6";
            this.lblAnswerNo6.Size = new System.Drawing.Size(200, 100);
            this.lblAnswerNo6.TabIndex = 28;
            this.lblAnswerNo6.Text = "06.";
            this.lblAnswerNo6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer1.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer1.ForeColor = System.Drawing.Color.Black;
            this.lblAnswer1.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswer1.Image")));
            this.lblAnswer1.Location = new System.Drawing.Point(200, 0);
            this.lblAnswer1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblAnswer1.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(919, 100);
            this.lblAnswer1.TabIndex = 9;
            this.lblAnswer1.Text = "............";
            this.lblAnswer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswerNo5
            // 
            this.lblAnswerNo5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerNo5.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerNo5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerNo5.ForeColor = System.Drawing.Color.Black;
            this.lblAnswerNo5.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswerNo5.Image")));
            this.lblAnswerNo5.Location = new System.Drawing.Point(0, 356);
            this.lblAnswerNo5.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswerNo5.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswerNo5.Name = "lblAnswerNo5";
            this.lblAnswerNo5.Size = new System.Drawing.Size(200, 100);
            this.lblAnswerNo5.TabIndex = 27;
            this.lblAnswerNo5.Text = "05.";
            this.lblAnswerNo5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswerNo4
            // 
            this.lblAnswerNo4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerNo4.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerNo4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerNo4.ForeColor = System.Drawing.Color.Black;
            this.lblAnswerNo4.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswerNo4.Image")));
            this.lblAnswerNo4.Location = new System.Drawing.Point(0, 267);
            this.lblAnswerNo4.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswerNo4.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswerNo4.Name = "lblAnswerNo4";
            this.lblAnswerNo4.Size = new System.Drawing.Size(200, 100);
            this.lblAnswerNo4.TabIndex = 26;
            this.lblAnswerNo4.Text = "04.";
            this.lblAnswerNo4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswerNo3
            // 
            this.lblAnswerNo3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerNo3.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerNo3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerNo3.ForeColor = System.Drawing.Color.Black;
            this.lblAnswerNo3.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswerNo3.Image")));
            this.lblAnswerNo3.Location = new System.Drawing.Point(0, 178);
            this.lblAnswerNo3.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswerNo3.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswerNo3.Name = "lblAnswerNo3";
            this.lblAnswerNo3.Size = new System.Drawing.Size(200, 100);
            this.lblAnswerNo3.TabIndex = 25;
            this.lblAnswerNo3.Text = "03.";
            this.lblAnswerNo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswerNo2
            // 
            this.lblAnswerNo2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerNo2.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerNo2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerNo2.ForeColor = System.Drawing.Color.Black;
            this.lblAnswerNo2.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswerNo2.Image")));
            this.lblAnswerNo2.Location = new System.Drawing.Point(0, 89);
            this.lblAnswerNo2.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswerNo2.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswerNo2.Name = "lblAnswerNo2";
            this.lblAnswerNo2.Size = new System.Drawing.Size(200, 100);
            this.lblAnswerNo2.TabIndex = 24;
            this.lblAnswerNo2.Text = "02.";
            this.lblAnswerNo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswerPts1
            // 
            this.lblAnswerPts1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerPts1.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerPts1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPts1.ForeColor = System.Drawing.Color.Black;
            this.lblAnswerPts1.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswerPts1.Image")));
            this.lblAnswerPts1.Location = new System.Drawing.Point(1119, 0);
            this.lblAnswerPts1.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswerPts1.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswerPts1.Name = "lblAnswerPts1";
            this.lblAnswerPts1.Size = new System.Drawing.Size(200, 100);
            this.lblAnswerPts1.TabIndex = 16;
            this.lblAnswerPts1.Text = "###";
            this.lblAnswerPts1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswerPts1.Visible = false;
            // 
            // lblAnswer6
            // 
            this.lblAnswer6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer6.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer6.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer6.ForeColor = System.Drawing.Color.Black;
            this.lblAnswer6.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswer6.Image")));
            this.lblAnswer6.Location = new System.Drawing.Point(200, 445);
            this.lblAnswer6.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswer6.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswer6.Name = "lblAnswer6";
            this.lblAnswer6.Size = new System.Drawing.Size(919, 100);
            this.lblAnswer6.TabIndex = 14;
            this.lblAnswer6.Text = "............";
            this.lblAnswer6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswer5
            // 
            this.lblAnswer5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer5.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer5.ForeColor = System.Drawing.Color.Black;
            this.lblAnswer5.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswer5.Image")));
            this.lblAnswer5.Location = new System.Drawing.Point(200, 356);
            this.lblAnswer5.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswer5.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswer5.Name = "lblAnswer5";
            this.lblAnswer5.Size = new System.Drawing.Size(919, 100);
            this.lblAnswer5.TabIndex = 15;
            this.lblAnswer5.Text = "............";
            this.lblAnswer5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswerPts5
            // 
            this.lblAnswerPts5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerPts5.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerPts5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPts5.ForeColor = System.Drawing.Color.Black;
            this.lblAnswerPts5.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswerPts5.Image")));
            this.lblAnswerPts5.Location = new System.Drawing.Point(1119, 356);
            this.lblAnswerPts5.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswerPts5.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswerPts5.Name = "lblAnswerPts5";
            this.lblAnswerPts5.Size = new System.Drawing.Size(200, 100);
            this.lblAnswerPts5.TabIndex = 19;
            this.lblAnswerPts5.Text = "###";
            this.lblAnswerPts5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswerPts5.Visible = false;
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer4.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer4.ForeColor = System.Drawing.Color.Black;
            this.lblAnswer4.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswer4.Image")));
            this.lblAnswer4.Location = new System.Drawing.Point(200, 267);
            this.lblAnswer4.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswer4.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(919, 100);
            this.lblAnswer4.TabIndex = 13;
            this.lblAnswer4.Text = "............";
            this.lblAnswer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswerPts4
            // 
            this.lblAnswerPts4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerPts4.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerPts4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPts4.ForeColor = System.Drawing.Color.Black;
            this.lblAnswerPts4.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswerPts4.Image")));
            this.lblAnswerPts4.Location = new System.Drawing.Point(1119, 267);
            this.lblAnswerPts4.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswerPts4.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswerPts4.Name = "lblAnswerPts4";
            this.lblAnswerPts4.Size = new System.Drawing.Size(200, 100);
            this.lblAnswerPts4.TabIndex = 20;
            this.lblAnswerPts4.Text = "###";
            this.lblAnswerPts4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswerPts4.Visible = false;
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer3.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer3.ForeColor = System.Drawing.Color.Black;
            this.lblAnswer3.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswer3.Image")));
            this.lblAnswer3.Location = new System.Drawing.Point(200, 178);
            this.lblAnswer3.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswer3.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(919, 100);
            this.lblAnswer3.TabIndex = 11;
            this.lblAnswer3.Text = "............";
            this.lblAnswer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswerPts2
            // 
            this.lblAnswerPts2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerPts2.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerPts2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPts2.ForeColor = System.Drawing.Color.Black;
            this.lblAnswerPts2.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswerPts2.Image")));
            this.lblAnswerPts2.Location = new System.Drawing.Point(1119, 89);
            this.lblAnswerPts2.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswerPts2.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswerPts2.Name = "lblAnswerPts2";
            this.lblAnswerPts2.Size = new System.Drawing.Size(200, 100);
            this.lblAnswerPts2.TabIndex = 22;
            this.lblAnswerPts2.Text = "###";
            this.lblAnswerPts2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswerPts2.Visible = false;
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer2.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer2.ForeColor = System.Drawing.Color.Black;
            this.lblAnswer2.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswer2.Image")));
            this.lblAnswer2.Location = new System.Drawing.Point(200, 89);
            this.lblAnswer2.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswer2.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(919, 100);
            this.lblAnswer2.TabIndex = 10;
            this.lblAnswer2.Text = "............";
            this.lblAnswer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswerPts3
            // 
            this.lblAnswerPts3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerPts3.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerPts3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPts3.ForeColor = System.Drawing.Color.Black;
            this.lblAnswerPts3.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswerPts3.Image")));
            this.lblAnswerPts3.Location = new System.Drawing.Point(1119, 178);
            this.lblAnswerPts3.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswerPts3.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswerPts3.Name = "lblAnswerPts3";
            this.lblAnswerPts3.Size = new System.Drawing.Size(200, 100);
            this.lblAnswerPts3.TabIndex = 21;
            this.lblAnswerPts3.Text = "###";
            this.lblAnswerPts3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswerPts3.Visible = false;
            // 
            // lblAnswerPts6
            // 
            this.lblAnswerPts6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerPts6.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerPts6.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPts6.ForeColor = System.Drawing.Color.Black;
            this.lblAnswerPts6.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswerPts6.Image")));
            this.lblAnswerPts6.Location = new System.Drawing.Point(1119, 445);
            this.lblAnswerPts6.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswerPts6.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswerPts6.Name = "lblAnswerPts6";
            this.lblAnswerPts6.Size = new System.Drawing.Size(200, 100);
            this.lblAnswerPts6.TabIndex = 18;
            this.lblAnswerPts6.Text = "###";
            this.lblAnswerPts6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswerPts6.Visible = false;
            // 
            // lblAnswerNo1
            // 
            this.lblAnswerNo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerNo1.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswerNo1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerNo1.ForeColor = System.Drawing.Color.Black;
            this.lblAnswerNo1.Image = ((System.Drawing.Image)(resources.GetObject("lblAnswerNo1.Image")));
            this.lblAnswerNo1.Location = new System.Drawing.Point(0, 0);
            this.lblAnswerNo1.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswerNo1.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblAnswerNo1.Name = "lblAnswerNo1";
            this.lblAnswerNo1.Size = new System.Drawing.Size(200, 100);
            this.lblAnswerNo1.TabIndex = 23;
            this.lblAnswerNo1.Text = "01.";
            this.lblAnswerNo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1319, 259);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Black;
            this.lblQuestion.Image = ((System.Drawing.Image)(resources.GetObject("lblQuestion.Image")));
            this.lblQuestion.Location = new System.Drawing.Point(4, 0);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(1311, 155);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "DefaultGameName";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblPlayerBlue, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblPlayerRed, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 158);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1313, 104);
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
            this.tableLayoutPanel6.Controls.Add(this.lblWrong1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblWrong2, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblWrong3, 2, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(406, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(500, 104);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // lblWrong1
            // 
            this.lblWrong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWrong1.Image = global::FamilienDuell.Properties.Resources.wrong;
            this.lblWrong1.InitialImage = global::FamilienDuell.Properties.Resources.wrong;
            this.lblWrong1.Location = new System.Drawing.Point(0, 0);
            this.lblWrong1.Margin = new System.Windows.Forms.Padding(0);
            this.lblWrong1.Name = "lblWrong1";
            this.lblWrong1.Size = new System.Drawing.Size(166, 104);
            this.lblWrong1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lblWrong1.TabIndex = 0;
            this.lblWrong1.TabStop = false;
            // 
            // lblWrong2
            // 
            this.lblWrong2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWrong2.Image = global::FamilienDuell.Properties.Resources.wrong;
            this.lblWrong2.InitialImage = global::FamilienDuell.Properties.Resources.wrong;
            this.lblWrong2.Location = new System.Drawing.Point(166, 0);
            this.lblWrong2.Margin = new System.Windows.Forms.Padding(0);
            this.lblWrong2.Name = "lblWrong2";
            this.lblWrong2.Size = new System.Drawing.Size(166, 104);
            this.lblWrong2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lblWrong2.TabIndex = 1;
            this.lblWrong2.TabStop = false;
            // 
            // lblWrong3
            // 
            this.lblWrong3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWrong3.Image = global::FamilienDuell.Properties.Resources.wrong;
            this.lblWrong3.InitialImage = global::FamilienDuell.Properties.Resources.wrong;
            this.lblWrong3.Location = new System.Drawing.Point(332, 0);
            this.lblWrong3.Margin = new System.Windows.Forms.Padding(0);
            this.lblWrong3.Name = "lblWrong3";
            this.lblWrong3.Size = new System.Drawing.Size(168, 104);
            this.lblWrong3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lblWrong3.TabIndex = 2;
            this.lblWrong3.TabStop = false;
            // 
            // lblPlayerBlue
            // 
            this.lblPlayerBlue.AutoSize = true;
            this.lblPlayerBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayerBlue.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerBlue.Location = new System.Drawing.Point(3, 0);
            this.lblPlayerBlue.Name = "lblPlayerBlue";
            this.lblPlayerBlue.Size = new System.Drawing.Size(400, 104);
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
            this.lblPlayerRed.Location = new System.Drawing.Point(909, 0);
            this.lblPlayerRed.Name = "lblPlayerRed";
            this.lblPlayerRed.Size = new System.Drawing.Size(401, 104);
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
            this.ClientSize = new System.Drawing.Size(1335, 918);
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
            ((System.ComponentModel.ISupportInitialize)(this.lblWrong1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblWrong2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblWrong3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPointsTeam1;
        private System.Windows.Forms.Label lblPointsTeam2;
        private System.Windows.Forms.Label lblRoundPoints;
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
        private System.Windows.Forms.Label lblPlayerBlue;
        private System.Windows.Forms.Label lblPlayerRed;
        private System.Windows.Forms.Timer resultWriter;
        private System.Windows.Forms.PictureBox lblWrong1;
        private System.Windows.Forms.PictureBox lblWrong2;
        private System.Windows.Forms.PictureBox lblWrong3;
    }
}