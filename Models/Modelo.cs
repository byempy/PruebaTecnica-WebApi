namespace ApiHotels.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Modelo : DbContext
    {
        public Modelo()
            : base("name=Modelo")
        {
        }

        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<HotelDetail> HotelDetail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>()
                .HasMany(e => e.HotelDetail)
                .WithOptional(e => e.Hotel)
                .HasForeignKey(e => e.IdHotel);
        }
    }
}
