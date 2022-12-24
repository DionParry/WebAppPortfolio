using System.Threading.Tasks;
using WebPortfolio.Models.ViewModels;

namespace WebPortfolio.ApplicationServices.Interfaces
{
    public interface IHomeApplicationService
    {
        public ResumeViewModel GetResumeViewModel();
    }
}