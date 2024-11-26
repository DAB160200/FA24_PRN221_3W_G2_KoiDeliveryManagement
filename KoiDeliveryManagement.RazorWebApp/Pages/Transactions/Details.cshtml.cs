using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KoiDeliveryManagement.Repository;
using KoiDeliveryManagement.Repository.Model;

namespace KoiDeliveryManagement.RazorWebApp.Pages.Transactions
{
    public class DetailsModel : PageModel
    {
        private readonly KoiDeliveryManagement.Repository.KoiContext _context;

        public DetailsModel(KoiDeliveryManagement.Repository.KoiContext context)
        {
            _context = context;
        }

        public Transaction Transaction { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions.FirstOrDefaultAsync(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }
            else
            {
                Transaction = transaction;
            }
            return Page();
        }
    }
}
