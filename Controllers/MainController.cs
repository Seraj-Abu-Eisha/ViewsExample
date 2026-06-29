using Microsoft.AspNetCore.Mvc;
namespace ViewsExample.Controllers
{
    public class MainController : Controller
    {
        [Route("main")]
        public IActionResult Index()
        {
            
            return View();
        }
    }
}