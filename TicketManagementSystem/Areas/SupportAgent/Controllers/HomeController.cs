using Microsoft.AspNetCore.Mvc;

namespace TicketManagementSystem.Areas.SupportAgent.Controllers
{
    [Area("SupportAgent")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
