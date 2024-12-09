using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KoiDeliveryManagement.Repository.Model;
using KoiDeliveryManagement.Services;

namespace KoiDeliveryManagement.RazorWebApp.Pages.Deliveries
{
    public class EditModel : PageModel
    {
        private readonly DeliveryService _deliveryService;

        public EditModel(DeliveryService deliveryService)
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

            Delivery = delivery;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            try
            {
                await _deliveryService.Update(Delivery);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryExists(Delivery.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DeliveryExists(int id)
        {
            return _deliveryService.GetById(id).Result != null;
        }
    }
}
