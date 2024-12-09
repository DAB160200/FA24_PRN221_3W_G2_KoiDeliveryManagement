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

namespace KoiDeliveryManagement.RazorWebApp.Pages.Suppliers
{
    public class CreateModel : PageModel
    {
        private readonly SupplierService _supplierService;

        public CreateModel(SupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        public IActionResult OnGet()
        {
            var selectList = new List<SelectListItem>();
            selectList.Add(new SelectListItem { Value = "SystemStaff", Text = "System Staff" });

            ViewData["RoleOptions"] = selectList;

            return Page();
        }

        [BindProperty]
        public Supplier Supplier { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            //_context.Suppliers.Add(Supplier);
            //await _context.SaveChangesAsync();

            //return RedirectToPage("./Index");
            var check = await _supplierService.Create(Supplier);
            if (check > 0)
            {
                return RedirectToPage("./Index");
            }

            return Page();
        }
    }
}
