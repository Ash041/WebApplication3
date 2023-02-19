using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Models;

namespace WebApplication3.Pages.Window_Opening_Drive
{
    public class CreateModel : PageModel
    {
        ApplicationContext Context;
        [BindProperty]
        public Window_Opening Window_State { get; set; } = new();
        public CreateModel(ApplicationContext db)
        {
            Context = db;
        }
        public async Task<IActionResult> OnPostAsync(int state)
        {
            Window_State.date = DateTime.Now;
            Window_State.state = state;
            Context.Window_Opening_Drive.Add(Window_State);
            await Context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
