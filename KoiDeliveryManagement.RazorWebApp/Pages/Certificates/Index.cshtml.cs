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
    public class IndexModel : PageModel
    {
        private readonly KoiDeliveryManagement.Repository.KoiContext _context;

        public IndexModel(KoiDeliveryManagement.Repository.KoiContext context)
        {
            _context = context;
        }

        public IList<Certificate> Certificate { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Certificate = await _context.Certificates
                .Include(c => c.Fish).ToListAsync();
        }
    }
}
