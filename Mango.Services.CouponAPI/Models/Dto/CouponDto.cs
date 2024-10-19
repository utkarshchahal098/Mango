namespace Mango.Services.CouponAPI.Models.Dto
{
    public class CouponDto
    {
        public int CouponId { get; set; }
        public string CouponCode { get; set; }
        public int MinAmount { get; set; }
        public double DiscontAmout { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
