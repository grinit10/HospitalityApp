using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class CreateModel : PageModel
    {
        private readonly AppContext _context;
        
        public CreateModel(AppContext context)
        {
            _context = context;
        }
     
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnPostAsync(Customer Customer)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customers.Add(Customer);
            await _context.SaveChangesAsync();
            return RedirectToPage("/");
        }
    }
}