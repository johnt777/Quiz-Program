using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuizLibrary.Entity;

namespace QuizLibrary.DAL
{
    public class QuizDbInitializer : DropCreateDatabaseIfModelChanges<QuizDbContext>
    {

        protected override void Seed(QuizDbContext context)
        {
            var students = new List<Student>
            {
                new Student() {FirstName = "Kimi", LastName = "Raikonen" },
                new Student() {FirstName = "Sebastian", LastName = "Vettel" },
                new Student() {FirstName = "Carlos", LastName = "Sainz" },
                new Student() {FirstName = "Lewis", LastName="Hamilton" },
                new Student() {FirstName = "Roman", LastName="Grosjean" }
            };

            //ForEach is a LINQ function
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var questions = new List<Question>
            {
                new Question() {QuestionText = "Classes are like", AnswerText = "Blueprints" },
                new Question() {QuestionText = "An int is a ", AnswerText = "Whole Number" },
                new Question() {QuestionText = "C# is a", AnswerText = "Object-Oriented Programming Language" },
                new Question() {QuestionText = "Constructors", AnswerText = "Have no return type" },
                new Question() {QuestionText = "Methods", AnswerText = "Are modular building blocks for your program" }
            };

            questions.ForEach(q => context.Questions.Add(q));
            context.SaveChanges();
        }
    }
}
