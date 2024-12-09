using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KoiDeliveryManagement.Repository;
using KoiDeliveryManagement.Repository.Model;
using KoiDeliveryManagement.Services;

namespace KoiDeliveryManagement.RazorWebApp.Pages.Suppliers
{
    public class EditModel : PageModel
    {
        private readonly SupplierService _supplierService;
        private readonly UserService _userService;

        public EditModel(SupplierService supplierService, UserService userService)
        {
            _supplierService = supplierService;
            _userService = userService;
        }

        [BindProperty]
        public Supplier Supplier { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplier =  await _supplierService.GetById(id.Value);
            if (supplier == null)
            {
                return NotFound();
            }
            Supplier = supplier;
           ViewData["OwnerId"] = new SelectList(await _userService.GetAll(), "Id", "Email");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.Attach(Supplier).State = EntityState.Modified;

            try
            {
                await _supplierService.Update(Supplier);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierExists(Supplier.Id))
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

        private bool SupplierExists(int id)
        {
            return _supplierService.GetById(id).Result != null;
        }
    }
}
