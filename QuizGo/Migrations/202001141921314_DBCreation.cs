namespace QuizGo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MCQ1Question",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CorrectOption = c.String(),
                        OptionA = c.String(),
                        OptionB = c.String(),
                        OptionC = c.String(),
                        OptionD = c.String(),
                        QuestionText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MCQ2Question",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsACorrect = c.Boolean(nullable: false),
                        IsBCorrect = c.Boolean(nullable: false),
                        IsCCorrect = c.Boolean(nullable: false),
                        IsDCorrect = c.Boolean(nullable: false),
                        OptionA = c.String(),
                        OptionB = c.String(),
                        OptionC = c.String(),
                        OptionD = c.String(),
                        QuestionText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubjectiveQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnswerText = c.String(),
                        QuestionText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SubjectiveQuestions");
            DropTable("dbo.MCQ2Question");
            DropTable("dbo.MCQ1Question");
        }
    }
}
