using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_App_Arqui.Pages
{
    public class ChangeGreetingModel : PageModel
    {
        [BindProperty]
        public string Greeting { set; get; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            bool result = true;
            if (result)
            {
                return RedirectToPage("/MessageMenu");
            }
            return Page();
        }
    }
}