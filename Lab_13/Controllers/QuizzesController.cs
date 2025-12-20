using Lab_13.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_13.Controllers;

public class QuizzesController : Controller
{
    public static readonly QuizResult Result = new();

    [HttpGet]
    public IActionResult Quiz()
    {
        Result.Add(new Quiz());
        return View(Result[^1]);
    }

    [HttpPost]
    public IActionResult Quiz([FromForm] int answer)
    {
        Result[^1].Answer = answer;
        Result.Add(new Quiz());
        return View(Result[^1]);
    }

    [HttpPost]
    public IActionResult QuizResult([FromForm] int answer)
    {
        Result[^1].Answer = answer;
        return View(Result);
    }
}