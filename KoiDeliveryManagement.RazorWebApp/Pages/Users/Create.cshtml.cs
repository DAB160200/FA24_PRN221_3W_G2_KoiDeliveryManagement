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

namespace KoiDeliveryManagement.RazorWebApp.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly UserService _userService;

        public CreateModel(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult OnGet()
        {
            var selectList = new List<SelectListItem>();
            selectList.Add(new SelectListItem { Value = "Customer", Text = "Customer" });
            selectList.Add(new SelectListItem { Value = "Supplier", Text = "Supplier" });
            selectList.Add(new SelectListItem { Value = "SystemStaff", Text = "System Staff" });
            selectList.Add(new SelectListItem { Value = "Delivery", Text = "Delivery" });

            ViewData["RoleOptions"] = selectList;

            return Page();
        }

        [BindProperty]
        public User User { get; set; } = default!;


        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            var check = await _userService.Create(User);
            if (check > 0)
            {
                return RedirectToPage("./Index");
            }

            return Page();
        }
    }
}
