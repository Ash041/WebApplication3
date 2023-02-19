using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net;
using WebApplication3.Models;

namespace WebApplication3.Pages.Soil_Moisture
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationContext _db;
        public IEnumerable<Soil_Moisture_Sensor> Soil_Moisture { get; private set; }
        public IndexModel(ApplicationContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Soil_Moisture = _db.Soil_Moisture;
        }

        public async Task<IActionResult> OnPostButton1(int id = 1)
        {
            Soil_Moisture_Sensor a = new Soil_Moisture_Sensor();
            a.id = id;

            if (id > 0)
            {
                string json = string.Empty;
                string url = $"https://dt.miet.ru/ppo_it/api/hum/{id}";

                using (WebClient wc = new WebClient())
                {
                    json = wc.DownloadString(url);
                }
                if (!string.IsNullOrEmpty(json))
                {
                    var result = JsonConvert.DeserializeObject<Soil_Moisture_Sensor>(json);
                    a.humidity = result.humidity;
                }
            }

            a.date = DateTime.Now;
            _db.Soil_Moisture.Add(a);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");

        }
        public async Task<IActionResult> OnPostButton2(int id = 2)
        {
            Soil_Moisture_Sensor a = new Soil_Moisture_Sensor();
            a.id = id;

            if (id > 0)
            {
                string json = string.Empty;
                string url = $"https://dt.miet.ru/ppo_it/api/hum/{id}";

                using (WebClient wc = new WebClient())
                {
                    json = wc.DownloadString(url);
                }
                if (!string.IsNullOrEmpty(json))
                {
                    var result = JsonConvert.DeserializeObject<Soil_Moisture_Sensor>(json);
                    a.humidity = result.humidity;
                }
            }

            a.date = DateTime.Now;
            _db.Soil_Moisture.Add(a);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");

        }
        public async Task<IActionResult> OnPostButton3(int id = 3)
        {
            Soil_Moisture_Sensor a = new Soil_Moisture_Sensor();
            a.id = id;

            if (id > 0)
            {
                string json = string.Empty;
                string url = $"https://dt.miet.ru/ppo_it/api/hum/{id}";

                using (WebClient wc = new WebClient())
                {
                    json = wc.DownloadString(url);
                }
                if (!string.IsNullOrEmpty(json))
                {
                    var result = JsonConvert.DeserializeObject<Soil_Moisture_Sensor>(json);
                    a.humidity = result.humidity;
                }
            }

            a.date = DateTime.Now;
            _db.Soil_Moisture.Add(a);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");

        }
        public async Task<IActionResult> OnPostButton4(int id = 4)
        {
            Soil_Moisture_Sensor a = new Soil_Moisture_Sensor();
            a.id = id;

            if (id > 0)
            {
                string json = string.Empty;
                string url = $"https://dt.miet.ru/ppo_it/api/hum/{id}";

                using (WebClient wc = new WebClient())
                {
                    json = wc.DownloadString(url);
                }
                if (!string.IsNullOrEmpty(json))
                {
                    var result = JsonConvert.DeserializeObject<Soil_Moisture_Sensor>(json);
                    a.humidity = result.humidity;
                }
            }

            a.date = DateTime.Now;
            _db.Soil_Moisture.Add(a);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");

        }
        public async Task<IActionResult> OnPostButton5(int id = 5)
        {
            Soil_Moisture_Sensor a = new Soil_Moisture_Sensor();
            a.id = id;

            if (id > 0)
            {
                string json = string.Empty;
                string url = $"https://dt.miet.ru/ppo_it/api/hum/{id}";

                using (WebClient wc = new WebClient())
                {
                    json = wc.DownloadString(url);
                }
                if (!string.IsNullOrEmpty(json))
                {
                    var result = JsonConvert.DeserializeObject<Soil_Moisture_Sensor>(json);
                    a.humidity = result.humidity;
                }
            }

            a.date = DateTime.Now;
            _db.Soil_Moisture.Add(a);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");

        }
        public async Task<IActionResult> OnPostButton6(int id = 6)
        {
            Soil_Moisture_Sensor a = new Soil_Moisture_Sensor();
            a.id = id;

            if (id > 0)
            {
                string json = string.Empty;
                string url = $"https://dt.miet.ru/ppo_it/api/hum/{id}";

                using (WebClient wc = new WebClient())
                {
                    json = wc.DownloadString(url);
                }
                if (!string.IsNullOrEmpty(json))
                {
                    var result = JsonConvert.DeserializeObject<Soil_Moisture_Sensor>(json);
                    a.humidity = result.humidity;
                }
            }

            a.date = DateTime.Now;
            _db.Soil_Moisture.Add(a);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");

        }

    }
}
