using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Models;

namespace WebApplication3.Pages.Window_Opening_Drive
{
    public class IndexModel : PageModel
    {
       private  ApplicationContext _db;
        public IEnumerable<Window_Opening> Window_Opening_Drive { get; private set; } 

        public IndexModel(ApplicationContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Window_Opening_Drive = _db.Window_Opening_Drive;
        }
    }
}
