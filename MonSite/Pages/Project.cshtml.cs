using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MonSite.Pages;

public class ProjectModel : PageModel
{
    
    public int? IdProject { get; set; }

    public void OnGet(int? idProject)
    {
        IdProject = idProject;
    }
    
}