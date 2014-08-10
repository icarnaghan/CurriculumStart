namespace Mapper21.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
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
                .ForeignKey("dbo.SubSectionStas", t => t.SubSectionStaId, cascadeDelete: true)
                .Index(t => t.SubSectionStaId);
            
            CreateTable(
                "dbo.SubSections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SectionId = c.Int(nullable: false),
                        SubSectionTypeId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        LastUpdatedBy = c.Int(),
                        LastUpdatedAt = c.DateTime(),
                        SubmittedBy = c.Int(),
                        SubmittedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .ForeignKey("dbo.SubSectionTypes", t => t.SubSectionTypeId, cascadeDelete: true)
                .Index(t => t.SectionId)
                .Index(t => t.SubSectionTypeId);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        GradeLevelId = c.String(maxLength: 128),
                        SectionTypeId = c.Int(nullable: false),
                        SubjectAreaId = c.Int(),
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
                .ForeignKey("dbo.SectionTypes", t => t.SectionTypeId, cascadeDelete: true)
                .ForeignKey("dbo.SubjectAreas", t => t.SubjectAreaId)
                .Index(t => t.GradeLevelId)
                .Index(t => t.SectionTypeId)
                .Index(t => t.SubjectAreaId);
            
            CreateTable(
                "dbo.SectionHabits",
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
                        Id = c.String(nullable: false, maxLength: 128),
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
                "dbo.SectionBigIdeasForSciences",
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
                "dbo.SectionBigIdeasForSocialStudies",
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
                "dbo.SubjectAreas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubSectionTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BigIdeas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
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
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GradeLevels", t => t.GradeLevelId)
                .Index(t => t.GradeLevelId);
            
            CreateTable(
                "dbo.SubSectionExperts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
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
            DropForeignKey("dbo.SubSectionServiceLearnings", "SubSectionId", "dbo.SubSections");
            DropForeignKey("dbo.SubSectionFieldworks", "SubSectionId", "dbo.SubSections");
            DropForeignKey("dbo.SubSectionExperts", "SubSectionId", "dbo.SubSections");
            DropForeignKey("dbo.CommonCoreStandards", "GradeLevelId", "dbo.GradeLevels");
            DropForeignKey("dbo.SubSectionStas", "SubSectionId", "dbo.SubSections");
            DropForeignKey("dbo.SubSections", "SubSectionTypeId", "dbo.SubSectionTypes");
            DropForeignKey("dbo.SubSections", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Sections", "SubjectAreaId", "dbo.SubjectAreas");
            DropForeignKey("dbo.SectionBigIdeasForSocialStudies", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Sections", "SectionTypeId", "dbo.SectionTypes");
            DropForeignKey("dbo.SectionBigIdeasForSciences", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.SectionGuidingQuestions", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Sections", "GradeLevelId", "dbo.GradeLevels");
            DropForeignKey("dbo.SectionHabits", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.SubSectionStandards", "SubSectionStaId", "dbo.SubSectionStas");
            DropForeignKey("dbo.SubSectionShortTermTargets", "SubSectionStaId", "dbo.SubSectionStas");
            DropForeignKey("dbo.SubSectionLongTermTargets", "SubSectionStaId", "dbo.SubSectionStas");
            DropForeignKey("dbo.SubSectionAssessments", "SubSectionStaId", "dbo.SubSectionStas");
            DropIndex("dbo.SubSectionServiceLearnings", new[] { "SubSectionId" });
            DropIndex("dbo.SubSectionFieldworks", new[] { "SubSectionId" });
            DropIndex("dbo.SubSectionExperts", new[] { "SubSectionId" });
            DropIndex("dbo.CommonCoreStandards", new[] { "GradeLevelId" });
            DropIndex("dbo.SubSectionStas", new[] { "SubSectionId" });
            DropIndex("dbo.SubSections", new[] { "SubSectionTypeId" });
            DropIndex("dbo.SubSections", new[] { "SectionId" });
            DropIndex("dbo.Sections", new[] { "SubjectAreaId" });
            DropIndex("dbo.SectionBigIdeasForSocialStudies", new[] { "SectionId" });
            DropIndex("dbo.Sections", new[] { "SectionTypeId" });
            DropIndex("dbo.SectionBigIdeasForSciences", new[] { "SectionId" });
            DropIndex("dbo.SectionGuidingQuestions", new[] { "SectionId" });
            DropIndex("dbo.Sections", new[] { "GradeLevelId" });
            DropIndex("dbo.SectionHabits", new[] { "SectionId" });
            DropIndex("dbo.SubSectionStandards", new[] { "SubSectionStaId" });
            DropIndex("dbo.SubSectionShortTermTargets", new[] { "SubSectionStaId" });
            DropIndex("dbo.SubSectionLongTermTargets", new[] { "SubSectionStaId" });
            DropIndex("dbo.SubSectionAssessments", new[] { "SubSectionStaId" });
            DropTable("dbo.SubSectionStaGrids");
            DropTable("dbo.SubSectionServiceLearnings");
            DropTable("dbo.SubSectionFieldworks");
            DropTable("dbo.SubSectionExperts");
            DropTable("dbo.CommonCoreStandards");
            DropTable("dbo.BigIdeas");
            DropTable("dbo.SubSectionTypes");
            DropTable("dbo.SubjectAreas");
            DropTable("dbo.SectionBigIdeasForSocialStudies");
            DropTable("dbo.SectionTypes");
            DropTable("dbo.SectionBigIdeasForSciences");
            DropTable("dbo.SectionGuidingQuestions");
            DropTable("dbo.GradeLevels");
            DropTable("dbo.SectionHabits");
            DropTable("dbo.Sections");
            DropTable("dbo.SubSections");
            DropTable("dbo.SubSectionStandards");
            DropTable("dbo.SubSectionShortTermTargets");
            DropTable("dbo.SubSectionLongTermTargets");
            DropTable("dbo.SubSectionStas");
            DropTable("dbo.SubSectionAssessments");
        }
    }
}
