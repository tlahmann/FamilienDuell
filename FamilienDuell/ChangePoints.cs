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
        int punkte, team;

        protected GameMonitor GameMonitor;

        public ChangePoints()
        {
            InitializeComponent();
        }

        public void injectGameMonitor(GameMonitor GameMonitor)
        {
            this.GameMonitor = GameMonitor;
        }

        private void btnTm1_Click(object sender, EventArgs e)
        {
            btnTm1.Enabled = false;
            btnTm2.Enabled = true;
        }

        private void btnTm2_Click(object sender, EventArgs e)
        {
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

        private void btnApply_Click(object sender, EventArgs e)
        {
            //Monitor.newPoints(2, int.Parse(tbPointsProceed.Text));
            punkte = Convert.ToInt16(tbPoints.Text.ToString());
            if (!btnTm1.Enabled)
            {
                team = 1;
                this.Close();
            }
            else if (!btnTm2.Enabled)
            {
                team = 2;
                this.Close();
            }
        }

        internal int getPoints()
        {
            return punkte;
        }

        internal int getTeam()
        {
            return team;
        }
    }
}
