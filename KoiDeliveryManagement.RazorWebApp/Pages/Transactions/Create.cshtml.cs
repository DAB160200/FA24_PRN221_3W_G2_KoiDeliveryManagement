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
        private readonly TransactionService _transactionService;
        private readonly OrderService _orderService;

        public CreateModel(TransactionService transactionService, OrderService orderService)
        {
            _transactionService = transactionService;
            _orderService = orderService;
        }

        public async Task<IActionResult> OnGet()
        {
        ViewData["OrderId"] = new SelectList(await _orderService.GetAllAsync(), "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Transaction Transaction { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            await _transactionService.Create(Transaction);

            return RedirectToPage("./Index");
        }
    }
}
