using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dotnetconf.Models;

namespace Dotnetconf.Controllers;

public class ChatController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    
}
