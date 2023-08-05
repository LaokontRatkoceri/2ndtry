using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

      //  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
    //        // You don't actually ever need to call this
  //      }

        public DbSet<Activity> Activities { get; set; }
    }

}