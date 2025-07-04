using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MonSite.Pages;

public class ProjectModel : PageModel
{
    [BindProperty(SupportsGet = true)]
    public int? IdProject { get; set; }

    public void OnGet()
    {
        // utilise IdProject ici
    }
}
