using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
public class DiemController : Controller
{
    [HttpGet]
    public IActionResult Grade()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Grade(double A, double B, double C)
    {
        if (A < 0 || A > 10 || B < 0 || B > 10 || C < 0 || C > 10)
        {
            ViewBag.Message = "Vui lòng nhập điểm trong khoảng từ 0 đến 10!";
            return View();
        }

        GradeModel grade = new GradeModel { A = A, B = B, C = C };

        ViewBag.FinalScore = grade.FinalScore.ToString("0.00");
        ViewBag.Grade = grade.GetGrade();

        return View();
    }
}
}