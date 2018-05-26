﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_App_Arqui.Pages
{
    public class InitialPromtModel : PageModel
    {
        [BindProperty]
        public string Message { set; get; }
        [BindProperty]
        public string IDMailbox { set; get; }
        private static string MessageInitial = "Ingrese el numero de buzon y presione llamar";
        private static string MessageErrorConnection = "Numero de buzon incorrecto. Intentelo de nuevo!";

        public void OnGet()
        {
            Message = MessageInitial;
        }
        public IActionResult OnPost()
        {
            bool result = simulate();
            if (result)
                return RedirectToPage("/Recording");
            Message = MessageErrorConnection;
            return Page();
        }

        /*references*/
        public bool simulate()
        {
            return IDMailbox==Convert.ToString(1);
        }
    }
}