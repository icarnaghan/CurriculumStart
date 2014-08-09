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
                new SectionType {Id = 1, Name = "First Six Weeks"},
                new SectionType {Id = 2, Name = "Fall Expedition"},
                new SectionType {Id = 3, Name = "Mini Mester"},
                new SectionType {Id = 4, Name = "Spring Expedition"},
                new SectionType {Id = 5, Name = "Strand"},
            };
            sectionTypes.ForEach(s => context.SectionTypes.AddOrUpdate(s));
            context.SaveChanges();

            var subSectionTypes = new List<SubSectionType>
            {
                new SubSectionType {Id = 1, Name = "Week"},
                new SubSectionType {Id = 1, Name = "Case Study"},
                new SubSectionType {Id = 1, Name = "Unit"},
            };
            subSectionTypes.ForEach(s => context.SubSectionTypes.AddOrUpdate(s));
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
            subjectArea.ForEach(s => context.SubjectAreas.AddOrUpdate(s));
            context.SaveChanges();

            // Fall Expedition
            var section = new Section
            {
                Id = 1,
                Year = 2013,
                GradeLevelId = "2",
                Name = "Ancient Civilizations",
                Description = "Summary Information",
                KickOff = "Ancient Civilizations Summary information",
                FinalProductName = "Civilizations of the early years",
                FinalProductDescription =
                    "Civilization or civilisation generally refers to state polities which combine these basic institutions: " +
                    "a ceremonial centre (a formal gathering place for social and cultural activities), a system of writing, and a city. ",
                SectionTypeId = 2
            };
            context.Sections.AddOrUpdate(section);
            context.SaveChanges();

            // Spring Expedition
            var section2 = new Section
            {
                Id = 2,
                Year = 2013,
                GradeLevelId = "2",
                Name = "Spring Expedition",
                Description = "TBD",
                KickOff = "",
                FinalProductName = "",
                FinalProductDescription =
                    "",
                SectionTypeId = 4
            };
            context.Sections.AddOrUpdate(section2);
            context.SaveChanges();

            // FSW
            var section3 = new Section
            {
                Id = 3,
                Year = 2013,
                GradeLevelId = "2",
                Name = "First Six Weeks",
                Description = "TBD",
                SectionTypeId = 1
            };
            context.Sections.AddOrUpdate(section3);
            context.SaveChanges();

            // Mini-Mester
            var section4 = new Section
            {
                Id = 4,
                Year = 2013,
                GradeLevelId = "2",
                Name = "Mini-Semester - Fall",
                Description = "TBD",
                KickOff = "",
                FinalProductName = "",
                FinalProductDescription =
                    "",
                SectionTypeId = 3
            };
            context.Sections.AddOrUpdate(section4);
            context.SaveChanges();

            // Subject
            var section5 = new Section
            {
                Id = 5,
                Year = 2013,
                GradeLevelId = "2",
                Name = "Second Grade Art",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 1
            };
            context.Sections.AddOrUpdate(section5);
            context.SaveChanges();

            // Subject
            var section6 = new Section
            {
                Id = 6,
                Year = 2013,
                GradeLevelId = "2",
                Name = "Second Grade Foreign Languages",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 2
            };
            context.Sections.AddOrUpdate(section6);
            context.SaveChanges();

            // Subject
            var section7 = new Section
            {
                Id = 7,
                Year = 2013,
                GradeLevelId = "2",
                Name = "Second Grade Language Arts",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 3
            };
            context.Sections.AddOrUpdate(section7);
            context.SaveChanges();

            // Subject
            var section8 = new Section
            {
                Id = 8,
                Year = 2013,
                GradeLevelId = "2",
                Name = "Second Grade Mathematics",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 4
            };
            context.Sections.AddOrUpdate(section8);
            context.SaveChanges();

            // Subject
            var section9 = new Section
            {
                Id = 9,
                Year = 2013,
                GradeLevelId = "2",
                Name = "Second Grade Media",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 5
            };
            context.Sections.AddOrUpdate(section9);
            context.SaveChanges();

            // Subject
            var section10 = new Section
            {
                Id = 10,
                Year = 2013,
                GradeLevelId = "2",
                Name = "Second Grade Music",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 6
            };
            context.Sections.AddOrUpdate(section10);
            context.SaveChanges();

            // Subject
            var section11 = new Section
            {
                Id = 11,
                Year = 2013,
                GradeLevelId = "2",
                Name = "Second Grade Physical Education",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 7
            };
            context.Sections.AddOrUpdate(section11);
            context.SaveChanges();

            // Subject
            var section12 = new Section
            {
                Id = 12,
                Year = 2013,
                GradeLevelId = "2",
                Name = "Second Grade Science",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 8
            };
            context.Sections.AddOrUpdate(section12);
            context.SaveChanges();

            // Subject
            var section13 = new Section
            {
                Id = 13,
                Year = 2013,
                GradeLevelId = "2",
                Name = "Second Grade Social Skills",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 9
            };
            context.Sections.AddOrUpdate(section13);
            context.SaveChanges();

            // Subject
            var section14 = new Section
            {
                Id = 14,
                Year = 2013,
                GradeLevelId = "2",
                Name = "Second Grade Social Studies",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 10
            };
            context.Sections.AddOrUpdate(section14);
            context.SaveChanges();

            // Subject
            var section15 = new Section
            {
                Id = 15,
                Year = 2013,
                GradeLevelId = "2",
                Name = "Second Grade Technology",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 11
            };
            context.Sections.AddOrUpdate(section15);
            context.SaveChanges();

            // Subject
            var section16 = new Section
            {
                Id = 16,
                Year = 2013,
                GradeLevelId = "2",
                Name = "Second Grade Writing",
                Description = "TBD",
                KickOff = "",
                SectionTypeId = 5,
                SubjectAreaId = 12
            };
            context.Sections.AddOrUpdate(section16);
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
            context.SubSections.AddOrUpdate(caseStudy);
            context.SaveChanges();

            var experts = new List<SubSectionExpert>
            {
                new SubSectionExpert {Id = 1, SubSectionId = 1, Name = "Tom Baker", Description = "Field Architect"},
                new SubSectionExpert {Id = 1, SubSectionId = 1, Name = "Steven Smith", Description = "Historical Professional"},
                new SubSectionExpert {Id = 1, SubSectionId = 1, Name = "Janet Fayhe", Description = "Interpreter"},
                new SubSectionExpert {Id = 1, SubSectionId = 1, Name = "Chris Appleson", Description = "Biologist"},
                new SubSectionExpert {Id = 1, SubSectionId = 1, Name = "Susan Johnson", Description = "Archaeologist"}
            };
            experts.ForEach(g => context.Experts.AddOrUpdate(g));
            context.SaveChanges();

            var fieldworks = new List<SubSectionFieldwork>
            {
                new SubSectionFieldwork {Id = 1, SubSectionId = 1, Name = "Anarundel Park Visit ", Description = "Exploratory"},
                new SubSectionFieldwork {Id = 1, SubSectionId = 1, Name = "Baltimore Aquarium", Description = "Scientific"},
            };
            fieldworks.ForEach(g => context.Fieldworks.AddOrUpdate(g));
            context.SaveChanges();

            var serviceLearnings = new List<SubSectionServiceLearning>
            {
                new SubSectionServiceLearning
                {
                    Id = 1,
                    SubSectionId = 1,
                    Name = "Natural Disasters",
                    Description = "Studied the consequences of natural disasters"
                },
                new SubSectionServiceLearning
                {
                    Id = 1,
                    SubSectionId = 1,
                    Name = "Health",
                    Description = "Learned about the health consequences of poor nutrition"
                },
                new SubSectionServiceLearning
                {
                    Id = 1,
                    SubSectionId = 1,
                    Name = "Wetlands",
                    Description = "Investigated the biological complexity and diversity of wetlands"
                },
                new SubSectionServiceLearning
                {
                    Id = 1,
                    SubSectionId = 1,
                    Name = "Non-Profit Organizations",
                    Description = "Looked for ways to support struggling local non-profit organizations"
                },
            };
            serviceLearnings.ForEach(g => context.ServiceLearnings.AddOrUpdate(g));
            context.SaveChanges();

            var expeditionHabits = new List<SectionHabit>
            {
                new SectionHabit
                {
                    Id = 1,
                    SectionId = 1,
                    Rationale =
                        "Synergy is achieved when two or more people work together to create something better than either could alone.",
                    Description = "Synergize"
                },
                new SectionHabit
                {
                    Id = 1,
                    SectionId = 1,
                    Rationale =
                        "Creates a personal mission statement which will act as a road map and direct and guide decision-making.",
                    Description = "Begin With the End in Mind"
                },
            };
            expeditionHabits.ForEach(g => context.Habits.AddOrUpdate(g));
            context.SaveChanges();

            var guidingQuestions = new List<SectionGuidingQuestion>
            {
                new SectionGuidingQuestion {Id = 1, SectionId = 1, Name = "Who will survive? or, What is waste?"},
                new SectionGuidingQuestion {Id = 1, SectionId = 1, Name = "Where do waves come from?"},
                new SectionGuidingQuestion {Id = 1, SectionId = 1, Name = "What is health?"},
                new SectionGuidingQuestion {Id = 1, SectionId = 1, Name = "When are laws fair?"},
            };
            guidingQuestions.ForEach(g => context.GuidingQuestions.AddOrUpdate(g));
            context.SaveChanges();

            var scienceBigIdeas = new List<SectionBigIdeasForScience>
            {
                new SectionBigIdeasForScience
                {
                    Id = 1,
                    SectionId = 1,
                    Rationale = "Promotes learning about environmental changes.",
                    Idea = "Structure and Function: When an environment changes, an organism must adapt, move, or die."
                },
                new SectionBigIdeasForScience
                {
                    Id = 1,
                    SectionId = 1,
                    Rationale = "Learn about organisms.",
                    Idea = "Interdependence: Organisms depend on one another and on their environment."
                },
                new SectionBigIdeasForScience
                {
                    Id = 1,
                    SectionId = 1,
                    Rationale = "Understanding size and scale.",
                    Idea =
                        "Scale: Some things are so immense or minute that they are difficult to measure and understand."
                },
            };
            scienceBigIdeas.ForEach(g => context.ScienceBigIdeases.AddOrUpdate(g));
            context.SaveChanges();

            var socialStudiesBigIdeas = new List<SectionBigIdeasForSocialStudies>
            {
                new SectionBigIdeasForSocialStudies
                {
                    Id = 1,
                    SectionId = 1,
                    Rationale = "Understand importance of migration.",
                    Idea = "Geographic Relationships: People migrate for a variety of reasons."
                },
                new SectionBigIdeasForSocialStudies
                {
                    Id = 1,
                    SectionId = 1,
                    Rationale = "Promote understanding of different cultures.",
                    Idea = "Universals of Culture: Cultures are dynamic."
                },
                new SectionBigIdeasForSocialStudies
                {
                    Id = 1,
                    SectionId = 1,
                    Rationale = "Raise awareness of regional change",
                    Idea = "Geographic Relationships: Changes in regions have human implications."
                },
            };
            socialStudiesBigIdeas.ForEach(g => context.SocialStudiesBigIdeas.AddOrUpdate(g));
            context.SaveChanges();

            var bigIdeasForScience = new List<BigIdeaForScience>
            {
                new BigIdeaForScience
                {
                    Name = "A system consists of related objects that form a whole.",
                    Category = "Systems"
                },
                new BigIdeaForScience
                {
                    Name = "A change in one part of a system can change the whole system.",
                    Category = "Systems"
                },
                new BigIdeaForScience
                {
                    Name = "Systems can be used to predict patterns.",
                    Category = "Systems"
                },
                new BigIdeaForScience
                {
                    Name = "The physical characteristics of an organism directly impact its survival.",
                    Category = "Structure and Function"
                },
                new BigIdeaForScience
                {
                    Name = "When an environment changes, an organism must adapt, move, or die.",
                    Category = "Structure and Function"
                },
                new BigIdeaForScience
                {
                    Name = "Organisms need energy to survive.",
                    Category = "Structure and Function"
                },
                new BigIdeaForScience
                {
                    Name = "Organisms have predictable patterns of change in growth and development.",
                    Category = "Constancy and Change"
                },
                new BigIdeaForScience
                {
                    Name = "New technologies can cause change, and change can lead to new technologies.",
                    Category = "Constancy and Change"
                },
                new BigIdeaForScience
                {
                    Name = "Forces of nature continuously change the Earth.",
                    Category = "Constancy and Change"
                },
                new BigIdeaForScience
                {
                    Name = "Energy can change forms but cannot be created or destroyed.",
                    Category = "Constancy and Change"
                },
                new BigIdeaForScience
                {
                    Name = "Organisms depend on one another and on their environment.",
                    Category = "Interdependence"
                },
                new BigIdeaForScience
                {
                    Name = "Models can be used to represent observable science phenomenon.",
                    Category = "Models"
                },
                new BigIdeaForScience
                {
                    Name = "Models can be used to test theories of science phenomenon that are not directly observable.",
                    Category = "Models"
                },
                new BigIdeaForScience
                {
                    Name =
                        "Models involving hypothesized relationships and process can be used to find, articulate, and test theories.",
                    Category = "Models"
                },
                new BigIdeaForScience
                {
                    Name = "Some things are so immense or minute that they are difficult to measure and understand.",
                    Category = "Scale"
                },
                new BigIdeaForScience
                {
                    Name = "The ways in which things work may change with changes to scale.",
                    Category = "Scale"
                },
            };
            bigIdeasForScience.ForEach(g => context.BigIdeas.AddOrUpdate(g));
            context.SaveChanges();

            var bigIdeasForSocialStudies = new List<BigIdeaForSocialStudies>
            {
                new BigIdeaForSocialStudies()
                {
                    Name = "Regions have diverse natural resources and geography.",
                    Category = "Geographic Relationships"
                },
                new BigIdeaForSocialStudies()
                {
                    Name = "Humans have an effect on the places they live.",
                    Category = "Geographic Relationships"
                },
                new BigIdeaForSocialStudies()
                {
                    Name = "Resources and the physical environment dictate what life is like in a particular region.",
                    Category = "Geographic Relationships"
                },
                new BigIdeaForSocialStudies()
                {
                    Name = "People migrate for a variety of reasons.",
                    Category = "Geographic Relationships"
                },
                new BigIdeaForSocialStudies()
                {
                    Name =
                        "A community’s government affects its culture, and a community’s culture affects its government.",
                    Category = "Evolution of Governance"
                },
                new BigIdeaForSocialStudies()
                {
                    Name = "Governance is how a community makes decisions.  Those decisions affect the people.",
                    Category = "Evolution of Governance"
                },
                new BigIdeaForSocialStudies()
                {
                    Name = "Democracy depends on the participation of its citizens.",
                    Category = "Evolution of Governance"
                },
                new BigIdeaForSocialStudies()
                {
                    Name = "Society drives the development of technology, and technology drives societal change.",
                    Category = "The Challenge of Progress"
                },
                new BigIdeaForSocialStudies()
                {
                    Name = "Economic systems impact decisions about the use of resources.",
                    Category = "The Challenge of Progress"
                },
                new BigIdeaForSocialStudies()
                {
                    Name = "People's culture is reflected in their celebrations and practices.",
                    Category = "Universals of Culture"
                },
                new BigIdeaForSocialStudies()
                {
                    Name = "People form communities based on their culture, beliefs, traditions, and values.",
                    Category = "Universals of Culture"
                },
                new BigIdeaForSocialStudies()
                {
                    Name = "Communities are dynamic.",
                    Category = "Universals of Culture"
                },
                new BigIdeaForSocialStudies()
                {
                    Name = "Differences in the access to resources can lead to conflict.",
                    Category = "Sources of Conflict"
                },
                new BigIdeaForSocialStudies()
                {
                    Name = "Cooperation and conflict among people contribute to political, economic, and social change.",
                    Category = "Sources of Conflict"
                },
                new BigIdeaForSocialStudies()
                {
                    Name = "Cultural differences and/or misunderstandings can lead to conflict.",
                    Category = "Sources of Conflict"
                },
                new BigIdeaForSocialStudies()
                {
                    Name =
                        "Historical patterns can be used to make sense of present events and predict future outcomes.",
                    Category = "Historical Inquiry"
                },
                new BigIdeaForSocialStudies()
                {
                    Name = "Examining multiple perspectives enriches our understanding of historical events.",
                    Category = "Historical Inquiry"
                },
            };
            bigIdeasForSocialStudies.ForEach(g => context.BigIdeas.AddOrUpdate(g));
            context.SaveChanges();
        }
    }
}

