using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Diagnostics;

namespace FamilienDuell
{

    class Question
    {

        public const int READ_ERROR = -1;
        public const int READ_WAITING = 0;
        public const int READ_READING = 1;

        protected string questionTitle;
        protected List<Answer> answers = new List<Answer>();

        protected XmlTextReader reader;

        public bool readQuestion()
        {
            XmlTextReader reader = this.reader;

            if (reader.ReadState == System.Xml.ReadState.Interactive)
            {
                throw new Exception("Unable to read question, given XmlTextReader object is already in interactive mode, file pointer most likely moved");
            }

            int readStatus = READ_WAITING;
            Answer bufferAnswer = new Answer();

            while (reader.Read()) {

                // Check if reader stream still is available
                if (reader.ReadState == ReadState.Closed || reader.ReadState == ReadState.Error) {
                    readStatus = READ_ERROR;
                }

                if (readStatus == READ_WAITING) {
                    if (reader.LocalName == "question")
                    {
                        this.questionTitle = reader.ReadElementContentAsString();
                        readStatus = READ_READING;
                    }
                } else if (readStatus == READ_READING) {
                    switch (reader.LocalName) {
                        case "answer":
                            if (reader.NodeType == XmlNodeType.Element) {
                                bufferAnswer = new Answer();
                            } else if (reader.NodeType == XmlNodeType.EndElement) {

                                // If this is the first element we are adding, it's our top answer
                                if (this.answers.Count == 0) {
                                    bufferAnswer.markAsTopAnswer();
                                }

                                this.answers.Add(bufferAnswer);
                            }
                            break;

                        case "title":
                            bufferAnswer.setTitle(reader.ReadElementContentAsString());
                            break;

                        case "quantity":
                            bufferAnswer.setQuantity(reader.ReadElementContentAsInt());
                            break;
                    }
                }

                // If a read error occured, return false, otherwise return true once we got EOF
                if (readStatus == READ_ERROR) {
                    return false;
                }
            }

            if (reader.EOF || reader.ReadState == ReadState.EndOfFile) {
                return true;
            }

            // If theres no EOF, theres no happy end.
            return false;

        }

        public bool isResolved() {
            foreach (Answer answer in this.getAnswers()) {
                if (answer.isResolved()) {
                    return true;
                }
            }

            return false;
        }

        public Question injectReaderObject(XmlTextReader reader)
        {
            this.reader = reader;
            return this;
        }

        public string getQuestion()
        {
            return this.questionTitle;
        }

        public List<Answer> getAnswers()
        {
            return this.answers;
        }


    }
}
