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
            this.lblHeadline = new System.Windows.Forms.Label();
            this.imgWaiting = new System.Windows.Forms.PictureBox();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.lblPointsTeam1 = new System.Windows.Forms.Label();
            this.lblPointsTeam2 = new System.Windows.Forms.Label();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.lblRoundPoints = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.timerWrong = new System.Windows.Forms.Timer(this.components);
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.lblAnswer6 = new System.Windows.Forms.Label();
            this.lblAnswer5 = new System.Windows.Forms.Label();
            this.timerRight = new System.Windows.Forms.Timer(this.components);
            this.lblAnswers1 = new System.Windows.Forms.Label();
            this.lblAnswers6 = new System.Windows.Forms.Label();
            this.lblAnswers5 = new System.Windows.Forms.Label();
            this.lblAnswers4 = new System.Windows.Forms.Label();
            this.lblAnswers3 = new System.Windows.Forms.Label();
            this.lblAnswers2 = new System.Windows.Forms.Label();
            this.timerAddPoints = new System.Windows.Forms.Timer(this.components);
            this.timerDelPoints = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgWaiting)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadline
            // 
            this.lblHeadline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeadline.BackColor = System.Drawing.Color.Transparent;
            this.lblHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadline.ForeColor = System.Drawing.Color.Blue;
            this.lblHeadline.Location = new System.Drawing.Point(-6, -1);
            this.lblHeadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(1264, 96);
            this.lblHeadline.TabIndex = 0;
            this.lblHeadline.Text = "Scale to right monitor!";
            this.lblHeadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgWaiting
            // 
            this.imgWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgWaiting.BackColor = System.Drawing.Color.Transparent;
            this.imgWaiting.Image = ((System.Drawing.Image)(resources.GetObject("imgWaiting.Image")));
            this.imgWaiting.Location = new System.Drawing.Point(751, 142);
            this.imgWaiting.Name = "imgWaiting";
            this.imgWaiting.Size = new System.Drawing.Size(520, 20);
            this.imgWaiting.TabIndex = 1;
            this.imgWaiting.TabStop = false;
            this.imgWaiting.Visible = false;
            // 
            // lblTeam1
            // 
            this.lblTeam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTeam1.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1.ForeColor = System.Drawing.Color.Green;
            this.lblTeam1.Location = new System.Drawing.Point(12, 672);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTeam1.Size = new System.Drawing.Size(353, 37);
            this.lblTeam1.TabIndex = 2;
            this.lblTeam1.Text = "Uwes Zuhause ASD";
            this.lblTeam1.Visible = false;
            // 
            // lblPointsTeam1
            // 
            this.lblPointsTeam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPointsTeam1.AutoSize = true;
            this.lblPointsTeam1.BackColor = System.Drawing.Color.Transparent;
            this.lblPointsTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsTeam1.Location = new System.Drawing.Point(371, 674);
            this.lblPointsTeam1.Name = "lblPointsTeam1";
            this.lblPointsTeam1.Size = new System.Drawing.Size(36, 39);
            this.lblPointsTeam1.TabIndex = 3;
            this.lblPointsTeam1.Text = "0";
            this.lblPointsTeam1.Visible = false;
            // 
            // lblPointsTeam2
            // 
            this.lblPointsTeam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPointsTeam2.BackColor = System.Drawing.Color.Transparent;
            this.lblPointsTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsTeam2.Location = new System.Drawing.Point(783, 671);
            this.lblPointsTeam2.Name = "lblPointsTeam2";
            this.lblPointsTeam2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPointsTeam2.Size = new System.Drawing.Size(115, 35);
            this.lblPointsTeam2.TabIndex = 4;
            this.lblPointsTeam2.Text = "0";
            this.lblPointsTeam2.Visible = false;
            // 
            // lblTeam2
            // 
            this.lblTeam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTeam2.Location = new System.Drawing.Point(899, 673);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(327, 39);
            this.lblTeam2.TabIndex = 5;
            this.lblTeam2.Text = "Uwes Zuhause ASD";
            this.lblTeam2.Visible = false;
            // 
            // lblRoundPoints
            // 
            this.lblRoundPoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoundPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundPoints.ForeColor = System.Drawing.Color.Maroon;
            this.lblRoundPoints.Location = new System.Drawing.Point(561, 673);
            this.lblRoundPoints.Name = "lblRoundPoints";
            this.lblRoundPoints.Size = new System.Drawing.Size(127, 39);
            this.lblRoundPoints.TabIndex = 6;
            this.lblRoundPoints.Text = "0";
            this.lblRoundPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRoundPoints.Visible = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.ForeColor = System.Drawing.Color.Yellow;
            this.lblQuestion.Location = new System.Drawing.Point(6, 95);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(1240, 25);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "Come in and find out!";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWrong
            // 
            this.lblWrong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWrong.BackColor = System.Drawing.Color.Transparent;
            this.lblWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong.ForeColor = System.Drawing.Color.Red;
            this.lblWrong.Location = new System.Drawing.Point(-5, 162);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(1264, 99);
            this.lblWrong.TabIndex = 8;
            this.lblWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWrong.Visible = false;
            // 
            // timerWrong
            // 
            this.timerWrong.Interval = 1050;
            this.timerWrong.Tick += new System.EventHandler(this.toggleWrong);
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer1.Font = new System.Drawing.Font("ISOCTEUR", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer1.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswer1.Location = new System.Drawing.Point(219, 326);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(878, 31);
            this.lblAnswer1.TabIndex = 9;
            this.lblAnswer1.Text = "................................................";
            this.lblAnswer1.Visible = false;
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer2.Font = new System.Drawing.Font("ISOCTEUR", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer2.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswer2.Location = new System.Drawing.Point(219, 360);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(878, 31);
            this.lblAnswer2.TabIndex = 10;
            this.lblAnswer2.Text = "................................................";
            this.lblAnswer2.Visible = false;
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer3.Font = new System.Drawing.Font("ISOCTEUR", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer3.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswer3.Location = new System.Drawing.Point(219, 398);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(878, 31);
            this.lblAnswer3.TabIndex = 11;
            this.lblAnswer3.Text = "................................................";
            this.lblAnswer3.Visible = false;
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer4.AutoSize = true;
            this.lblAnswer4.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer4.Font = new System.Drawing.Font("ISOCTEUR", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer4.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswer4.Location = new System.Drawing.Point(219, 434);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(878, 31);
            this.lblAnswer4.TabIndex = 13;
            this.lblAnswer4.Text = "................................................";
            this.lblAnswer4.Visible = false;
            // 
            // lblAnswer6
            // 
            this.lblAnswer6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer6.AutoSize = true;
            this.lblAnswer6.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer6.Font = new System.Drawing.Font("ISOCTEUR", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer6.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswer6.Location = new System.Drawing.Point(219, 513);
            this.lblAnswer6.Name = "lblAnswer6";
            this.lblAnswer6.Size = new System.Drawing.Size(878, 31);
            this.lblAnswer6.TabIndex = 14;
            this.lblAnswer6.Text = "................................................";
            this.lblAnswer6.Visible = false;
            // 
            // lblAnswer5
            // 
            this.lblAnswer5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer5.AutoSize = true;
            this.lblAnswer5.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer5.Font = new System.Drawing.Font("ISOCTEUR", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer5.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswer5.Location = new System.Drawing.Point(219, 472);
            this.lblAnswer5.Name = "lblAnswer5";
            this.lblAnswer5.Size = new System.Drawing.Size(878, 31);
            this.lblAnswer5.TabIndex = 15;
            this.lblAnswer5.Text = "................................................";
            this.lblAnswer5.Visible = false;
            // 
            // timerRight
            // 
            this.timerRight.Interval = 2050;
            this.timerRight.Tick += new System.EventHandler(this.showQuantity);
            // 
            // lblAnswers1
            // 
            this.lblAnswers1.AutoSize = true;
            this.lblAnswers1.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswers1.Font = new System.Drawing.Font("ISOCTEUR", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswers1.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswers1.Location = new System.Drawing.Point(943, 326);
            this.lblAnswers1.Name = "lblAnswers1";
            this.lblAnswers1.Size = new System.Drawing.Size(50, 31);
            this.lblAnswers1.TabIndex = 16;
            this.lblAnswers1.Text = "..";
            this.lblAnswers1.Visible = false;
            // 
            // lblAnswers6
            // 
            this.lblAnswers6.AutoSize = true;
            this.lblAnswers6.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswers6.Font = new System.Drawing.Font("ISOCTEUR", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswers6.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswers6.Location = new System.Drawing.Point(943, 513);
            this.lblAnswers6.Name = "lblAnswers6";
            this.lblAnswers6.Size = new System.Drawing.Size(50, 31);
            this.lblAnswers6.TabIndex = 18;
            this.lblAnswers6.Text = "..";
            this.lblAnswers6.Visible = false;
            // 
            // lblAnswers5
            // 
            this.lblAnswers5.AutoSize = true;
            this.lblAnswers5.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswers5.Font = new System.Drawing.Font("ISOCTEUR", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswers5.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswers5.Location = new System.Drawing.Point(943, 472);
            this.lblAnswers5.Name = "lblAnswers5";
            this.lblAnswers5.Size = new System.Drawing.Size(50, 31);
            this.lblAnswers5.TabIndex = 19;
            this.lblAnswers5.Text = "..";
            this.lblAnswers5.Visible = false;
            // 
            // lblAnswers4
            // 
            this.lblAnswers4.AutoSize = true;
            this.lblAnswers4.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswers4.Font = new System.Drawing.Font("ISOCTEUR", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswers4.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswers4.Location = new System.Drawing.Point(943, 434);
            this.lblAnswers4.Name = "lblAnswers4";
            this.lblAnswers4.Size = new System.Drawing.Size(50, 31);
            this.lblAnswers4.TabIndex = 20;
            this.lblAnswers4.Text = "..";
            this.lblAnswers4.Visible = false;
            // 
            // lblAnswers3
            // 
            this.lblAnswers3.AutoSize = true;
            this.lblAnswers3.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswers3.Font = new System.Drawing.Font("ISOCTEUR", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswers3.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswers3.Location = new System.Drawing.Point(943, 398);
            this.lblAnswers3.Name = "lblAnswers3";
            this.lblAnswers3.Size = new System.Drawing.Size(50, 31);
            this.lblAnswers3.TabIndex = 21;
            this.lblAnswers3.Text = "..";
            this.lblAnswers3.Visible = false;
            // 
            // lblAnswers2
            // 
            this.lblAnswers2.AutoSize = true;
            this.lblAnswers2.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswers2.Font = new System.Drawing.Font("ISOCTEUR", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswers2.ForeColor = System.Drawing.Color.Lime;
            this.lblAnswers2.Location = new System.Drawing.Point(943, 360);
            this.lblAnswers2.Name = "lblAnswers2";
            this.lblAnswers2.Size = new System.Drawing.Size(50, 31);
            this.lblAnswers2.TabIndex = 22;
            this.lblAnswers2.Text = "..";
            this.lblAnswers2.Visible = false;
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
            // GameMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 764);
            this.Controls.Add(this.lblAnswers2);
            this.Controls.Add(this.lblAnswers3);
            this.Controls.Add(this.lblAnswers4);
            this.Controls.Add(this.lblAnswers5);
            this.Controls.Add(this.lblAnswers6);
            this.Controls.Add(this.lblAnswers1);
            this.Controls.Add(this.lblAnswer5);
            this.Controls.Add(this.lblAnswer6);
            this.Controls.Add(this.lblAnswer4);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblRoundPoints);
            this.Controls.Add(this.lblTeam2);
            this.Controls.Add(this.lblPointsTeam2);
            this.Controls.Add(this.lblPointsTeam1);
            this.Controls.Add(this.lblTeam1);
            this.Controls.Add(this.imgWaiting);
            this.Controls.Add(this.lblHeadline);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "GameMonitor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.imgWaiting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.PictureBox imgWaiting;
        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.Label lblPointsTeam1;
        private System.Windows.Forms.Label lblPointsTeam2;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.Label lblRoundPoints;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Timer timerWrong;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.Label lblAnswer4;
        private System.Windows.Forms.Label lblAnswer6;
        private System.Windows.Forms.Label lblAnswer5;
        public System.Windows.Forms.Timer timerRight;
        private System.Windows.Forms.Label lblAnswers1;
        private System.Windows.Forms.Label lblAnswers6;
        private System.Windows.Forms.Label lblAnswers5;
        private System.Windows.Forms.Label lblAnswers4;
        private System.Windows.Forms.Label lblAnswers3;
        private System.Windows.Forms.Label lblAnswers2;
        private System.Windows.Forms.Timer timerAddPoints;
        private System.Windows.Forms.Timer timerDelPoints;
    }
}