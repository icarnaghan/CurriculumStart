namespace Mapper21.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assessments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        StaCollectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StaCollections", t => t.StaCollectionId, cascadeDelete: true)
                .Index(t => t.StaCollectionId);
            
            CreateTable(
                "dbo.StaCollections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CaseStudyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CaseStudies", t => t.CaseStudyId, cascadeDelete: true)
                .Index(t => t.CaseStudyId);
            
            CreateTable(
                "dbo.CaseStudies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SectionId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .Index(t => t.SectionId);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SectionTypeId = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        GradeLevelId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        KickOff = c.String(),
                        FinalProductName = c.String(),
                        FinalProductDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GradeLevels", t => t.GradeLevelId, cascadeDelete: true)
                .ForeignKey("dbo.SectionTypes", t => t.SectionTypeId, cascadeDelete: true)
                .Index(t => t.GradeLevelId)
                .Index(t => t.SectionTypeId);
            
            CreateTable(
                "dbo.Habits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rationale = c.String(),
                        Description = c.String(),
                        SectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .Index(t => t.SectionId);
            
            CreateTable(
                "dbo.GradeLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GuidingQuestions",
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
                "dbo.ScienceBigIdeas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Idea = c.String(),
                        Rationale = c.String(),
                        SectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .Index(t => t.SectionId);
            
            CreateTable(
                "dbo.SectionTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SocialStudiesBigIdeas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Idea = c.String(),
                        Rationale = c.String(),
                        SectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .Index(t => t.SectionId);
            
            CreateTable(
                "dbo.LongTermTargets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StaCollectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StaCollections", t => t.StaCollectionId, cascadeDelete: true)
                .Index(t => t.StaCollectionId);
            
            CreateTable(
                "dbo.ShortTermTargets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StaCollectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StaCollections", t => t.StaCollectionId, cascadeDelete: true)
                .Index(t => t.StaCollectionId);
            
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StaCollectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StaCollections", t => t.StaCollectionId, cascadeDelete: true)
                .Index(t => t.StaCollectionId);
            
            CreateTable(
                "dbo.Experts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CaseStudyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CaseStudies", t => t.CaseStudyId, cascadeDelete: true)
                .Index(t => t.CaseStudyId);
            
            CreateTable(
                "dbo.Fieldworks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CaseStudyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CaseStudies", t => t.CaseStudyId, cascadeDelete: true)
                .Index(t => t.CaseStudyId);
            
            CreateTable(
                "dbo.ServiceLearnings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CaseStudyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CaseStudies", t => t.CaseStudyId, cascadeDelete: true)
                .Index(t => t.CaseStudyId);
            
            CreateTable(
                "dbo.StaGrids",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaCollectionId = c.Int(nullable: false),
                        CaseStudyId = c.Int(nullable: false),
                        Standards = c.String(),
                        LongTermTargets = c.String(),
                        ShortTermTargets = c.String(),
                        Assessments = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceLearnings", "CaseStudyId", "dbo.CaseStudies");
            DropForeignKey("dbo.Fieldworks", "CaseStudyId", "dbo.CaseStudies");
            DropForeignKey("dbo.Experts", "CaseStudyId", "dbo.CaseStudies");
            DropForeignKey("dbo.Standards", "StaCollectionId", "dbo.StaCollections");
            DropForeignKey("dbo.ShortTermTargets", "StaCollectionId", "dbo.StaCollections");
            DropForeignKey("dbo.LongTermTargets", "StaCollectionId", "dbo.StaCollections");
            DropForeignKey("dbo.StaCollections", "CaseStudyId", "dbo.CaseStudies");
            DropForeignKey("dbo.SocialStudiesBigIdeas", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Sections", "SectionTypeId", "dbo.SectionTypes");
            DropForeignKey("dbo.ScienceBigIdeas", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.GuidingQuestions", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Sections", "GradeLevelId", "dbo.GradeLevels");
            DropForeignKey("dbo.Habits", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.CaseStudies", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Assessments", "StaCollectionId", "dbo.StaCollections");
            DropIndex("dbo.ServiceLearnings", new[] { "CaseStudyId" });
            DropIndex("dbo.Fieldworks", new[] { "CaseStudyId" });
            DropIndex("dbo.Experts", new[] { "CaseStudyId" });
            DropIndex("dbo.Standards", new[] { "StaCollectionId" });
            DropIndex("dbo.ShortTermTargets", new[] { "StaCollectionId" });
            DropIndex("dbo.LongTermTargets", new[] { "StaCollectionId" });
            DropIndex("dbo.StaCollections", new[] { "CaseStudyId" });
            DropIndex("dbo.SocialStudiesBigIdeas", new[] { "SectionId" });
            DropIndex("dbo.Sections", new[] { "SectionTypeId" });
            DropIndex("dbo.ScienceBigIdeas", new[] { "SectionId" });
            DropIndex("dbo.GuidingQuestions", new[] { "SectionId" });
            DropIndex("dbo.Sections", new[] { "GradeLevelId" });
            DropIndex("dbo.Habits", new[] { "SectionId" });
            DropIndex("dbo.CaseStudies", new[] { "SectionId" });
            DropIndex("dbo.Assessments", new[] { "StaCollectionId" });
            DropTable("dbo.StaGrids");
            DropTable("dbo.ServiceLearnings");
            DropTable("dbo.Fieldworks");
            DropTable("dbo.Experts");
            DropTable("dbo.Standards");
            DropTable("dbo.ShortTermTargets");
            DropTable("dbo.LongTermTargets");
            DropTable("dbo.SocialStudiesBigIdeas");
            DropTable("dbo.SectionTypes");
            DropTable("dbo.ScienceBigIdeas");
            DropTable("dbo.GuidingQuestions");
            DropTable("dbo.GradeLevels");
            DropTable("dbo.Habits");
            DropTable("dbo.Sections");
            DropTable("dbo.CaseStudies");
            DropTable("dbo.StaCollections");
            DropTable("dbo.Assessments");
        }
    }
}
