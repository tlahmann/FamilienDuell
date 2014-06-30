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
    public partial class ChangePoints : Form
    {
        protected Main controller;

        public ChangePoints()
        {
            InitializeComponent();
        }

        public void injectController(Main controller)
        {
            this.controller = controller;
        }

        private void btnRound_Click(object sender, EventArgs e) {
            btnRound.Enabled = false;
            btnTm1.Enabled = true;
            btnTm2.Enabled = true;
        }

        private void btnTm1_Click(object sender, EventArgs e) {
            btnRound.Enabled = true;
            btnTm1.Enabled = false;
            btnTm2.Enabled = true;
        }

        private void btnTm2_Click(object sender, EventArgs e) {
            btnRound.Enabled = true;
            btnTm1.Enabled = true;
            btnTm2.Enabled = false;
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            int punkte = Convert.ToInt16(tbPoints.Text.ToString());
            punkte += 1;
            tbPoints.Text = punkte.ToString();
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            int punkte = Convert.ToInt16(tbPoints.Text.ToString());
            punkte += 5;
            tbPoints.Text = punkte.ToString();
        }

        private void btnPlus3_Click(object sender, EventArgs e)
        {
            int punkte = Convert.ToInt16(tbPoints.Text.ToString());
            punkte += 10;
            tbPoints.Text = punkte.ToString();
        }

        private void btnMinus1_Click(object sender, EventArgs e)
        {
            int punkte = Convert.ToInt16(tbPoints.Text.ToString());
            punkte -= 1;
            tbPoints.Text = punkte.ToString();
        }

        private void btnMinus2_Click(object sender, EventArgs e)
        {
            int punkte = Convert.ToInt16(tbPoints.Text.ToString());
            punkte -= 5;
            tbPoints.Text = punkte.ToString();
        }

        private void btnMinus3_Click(object sender, EventArgs e)
        {
            int punkte = Convert.ToInt16(tbPoints.Text.ToString());
            punkte -= 10;
            tbPoints.Text = punkte.ToString();
        }

        private void btnAddTo_Click(object sender, EventArgs e)
        {
            int punkte = Convert.ToInt16(tbPoints.Text);
            int team = -1;

            if (!btnTm1.Enabled) {
                team = 1;
            } else if (!btnTm2.Enabled) {
                team = 2;
            } else if (!btnRound.Enabled){
                team = 0;
            }

            if (team != -1) {
               this.controller.addPointsToList(team, punkte, 2);
            }
        }

        private void btnSet_Click(object sender, EventArgs e) {
            int points = 0;
            int team = -1;
            try {points = Convert.ToInt16(tbPoints.Text);} catch (Exception) {}

            if (!btnTm1.Enabled) {
                team = 1;
            } else if (!btnTm2.Enabled) {
                team = 2;
            } else if (!btnRound.Enabled) {
                team = 0;
            }

            if (team != -1) {
                this.controller.addPointsToList(team, points, 1);
            }
        }
    }
}
