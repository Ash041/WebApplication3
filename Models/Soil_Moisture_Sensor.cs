using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace WebApplication3.Models
{
    public class Soil_Moisture_Sensor
    {
        [Key]
        public int PrimaryID { get; set; }

        [Required]

        public int id { get; set; }
        public DateTime date { get; set; } = DateTime.Now;

        public string? humidity { get; set; }
       
    }
}
