using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.AspNetCore.Mvc;

namespace TicketManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private SecretClient _secretClient;
        public IActionResult Index()
        {
            var key = "https://meghanakeyvault23.vault.azure.net/";
            _secretClient = new SecretClient(new Uri(key), new DefaultAzureCredential());
            var secretName = Environment.GetEnvironmentVariable("Name");
            var secretValue = _secretClient.GetSecret(secretName);
            ViewBag.Secret = secretValue.Value.Value;
            return View();
        }
    }
}
