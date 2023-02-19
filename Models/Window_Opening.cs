using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3.Models
{
    public class Window_Opening
    {
        [Key]
        public int PrimaryID { get; set; }

        public DateTime date { get; set; } = DateTime.Now;
        public int state { get; set; }

        public Window_Opening()
        {

        }

     
    }
}
