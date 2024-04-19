using System;
using System.Data.Entity;
using System.Data.SQLite;

namespace sinemaseanstakipuygulama
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Salon> Salonlar { get; set; }
        public DbSet<Seans> Seanslar { get; set; }

        public ApplicationContext() : base("Data Source=SinemaDB.db;")
        {
        }
    }
}
