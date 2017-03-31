using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace QuizLibrary.Entity
{
    public class Question
    {
        public int Id { get; set; }
        [Display(Name = "Question Text")]
        public string QuestionText { get; set; }
        [Display(Name = "Answer Text")]
        public string AnswerText { get; set; }
       
        public int Likes { get; set; }
        public int Dislikes { get; set; }

    }
}
