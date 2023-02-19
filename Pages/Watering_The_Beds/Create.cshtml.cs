using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Models;

namespace WebApplication3.Pages.Watering_The_Beds
{
    public class CreateModel : PageModel
    {
        ApplicationContext Context;
        [BindProperty]
        public Watering_The_Bed Watering_State { get; set; } = new();
        public CreateModel(ApplicationContext db)
        {
            Context = db;
        }
        public async Task<IActionResult> OnPostAsync(int state)
        {
            Watering_State.date = DateTime.Now;
            Watering_State.state = state;
            Context.Watering_The_Beds.Add(Watering_State);
            await Context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
