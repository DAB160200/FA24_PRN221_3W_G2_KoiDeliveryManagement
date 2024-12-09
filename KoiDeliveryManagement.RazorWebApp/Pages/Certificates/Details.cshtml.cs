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
    public class DetailsModel : PageModel
    {
        private readonly KoiDeliveryManagement.Repository.KoiContext _context;

        public DetailsModel(KoiDeliveryManagement.Repository.KoiContext context)
        {
            _context = context;
        }

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
    }
}
