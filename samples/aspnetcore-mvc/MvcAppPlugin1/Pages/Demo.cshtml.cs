using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcAppPlugin1.Pages
{
    public class Demo : PageModel
    {
        [BindProperty]
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "testing 123";
        }

        public void OnPost()
        {
            Console.WriteLine("What");
        }
    }
}
