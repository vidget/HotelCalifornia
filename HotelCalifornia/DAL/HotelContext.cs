using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelCalifornia.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HotelCalifornia.DAL
{
    public class HotelContext : DbContext
    {

        
        public HotelContext() : base("HotelContext")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RoomStyle> RoomStyles { get; set; } 




        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}