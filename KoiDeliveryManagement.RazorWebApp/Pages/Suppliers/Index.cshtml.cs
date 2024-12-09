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

namespace KoiDeliveryManagement.RazorWebApp.Pages.Suppliers
{
    public class IndexModel : PageModel
    {
        private readonly SupplierService _supplierService;

        public IndexModel(SupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        //public IList<Supplier> Supplier { get;set; } = default!;
        public PaginatedList<Supplier> Supplier { get; set; } = default!;

        public int TotalItems { get; private set; }
        public int PageIndex { get; private set; } = 1;
        public int PageSize { get; private set; } = 5;
        public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);

        public async Task<IActionResult> OnGetAsync(int pageIndex = 1)
        {
            PageIndex = pageIndex;

            var query = await _supplierService.GetAll();

            TotalItems = query.Count();
            Supplier = PaginatedList<Supplier>.Create(query, pageIndex, PageSize);

            return Page();
        }
    }
}
