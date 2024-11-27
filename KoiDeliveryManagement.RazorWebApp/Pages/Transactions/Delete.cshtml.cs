using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KoiDeliveryManagement.Repository.Model;
using KoiDeliveryManagement.Services;

namespace KoiDeliveryManagement.RazorWebApp.Pages.Transactions
{
    public class DeleteModel : PageModel
    {
        private readonly TransactionService _transactionService;

        public DeleteModel(TransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [BindProperty]
        public Transaction Transaction { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _transactionService.GetById(id.Value);

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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _transactionService.GetById(id.Value);
            if (transaction != null)
            {
                Transaction = transaction;
                await _transactionService.Delete(transaction);
            }

            return RedirectToPage("./Index");
        }
    }
}
