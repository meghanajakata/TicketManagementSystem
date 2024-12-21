using Microsoft.AspNetCore.Mvc;

namespace TicketManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TicketManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
