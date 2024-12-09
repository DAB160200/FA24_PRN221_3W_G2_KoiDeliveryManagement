using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KoiDeliveryManagement.Repository;
using KoiDeliveryManagement.Repository.Model;

namespace KoiDeliveryManagement.RazorWebApp.Pages.Certificates
{
    public class CreateModel : PageModel
    {
        private readonly KoiDeliveryManagement.Repository.KoiContext _context;

        public CreateModel(KoiDeliveryManagement.Repository.KoiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["FishId"] = new SelectList(_context.Fishes, "Id", "Breed");
            return Page();
        }

        [BindProperty]
        public Certificate Certificate { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Certificates.Add(Certificate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
