using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KoiDeliveryManagement.Repository;
using KoiDeliveryManagement.Repository.Model;

namespace KoiDeliveryManagement.RazorWebApp.Pages.Certificates
{
    public class DeleteModel : PageModel
    {
        private readonly KoiDeliveryManagement.Repository.KoiContext _context;

        public DeleteModel(KoiDeliveryManagement.Repository.KoiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Certificate Certificate { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certificate = await _context.Certificates.FirstOrDefaultAsync(m => m.Id == id);

            if (certificate == null)
            {
                return NotFound();
            }
            else
            {
                Certificate = certificate;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certificate = await _context.Certificates.FindAsync(id);
            if (certificate != null)
            {
                Certificate = certificate;
                _context.Certificates.Remove(Certificate);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
