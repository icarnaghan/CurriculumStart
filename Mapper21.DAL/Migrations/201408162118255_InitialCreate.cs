namespace Mapper21.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CommonCoreStandards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        GradeLevelId = c.String(maxLength: 128),
                        Code = c.String(),
                        Name = c.String(),
                        Strand = c.String(),
                        SubCategory = c.String(),
                        Domain = c.String(),
                        ClusterStatement = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GradeLevels", t => t.GradeLevelId)
                .Index(t => t.GradeLevelId);
            
            CreateTable(
                "dbo.GradeLevels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Habits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ScienceBigIdeas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SectionGuidingQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .Index(t => t.SectionId);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        GradeLevelId = c.String(maxLength: 128),
                        SectionTypeId = c.String(maxLength: 128),
                        Name = c.String(),
                        Description = c.String(),
                        KickOff = c.String(),
                        FinalProductName = c.String(),
                        FinalProductDescription = c.String(),
                        LastUpdatedBy = c.Int(),
                        LastUpdatedAt = c.DateTime(),
                        SubmittedBy = c.Int(),
                        SubmittedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GradeLevels", t => t.GradeLevelId)
                .ForeignKey("dbo.SectionTypes", t => t.SectionTypeId)
                .Index(t => t.GradeLevelId)
                .Index(t => t.SectionTypeId);
            
            CreateTable(
                "dbo.SectionHabits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HabitId = c.Int(nullable: false),
                        Context = c.String(),
                        SectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Habits", t => t.HabitId, cascadeDelete: true)
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .Index(t => t.HabitId)
                .Index(t => t.SectionId);
            
            CreateTable(
                "dbo.SectionScienceBigIdeas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BigIdeaForScienceId = c.Int(nullable: false),
                        Context = c.String(),
                        SectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ScienceBigIdeas", t => t.BigIdeaForScienceId, cascadeDelete: true)
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .Index(t => t.BigIdeaForScienceId)
                .Index(t => t.SectionId);
            
            CreateTable(
                "dbo.SectionTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SectionSocialStudiesBigIdeas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BigIdeaForSocialStudiesId = c.Int(nullable: false),
                        Context = c.String(),
                        SectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SocialStudiesBigIdeas", t => t.BigIdeaForSocialStudiesId, cascadeDelete: true)
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .Index(t => t.BigIdeaForSocialStudiesId)
                .Index(t => t.SectionId);
            
            CreateTable(
                "dbo.SocialStudiesBigIdeas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubSections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SectionId = c.Int(nullable: false),
                        SubSectionTypeId = c.String(maxLength: 128),
                        Name = c.String(),
                        Description = c.String(),
                        LastUpdatedBy = c.Int(),
                        LastUpdatedAt = c.DateTime(),
                        SubmittedBy = c.Int(),
                        SubmittedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .ForeignKey("dbo.SubSectionTypes", t => t.SubSectionTypeId)
                .Index(t => t.SectionId)
                .Index(t => t.SubSectionTypeId);
            
            CreateTable(
                "dbo.SubSectionTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SectionOtherBigIdeas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Context = c.String(),
                        SectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .Index(t => t.SectionId);
            
            CreateTable(
                "dbo.SubSectionAssessments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        SubSectionStaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubSectionStas", t => t.SubSectionStaId, cascadeDelete: true)
                .Index(t => t.SubSectionStaId);
            
            CreateTable(
                "dbo.SubSectionStas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubSectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubSections", t => t.SubSectionId, cascadeDelete: true)
                .Index(t => t.SubSectionId);
            
            CreateTable(
                "dbo.SubSectionLongTermTargets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SubSectionStaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubSectionStas", t => t.SubSectionStaId, cascadeDelete: true)
                .Index(t => t.SubSectionStaId);
            
            CreateTable(
                "dbo.SubSectionShortTermTargets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SubSectionStaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubSectionStas", t => t.SubSectionStaId, cascadeDelete: true)
                .Index(t => t.SubSectionStaId);
            
            CreateTable(
                "dbo.SubSectionStandards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubSectionStaId = c.Int(nullable: false),
                        CommonCoreStandardId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CommonCoreStandards", t => t.CommonCoreStandardId, cascadeDelete: true)
                .ForeignKey("dbo.SubSectionStas", t => t.SubSectionStaId, cascadeDelete: true)
                .Index(t => t.CommonCoreStandardId)
                .Index(t => t.SubSectionStaId);
            
            CreateTable(
                "dbo.SubSectionExperts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Notes = c.String(),
                        SubSectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubSections", t => t.SubSectionId, cascadeDelete: true)
                .Index(t => t.SubSectionId);
            
            CreateTable(
                "dbo.SubSectionFieldworks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Notes = c.String(),
                        SubSectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubSections", t => t.SubSectionId, cascadeDelete: true)
                .Index(t => t.SubSectionId);
            
            CreateTable(
                "dbo.SubSectionGuidingQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SubSectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubSections", t => t.SubSectionId, cascadeDelete: true)
                .Index(t => t.SubSectionId);
            
            CreateTable(
                "dbo.SubSectionHabits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HabitId = c.Int(nullable: false),
                        Context = c.String(),
                        SubSectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Habits", t => t.HabitId, cascadeDelete: true)
                .ForeignKey("dbo.SubSections", t => t.SubSectionId, cascadeDelete: true)
                .Index(t => t.HabitId)
                .Index(t => t.SubSectionId);
            
            CreateTable(
                "dbo.SubSectionOtherBigIdeas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Context = c.String(),
                        SubSectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubSections", t => t.SubSectionId, cascadeDelete: true)
                .Index(t => t.SubSectionId);
            
            CreateTable(
                "dbo.SubSectionServiceLearnings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Notes = c.String(),
                        SubSectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubSections", t => t.SubSectionId, cascadeDelete: true)
                .Index(t => t.SubSectionId);
            
            CreateTable(
                "dbo.SubSectionStaGrids",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubSectionStaId = c.Int(nullable: false),
                        SubSectionId = c.Int(nullable: false),
                        Standards = c.String(),
                        LongTermTargets = c.String(),
                        ShortTermTargets = c.String(),
                        Assessments = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubSectionServiceLearnings", "SubSectionId", "dbo.SubSections");
            DropForeignKey("dbo.SubSectionOtherBigIdeas", "SubSectionId", "dbo.SubSections");
            DropForeignKey("dbo.SubSectionHabits", "SubSectionId", "dbo.SubSections");
            DropForeignKey("dbo.SubSectionHabits", "HabitId", "dbo.Habits");
            DropForeignKey("dbo.SubSectionGuidingQuestions", "SubSectionId", "dbo.SubSections");
            DropForeignKey("dbo.SubSectionFieldworks", "SubSectionId", "dbo.SubSections");
            DropForeignKey("dbo.SubSectionExperts", "SubSectionId", "dbo.SubSections");
            DropForeignKey("dbo.SubSectionStas", "SubSectionId", "dbo.SubSections");
            DropForeignKey("dbo.SubSectionStandards", "SubSectionStaId", "dbo.SubSectionStas");
            DropForeignKey("dbo.SubSectionStandards", "CommonCoreStandardId", "dbo.CommonCoreStandards");
            DropForeignKey("dbo.SubSectionShortTermTargets", "SubSectionStaId", "dbo.SubSectionStas");
            DropForeignKey("dbo.SubSectionLongTermTargets", "SubSectionStaId", "dbo.SubSectionStas");
            DropForeignKey("dbo.SubSectionAssessments", "SubSectionStaId", "dbo.SubSectionStas");
            DropForeignKey("dbo.SectionOtherBigIdeas", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.SubSections", "SubSectionTypeId", "dbo.SubSectionTypes");
            DropForeignKey("dbo.SubSections", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.SectionSocialStudiesBigIdeas", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.SectionSocialStudiesBigIdeas", "BigIdeaForSocialStudiesId", "dbo.SocialStudiesBigIdeas");
            DropForeignKey("dbo.Sections", "SectionTypeId", "dbo.SectionTypes");
            DropForeignKey("dbo.SectionScienceBigIdeas", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.SectionScienceBigIdeas", "BigIdeaForScienceId", "dbo.ScienceBigIdeas");
            DropForeignKey("dbo.SectionGuidingQuestions", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Sections", "GradeLevelId", "dbo.GradeLevels");
            DropForeignKey("dbo.SectionHabits", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.SectionHabits", "HabitId", "dbo.Habits");
            DropForeignKey("dbo.CommonCoreStandards", "GradeLevelId", "dbo.GradeLevels");
            DropIndex("dbo.SubSectionServiceLearnings", new[] { "SubSectionId" });
            DropIndex("dbo.SubSectionOtherBigIdeas", new[] { "SubSectionId" });
            DropIndex("dbo.SubSectionHabits", new[] { "SubSectionId" });
            DropIndex("dbo.SubSectionHabits", new[] { "HabitId" });
            DropIndex("dbo.SubSectionGuidingQuestions", new[] { "SubSectionId" });
            DropIndex("dbo.SubSectionFieldworks", new[] { "SubSectionId" });
            DropIndex("dbo.SubSectionExperts", new[] { "SubSectionId" });
            DropIndex("dbo.SubSectionStas", new[] { "SubSectionId" });
            DropIndex("dbo.SubSectionStandards", new[] { "SubSectionStaId" });
            DropIndex("dbo.SubSectionStandards", new[] { "CommonCoreStandardId" });
            DropIndex("dbo.SubSectionShortTermTargets", new[] { "SubSectionStaId" });
            DropIndex("dbo.SubSectionLongTermTargets", new[] { "SubSectionStaId" });
            DropIndex("dbo.SubSectionAssessments", new[] { "SubSectionStaId" });
            DropIndex("dbo.SectionOtherBigIdeas", new[] { "SectionId" });
            DropIndex("dbo.SubSections", new[] { "SubSectionTypeId" });
            DropIndex("dbo.SubSections", new[] { "SectionId" });
            DropIndex("dbo.SectionSocialStudiesBigIdeas", new[] { "SectionId" });
            DropIndex("dbo.SectionSocialStudiesBigIdeas", new[] { "BigIdeaForSocialStudiesId" });
            DropIndex("dbo.Sections", new[] { "SectionTypeId" });
            DropIndex("dbo.SectionScienceBigIdeas", new[] { "SectionId" });
            DropIndex("dbo.SectionScienceBigIdeas", new[] { "BigIdeaForScienceId" });
            DropIndex("dbo.SectionGuidingQuestions", new[] { "SectionId" });
            DropIndex("dbo.Sections", new[] { "GradeLevelId" });
            DropIndex("dbo.SectionHabits", new[] { "SectionId" });
            DropIndex("dbo.SectionHabits", new[] { "HabitId" });
            DropIndex("dbo.CommonCoreStandards", new[] { "GradeLevelId" });
            DropTable("dbo.SubSectionStaGrids");
            DropTable("dbo.SubSectionServiceLearnings");
            DropTable("dbo.SubSectionOtherBigIdeas");
            DropTable("dbo.SubSectionHabits");
            DropTable("dbo.SubSectionGuidingQuestions");
            DropTable("dbo.SubSectionFieldworks");
            DropTable("dbo.SubSectionExperts");
            DropTable("dbo.SubSectionStandards");
            DropTable("dbo.SubSectionShortTermTargets");
            DropTable("dbo.SubSectionLongTermTargets");
            DropTable("dbo.SubSectionStas");
            DropTable("dbo.SubSectionAssessments");
            DropTable("dbo.SectionOtherBigIdeas");
            DropTable("dbo.SubSectionTypes");
            DropTable("dbo.SubSections");
            DropTable("dbo.SocialStudiesBigIdeas");
            DropTable("dbo.SectionSocialStudiesBigIdeas");
            DropTable("dbo.SectionTypes");
            DropTable("dbo.SectionScienceBigIdeas");
            DropTable("dbo.SectionHabits");
            DropTable("dbo.Sections");
            DropTable("dbo.SectionGuidingQuestions");
            DropTable("dbo.ScienceBigIdeas");
            DropTable("dbo.Habits");
            DropTable("dbo.GradeLevels");
            DropTable("dbo.CommonCoreStandards");
        }
    }
}
