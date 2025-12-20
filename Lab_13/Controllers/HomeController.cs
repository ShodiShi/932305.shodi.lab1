using Microsoft.AspNetCore.Mvc;

namespace Lab_13.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        QuizzesController.Result.Clear();
        return View();
    }
}