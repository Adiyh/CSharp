using AppointmentSchedulerproject.Models;
using Microsoft.EntityFrameworkCore;

namespace AppointmentSchedulerproject.Data
{
   
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            public DbSet<User> Users { get; set; }
        }
}