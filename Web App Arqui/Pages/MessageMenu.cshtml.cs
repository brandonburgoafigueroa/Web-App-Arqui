using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_App_Arqui.Pages
{
    public class MessageMenuModel : PageModel
    {
        [BindProperty]
        public string Message { set; get; }
        [BindProperty]
        public string CurrentMessageText { set; get; }
        public string Error { set; get; }
        public void OnGet()
        {

        }
        public IActionResult OnPostListen()
        {
            bool result = true;
            if (result)
            {
                CurrentMessageText = "Mensaje nuevo";
                Message = "Mensaje actual";
                Error = "";
                return Page();
            }
            Error = "Algo salio mal";
            return Page();
        }
        public IActionResult OnPostSave()
        {
            bool result = true;
            if (result) { 
                Error = "";
            return Page();
            }
            Error = "Algo salio mal";
            return Page();

        }
        public IActionResult OnPostDelete()
        {
            bool result = true;
            if (result) { 
                Error = "";
            return Page();
        }
        Error = "Algo salio mal";
            return Page();
        }
        
        public IActionResult OnPostMailBoxMenu()
        {
            bool result = true;
            if (result)
            {
                Error = "";
                return RedirectToPage("/MailBoxMenu");
            }
            Error = "Algo salio mal";
            return Page();
        }
        


    }
}