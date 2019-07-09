using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using Repository;

namespace HospitalityApp.Controllers
{
    public class HospitalityController : Controller
    {
        private readonly IRepository<Hotel> _context;

        public HospitalityController(IRepository<Hotel> context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHotels()
        {
            var hotels = await _context.GetAllAsync();
            
            return View(hotels);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var hotel = await _context.GetByConditionAsync(id);
            return View(hotel);
        }

        [HttpPost]
        public IActionResult Edit(Guid id, Hotel Hotel)
        {
            if (id != Hotel.Id)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest();

            _context.Update(Hotel);
            return RedirectToAction("GetAllHotels");
        }
        public IActionResult Details()
        {
            throw new NotImplementedException();
        }

        public IActionResult Delete()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Hotel hotel)
        {
            _context.Create(hotel);
            return RedirectToAction("GetAllHotels");
        }
    }
}