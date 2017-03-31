using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLibrary.Entity
{
    public class Quiz
    {
        private List<QuestionAsked> asked;

        public List<QuestionAsked> Asked
        {
            get
            {
                return asked;
            }

            set
            {
                asked = value;
            }
        }

        public Quiz()
        {
            asked = new List<QuestionAsked>();
        }
    }
}
