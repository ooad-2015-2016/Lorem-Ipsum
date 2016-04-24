using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace MashComputerShop.MashShopDB.Models
{
    public class MashShopDBContext : DbContext
    {
        // Set koji sadrzi sve registrovane korisnike
        public DbSet<RegisteredUser> AllRegisteredUsers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbFilePath = "MashShop.db";

            try { dbFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, dbFilePath); }
            catch { /* Ovdje vjerovatno treba neki upis u log staviti */ }

            // Određujemo koju bazu ćemo koristiti
            optionsBuilder.UseSqlite($"Data source={dbFilePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // postavljamo značenje "byte[]" u polju "ProfileImage"
            modelBuilder.Entity<RegisteredUser>().Property(p => p.ProfileImage).HasColumnType("image");
        }

    }
}
