using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using WebApplication3.Models;

namespace WebApplication3.Pages.Temp_And_Humidity;

public class IndexModel : PageModel
{
     ApplicationContext _db;
    public IEnumerable<Temp_And_Humidity_Sensor> obj_Temp_And_Humidity { get; private set; }
    public IndexModel(ApplicationContext db)
    {
        _db = db;
    }
    public void OnGet()
    {
        obj_Temp_And_Humidity = _db.Temp_And_Humidity;
    }

    public async Task<IActionResult> OnPostButton1(int id = 1)
    {
        Temp_And_Humidity_Sensor a = new Temp_And_Humidity_Sensor();
        a.id = id;

        if (id > 0)
        {
            string json = string.Empty;
            string url = $"https://dt.miet.ru/ppo_it/api/temp_hum/{id}";

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(url);
            }
            if (!string.IsNullOrEmpty(json))
            {
                var result = JsonConvert.DeserializeObject<Temp_And_Humidity_Sensor>(json);
                a.humidity = result.humidity;
                a.temperature = result.temperature;
            }
        }

        a.date = DateTime.Now;
        _db.Temp_And_Humidity.Add(a);
        await _db.SaveChangesAsync();

        return RedirectToPage("Index");

    }
    public async Task<IActionResult> OnPostButton2(int id = 2)
    {
        Temp_And_Humidity_Sensor a = new Temp_And_Humidity_Sensor();
        a.id = id;

        if (id > 0)
        {
            string json = string.Empty;
            string url = $"https://dt.miet.ru/ppo_it/api/temp_hum/{id}";

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(url);
            }
            if (!string.IsNullOrEmpty(json))
            {
                var result = JsonConvert.DeserializeObject<Temp_And_Humidity_Sensor>(json);
                a.humidity = result.humidity;
                a.temperature = result.temperature;
            }
        }

        a.date = DateTime.Now;
        _db.Temp_And_Humidity.Add(a);
        await _db.SaveChangesAsync();

        return RedirectToPage("Index");

    }
    public async Task<IActionResult> OnPostButton3(int id = 3)
    {
        Temp_And_Humidity_Sensor a = new Temp_And_Humidity_Sensor();
        a.id = id;

        if (id > 0)
        {
            string json = string.Empty;
            string url = $"https://dt.miet.ru/ppo_it/api/temp_hum/{id}";

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(url);
            }
            if (!string.IsNullOrEmpty(json))
            {
                var result = JsonConvert.DeserializeObject<Temp_And_Humidity_Sensor>(json);
                a.humidity = result.humidity;
                a.temperature = result.temperature;
            }
        }

        a.date = DateTime.Now;
        _db.Temp_And_Humidity.Add(a);
        await _db.SaveChangesAsync();

        return RedirectToPage("Index");

    }
    public async Task<IActionResult> OnPostButton4(int id = 4)
    {
        Temp_And_Humidity_Sensor a = new Temp_And_Humidity_Sensor();
        a.id = id;

        if (id > 0)
        {
            string json = string.Empty;
            string url = $"https://dt.miet.ru/ppo_it/api/temp_hum/{id}";

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(url);
            }
            if (!string.IsNullOrEmpty(json))
            {
                var result = JsonConvert.DeserializeObject<Temp_And_Humidity_Sensor>(json);
                a.humidity = result.humidity;
                a.temperature = result.temperature;
            }
        }

        a.date = DateTime.Now;
        _db.Temp_And_Humidity.Add(a);
        await _db.SaveChangesAsync();

        return RedirectToPage("Index");

    }
}