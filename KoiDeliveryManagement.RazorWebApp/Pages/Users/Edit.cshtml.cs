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

namespace KoiDeliveryManagement.RazorWebApp.Pages.Users
{
    public class EditModel : PageModel
    {
        private readonly UserService _userService;

        public EditModel(UserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user =  await _userService.GetById(id.Value);
            if (user == null)
            {
                return NotFound();
            }

            User = user;

            var selectList = new List<SelectListItem>();
            selectList.Add(new SelectListItem { Value = "Customer", Text = "Customer" });
            selectList.Add(new SelectListItem { Value = "Supplier", Text = "Supplier" });
            selectList.Add(new SelectListItem { Value = "SystemStaff", Text = "System Staff" });
            selectList.Add(new SelectListItem { Value = "Delivery", Text = "Delivery" });

            foreach (var item in selectList)
            {
                if (item.Value == User.Role)
                {
                    item.Selected = true;
                    break;
                }
            }

            ViewData["RoleOptions"] = selectList;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            try
            {
                await _userService.Update(User);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(User.Id))
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

        private bool UserExists(int id)
        {
            bool check = false;
            var user = _userService.GetById(id).Result;
            if (user != null)
            {
                check = true;
            }
            return check;
        }
    }
}
