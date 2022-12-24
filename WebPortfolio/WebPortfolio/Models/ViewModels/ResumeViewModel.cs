using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebPortfolio.Models.ViewModels
{
    public class ResumeViewModel
    {
        public string Title { get; set; }
        public string ApplicantName { get; set; }
        public string ProfileDescription { get; set; }
        public string ProjectDescription { get; set; }
        public IEnumerable<string> TechnicalSkills { get; set; }
        public IEnumerable<string> References { get; set; }
        public IEnumerable<string> Achievements { get; set; }
        public List<string> ContactDetails { get; set; }
        public List<string> ContactDetailsDescription { get; set; }
        public Dictionary<string, List<string>> EmploymentHistoryDescription { get; set; }
        public string JobTitle1 { get; set; }
        public string JobTitle2 { get; set; }
        public ResumeViewModel LoadFrom()
        {
            const string jobTitle1 = "Analyst Programmer";
            const string jobTitle2 = "Software Developer";

            var jobDescription1 = new List<string>
            {
                "Primarily making use of Regex and Linux based commands to analyse " +
                "multiple logs before preparing a script/parser to parse over the data whilst applying various" +
                "integration techniques to extract relevant information."
            };
            var jobDescription2 = new List<string>
            {
                "Played a key role in organising and planning the next steps for integrating existing technologies " +
                "towards new innovative systems",
                "Writing scalable, maintainable and testable code to a high standard using C# .NET " +
                "whilst Maintaining existing applications and products (including legacy technologies).",
                "Responsible for overseeing / delivering weekly deployments ensuring pull requests are to a high coding " +
                "standard and adhere to good coding conventions/ best practices."
            };

            var vm = new ResumeViewModel
            {
                Title = "Software Developer",
                ApplicantName = "DionParry",
                ProfileDescription = "A confident and highly motivated individual with strong problem solving abilities. " +
                                     "Skilled at working closely with others in a team environment. " +
                                     "Looking to utilize / explore newer technologies to expand my knowledge in software development.",
                ProjectDescription = "Using Unity and C# to develop interactive interfaces, adaptive environments with " +
                                      "use of artificial intelligence and movement mechanics whilst adhering to VR best practices.",
                TechnicalSkills = new List<string>
                {
                    "C# .Net Framework / MVC / .Net 6",
                    "Entity Framework / Entity Core",
                    "React / Redux / Typescript",
                    "DDD, TDD, SOLID PRINCIPLES",
                    "Git / TeamCity / Octopus",
                    "Unity Game Engine (C#) / Blender / MAYA",
                },
                References = new List<string> {
                    "Dr Llyr Ap Cenydd (Developer of Ocean Rift)",
                    "Employment reference available upon request."
                },
                ContactDetails = new List<string>
                {
                    "GitLab", "GitHub", "Mobile", "Email", "Address"
                },
                ContactDetailsDescription = new List<string> {
                    "https://gitlab.com/DionParry", "https://github.com/DionParry",
                    "07592 757 905", "dionjohnparry@gmail.com", "Ellesmere Port, Cheshire"
                },
                JobTitle1 = jobTitle1,
                JobTitle2 = jobTitle2,
                EmploymentHistoryDescription = new Dictionary<string, List<string>>
                {
                    {jobTitle1, jobDescription1},
                    {jobTitle2, jobDescription2},
                },
                Achievements =  new List<string>
                {
                    "Project and career expo - Best Poster (1st Place)", 
                    "Dr John Roberts Jones Prize 2018 (Nominee)"
                },
                
            };

            return vm;
        }
    }
}