using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;

namespace WebApplication3.Models
{
    public class Temp_And_Humidity_Sensor
    {
        [Key]
        public int PrimaryID { get; set; }

        [Required]

        public int id { get; set; }
        public string? temperature { get; set; }
        public string? humidity { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
        public interface ITempAndHum
        {
            List<Temp_And_Humidity_Sensor> ReadAll();
        }

        //public Temp_And_Humidity_Sensor(int id)
        //{
        //    this.id = id;
        //    temperature = String.Empty;
        //    humidity = String.Empty;
        //}
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\SOFIYA\\GardenControl.mdf;Integrated Security=True";

        private static SqlConnection sqlConnection = null;
        private static string sqlExpression = null;


        //public void GetData()
        //{
        //    DoRequest();
        //    SaveInDb(this.id, this.humidity, this.temperature, sqlConnection);
        //    Log();
        //}
        public void DoRequest()
        {
            if (id > 0)
            {
                string json = string.Empty;
                string url = $"https://dt.miet.ru/ppo_it/api/temp_hum/{this.id}";

                using (WebClient wc = new WebClient())
                {
                    json = wc.DownloadString(url);
                }
                if (!string.IsNullOrEmpty(json))
                {
                    var result = JsonConvert.DeserializeObject<Temp_And_Humidity_Sensor>(json);
                    this.humidity = result.humidity;
                    this.temperature = result.temperature;
                }
            }

        }
    

    }
}
