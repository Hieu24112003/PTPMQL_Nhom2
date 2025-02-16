using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
public class FirstController : Controller
{
    public IActionResult Create()
    { 
       return View();
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Create(FirstController std)
    {
        ViewBag.first = "Id:" + std.id + "Name" + std.Name + "Class" + std.Class + "MSV" + std.MSV;
        return View();
    }
}
}
