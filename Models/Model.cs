using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Design;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationJWT5.Models
{
    public class Tour
    {
        [Key]
        public int id { get; set; }
        public string hotel { get; set; }
        public int price { get; set; }
        public bool isTransferInclude { get; set; }
    }

    public class TourAgencyContext : DbContext
    {

        bool IsInitialize = true;

        public Tour tour1 = new Tour { hotel = "Green Beach Resort", price = 16000, isTransferInclude = true };
        public Tour tour2 = new Tour { hotel = "Grand Park Kemer", price = 18000, isTransferInclude = true };
        public Tour tour3 = new Tour { hotel = "Reef Oasis Beach Resort", price = 19000, isTransferInclude = true };

        public Tour tour = new Tour();

        public DbSet<Tour> TourSet { get; set; }

        public void Initialize()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            TourSet.Add(tour1);
            TourSet.Add(tour2);
            TourSet.Add(tour3);
            SaveChanges();
        }
        
        public TourAgencyContext(DbContextOptions<TourAgencyContext> options) : base(options)
        {
            if(IsInitialize)
            {
                Initialize();
            }
        }

        //execute test push

        public void Changes()
        {
            tour.hotel = "extra";
            tour.price = 50000;
            tour.isTransferInclude = true;

            TourSet.Add(tour);
            SaveChanges();
        }
    }
}
