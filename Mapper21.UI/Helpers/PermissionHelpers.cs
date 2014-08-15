namespace Mapper21.UI.Helpers
{
    public class PermissionHelpers
    {
        public static string GetCurrentGradeLevel(System.Security.Principal.IPrincipal user)
        {
            var gradeLevelId = "";
            if (user.IsInRole("Kindergarten")) gradeLevelId = "K";
            if (user.IsInRole("First Grade")) gradeLevelId = "1";
            if (user.IsInRole("Second Grade")) gradeLevelId = "2";
            if (user.IsInRole("Third Grade")) gradeLevelId = "3";
            if (user.IsInRole("Fourth Grade")) gradeLevelId = "4";
            if (user.IsInRole("Fifth Grade")) gradeLevelId = "5";
            if (user.IsInRole("Sixth Grade")) gradeLevelId = "6";
            if (user.IsInRole("Sixth Grade")) gradeLevelId = "7";
            if (user.IsInRole("Sixth Grade")) gradeLevelId = "8";
            return gradeLevelId;
        }

        public static int CurrentSubjectArea(string subjectArea)
        {
            var subjectAreaId = 0;
            if (subjectArea == "Art") subjectAreaId = 1;
            if (subjectArea == "ForeignLanguages") subjectAreaId = 2;
            if (subjectArea == "LanguageArts") subjectAreaId = 3;
            if (subjectArea == "Mathematics") subjectAreaId = 4;
            if (subjectArea == "Media") subjectAreaId = 5;
            if (subjectArea == "Music") subjectAreaId = 6;
            if (subjectArea == "PhysicalEducation") subjectAreaId = 7;
            if (subjectArea == "Science") subjectAreaId = 8;
            if (subjectArea == "SocialSkills") subjectAreaId = 9;
            if (subjectArea == "SocialStudies") subjectAreaId = 10;
            if (subjectArea == "Technology") subjectAreaId = 11;
            if (subjectArea == "Writing") subjectAreaId = 12;
            return subjectAreaId;
        }

        public static string GetSubSectionType(string sectionTypeId)
        {
            switch (sectionTypeId)
            {
                case "FirstSixWeeks":
                    return "Week"; // Return Week Type
                case "Strand": // Strand
                    return "Unit"; // Return Unit Type
                default:
                    return "CaseStudy"; // Return Case Study Type
            }
        }
    }
}