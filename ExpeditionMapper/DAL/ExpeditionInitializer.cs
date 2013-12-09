using System.Collections.Generic;
using System.Data.Entity;
using ExpeditionMapper.Models.Domain;
using ExpeditionMapper.Models.Domain.LookUps;

namespace ExpeditionMapper.DAL
{
    public class ExpeditionInitializer : DropCreateDatabaseIfModelChanges<ExpeditionContext>
    {
        protected override void Seed(ExpeditionContext context)
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

            var expedition = new Expedition
            {
                Id = 1,
                Year = 2013,
                GradeLevelId = 2,
                Name = "Ancient Civilizations",
                Description = "Summary Information",
                KickOff = "Ancient Civilizations Summary information",
                FinalProductName = "Civilizations of the early years",
                FinalProductDescription =
                    "Civilization or civilisation generally refers to state polities which combine these basic institutions: " +
                    "a ceremonial centre (a formal gathering place for social and cultural activities), a system of writing, and a city. "
            };
            context.Expeditions.Add(expedition);
            context.SaveChanges();

            var caseStudy = new CaseStudy
            {
                Id = 1,
                ExpeditionId = 1,
                Name = "Ancient Greece",
                Description =
                    "The ancient Greece case study encompasses several tasks associated with ancient civilizations."
            };
            context.CaseStudies.Add(caseStudy);
            context.SaveChanges();

            var experts = new List<Expert>
            {
                new Expert {Id = 1, CaseStudyId = 1, Name = "Tom Baker", Description = "Field Architect"},
                new Expert {Id = 1, CaseStudyId = 1, Name = "Steven Smith", Description = "Historical Professional"},
                new Expert {Id = 1, CaseStudyId = 1, Name = "Janet Fayhe", Description = "Interpreter"},
                new Expert {Id = 1, CaseStudyId = 1, Name = "Chris Appleson", Description = "Biologist"},
                new Expert {Id = 1, CaseStudyId = 1, Name = "Susan Johnson", Description = "Archaeologist"}
            };
            experts.ForEach(g => context.Experts.Add(g));
            context.SaveChanges();

            var fieldworks = new List<Fieldwork>
            {
                new Fieldwork {Id = 1, CaseStudyId = 1, Name = "Anarundel Park Visit ", Description = "Exploratory"},
                new Fieldwork {Id = 1, CaseStudyId = 1, Name = "Baltimore Aquarium", Description = "Scientific"},
            };
            fieldworks.ForEach(g => context.Fieldworks.Add(g));
            context.SaveChanges();

            var serviceLearnings = new List<ServiceLearning>
            {
                new ServiceLearning {Id = 1, CaseStudyId = 1, Name = "Natural Disasters", Description = "Studied the consequences of natural disasters"},
                new ServiceLearning {Id = 1, CaseStudyId = 1, Name = "Health", Description = "Learned about the health consequences of poor nutrition"},
                new ServiceLearning {Id = 1, CaseStudyId = 1, Name = "Wetlands", Description = "Investigated the biological complexity and diversity of wetlands"},
                new ServiceLearning {Id = 1, CaseStudyId = 1, Name = "Non-Profit Organizations", Description = "Looked for ways to support struggling local non-profit organizations"},
            };
            serviceLearnings.ForEach(g => context.ServiceLearnings.Add(g));
            context.SaveChanges();

            var expeditionHabits = new List<ExpeditionHabit>
            {
                new ExpeditionHabit {Id = 1, ExpeditionId = 1, Rationale = "Synergy is achieved when two or more people work together to create something better than either could alone.", Habit = "Synergize"},
                new ExpeditionHabit {Id = 1, ExpeditionId = 1, Rationale = "Creates a personal mission statement which will act as a road map and direct and guide decision-making.", Habit = "Begin With the End in Mind"},
            };
            expeditionHabits.ForEach(g => context.ExpeditionHabits.Add(g));
            context.SaveChanges();

            var guidingQuestions = new List<GuidingQuestion>
            {
                new GuidingQuestion {Id = 1, ExpeditionId = 1, Name = "Who will survive? or, What is waste?"},
                new GuidingQuestion {Id = 1, ExpeditionId = 1, Name = "Where do waves come from?"},
                new GuidingQuestion {Id = 1, ExpeditionId = 1, Name = "What is health?"},
                new GuidingQuestion {Id = 1, ExpeditionId = 1, Name = "When are laws fair?"},
            };
            guidingQuestions.ForEach(g => context.GuidingQuestions.Add(g));
            context.SaveChanges();

            var scienceBigIdeas = new List<ScienceBigIdea>
            {
                new ScienceBigIdea {Id = 1, ExpeditionId = 1, Rationale = "Promotes learning about environmental changes.", Idea = "Structure and Function: When an environment changes, an organism must adapt, move, or die."},
                new ScienceBigIdea {Id = 1, ExpeditionId = 1, Rationale = "Learn about organisms.", Idea = "Interdependence: Organisms depend on one another and on their environment."},
                new ScienceBigIdea {Id = 1, ExpeditionId = 1, Rationale = "Understanding size and scale.", Idea = "Scale: Some things are so immense or minute that they are difficult to measure and understand."},
            };
            scienceBigIdeas.ForEach(g => context.ScienceBigIdeases.Add(g));
            context.SaveChanges();

            var socialStudiesBigIdeas = new List<SocialStudiesBigIdea>
            {
                new SocialStudiesBigIdea {Id = 1, ExpeditionId = 1, Rationale = "Understand importance of migration.", Idea = "Geographic Relationships: People migrate for a variety of reasons."},
                new SocialStudiesBigIdea {Id = 1, ExpeditionId = 1, Rationale = "Promote understanding of different cultures.", Idea = "Universals of Culture: Cultures are dynamic."},
                new SocialStudiesBigIdea {Id = 1, ExpeditionId = 1, Rationale = "Raise awareness of regional change", Idea = "Geographic Relationships: Changes in regions have human implications."},
            };
            socialStudiesBigIdeas.ForEach(g => context.SocialStudiesBigIdeas.Add(g));
            context.SaveChanges();
        }
    }
}