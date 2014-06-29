using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FamilienDuell {
    class PointControl {
        private int teamID;
        private int pointsVal;

        public PointControl(int tm, int pts) {
            this.teamID = tm;
            this.pointsVal = pts;
        }

        public int team {
            get { return this.teamID; }
            set { this.team = team; }
        }

        public int points {
            get { return this.pointsVal; }
            set { this.pointsVal = points; }
        }
    }
}
