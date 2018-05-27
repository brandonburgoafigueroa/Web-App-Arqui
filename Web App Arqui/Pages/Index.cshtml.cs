using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_App_Arqui.ApiConsumer;

namespace Web_App_Arqui.Pages
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {

            return RedirectToPage("/Connect");
        }
    }
}
