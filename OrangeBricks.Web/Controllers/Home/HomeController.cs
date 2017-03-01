using Microsoft.AspNet.Identity;
using OrangeBricks.Web.Controllers.Home.Builders;
using OrangeBricks.Web.Models;
using System.Web.Mvc;

namespace OrangeBricks.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrangeBricksContext _context;

        public HomeController(IOrangeBricksContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var builder = new HomePageViewModelBuilder(_context);
            var viewModel = builder.Build(User.Identity.GetUserId());

            return View(viewModel);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}