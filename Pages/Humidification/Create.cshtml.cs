using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Models;

namespace WebApplication3.Pages.Humidification
{
    public class CreateModel : PageModel
    {
        ApplicationContext Context;
      
        [BindProperty]
        public Humidification_System HumSystem { get; set; } = new();
        public CreateModel(ApplicationContext db)
        {
            Context = db;
        }
        public async Task<IActionResult> OnPostAsync(int state)
        {
            HumSystem.date = DateTime.Now;
            HumSystem.state = state;
            Context.Humidification.Add(HumSystem);
            await Context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
