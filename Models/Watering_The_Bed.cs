using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3.Models
{
    public class Watering_The_Bed
    {
        [Key]
        public int PrimaryID { get; set; }

        [Required]

        public int id { get; set; }
        public int state { get; set; }
        public DateTime date { get; set; } = DateTime.Now;

        public Watering_The_Bed()
        {

        }
    
    }
}
