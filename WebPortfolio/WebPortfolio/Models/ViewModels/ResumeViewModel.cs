using System.Threading.Tasks;

namespace WebPortfolio.Models.ViewModels
{
    public class ResumeViewModel
    {
        public string Title { get; set; }

        public static async Task<ResumeViewModel> LoadFrom()
        {
            var vm = new ResumeViewModel
            {
                Title = "Software Developer"
            };

            return vm;
        }
    }
}