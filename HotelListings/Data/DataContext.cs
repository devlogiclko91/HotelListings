using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListings.Data
{
    public class DatabaseDataContext: DbContext
    {
        public DatabaseDataContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id=1,
                    Name="United States",
                    ShortName="US"
                },
                new Country
                {
                    Id=2,
                    Name="India",
                    ShortName="IND"
                },
                new Country
                {
                    Id=3,
                    Name="Bhamas",
                    ShortName="BHS"
                }
                );
            builder.Entity<Hotles>().HasData(
               new Hotles
               {
                   Id = 1,
                   Name = "Caaan",
                   Address="Califonia",
                   Rating=4.5,
                   CountryId=1
                   
               },
               new Hotles
               {
                   Id = 2,
                   Name = "KAJI",
                   Address = "Califonia",
                   Rating = 5,
                   CountryId = 1
               },
               new Hotles
               {
                   Id = 3,
                   Name = "Jakana",
                   Address = "Lucknow",
                   Rating = 4,
                   CountryId = 2
               },
               new Hotles
               {
                   Id = 4,
                   Name = "Hotel San",
                   Address = "Lucknow",
                   Rating = 5,
                   CountryId = 2
               }
               );
        }
        public DbSet<Country> countries { get; set; }
        public DbSet<Hotles> hotles { get; set; }
    }
}
