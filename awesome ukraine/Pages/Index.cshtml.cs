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
        public IndexModel(Sections sections)
        {
            Topics = sections.All;
        }

        public IReadOnlyCollection<Section> Topics { get; }

        public void OnGet()
        {
        }
    }
}
