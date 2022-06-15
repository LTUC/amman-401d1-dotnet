using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace RazorPagesDemo.Pages.Settings
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public bool Mode { get; set; }
        public void OnGet()
        {
            Name = HttpContext.Request.Cookies["username"];
        }

        public void OnPost()
        {
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = new System.DateTimeOffset(DateTime.Now.AddDays(7));
            HttpContext.Response.Cookies.Append("username", Name, cookieOptions);
            HttpContext.Response.Cookies.Append("Mode", Mode.ToString(), cookieOptions);
        }
    }
}
