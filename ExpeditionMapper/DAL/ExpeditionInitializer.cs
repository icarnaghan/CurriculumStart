using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
        }
    }
}