namespace QuizLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionText = c.String(),
                        AnswerText = c.String(),
                        Likes = c.Int(nullable: false),
                        Dislikes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.QuestionAsked",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuizId = c.String(),
                        AskedDate = c.DateTime(nullable: false),
                        Question_Id = c.Int(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Question", t => t.Question_Id)
                .ForeignKey("dbo.Student", t => t.Student_Id)
                .Index(t => t.Question_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Correct = c.Int(nullable: false),
                        Attempts = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuestionAsked", "Student_Id", "dbo.Student");
            DropForeignKey("dbo.QuestionAsked", "Question_Id", "dbo.Question");
            DropIndex("dbo.QuestionAsked", new[] { "Student_Id" });
            DropIndex("dbo.QuestionAsked", new[] { "Question_Id" });
            DropTable("dbo.Student");
            DropTable("dbo.QuestionAsked");
            DropTable("dbo.Question");
        }
    }
}
