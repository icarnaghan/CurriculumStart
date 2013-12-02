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

            var bigIdeasScience = new List<BigIdeasScience>
            {
                new BigIdeasScience{Id = 1, Name = "Systems: A system consists of related objects that form a whole."},
                new BigIdeasScience{Id = 2, Name = "Systems: A change in one part of a system can change the whole system."},
                new BigIdeasScience{Id = 3, Name = "Systems: Systems can be used to predict patterns."},
                new BigIdeasScience{Id = 4, Name = "Structure and Function: The physical characteristics of an organism directly impact its survival."},
                new BigIdeasScience{Id = 5, Name = "Structure and Function: When an environment changes, an organism must adapt, move, or die."},
                new BigIdeasScience{Id = 6, Name = "Structure and Function: Organisms need energy to survive."},
                new BigIdeasScience{Id = 7, Name = "Constancy and Change: Organisms have predictable patterns of change in growth and development."},
                new BigIdeasScience{Id = 8, Name = "Constancy and Change: New technologies can cause change, and change can lead to new technologies."},
                new BigIdeasScience{Id = 9, Name = "Constancy and Change: Forces of nature continuously change the Earth."},
                new BigIdeasScience{Id = 10, Name = "Constancy and Change: Energy can change forms but cannot be created or destroyed."},
                new BigIdeasScience{Id = 11, Name = "Interdependence: Organisms depend on one another and on their environment."},
                new BigIdeasScience{Id = 12, Name = "Models: Models can be used to represent observable science phenomenon."},
                new BigIdeasScience{Id = 13, Name = "Models: Models can be used to test theories of science phenomenon that are not directly observable."},
                new BigIdeasScience{Id = 14, Name = "Models: Models involving hypothesized relationships and process can be used to find, articulate, and test theories."},
                new BigIdeasScience{Id = 15, Name = "Scale: Some things are so immense or minute that they are difficult to measure and understand."},
                new BigIdeasScience{Id = 16, Name = "Scale: The ways in which things work may change with changes to scale."}
            };
            bigIdeasScience.ForEach(g => context.BigIdeas.Add(g));
            context.SaveChanges();

            var bigIdeasSocialStudies = new List<BigIdeasSocialStudies>
            {
                new BigIdeasSocialStudies{Id = 1, Name = "Geographic Relationships: Regions are defined in multiple ways."},
                new BigIdeasSocialStudies{Id = 2, Name = "Geographic Relationships: Humans have an effect on the places they live."},
                new BigIdeasSocialStudies{Id = 3, Name = "Geographic Relationships: Resources and the physical environment dictate what life is like in a particular region."},
                new BigIdeasSocialStudies{Id = 4, Name = "Geographic Relationships: Changes in regions have human implications"},
                new BigIdeasSocialStudies{Id = 5, Name = "Geographic Relationships: People migrate for a variety of reasons."},
                new BigIdeasSocialStudies{Id = 6, Name = "Evolution of Governance: A community’s government affects its culture, and a community’s culture affects its government."},
                new BigIdeasSocialStudies{Id = 7, Name = "Evolution of Governance: Power is gained, used and justified in many ways."},
                new BigIdeasSocialStudies{Id = 8, Name = "Evolution of Governance: Governance is how a community makes decisions and communicates a value of the role of the institution and the role of the individual."},
                new BigIdeasSocialStudies{Id = 9, Name = "Evolution of Governance: Democracy depends on the understanding and participation of its citizens"},
                new BigIdeasSocialStudies{Id = 10, Name = "The Challenge of Progress: Society drives the development of technology, and technology drives societal change."},
                new BigIdeasSocialStudies{Id = 11, Name = "The Challenge of Progress: Economic systems impact decisions about the use of resources."},
                new BigIdeasSocialStudies{Id = 12, Name = "The Challenge of Progress: Scientific, technological and economic developments have affected people’s lives and political structures."},
                new BigIdeasSocialStudies{Id = 13, Name = "The Challenge of Progress: Technology today forms the basis for some of the most difficult social choices."},
                new BigIdeasSocialStudies{Id = 14, Name = "The Challenge of Progress: Tensions between national interests and global priorities contribute to the development of a solution to persistent and emerging global issues in many fields."},
                new BigIdeasSocialStudies{Id = 15, Name = "Universals of Culture: People’s culture is reflected in their celebrations and practices."},
                new BigIdeasSocialStudies{Id = 16, Name = "Universals of Culture: People form communities based on their culture, beliefs, traditions, and values."},
                new BigIdeasSocialStudies{Id = 17, Name = "Universals of Culture: Cultures are dynamic."},
                new BigIdeasSocialStudies{Id = 18, Name = "Universals of Culture: Patterns and relationships within and among world cultures lead to policy that has both national and global interactions."},
                new BigIdeasSocialStudies{Id = 19, Name = "Sources of Conflict: Differences in the access to resources can lead to conflict."},
                new BigIdeasSocialStudies{Id = 20, Name = "Sources of Conflict: Cooperation and conflict among people contribute to political, economic, and social change."},
                new BigIdeasSocialStudies{Id = 21, Name = "Sources of Conflict: Cultural differences and/or misunderstandings can lead to conflict."},
                new BigIdeasSocialStudies{Id = 22, Name = "Historical Inquiry: Historical patterns can be used to make sense of present events and predict future outcomes."},
                new BigIdeasSocialStudies{Id = 23, Name = "Historical Inquiry: Examining multiple perspectives enriches our understanding of historical events."},
                new BigIdeasSocialStudies{Id = 24, Name = "Production, Distribution and Consumption: People have wants that often exceed the limited resources available to them."},
                new BigIdeasSocialStudies{Id = 25, Name = "Production, Distribution and Consumption: Unequal distribution of resources necessitates systems of exchange."},
                new BigIdeasSocialStudies{Id = 26, Name = "Production, Distribution and Consumption: The role of government in economic policymaking varies over time and from place to place."}
            };
            bigIdeasSocialStudies.ForEach(g => context.BigIdeas.Add(g));
            context.SaveChanges();

        }
    }
}