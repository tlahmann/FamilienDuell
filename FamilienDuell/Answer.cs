using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FamilienDuell {
    class Answer {
        protected string title;
        protected int quantity;

        protected Label answerField;
        protected Label quantityField;

        public Answer setTitle(string title) {
            this.title = title;
            return this;
        }

        public Answer setQuantity(int quantity) {
            this.quantity = quantity;
            return this;
        }

        public string getTitle() {
            return this.title;
        }

        public int getQuantity() {
            return this.quantity;
        }

        public string getQuantityAsString() {
            return this.quantity.ToString();
        }
    }
}
