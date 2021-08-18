using System.Threading.Tasks;
using WebPortfolio.ApplicationServices.Interfaces;
using WebPortfolio.Models.ViewModels;

namespace WebPortfolio.ApplicationServices
{
    public class HomeApplicationService : IHomeApplicationService
    {
        public async Task<ResumeViewModel> GetResumeViewModel()
        {
            return await ResumeViewModel.LoadFrom();
        }
    }
}