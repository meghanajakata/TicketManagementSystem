using Microsoft.AspNetCore.Mvc;

namespace TicketManagementSystem.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
       public IActionResult Index()
        {
            return View();
        }
    }
}
