using coupon_system;
using coupon_system.models;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;

namespace coupon_system.data
{
    //public class ApplicationDbContext



    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<WeatherForecast> Coupons { get; set; }  // 
        public DbSet<Coupon> Coupon { get; set; }
        public DbSet<CouponUsage> CouponUsages { get; set; }

    }


}