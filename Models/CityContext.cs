using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Models
{
   
    public class CityContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        
    }
}
