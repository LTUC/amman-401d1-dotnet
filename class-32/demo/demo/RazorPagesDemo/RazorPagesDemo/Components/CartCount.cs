using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace RazorPagesDemo.Components
{


    // 1- create components folder inside the project
    // 2- create a calass that inherits ViewComponent inside that folder
    // 3- create the InvodeAsync method inside, and return View

    // 4- create components folder inside pages folder
    // 5- create a folder inside the components folder and give it a name that matches your cs file name
    // 6- add a view named default inside

    // 7- add the call for the component wherever you want to include it @await Compinent.InvoceAsync("name of the component")
    public class CartCount : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewComponentModel cartData = new ViewComponentModel { Name = HttpContext.Request.Cookies["username"] };
            return View(cartData);
        }

        public class ViewComponentModel
        {
            public string Name { get; set; }
        }
    }
}
