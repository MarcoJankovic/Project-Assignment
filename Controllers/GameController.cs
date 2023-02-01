using Microsoft.AspNetCore.Mvc;

namespace Project_Assignment.Controllers;

public class GameController : Controller
{
    public IActionResult Games()
    {
        return View();
    }
}