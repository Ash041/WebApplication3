using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplication3.Models
{  
        public class ApplicationContext : DbContext
        {
        public DbSet<Temp_And_Humidity_Sensor> Temp_And_Humidity { get; set; }
        public DbSet<Humidification_System> Humidification { get; set; }
        public DbSet<Watering_The_Bed> Watering_The_Beds { get; set; } = null!;
        public DbSet<Window_Opening> Window_Opening_Drive { get; set; } = null!;
        public DbSet<Soil_Moisture_Sensor> Soil_Moisture { get; set; } 
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
            {
                Database.EnsureCreated();
            }
        }
}
