﻿namespace Mango.Services.CouponAPI.Models
{
    public class Coupon
    {
        public int CouponId { get; set; }
        public string CouponCode { get; set; }
        public int MinAmount { get; set; }
        public double DiscontAmout { get; set; }
    }
}
