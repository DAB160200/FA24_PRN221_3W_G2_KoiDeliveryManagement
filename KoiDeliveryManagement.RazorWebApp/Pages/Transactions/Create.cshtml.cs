using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KoiDeliveryManagement.Repository;
using KoiDeliveryManagement.Repository.Model;
using KoiDeliveryManagement.Services;

namespace KoiDeliveryManagement.RazorWebApp.Pages.Transactions
{
    public class CreateModel : PageModel
    {
        private readonly OrderService _orderService;
        private readonly TransactionService _transactionService;

        public CreateModel(OrderService orderService, TransactionService transactionService)
        {
            _orderService = orderService;
            _transactionService = transactionService;
        }

        public async Task<IActionResult> OnGet()
        {
            var orders = await _orderService.GetAllAsync();
            ViewData["OrderId"] = new SelectList(orders, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Transaction Transaction { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _transactionService.Create(Transaction);

            return RedirectToPage("./Index");
        }
    }
}
