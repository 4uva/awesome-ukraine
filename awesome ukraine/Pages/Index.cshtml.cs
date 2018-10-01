using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using awesome_ukraine.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace awesome_ukraine.Pages
{
    public class IndexModel : PageModel
    {
        public IReadOnlyCollection<Section> Topics { get; } = Sections.All;

        public void OnGet()
        {
        }
    }
}
