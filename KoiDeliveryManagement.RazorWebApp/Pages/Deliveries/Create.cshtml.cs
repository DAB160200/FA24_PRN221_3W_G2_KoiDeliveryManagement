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

namespace KoiDeliveryManagement.RazorWebApp.Pages.Deliveries
{
    public class CreateModel : PageModel
    {
        private readonly DeliveryService _deliveryService;

        public CreateModel(DeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        public IActionResult OnGet()
        {
            //ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public KoiDeliveryManagement.Repository.Model.Delivery Delivery { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            var check = await _deliveryService.Create(Delivery);
            if (check > 0)
            {
                return RedirectToPage("./Index");
            }
            return Page();
        }
    }
}
