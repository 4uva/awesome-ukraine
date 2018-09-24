using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace awesome_ukraine.Pages
{
    public class HistoryModel : PageModel
    {
        public string Description { get; } =
            "Simply put, it is all that is awesome about Ukraine — from national dishes, to facts, symbols," +
            " personalities, locations, etc from HISTORIC prospective.";

        public void OnGet()
        {
        }
    }
}