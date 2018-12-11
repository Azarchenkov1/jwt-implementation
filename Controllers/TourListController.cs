using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationJWT5.Models;

namespace WebApplicationJWT5.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class TourListController : Controller
    {

        static TourAgencyContext db;

        TourAgencyContext Factory()
        {
            var optionsBuilder = new DbContextOptionsBuilder<TourAgencyContext>();
            var connection = "Server=LAPTOP-73MHSR7G\\SQLEXPRESS;Database=TourAgencyDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connection);
            return new TourAgencyContext(optionsBuilder.Options);
        }

        public static string[] TourList = new[]
        {
            "Hilton Sharks Bay", "Reef Oasis", "Queen Sharm Resort", "Sharjah Palace", "Maxx Royal Belek"
        };

        [HttpGet("[action]")]
        public IEnumerable<Tour> TourListInit()
        {
            var rng = new Random();
            return Enumerable.Range(1, 3).Select(index => new Tour
            {
                id = index,
                hotel = TourList[rng.Next(0, 4)],
                price = rng.Next(10000, 20000),
                isTransferInclude = true
            });
        }

        [HttpGet("[action]")]
        public void ModelPush()
        {
            db.Changes();
        }

        [HttpGet("[action]")]
        public void DataBaseInitialize()
        {
            db = this.Factory();
        }

        public class Tour
        {
            public int id { get; set; }
            public string hotel { get; set; }
            public int price { get; set; }
            public bool isTransferInclude { get; set; }
        }
    }
}