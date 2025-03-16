using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Data;
using DemoMVC.Models;
using DemoMVC.Controllers;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Controllers
{
    public class TenController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TenController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var ten = await _context.Ten.ToListAsync();
            //tra du lieu ve view
            return View(ten);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Ten std)
        {
            //them doi tuong std vao trong Db Context
            await _context.Ten.AddAsync(std);
            //luu thay doi vao co so du lieu
            await _context.SaveChangesAsync();
            //dieu huong ve trang index khi xu ly thanh cong
            return RedirectToAction("Index");
        }
    }
}