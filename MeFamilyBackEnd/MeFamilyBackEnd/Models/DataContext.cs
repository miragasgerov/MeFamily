using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeFamilyBackEnd.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions <DataContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<MyFamily> MyFamilies { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<RecentPhoto> RecentPhotos { get; set; }



    }
}
