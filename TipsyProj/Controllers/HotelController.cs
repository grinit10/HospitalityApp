using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TipsyProj.Models;
using TypsyApi.Models;

namespace TipsyProj.Controllers
{
    public class HotelController : Controller
    {
        private readonly HotelContext _context;

        public HotelController(HotelContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var x = _context.Hotels
            return View();
        }
    }
}