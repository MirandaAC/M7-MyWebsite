using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Areas.Help.Controllers
{
    [Area("Help")]
    public class HelpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
