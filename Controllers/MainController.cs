using Microsoft.AspNetCore.Mvc;
namespace ViewsExample.Controllers
{
    public class MainController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}