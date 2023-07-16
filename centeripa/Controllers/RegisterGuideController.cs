using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using centeripa.Models;

namespace centeripa.Controllers;

public class RegisterGuideController : Controller
{
    private readonly ILogger<RegisterGuideController> _logger;

    public RegisterGuideController(ILogger<RegisterGuideController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

