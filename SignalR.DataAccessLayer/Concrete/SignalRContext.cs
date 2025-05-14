using Microsoft.EntityFrameworkCore;
using SignalR.EntityLayer.Entities;
using SignalRAPI.SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Concrete
{
    public class SignalRContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #region TODO: AppSettingsten alınacak hale çevir.
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection")); 
            #endregion
            // This is encoded connection string. You can decode from https://www.base64encode.org/
            try
            {
                string connString = "U2VydmVyPURFU0tUT1AtRDJUMDMwUlxcU1FMRVhQUkVTUztJbml0aWFsIENhdGFsb2c9U2lnbmFsUkRiO0ludGVncmF0ZWQgU2VjdXJpdHk9dHJ1ZTtUcnVzdFNlcnZlckNlcnRpZmljYXRlPVRydWU=";
                optionsBuilder.UseSqlServer(Encoding.UTF8.GetString(Convert.FromBase64String(connString)));
            }
            catch (Exception ex)
            {
                Console.WriteLine("[ERROR] : Connection string is not base64 string. Decoding error. ", ex);
                throw;
            }
            

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Booking { get; set; }

        public DbSet<Category> Category { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<Feature> Feature { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Testimonial> Testimonial { get; set; }


    }
}
