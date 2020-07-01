using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorldWithGit.Pages
{
    public class IndexModel : PageModel
    {
        public string Time;
        public void OnGet()
        {
            Time = DateTime.Now.ToShortTimeString();
            ViewData["Message"] = "Hello,Welcome to Azure ";
        }
    }
}
