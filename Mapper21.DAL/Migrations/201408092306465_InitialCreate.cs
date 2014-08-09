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
                        SubSectionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubSections", t => t.SubSectionId, cascadeDelete: true)
                .Index(t => t.SubSectionId);
            
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
                        Id = c.String(nullable: false, maxLength: 128),
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
                "dbo.Experts",
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
                "dbo.Fieldworks",
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
                "dbo.ServiceLearnings",
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
            DropForeignKey("dbo.ServiceLearnings", "SubSectionId", "dbo.SubSections");
            DropForeignKey("dbo.Fieldworks", "SubSectionId", "dbo.SubSections");
            DropForeignKey("dbo.Experts", "SubSectionId", "dbo.SubSections");
            DropForeignKey("dbo.CommonCoreStandards", "GradeLevelId", "dbo.GradeLevels");
            DropForeignKey("dbo.StaCollections", "SubSectionId", "dbo.SubSections");
            DropForeignKey("dbo.SubSections", "SubSectionTypeId", "dbo.SubSectionTypes");
            DropForeignKey("dbo.SubSections", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Sections", "SubjectAreaId", "dbo.SubjectAreas");
            DropForeignKey("dbo.SocialStudiesBigIdeas", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Sections", "SectionTypeId", "dbo.SectionTypes");
            DropForeignKey("dbo.ScienceBigIdeas", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.GuidingQuestions", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Sections", "GradeLevelId", "dbo.GradeLevels");
            DropForeignKey("dbo.Habits", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Standards", "StaCollectionId", "dbo.StaCollections");
            DropForeignKey("dbo.ShortTermTargets", "StaCollectionId", "dbo.StaCollections");
            DropForeignKey("dbo.LongTermTargets", "StaCollectionId", "dbo.StaCollections");
            DropForeignKey("dbo.Assessments", "StaCollectionId", "dbo.StaCollections");
            DropIndex("dbo.ServiceLearnings", new[] { "SubSectionId" });
            DropIndex("dbo.Fieldworks", new[] { "SubSectionId" });
            DropIndex("dbo.Experts", new[] { "SubSectionId" });
            DropIndex("dbo.CommonCoreStandards", new[] { "GradeLevelId" });
            DropIndex("dbo.StaCollections", new[] { "SubSectionId" });
            DropIndex("dbo.SubSections", new[] { "SubSectionTypeId" });
            DropIndex("dbo.SubSections", new[] { "SectionId" });
            DropIndex("dbo.Sections", new[] { "SubjectAreaId" });
            DropIndex("dbo.SocialStudiesBigIdeas", new[] { "SectionId" });
            DropIndex("dbo.Sections", new[] { "SectionTypeId" });
            DropIndex("dbo.ScienceBigIdeas", new[] { "SectionId" });
            DropIndex("dbo.GuidingQuestions", new[] { "SectionId" });
            DropIndex("dbo.Sections", new[] { "GradeLevelId" });
            DropIndex("dbo.Habits", new[] { "SectionId" });
            DropIndex("dbo.Standards", new[] { "StaCollectionId" });
            DropIndex("dbo.ShortTermTargets", new[] { "StaCollectionId" });
            DropIndex("dbo.LongTermTargets", new[] { "StaCollectionId" });
            DropIndex("dbo.Assessments", new[] { "StaCollectionId" });
            DropTable("dbo.StaGrids");
            DropTable("dbo.ServiceLearnings");
            DropTable("dbo.Fieldworks");
            DropTable("dbo.Experts");
            DropTable("dbo.CommonCoreStandards");
            DropTable("dbo.SubSectionTypes");
            DropTable("dbo.SubjectAreas");
            DropTable("dbo.SocialStudiesBigIdeas");
            DropTable("dbo.SectionTypes");
            DropTable("dbo.ScienceBigIdeas");
            DropTable("dbo.GuidingQuestions");
            DropTable("dbo.GradeLevels");
            DropTable("dbo.Habits");
            DropTable("dbo.Sections");
            DropTable("dbo.SubSections");
            DropTable("dbo.Standards");
            DropTable("dbo.ShortTermTargets");
            DropTable("dbo.LongTermTargets");
            DropTable("dbo.StaCollections");
            DropTable("dbo.Assessments");
        }
    }
}
