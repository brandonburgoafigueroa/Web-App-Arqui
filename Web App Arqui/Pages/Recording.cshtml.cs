using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_App_Arqui.Pages
{
    public class RecordingModel : PageModel
    {

        [BindProperty]
        public string Message { set; get; }

        [BindProperty]
        public string Passcode { set; get; }
        [BindProperty]
        public string Error { set; get; }
        [BindProperty]
        public string Greeting { set; get; }
        public void OnGet()
        {
            Mailbox Mailbox = new Mailbox();
            Greeting = Mailbox.Greeting;
        }
        public IActionResult OnPostSendMessage()
        {
            //añadir mensage
            bool result = true;
            if (result)
                return RedirectToPage("/Connect");
            Error = "Algo sucedio";
            return Page();
            
        }
        public IActionResult OnPostLogin()
        {
            //estado
            bool result = Passcode == Convert.ToString(1);
            if (result)
                return RedirectToPage("/MailboxMenu");
            Error = "Incorrect passcode. Try again!";
            return Page();
        }
    }
    public class Mailbox
    {
        public MessageQueue NewMessages { set; get; }
        public MessageQueue KeptMessages { set; get; }
        public string Passcode { set; get; }
        public string Greeting { set; get; }

    }
    public class MessageQueue
    {
        public List<Message> Queue { set; get; }
    }
    public class Message
    {
        public string From { set; get; }

        public string Text { set; get; }
    }
}