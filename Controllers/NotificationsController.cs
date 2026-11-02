using Microsoft.AspNetCore.Mvc;

namespace ExpressRepairAssessment.Controllers;

public class NotificationsController : Controller
{
    public IActionResult Index() => View();
}
