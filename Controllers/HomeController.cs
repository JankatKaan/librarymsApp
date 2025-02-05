using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using librarymsApp.Models;
using librarymsApp.Data;
using Microsoft.EntityFrameworkCore;

namespace librarymsApp.Controllers;

public class HomeController : Controller
{
    private readonly DataContext _context;

    public HomeController(DataContext context)
    {
        _context = context;
    }


    public async Task<IActionResult> Index()
    {
        return View(await _context.Books.ToListAsync());
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
