namespace coupon_system.models
{
    public class Coupon
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public DateTime ExpiryDate { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
