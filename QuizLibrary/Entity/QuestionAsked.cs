using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLibrary.Entity
{
    public class QuestionAsked
    {

        public int Id { get; set; }
        public string QuizId { get; set; }
        public DateTime AskedDate { get; set; }

        public Student Student { get; set; }

        public Question Question { get; set; }
    }
}
