using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class HotelRepo : IRepository<Hotel> 
    {
        private HospitalityContext _context;

        public HotelRepo(HospitalityContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Hotel>> GetAllAsync()
        {
            return await _context.Hotels.ToListAsync();
        }

        public async Task<Hotel> GetByConditionAsync(Guid id)
        {
            var query = _context.Hotels.Where(c => c.Id == id);
            return await query.FirstOrDefaultAsync();
        }

        public void Create(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            _context.SaveChanges();
        }

        public void Update(Hotel hotel)
        {
            _context.Hotels.Update(hotel);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var query = _context.Hotels.Where(c => c.Id == id);
            _context.Hotels.Remove(query.First());
            _context.SaveChanges();
        }
    }
}
