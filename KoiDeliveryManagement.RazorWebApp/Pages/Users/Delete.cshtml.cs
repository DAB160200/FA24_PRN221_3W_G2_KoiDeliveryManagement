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

namespace KoiDeliveryManagement.RazorWebApp.Pages.Users
{
    public class DeleteModel : PageModel
    {
        private readonly UserService _userService;

        public DeleteModel(UserService userService)
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

            var user = await _userService.GetById(id.Value);

            if (user == null)
            {
                return NotFound();
            }
            else
            {
                User = user;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userService.GetById(id.Value);
            if (user != null)
            {
                User = user;
                await _userService.Delete(User);
            }

            return RedirectToPage("./Index");
        }
    }
}
