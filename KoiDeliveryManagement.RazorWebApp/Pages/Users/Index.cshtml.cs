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

namespace KoiDeliveryManagement.RazorWebApp.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly UserService _userService;

        public IndexModel(UserService userService)
        {
            _userService = userService;
        }

        public PaginatedList<User> User { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchName { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchPhone { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchEmail { get; set; }

        [BindProperty(SupportsGet = true)]
        public int PageSize { get; set; } = 5;

        public async Task OnGetAsync(int pageIndex = 1)
        {
            var users = await _userService.GetAll();

            if (!string.IsNullOrWhiteSpace(SearchName))
            {
                users = await _userService.SearchByName(SearchName);
            }
            else if (!string.IsNullOrWhiteSpace(SearchPhone))
            {
                users = await _userService.SearchByPhone(SearchPhone);
            }
            else if (!string.IsNullOrWhiteSpace(SearchEmail))
            {
                users = await _userService.SearchByEmail(SearchEmail);
            }

            User = PaginatedList<User>.Create(users, pageIndex, PageSize);
        }
    }
}
