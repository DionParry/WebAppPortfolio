using System.Collections.Generic;
using System.Linq;
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
        public static async Task<ResumeViewModel> LoadFrom()
        {
            var vm = new ResumeViewModel
            {
                Title = "Software Developer",
                ApplicantName = "DionParry",
                ProfileDescription = "A confident and highly motivated individual with strong problem solving abilities." +
                                     "Skilled at working closely with others in a team environment." +
                                     "Looking for a change of pace to expand my knowledge in software development.",
                ProjectDescription = "Using Unity and C# to develop interactive interfaces, adaptive environments with " +
                                      "use of artificial intelligence and movement mechanics whilst adhering to VR best practices.",
                TechnicalSkills = new List<string>
                {
                    "Unity Game Engine (C#) / Blender / MAYA",
                    "C# .NET / MVC / REACT",
                    "DDD, TDD, SOLID PRINCIPLES",
                    "SQL / HTML / CSS / JS",
                    "GitHub / TeamCity / Octopus",
                    "Linux / SVN / Regex"
                },
                References = new List<string> {
                    "Dr Llyr Ap Cenydd (Developer of Ocean Rift",
                    "Employment reference available upon request."
                },
                ContactDetails = new List<string>
                {
                    "Website", "GitLab", "GitHub", "Mobile", "Email", "Address"
                },
                ContactDetailsDescription = new List<string> {
                    "dionparry.co.uk", "https://gitlab.com/DionParry", "https://github.com/DionParry",
                    "07592 757 905", "dionjohnparry@gmail.com", "Ellesmere Port, Cheshire"
                },
            };

            return vm;
        }
    }
}