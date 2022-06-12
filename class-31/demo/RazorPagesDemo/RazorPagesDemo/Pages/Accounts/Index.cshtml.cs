using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemo.Models;
using RazorPagesDemo.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorPagesDemo.Pages.Accounts
{
    public class IndexModel : PageModel
    {
        private IPerson PeopleService;

        [BindProperty]
        public List<Person> people { get; set; }

        public IndexModel(IPerson service)
        {
            PeopleService = service;
        }

        public async Task OnGet()
        {
            people = await PeopleService.GetAll();
        }
    }
}
