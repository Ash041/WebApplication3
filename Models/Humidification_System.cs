using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3.Models
{
    public class Humidification_System
    {
        [Key]
        public int PrimaryID { get; set; }
        
        public int state { get; set; }
        public DateTime date { get; set; } = DateTime.Now;


       public Humidification_System()
        {

        }

    }
}
