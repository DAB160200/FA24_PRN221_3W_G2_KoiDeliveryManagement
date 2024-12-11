using KoiDeliveryManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiDeliveryManagement.RazorWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly UserService _userService;

        public IndexModel(ILogger<IndexModel> logger, UserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [BindProperty]
        public string UserName { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostLoginAsync()
        {
            var user = await _userService.GetByUserName(UserName);
            if (user != null)
            {
                if (user.PasswordHash == Password)
                {
                    HttpContext.Session.SetInt32("UserId", user.Id);
                    HttpContext.Session.SetString("UserName", user.Username);
                    HttpContext.Session.SetString("Role", user.Role);
                    HttpContext.Session.SetString("FullName", user.FullName);
                    return RedirectToPage("/Users/Index");
                }
                else
                {
                    ViewData["ErrorMessage"] = "Username or password is incorrect.";
                    return Page();
                }
            }
            else
            {
                ViewData["ErrorMessage"] = "Username or password is incorrect.";
                return Page();
            }
        }
    }
}
