using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Models;

namespace WebApplication3.Pages.Soil_Moisture;

public class CreateModel : PageModel
{
    ApplicationContext context;
    [BindProperty]
    public Soil_Moisture_Sensor Sensor { get; set; } = new();
    public CreateModel(ApplicationContext db)
    {
        context = db;
    }
    public async Task<IActionResult> OnPostAsync()
    {
        Sensor.date = DateTime.Now;
        context.Soil_Moisture.Add(Sensor);
        await context.SaveChangesAsync();
        return RedirectToPage("Index");
    }
}
