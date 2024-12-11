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

namespace KoiDeliveryManagement.RazorWebApp.Pages.Deliveries
{
    public class DeleteModel : PageModel
    {
        private readonly DeliveryService _deliveryService;

        public DeleteModel(DeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        [BindProperty]
        public Delivery Delivery { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delivery = await _deliveryService.GetById(id.Value);

            if (delivery == null)
            {
                return NotFound();
            }
            else
            {
                Delivery = delivery;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delivery = await _deliveryService.GetById(id.Value);
            if (delivery != null)
            {
                Delivery = delivery;
                await _deliveryService.Delete(Delivery);
            }

            return RedirectToPage("./Index");
        }
    }
}
