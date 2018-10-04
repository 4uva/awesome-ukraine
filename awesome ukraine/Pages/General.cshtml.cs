using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

using awesome_ukraine.Model;

namespace awesome_ukraine.Pages
{
    public class GeneralModel : PageModel
    {
        public GeneralModel(Sections sections)
        {
            Topics = sections.All;
        }

        public IReadOnlyCollection<Section> Topics { get; }

        public void OnGet()
        {
        }
    }
}
