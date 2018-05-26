using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_App_Arqui.Pages
{
    public class MailboxMenuModel : PageModel
    {

        public void OnGet()
        {

        }
        public IActionResult OnPostListen()
        {
            return RedirectToPage("/MessageMenu");
        }
        public IActionResult OnPostPasscode()
        {
            return RedirectToPage("/ChangePasscode");
        }
        public IActionResult OnPostGreeting()
        {
            return RedirectToPage("/ChangeGreeting");
        }
        public IActionResult OnPostExit()
        {
            return RedirectToPage("/Connect");
        }
    }
}