using System.Threading.Tasks;
using System.Web.Mvc;
using WebPortfolio.ApplicationServices.Interfaces;

namespace WebPortfolio.Controllers
{
    public class ProjectController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}