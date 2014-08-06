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
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Mapper21.DAL.Provider.Mapper21Context context)
        {
            var grades = new List<GradeLevel>
            {
                new GradeLevel {Id = 1, Name = "Kindergarten"},
                new GradeLevel {Id = 2, Name = "First Grade"},
                new GradeLevel {Id = 3, Name = "Second Grade"},
                new GradeLevel {Id = 4, Name = "Third Grade"},
                new GradeLevel {Id = 5, Name = "Forth Grade"},
                new GradeLevel {Id = 6, Name = "Fifth Grade"},
                new GradeLevel {Id = 7, Name = "Sixth Grade"},
                new GradeLevel {Id = 8, Name = "Seventh Grade"},
                new GradeLevel {Id = 9, Name = "Eighth Grade"},
            };
            grades.ForEach(g => context.GradeLevels.Add(g));
            context.SaveChanges();

            var sectionTypes = new List<SectionType>
            {
                new SectionType {Id = 1, Name = "First Six Weeks"},
                new SectionType {Id = 2, Name = "Fall Expedition"},
                new SectionType {Id = 3, Name = "Mini Mester"},
                new SectionType {Id = 4, Name = "Spring Expedition"},
                new SectionType {Id = 5, Name = "Strand"},
            };
            sectionTypes.ForEach(s => context.SectionTypes.Add(s));
            context.SaveChanges();

            var subSectionTypes = new List<SubSectionType>
            {
                new SubSectionType {Id = 1, Name = "Week"},
                new SubSectionType {Id = 1, Name = "Case Study"},
                new SubSectionType {Id = 1, Name = "Unit"},
            };
            subSectionTypes.ForEach(s => context.SubSectionTypes.Add(s));
            context.SaveChanges();

            var subjectArea = new List<SubjectArea>
            {
                new SubjectArea {Id = 1, Name = "Art"},
                new SubjectArea {Id = 2, Name = "Foreign Languages"},
                new SubjectArea {Id = 3, Name = "Language Arts"},
                new SubjectArea {Id = 4, Name = "Mathematics"},
                new SubjectArea {Id = 5, Name = "Media"},
                new SubjectArea {Id = 6, Name = "Music"},
                new SubjectArea {Id = 7, Name = "Physical Education"},
                new SubjectArea {Id = 8, Name = "Science"},
                new SubjectArea {Id = 9, Name = "Social Skills"},
                new SubjectArea {Id = 10, Name = "Social Studies"},
                new SubjectArea {Id = 11, Name = "Technology"},
                new SubjectArea {Id = 12, Name = "Writing"},
            };
            subjectArea.ForEach(s => context.SubjectAreas.Add(s));
            context.SaveChanges();

            // Fall Expedition
            var section = new Section
            {
                Id = 1,
                Year = 2013,
                GradeLevelId = 3,
                Name = "Ancient Civilizations",
                Description = "Summary Information",
                KickOff = "Ancient Civilizations Summary information",
                FinalProductName = "Civilizations of the early years",
                FinalProductDescription =
                    "Civilization or civilisation generally refers to state polities which combine these basic institutions: " +
                    "a ceremonial centre (a formal gathering place for social and cultural activities), a system of writing, and a city. ",
                SectionTypeId = 2
            };
            context.Sections.Add(section);
            context.SaveChanges();

            // Spring Expedition
            var section2 = new Section
            {
                Id = 2,
                Year = 2013,
                GradeLevelId = 3,
                Name = "Spring Expedition",
                Description = "TBD",
                KickOff = "",
                FinalProductName = "",
                FinalProductDescription =
                    "",
                SectionTypeId = 4
            };
            context.Sections.Add(section2);
            context.SaveChanges();

            // FSW
            var section3 = new Section
            {
                Id = 3,
                Year = 2013,
                GradeLevelId = 3,
                Name = "First Six Weeks",
                Description = "TBD",
                SectionTypeId = 1
            };
            context.Sections.Add(section3);
            context.SaveChanges();

            // Mini-Mester
            var section4 = new Section
            {
                Id = 4,
                Year = 2013,
                GradeLevelId = 3,
                Name = "Mini-Semester - Fall",
                Description = "TBD",
                KickOff = "",
                FinalProductName = "",
                FinalProductDescription =
                    "",
                SectionTypeId = 3
            };
            context.Sections.Add(section4);
            context.SaveChanges();

            // Subject
            var section5 = new Section
            {
                Id = 5,
                Year = 2013,
                GradeLevelId = 3,
                Name = "Second Grade Art",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 1
            };
            context.Sections.Add(section5);
            context.SaveChanges();

            // Subject
            var section6 = new Section
            {
                Id = 6,
                Year = 2013,
                GradeLevelId = 3,
                Name = "Second Grade Foreign Languages",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 2
            };
            context.Sections.Add(section6);
            context.SaveChanges();

            // Subject
            var section7 = new Section
            {
                Id = 7,
                Year = 2013,
                GradeLevelId = 3,
                Name = "Second Grade Language Arts",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 3
            };
            context.Sections.Add(section7);
            context.SaveChanges();

            // Subject
            var section8 = new Section
            {
                Id = 8,
                Year = 2013,
                GradeLevelId = 3,
                Name = "Second Grade Mathematics",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 4
            };
            context.Sections.Add(section8);
            context.SaveChanges();

            // Subject
            var section9 = new Section
            {
                Id = 9,
                Year = 2013,
                GradeLevelId = 3,
                Name = "Second Grade Media",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 5
            };
            context.Sections.Add(section9);
            context.SaveChanges();

            // Subject
            var section10 = new Section
            {
                Id = 10,
                Year = 2013,
                GradeLevelId = 3,
                Name = "Second Grade Music",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 6
            };
            context.Sections.Add(section10);
            context.SaveChanges();

            // Subject
            var section11 = new Section
            {
                Id = 11,
                Year = 2013,
                GradeLevelId = 3,
                Name = "Second Grade Physical Education",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 7
            };
            context.Sections.Add(section11);
            context.SaveChanges();

            // Subject
            var section12 = new Section
            {
                Id = 12,
                Year = 2013,
                GradeLevelId = 3,
                Name = "Second Grade Science",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 8
            };
            context.Sections.Add(section12);
            context.SaveChanges();

            // Subject
            var section13 = new Section
            {
                Id = 13,
                Year = 2013,
                GradeLevelId = 3,
                Name = "Second Grade Social Skills",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 9
            };
            context.Sections.Add(section13);
            context.SaveChanges();

            // Subject
            var section14 = new Section
            {
                Id = 14,
                Year = 2013,
                GradeLevelId = 3,
                Name = "Second Grade Social Studies",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 10
            };
            context.Sections.Add(section14);
            context.SaveChanges();

            // Subject
            var section15 = new Section
            {
                Id = 15,
                Year = 2013,
                GradeLevelId = 3,
                Name = "Second Grade Technology",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 11
            };
            context.Sections.Add(section15);
            context.SaveChanges();

            // Subject
            var section16 = new Section
            {
                Id = 16,
                Year = 2013,
                GradeLevelId = 3,
                Name = "Second Grade Writing",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 12
            };
            context.Sections.Add(section16);
            context.SaveChanges();

            var caseStudy = new SubSection
            {
                Id = 1,
                SectionId = 1,
                Name = "Ancient Greece",
                Description =
                    "The ancient Greece case study encompasses several tasks associated with ancient civilizations.",
                SubSectionTypeId = 2
            };
            context.SubSections.Add(caseStudy);
            context.SaveChanges();

            var experts = new List<Expert>
            {
                new Expert {Id = 1, SubSectionId = 1, Name = "Tom Baker", Description = "Field Architect"},
                new Expert {Id = 1, SubSectionId = 1, Name = "Steven Smith", Description = "Historical Professional"},
                new Expert {Id = 1, SubSectionId = 1, Name = "Janet Fayhe", Description = "Interpreter"},
                new Expert {Id = 1, SubSectionId = 1, Name = "Chris Appleson", Description = "Biologist"},
                new Expert {Id = 1, SubSectionId = 1, Name = "Susan Johnson", Description = "Archaeologist"}
            };
            experts.ForEach(g => context.Experts.Add(g));
            context.SaveChanges();

            var fieldworks = new List<Fieldwork>
            {
                new Fieldwork {Id = 1, SubSectionId = 1, Name = "Anarundel Park Visit ", Description = "Exploratory"},
                new Fieldwork {Id = 1, SubSectionId = 1, Name = "Baltimore Aquarium", Description = "Scientific"},
            };
            fieldworks.ForEach(g => context.Fieldworks.Add(g));
            context.SaveChanges();

            var serviceLearnings = new List<ServiceLearning>
            {
                new ServiceLearning
                {
                    Id = 1,
                    SubSectionId = 1,
                    Name = "Natural Disasters",
                    Description = "Studied the consequences of natural disasters"
                },
                new ServiceLearning
                {
                    Id = 1,
                    SubSectionId = 1,
                    Name = "Health",
                    Description = "Learned about the health consequences of poor nutrition"
                },
                new ServiceLearning
                {
                    Id = 1,
                    SubSectionId = 1,
                    Name = "Wetlands",
                    Description = "Investigated the biological complexity and diversity of wetlands"
                },
                new ServiceLearning
                {
                    Id = 1,
                    SubSectionId = 1,
                    Name = "Non-Profit Organizations",
                    Description = "Looked for ways to support struggling local non-profit organizations"
                },
            };
            serviceLearnings.ForEach(g => context.ServiceLearnings.Add(g));
            context.SaveChanges();

            var expeditionHabits = new List<Habit>
            {
                new Habit
                {
                    Id = 1,
                    SectionId = 1,
                    Rationale =
                        "Synergy is achieved when two or more people work together to create something better than either could alone.",
                    Description = "Synergize"
                },
                new Habit
                {
                    Id = 1,
                    SectionId = 1,
                    Rationale =
                        "Creates a personal mission statement which will act as a road map and direct and guide decision-making.",
                    Description = "Begin With the End in Mind"
                },
            };
            expeditionHabits.ForEach(g => context.Habits.Add(g));
            context.SaveChanges();

            var guidingQuestions = new List<GuidingQuestion>
            {
                new GuidingQuestion {Id = 1, SectionId = 1, Name = "Who will survive? or, What is waste?"},
                new GuidingQuestion {Id = 1, SectionId = 1, Name = "Where do waves come from?"},
                new GuidingQuestion {Id = 1, SectionId = 1, Name = "What is health?"},
                new GuidingQuestion {Id = 1, SectionId = 1, Name = "When are laws fair?"},
            };
            guidingQuestions.ForEach(g => context.GuidingQuestions.Add(g));
            context.SaveChanges();

            var scienceBigIdeas = new List<ScienceBigIdea>
            {
                new ScienceBigIdea
                {
                    Id = 1,
                    SectionId = 1,
                    Rationale = "Promotes learning about environmental changes.",
                    Idea = "Structure and Function: When an environment changes, an organism must adapt, move, or die."
                },
                new ScienceBigIdea
                {
                    Id = 1,
                    SectionId = 1,
                    Rationale = "Learn about organisms.",
                    Idea = "Interdependence: Organisms depend on one another and on their environment."
                },
                new ScienceBigIdea
                {
                    Id = 1,
                    SectionId = 1,
                    Rationale = "Understanding size and scale.",
                    Idea =
                        "Scale: Some things are so immense or minute that they are difficult to measure and understand."
                },
            };
            scienceBigIdeas.ForEach(g => context.ScienceBigIdeases.Add(g));
            context.SaveChanges();

            var socialStudiesBigIdeas = new List<SocialStudiesBigIdea>
            {
                new SocialStudiesBigIdea
                {
                    Id = 1,
                    SectionId = 1,
                    Rationale = "Understand importance of migration.",
                    Idea = "Geographic Relationships: People migrate for a variety of reasons."
                },
                new SocialStudiesBigIdea
                {
                    Id = 1,
                    SectionId = 1,
                    Rationale = "Promote understanding of different cultures.",
                    Idea = "Universals of Culture: Cultures are dynamic."
                },
                new SocialStudiesBigIdea
                {
                    Id = 1,
                    SectionId = 1,
                    Rationale = "Raise awareness of regional change",
                    Idea = "Geographic Relationships: Changes in regions have human implications."
                },
            };
            socialStudiesBigIdeas.ForEach(g => context.SocialStudiesBigIdeas.Add(g));
            context.SaveChanges();
        }
    }
}
