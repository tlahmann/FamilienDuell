using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FamilienDuell {
    class Answer {
        protected string title;
        protected int quantity;

        protected bool resolved = false;
        protected bool topAnswer = false;
        protected int index;

        protected Label answerField;
        protected Label quantityField;

        #region Setters
        public Answer setTitle(string title) {
            this.title = title;
            return this;
        }

        public Answer setQuantity(int quantity) {
            this.quantity = quantity;
            return this;
        }

        public Answer setAnswerField(Label answerField) {
            this.answerField = answerField;
            return this;
        }

        public Answer setQuantityField(Label quantityField) {
            this.quantityField = quantityField;
            return this;
        }

        public Answer markAsTopAnswer() {
            this.topAnswer = true;
            return this;
        }

        public Answer markAsResolved() {
            this.resolved = true;
            return this;
        }

        public Answer setIndex(int index) {
            this.index = index;
            return this;
        }
        #endregion

        #region Getters
        public string getTitle() {
            return this.title;
        }

        public int getQuantity() {
            return this.quantity;
        }

        public string getQuantityAsString() {
            return this.quantity.ToString();
        }

        public bool isTopAnswer() {
            return this.topAnswer;
        }

        public bool isResolved() {
            return this.resolved;
        }

        public int getIndex() {
            return this.index;
        }
        #endregion
    }
}
