using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FamilienDuell {
    class AnswerResolver {

        protected Timer Timer;
        protected string Answer;
        protected Label Label;

        public void Main(string Answer, Label Label) {
            this.Answer = Answer;
            this.Label = Label;
            this.Timer = new Timer();

        }

    }
}
