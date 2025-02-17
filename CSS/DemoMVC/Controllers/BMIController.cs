using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
public class BMIController : Controller
{
    [HttpGet]
    public IActionResult Test()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Test(double weight, double height)
    {
        if (weight <= 0 || height <= 0)
        {
            ViewBag.Message = "Vui lòng nhập cân nặng và chiều cao hợp lệ!";
            return View();
        }

        double bmi = weight / (height * height);
        string result;

        if (bmi < 18.5)
            result = "Bạn bị thiếu cân!";
        else if (bmi < 24.9)
            result = "Bạn có cân nặng bình thường.";
        else if (bmi < 29.9)
            result = "Bạn bị thừa cân!";
        else
            result = "Bạn bị béo phì!";

        ViewBag.BMI = bmi.ToString("0.00");
        ViewBag.Message = result;

        return View();
    }
}
}