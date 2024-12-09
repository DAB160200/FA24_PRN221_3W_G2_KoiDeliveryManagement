using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KoiDeliveryManagement.Repository;
using KoiDeliveryManagement.Repository.Model;
using KoiDeliveryManagement.Services;
using KoiDeliveryManagement.RazorWebApp.Utils.Pagination;

namespace KoiDeliveryManagement.RazorWebApp.Pages.Transactions
{
    public class IndexModel : PageModel
    {
        private readonly TransactionService _transactionService;

        public IndexModel(TransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        public PaginatedList<Transaction> Transaction { get;set; } = default!;

        public int TotalItems { get; private set; }
        public int PageIndex { get; private set; } = 1;
        public int PageSize { get; private set; } = 5;
        public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);

        [BindProperty(SupportsGet = true)]
        public string? Currency { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? PaymentMethod { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? CustomerName { get; set; }

        public async Task<IActionResult> OnGetAsync(int pageIndex = 1)
        {
            PageIndex = pageIndex;

            var query = string.IsNullOrEmpty(Currency) && string.IsNullOrEmpty(PaymentMethod) && string.IsNullOrEmpty(CustomerName)
                ? await _transactionService.GetAll()
                : await _transactionService.SearchTransaction(Currency, PaymentMethod, CustomerName);

            TotalItems = query.Count();
            Transaction = PaginatedList<Transaction>.Create(query, pageIndex, PageSize);

            return Page();
        }
    }
}
