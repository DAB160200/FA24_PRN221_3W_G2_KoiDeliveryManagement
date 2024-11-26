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
    public class IndexModel : PageModel
    {
        private readonly KoiDeliveryManagement.Repository.KoiContext _context;

        public IndexModel(KoiDeliveryManagement.Repository.KoiContext context)
        {
            _context = context;
        }

        public IList<Transaction> Transaction { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Transaction = await _context.Transactions
                .Include(t => t.Order).ToListAsync();
        }
    }
}
