using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KoiDeliveryManagement.Repository;
using KoiDeliveryManagement.Repository.Model;

namespace KoiDeliveryManagement.RazorWebApp.Pages.Certificates
{
    public class EditModel : PageModel
    {
        private readonly KoiDeliveryManagement.Repository.KoiContext _context;

        public EditModel(KoiDeliveryManagement.Repository.KoiContext context)
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

            var certificate =  await _context.Certificates.FirstOrDefaultAsync(m => m.Id == id);
            if (certificate == null)
            {
                return NotFound();
            }
            Certificate = certificate;
           ViewData["FishId"] = new SelectList(_context.Fishes, "Id", "Breed");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Certificate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CertificateExists(Certificate.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CertificateExists(int id)
        {
            return _context.Certificates.Any(e => e.Id == id);
        }
    }
}
