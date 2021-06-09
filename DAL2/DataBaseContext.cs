using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL2
{
    public class DataBaseContext:DbContext
    {
        public DbSet<Model.Student> Students { get; set; }
        public DbSet<Model.Group> Groups { get; set; }
        public DbSet<Model.Hostel> Hostels { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {

        }
        public DataBaseContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NAULOVE;Trusted_Connection=True;");
            }
        }
    }
}
