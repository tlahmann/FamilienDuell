namespace FamilienDuell
{
    partial class ChangePoints
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPoints = new System.Windows.Forms.TextBox();
            this.btnTm1 = new System.Windows.Forms.Button();
            this.btnTm2 = new System.Windows.Forms.Button();
            this.btnPlus1 = new System.Windows.Forms.Button();
            this.btnPlus2 = new System.Windows.Forms.Button();
            this.btnMinus1 = new System.Windows.Forms.Button();
            this.btnMinus2 = new System.Windows.Forms.Button();
            this.btnPlus3 = new System.Windows.Forms.Button();
            this.btnMinus3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRound = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPoints
            // 
            this.tbPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.tbPoints.Location = new System.Drawing.Point(14, 12);
            this.tbPoints.Name = "tbPoints";
            this.tbPoints.Size = new System.Drawing.Size(155, 31);
            this.tbPoints.TabIndex = 0;
            this.tbPoints.Text = "0";
            this.tbPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTm1
            // 
            this.btnTm1.Location = new System.Drawing.Point(14, 154);
            this.btnTm1.Name = "btnTm1";
            this.btnTm1.Size = new System.Drawing.Size(46, 23);
            this.btnTm1.TabIndex = 1;
            this.btnTm1.Text = "T1";
            this.btnTm1.UseVisualStyleBackColor = true;
            this.btnTm1.Click += new System.EventHandler(this.btnTm1_Click);
            // 
            // btnTm2
            // 
            this.btnTm2.Location = new System.Drawing.Point(67, 154);
            this.btnTm2.Name = "btnTm2";
            this.btnTm2.Size = new System.Drawing.Size(49, 23);
            this.btnTm2.TabIndex = 2;
            this.btnTm2.Text = "T2";
            this.btnTm2.UseVisualStyleBackColor = true;
            this.btnTm2.Click += new System.EventHandler(this.btnTm2_Click);
            // 
            // btnPlus1
            // 
            this.btnPlus1.Location = new System.Drawing.Point(14, 51);
            this.btnPlus1.Name = "btnPlus1";
            this.btnPlus1.Size = new System.Drawing.Size(75, 23);
            this.btnPlus1.TabIndex = 3;
            this.btnPlus1.Text = "+ 1";
            this.btnPlus1.UseVisualStyleBackColor = true;
            this.btnPlus1.Click += new System.EventHandler(this.btnPlus1_Click);
            // 
            // btnPlus2
            // 
            this.btnPlus2.Location = new System.Drawing.Point(14, 80);
            this.btnPlus2.Name = "btnPlus2";
            this.btnPlus2.Size = new System.Drawing.Size(75, 23);
            this.btnPlus2.TabIndex = 4;
            this.btnPlus2.Text = "+ 5";
            this.btnPlus2.UseVisualStyleBackColor = true;
            this.btnPlus2.Click += new System.EventHandler(this.btnPlus2_Click);
            // 
            // btnMinus1
            // 
            this.btnMinus1.Location = new System.Drawing.Point(94, 51);
            this.btnMinus1.Name = "btnMinus1";
            this.btnMinus1.Size = new System.Drawing.Size(75, 23);
            this.btnMinus1.TabIndex = 5;
            this.btnMinus1.Text = "- 1";
            this.btnMinus1.UseVisualStyleBackColor = true;
            this.btnMinus1.Click += new System.EventHandler(this.btnMinus1_Click);
            // 
            // btnMinus2
            // 
            this.btnMinus2.Location = new System.Drawing.Point(94, 80);
            this.btnMinus2.Name = "btnMinus2";
            this.btnMinus2.Size = new System.Drawing.Size(75, 23);
            this.btnMinus2.TabIndex = 6;
            this.btnMinus2.Text = "- 5";
            this.btnMinus2.UseVisualStyleBackColor = true;
            this.btnMinus2.Click += new System.EventHandler(this.btnMinus2_Click);
            // 
            // btnPlus3
            // 
            this.btnPlus3.Location = new System.Drawing.Point(14, 109);
            this.btnPlus3.Name = "btnPlus3";
            this.btnPlus3.Size = new System.Drawing.Size(75, 23);
            this.btnPlus3.TabIndex = 7;
            this.btnPlus3.Text = "+ 10";
            this.btnPlus3.UseVisualStyleBackColor = true;
            this.btnPlus3.Click += new System.EventHandler(this.btnPlus3_Click);
            // 
            // btnMinus3
            // 
            this.btnMinus3.Location = new System.Drawing.Point(94, 109);
            this.btnMinus3.Name = "btnMinus3";
            this.btnMinus3.Size = new System.Drawing.Size(75, 23);
            this.btnMinus3.TabIndex = 8;
            this.btnMinus3.Text = "- 10";
            this.btnMinus3.UseVisualStyleBackColor = true;
            this.btnMinus3.Click += new System.EventHandler(this.btnMinus3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(95, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Addieren";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddTo_Click);
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(122, 154);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(47, 23);
            this.btnRound.TabIndex = 10;
            this.btnRound.Text = "RND";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(14, 183);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(73, 23);
            this.btnSet.TabIndex = 11;
            this.btnSet.Text = "Setzen";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // ChangePoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 218);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMinus3);
            this.Controls.Add(this.btnPlus3);
            this.Controls.Add(this.btnMinus2);
            this.Controls.Add(this.btnMinus1);
            this.Controls.Add(this.btnPlus2);
            this.Controls.Add(this.btnPlus1);
            this.Controls.Add(this.btnTm2);
            this.Controls.Add(this.btnTm1);
            this.Controls.Add(this.tbPoints);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(197, 256);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(197, 256);
            this.Name = "ChangePoints";
            this.Text = "ChangePoints";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPoints;
        private System.Windows.Forms.Button btnTm1;
        private System.Windows.Forms.Button btnTm2;
        private System.Windows.Forms.Button btnPlus1;
        private System.Windows.Forms.Button btnPlus2;
        private System.Windows.Forms.Button btnMinus1;
        private System.Windows.Forms.Button btnMinus2;
        private System.Windows.Forms.Button btnPlus3;
        private System.Windows.Forms.Button btnMinus3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Button btnSet;
    }
}