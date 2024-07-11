using API.Model;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ApplicationDb :DbContext 
    {
        public ApplicationDb(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<AllStations> station { get; set; }
        public DbSet<AddTrain> TrainsLists { get; set; }

        public DbSet<register> registersedUsers { get; set; }
        public DbSet<register> Bookings { get; set; }

        public DbSet<bookeduser> usersbookings { get; set; }
        //  public DbSet<userbookings> bookingsList { get; set; }

        //public DbSet<passengersList> passengersList { get; set; }

        public DbSet<userbookings> tejabookings { get; set; }
        public DbSet<passenegerBokings> passenegerBokings { get; set; }
    } 

}
