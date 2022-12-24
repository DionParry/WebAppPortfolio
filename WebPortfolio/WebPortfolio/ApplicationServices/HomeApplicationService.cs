using System.Threading.Tasks;
using WebPortfolio.ApplicationServices.Interfaces;
using WebPortfolio.Models.ViewModels;

namespace WebPortfolio.ApplicationServices
{
    public class HomeApplicationService : IHomeApplicationService
    {
        public ResumeViewModel GetResumeViewModel()
        {
            return new ResumeViewModel().LoadFrom();
        }
    }
}