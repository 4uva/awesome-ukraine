﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace awesome_ukraine.Pages
{
    public class GeneralModel : PageModel
    {
        public List<string> Topics { get; /*private set;*/ } =
            new List<string>()
            {
                "History",
                "Culture",
                "Places",
                "Nature",
                "Sports",
                "Technology"
            };

        public void OnGet()
        {
        }
    }
}