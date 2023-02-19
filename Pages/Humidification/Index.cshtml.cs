using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Models;

namespace WebApplication3.Pages.Humidification
{
    public class IndexModel : PageModel
    {
        private  ApplicationContext _db;
        public IEnumerable<Humidification_System> Humidification { get; private set; }
        public IndexModel(ApplicationContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Humidification = _db.Humidification;
        }
    }
}
