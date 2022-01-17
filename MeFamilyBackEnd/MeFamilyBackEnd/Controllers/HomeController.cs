using MeFamilyBackEnd.Models;
using MeFamilyBackEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MeFamilyBackEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVm = new HomeViewModel
            {
                Sliders = _context.Sliders.Include(x => x.Image).ToList(),
                MyFamilies = _context.MyFamilies.ToList(),
                Services = _context.Services.ToList(),
                RecentPhotos = _context.RecentPhotos.ToList()
            };
            return View(homeVm);
        }

      
    }
}
