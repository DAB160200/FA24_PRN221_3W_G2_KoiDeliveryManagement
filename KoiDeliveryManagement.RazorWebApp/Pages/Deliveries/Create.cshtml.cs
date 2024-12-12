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
        private readonly OrderService _orderService;

        public CreateModel(DeliveryService deliveryService, OrderService orderService)
        {
            _deliveryService = deliveryService;
            _orderService = orderService;
        }

        public async Task<IActionResult> OnGet()
        {
            ViewData["OrderId"] = new SelectList(await _orderService.GetAllAsync(), "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Delivery Delivery { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            await _deliveryService.Create(Delivery);

            return RedirectToPage("./Index");
        }
    }
}
