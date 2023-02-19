using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Models;

namespace WebApplication3.Pages.Watering_The_Beds
{
    public class IndexModel : PageModel
    {
       private ApplicationContext _db;
        public IEnumerable<Watering_The_Bed> Watering_The_Beds { get; private set; }

        public IndexModel(ApplicationContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Watering_The_Beds = _db.Watering_The_Beds;
        }
    }
}
