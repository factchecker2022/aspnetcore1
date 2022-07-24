using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aspnetcore1.Models;
using RandomStringCreator;

namespace aspnetcore1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public String Index()
    {
        
        string s = new StringCreator().Get(6);
        return s;
;
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

