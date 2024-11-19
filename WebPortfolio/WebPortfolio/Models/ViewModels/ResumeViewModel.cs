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
        public string ProjectDescription2 { get; set; }
        public IEnumerable<string> TechnicalSkills { get; set; }
        public IEnumerable<string> References { get; set; }
        public IEnumerable<string> Achievements { get; set; }
        public List<string> ContactDetails { get; set; }
        public List<string> ContactDetailsDescription { get; set; }
        public Dictionary<string, List<string>> EmploymentHistoryDescription { get; set; }
        public string JobTitle1 { get; set; }
        public string JobTitle2 { get; set; }
        public string JobTitle3 { get; set; }
        public ResumeViewModel LoadFrom()
        {
            const string jobTitle1 = "Analyst Programmer";
            const string jobTitle2 = "Software Developer";
            const string jobTitle3 = "Software Team Lead";

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
            };
            var jobDescription3 = new List<string>
            {
                "Introduced and modernised the work processes, practices and development / Qa team as a whole",
                "Key role in planning the migration of tech debt and older work streams to newer standards.",
                // "Writing scalable, maintainable and testable code to a high standard using C# .net with an eye on ensuring the developers within the team are meeting the standard set.",
                "Actively engaged in bi-monthly lead developer meetings to organise and address integration / problems within the different software teams.",
                "Responsible for overseeing / delivering weekly deployments ensuring pull requests are to a high coding " +
                "standard and adhere to good coding conventions/ best practices.",
                "Actively supporting and suggesting security improvements through azure and inbuilt methods to better secure the company.",
                "Regularly performing reviews on an individual and team basis where appropriate.",
                "Responsible for overseeing the recruitment of developers within the team. "
            };

            var vm = new ResumeViewModel
            {
                Title = "Software Team Lead",
                ApplicantName = "DionParry",
                ProfileDescription = "A confident and highly motivated individual with strong problem solving abilities. " +
                                     "Skilled at working closely with others in a team environment. " +
                                     "Looking for a role to put my skills and knowledge into practice by improving team performance, organisation productivity and application quality",
                ProjectDescription = "Using Unity and C# to develop interactive interfaces, adaptive environments with " +
                                     "use of artificial intelligence and movement mechanics whilst adhering to VR best practices.",
                ProjectDescription2 = "At the later stages of releasing a mobile app to meet a gap within the market using expo, react native and .net",
                TechnicalSkills = new List<string>
                {
                    "C# .Net",
                    "React / Redux / React Query / Typescript",
                    "DDD, TDD, SOLID PRINCIPLES",
                    "Git Actions / Team City / Octopus",
                    "Azure"
                },
                References = new List<string> {
                    "Dr Llyr Ap Cenydd (Developer of Ocean Rift)",
                    "Employment reference available upon request."
                },
                ContactDetails = new List<string>
                {
                    "GitHub", "Mobile", "Email", "Address"
                },
                ContactDetailsDescription = new List<string> {
                    "https://github.com/DionParry", "07592 757 905", "dionjohnparry@gmail.com", "Ellesmere Port, Cheshire"
                },
                JobTitle1 = jobTitle1,
                JobTitle2 = jobTitle2,
                JobTitle3 = jobTitle3,
                EmploymentHistoryDescription = new Dictionary<string, List<string>>
                {
                    {jobTitle1, jobDescription1},
                    {jobTitle2, jobDescription2},
                    {jobTitle3, jobDescription3},
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