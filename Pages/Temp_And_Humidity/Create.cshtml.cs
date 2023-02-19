using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using WebApplication3.Models;

namespace WebApplication3.Pages.Temp_And_Humidity
{
    public class CreateModel : PageModel
    {
        ApplicationContext Context;
       


        //public Temp_And_Humidity_Sensor(int id)
        //{
        //    this.id = id;
        //    temperature = String.Empty;
        //    humidity = String.Empty;
        //}
     
        [BindProperty]
        public Temp_And_Humidity_Sensor Sensor { get; set; } = new();
        public CreateModel(ApplicationContext db)
        {
            Context = db;
        }
        public async Task<IActionResult> OnPostAsync()
        {

            Sensor.date = DateTime.Now;
            Context.Temp_And_Humidity.Add(Sensor);
            await Context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
       

    }
}
