using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemo.Models;
using RazorPagesDemo.Services.Interfaces;
using System.Threading.Tasks;

namespace RazorPagesDemo.Pages.Accounts
{
    public class RegisterModel : PageModel
    {

        private IPerson PeopleService;

        public RegisterModel(IPerson service)
        {
            PeopleService = service;
        }

        [BindProperty]
        public RegisterData Input { get; set; }
        public void OnGet()
        {
        }

        public async Task OnPostAsync()
        {
            Person person = new Person()
            {
                Name = Input.Name,
                Age = Input.Age
            };

            Person p = await PeopleService.Create(person);

            // I will leave it for your exploration .... 
        }

        public class RegisterData
        {
            public string Name{ get; set; }
            public int Age { get; set; }
        }
    }
}
