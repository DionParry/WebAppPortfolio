using System.Threading.Tasks;

namespace WebPortfolio.Models.ViewModels
{
    public class ResumeViewModel
    {
        public string Title { get; set; }
        public string ApplicantName { get; set; }
        public string ProfileDescription { get; set; }
        public int Test { get; set; }

        public static async Task<ResumeViewModel> LoadFrom()
        {
            var vm = new ResumeViewModel
            {
                Title = "Software Developer",
                ApplicantName = "DionParry",
                ProfileDescription = "A confident and highly motivated individual with strong problem solving abilities." +
                                     "Skilled at working closely with others in a team environment." +
                                     "Looking for a change of pace to expand my knowledge in software development."
            };

            return vm;
        }
    }
}