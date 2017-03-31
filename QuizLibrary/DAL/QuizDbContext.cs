using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

using QuizLibrary.Entity;
using System.Data.Entity;

namespace QuizLibrary.DAL
{
    public class QuizDbContext : DbContext
    {

        public QuizDbContext() : base("QuizDbContext") { }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<QuestionAsked> QuestionsAsked { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}