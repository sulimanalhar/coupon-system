using System;

namespace coupon_system.models
{
    public class CouponUsage
    {
        public int Id { get; set; }
        public int CouponId { get; set; }
        public string UserId { get; set; }
        public DateTime UsedAt { get; set; }

        // Navigation Property
        public Coupon Coupon { get; set; }
    }
}
