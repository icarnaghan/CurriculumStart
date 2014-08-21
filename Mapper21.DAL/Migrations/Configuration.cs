using System.Collections.Generic;
using Mapper21.BE.Domain;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mapper21.DAL.Provider.Mapper21Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Mapper21.DAL.Provider.Mapper21Context context)
        {
            var grades = new List<GradeLevel>
            {
                new GradeLevel {Id = "K", Name = "Kindergarten"},
                new GradeLevel {Id = "1", Name = "First Grade"},
                new GradeLevel {Id = "2", Name = "Second Grade"},
                new GradeLevel {Id = "3", Name = "Third Grade"},
                new GradeLevel {Id = "4", Name = "Forth Grade"},
                new GradeLevel {Id = "5", Name = "Fifth Grade"},
                new GradeLevel {Id = "6", Name = "Sixth Grade"},
                new GradeLevel {Id = "7", Name = "Seventh Grade"},
                new GradeLevel {Id = "8", Name = "Eighth Grade"},
                new GradeLevel {Id = "9", Name = "Ninth Grade"},
                new GradeLevel {Id = "10", Name = "Tenth Grade"},
                new GradeLevel {Id = "11", Name = "Eleventh Grade"},
                new GradeLevel {Id = "12", Name = "Twelfth Grade"},
            };
            grades.ForEach(g => context.GradeLevels.AddOrUpdate(g));
            context.SaveChanges();

            var sectionTypes = new List<SectionType>
            {
                new SectionType {Id = "FirstSixWeeks", Name = "First Six Weeks"},
                new SectionType {Id = "FallExpedition", Name = "Fall Expedition"},
                new SectionType {Id = "MiniMester", Name = "Mini Mester"},
                new SectionType {Id = "SpringExpedition", Name = "Spring Expedition"},
                new SectionType {Id = "Art", Name = "Art"},
                new SectionType {Id = "ForeignLanguages", Name = "ForeignLanguages"},
                new SectionType {Id = "LanguageArts", Name = "Language Arts"},
                new SectionType {Id = "Mathematics", Name = "Mathematics"},
                new SectionType {Id = "Media", Name = "Media"},
                new SectionType {Id = "Music", Name = "Music"},
                new SectionType {Id = "PeHealth", Name = "PE / Health"},
                new SectionType {Id = "Science", Name = "Science"},
                new SectionType {Id = "SocialSkills", Name = "Social Skills"},
                new SectionType {Id = "SocialStudiesHumanities", Name = "Social Studies / Humanities"},
                new SectionType {Id = "Technology", Name = "Technology"},
                new SectionType {Id = "Writing", Name = "Writing"},
                new SectionType {Id = "ClubC", Name = "Club C"},
                new SectionType {Id = "Crew", Name = "Crew"},
                new SectionType {Id = "Sas", Name = "SAS"},
            };
            sectionTypes.ForEach(s => context.SectionTypes.AddOrUpdate(s));
            context.SaveChanges();

            var subSectionTypes = new List<SubSectionType>
            {
                new SubSectionType {Id = "Week", Name = "Week"},
                new SubSectionType {Id = "CaseStudy", Name = "Case Study"},
                new SubSectionType {Id = "Unit", Name = "Unit"},
            };
            subSectionTypes.ForEach(s => context.SubSectionTypes.AddOrUpdate(s));
            context.SaveChanges();

            // Fall Expedition
            var sections = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FallExpedition"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FallExpedition"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FallExpedition"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FallExpedition"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FallExpedition"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FallExpedition"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FallExpedition"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FallExpedition"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FallExpedition"},
            };
            sections.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();

            // Spring Expedition
            var sections2 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SpringExpedition"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SpringExpedition"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SpringExpedition"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SpringExpedition"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SpringExpedition"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SpringExpedition"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SpringExpedition"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SpringExpedition"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SpringExpedition"},
            };
            sections2.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();

            // FSW
            var sections3 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FirstSixWeeks"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FirstSixWeeks"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FirstSixWeeks"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FirstSixWeeks"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FirstSixWeeks"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FirstSixWeeks"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FirstSixWeeks"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FirstSixWeeks"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "FirstSixWeeks"},
            };
            sections3.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();

            // Mini-Mester
            var sections4 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "MiniMester"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "MiniMester"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "MiniMester"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "MiniMester"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "MiniMester"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "MiniMester"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "MiniMester"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "MiniMester"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "MiniMester"},
            };
            sections4.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();

            // Subject
            var sections5 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Art"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Art"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Art"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Art"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Art"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Art"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Art"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Art"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Art"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "9", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Art"},
            };
            sections5.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();

            // Subject
            var sections6 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ForeignLanguages"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ForeignLanguages"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ForeignLanguages"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ForeignLanguages"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ForeignLanguages"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ForeignLanguages"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ForeignLanguages"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ForeignLanguages"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ForeignLanguages"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "9", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ForeignLanguages"},
            };
            sections6.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();

            // Subject
            var sections7 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "LanguageArts"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "LanguageArts"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "LanguageArts"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "LanguageArts"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "LanguageArts"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "LanguageArts"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "LanguageArts"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "LanguageArts"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "LanguageArts"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "9", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "LanguageArts"},
            };
            sections7.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();

            // Subject
            var sections8 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Mathematics"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Mathematics"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Mathematics"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Mathematics"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Mathematics"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Mathematics"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Mathematics"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Mathematics"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Mathematics"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "9", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Mathematics"},
            };
            sections8.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();


            // Subject
            var sections9 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Media"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Media"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Media"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Media"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Media"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Media"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Media"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Media"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Media"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "9", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Media"},
            };
            sections9.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();

            // Subject
            var sections10 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Music"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Music"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Music"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Music"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Music"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Music"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Music"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Music"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Music"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "9", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Music"},
            };
            sections10.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();

            // Subject
            // Subject
            var sections11 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "PeHealth"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "PeHealth"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "PeHealth"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "PeHealth"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "PeHealth"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "PeHealth"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "PeHealth"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "PeHealth"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "PeHealth"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "9", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "PeHealth"},
            };
            sections11.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();

            // Subject
            var sections12 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Science"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Science"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Science"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Science"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Science"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Science"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Science"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Science"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Science"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "9", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Science"},
            };
            sections12.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();


            // Subject
            var sections13 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialSkills"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialSkills"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialSkills"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialSkills"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialSkills"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialSkills"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialSkills"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialSkills"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialSkills"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "9", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialSkills"},
            };
            sections13.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();

            // Subject
            var sections14 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialStudiesHumanities"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialStudiesHumanities"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialStudiesHumanities"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialStudiesHumanities"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialStudiesHumanities"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialStudiesHumanities"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialStudiesHumanities"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialStudiesHumanities"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialStudiesHumanities"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "9", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "SocialStudiesHumanities"},
            };
            sections14.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();

            // Subject
            var sections15 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Technology"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Technology"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Technology"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Technology"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Technology"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Technology"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Technology"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Technology"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Technology"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "9", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Technology"},
            };
            sections15.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();

            // Subject
            var sections16 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Writing"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Writing"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Writing"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Writing"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Writing"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Writing"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Writing"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Writing"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Writing"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "9", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Writing"},
            };
            sections16.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();

            // Subject
            var sections17 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ClubC"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ClubC"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ClubC"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ClubC"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ClubC"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ClubC"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ClubC"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ClubC"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ClubC"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "9", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "ClubC"},
            };
            sections17.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();

            // Subject
            var sections18 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Crew"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Crew"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Crew"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Crew"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Crew"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Crew"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Crew"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Crew"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Crew"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "9", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Crew"},
            };
            sections18.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();

            // Subject
            var sections19 = new List<Section>
            {
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "K", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Sas"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "1", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Sas"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "2", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Sas"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "3", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Sas"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "4", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Sas"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "5", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Sas"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "6", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Sas"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "7", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Sas"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "8", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Sas"},
                new Section { Id = Guid.NewGuid(), Year = 2014, GradeLevelId = "9", Name = "", Description = "", KickOff = "", FinalProductName = "", FinalProductDescription = "", SectionTypeId = "Sas"},
            };
            sections19.ForEach(s => context.Sections.AddOrUpdate(s));
            context.SaveChanges();

            var bigIdeasForScience = new List<ScienceBigIdea>
            {
                new ScienceBigIdea
                {
                    Id = 1,
                    Name = "A system consists of related objects that form a whole.",
                    Category = "Systems"
                },
                new ScienceBigIdea
                {
                    Id = 2,
                    Name = "A change in one part of a system can change the whole system.",
                    Category = "Systems"
                },
                new ScienceBigIdea
                {
                    Id = 3,
                    Name = "Systems can be used to predict patterns.",
                    Category = "Systems"
                },
                new ScienceBigIdea
                {
                    Id = 4,
                    Name = "The physical characteristics of an organism directly impact its survival.",
                    Category = "Structure and Function"
                },
                new ScienceBigIdea
                {
                    Id = 5,
                    Name = "When an environment changes, an organism must adapt, move, or die.",
                    Category = "Structure and Function"
                },
                new ScienceBigIdea
                {
                    Id = 6,
                    Name = "Organisms need energy to survive.",
                    Category = "Structure and Function"
                },
                new ScienceBigIdea
                {
                    Id = 7,
                    Name = "Organisms have predictable patterns of change in growth and development.",
                    Category = "Constancy and Change"
                },
                new ScienceBigIdea
                {
                    Id = 8,
                    Name = "New technologies can cause change, and change can lead to new technologies.",
                    Category = "Constancy and Change"
                },
                new ScienceBigIdea
                {
                    Id = 9,
                    Name = "Forces of nature continuously change the Earth.",
                    Category = "Constancy and Change"
                },
                new ScienceBigIdea
                {
                    Id = 10,
                    Name = "Energy can change forms but cannot be created or destroyed.",
                    Category = "Constancy and Change"
                },
                new ScienceBigIdea
                {
                    Id = 11,
                    Name = "Organisms depend on one another and on their environment.",
                    Category = "Interdependence"
                },
                new ScienceBigIdea
                {
                    Id = 12,
                    Name = "Models can be used to represent observable science phenomenon.",
                    Category = "Models"
                },
                new ScienceBigIdea
                {
                    Id = 13,
                    Name = "Models can be used to test theories of science phenomenon that are not directly observable.",
                    Category = "Models"
                },
                new ScienceBigIdea
                {
                    Id = 14,
                    Name =
                        "Models involving hypothesized relationships and process can be used to find, articulate, and test theories.",
                    Category = "Models"
                },
                new ScienceBigIdea
                {
                    Id = 15,
                    Name = "Some things are so immense or minute that they are difficult to measure and understand.",
                    Category = "Scale"
                },
                new ScienceBigIdea
                {
                    Id = 16,
                    Name = "The ways in which things work may change with changes to scale.",
                    Category = "Scale"
                },
            };
            bigIdeasForScience.ForEach(g => context.ScienceBigIdeas.AddOrUpdate(g));
            context.SaveChanges();

            var bigIdeasForSocialStudies = new List<SocialStudiesBigIdea>
            {
                new SocialStudiesBigIdea()
                {
                    Id = 17,
                    Name = "Regions have diverse natural resources and geography.",
                    Category = "Geographic Relationships"
                },
                new SocialStudiesBigIdea()
                {
                    Id = 18,
                    Name = "Humans have an effect on the places they live.",
                    Category = "Geographic Relationships"
                },
                new SocialStudiesBigIdea()
                {
                    Id = 19,
                    Name = "Resources and the physical environment dictate what life is like in a particular region.",
                    Category = "Geographic Relationships"
                },
                new SocialStudiesBigIdea()
                {
                    Id = 20,
                    Name = "People migrate for a variety of reasons.",
                    Category = "Geographic Relationships"
                },
                new SocialStudiesBigIdea()
                {
                    Id = 21,
                    Name =
                        "A community’s government affects its culture, and a community’s culture affects its government.",
                    Category = "Evolution of Governance"
                },
                new SocialStudiesBigIdea()
                {
                    Id = 22,
                    Name = "Governance is how a community makes decisions.  Those decisions affect the people.",
                    Category = "Evolution of Governance"
                },
                new SocialStudiesBigIdea()
                {
                    Id = 23,
                    Name = "Democracy depends on the participation of its citizens.",
                    Category = "Evolution of Governance"
                },
                new SocialStudiesBigIdea()
                {
                    Id = 24,
                    Name = "Society drives the development of technology, and technology drives societal change.",
                    Category = "The Challenge of Progress"
                },
                new SocialStudiesBigIdea()
                {
                    Id = 25,
                    Name = "Economic systems impact decisions about the use of resources.",
                    Category = "The Challenge of Progress"
                },
                new SocialStudiesBigIdea()
                {
                    Id = 26,
                    Name = "People's culture is reflected in their celebrations and practices.",
                    Category = "Universals of Culture"
                },
                new SocialStudiesBigIdea()
                {
                    Id = 27,
                    Name = "People form communities based on their culture, beliefs, traditions, and values.",
                    Category = "Universals of Culture"
                },
                new SocialStudiesBigIdea()
                {
                    Id = 28,
                    Name = "Communities are dynamic.",
                    Category = "Universals of Culture"
                },
                new SocialStudiesBigIdea()
                {
                    Id = 29,
                    Name = "Differences in the access to resources can lead to conflict.",
                    Category = "Sources of Conflict"
                },
                new SocialStudiesBigIdea()
                {
                    Id = 30,
                    Name = "Cooperation and conflict among people contribute to political, economic, and social change.",
                    Category = "Sources of Conflict"
                },
                new SocialStudiesBigIdea()
                {
                    Id = 31,
                    Name = "Cultural differences and/or misunderstandings can lead to conflict.",
                    Category = "Sources of Conflict"
                },
                new SocialStudiesBigIdea()
                {
                    Id = 32,
                    Name =
                        "Historical patterns can be used to make sense of present events and predict future outcomes.",
                    Category = "Historical Inquiry"
                },
                new SocialStudiesBigIdea()
                {
                    Id = 33,
                    Name = "Examining multiple perspectives enriches our understanding of historical events.",
                    Category = "Historical Inquiry"
                },
            };
            bigIdeasForSocialStudies.ForEach(g => context.SocialStudiesBigIdeas.AddOrUpdate(g));
            context.SaveChanges();

            var habit = new List<Habit>
            {
                new Habit()
                {
                    Id = 1,
                    Name = "Quality",
                },
                new Habit()
                {
                    Id = 2,
                    Name = "Responsibility",
                },
                new Habit()
                {
                    Id = 3,
                    Name = "Collaboration",
                },
                new Habit()
                {
                    Id = 4,
                    Name = "Inquiry",
                },
                new Habit()
                {
                    Id = 5,
                    Name = "Perseverance",
                },
                new Habit()
                {
                    Id = 6,
                    Name = "Service and Compassion",
                },
            };
            habit.ForEach(g => context.Habits.AddOrUpdate(g));
            context.SaveChanges();
        }
    }
}

