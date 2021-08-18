using System.Threading.Tasks;
using System.Web.Mvc;
using WebPortfolio.ApplicationServices.Interfaces;

namespace WebPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeApplicationService _homeApplicationService;
        public HomeController(IHomeApplicationService homeApplicationService)
        {
            _homeApplicationService = homeApplicationService;
        }
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What you can find on this website";
            return View();
        }
        
        public async Task<ActionResult> Resume()
        {
            var vm = await _homeApplicationService.GetResumeViewModel();
            return View(vm);
        }
    }
}