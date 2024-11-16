using Mango.Services.CouponAPI.Database;
using Mango.Services.CouponAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CouponsController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        [HttpGet("GetCoupons")]
        public object GetCoupons()
        {
            try
            {
                IEnumerable<Coupon> objList = _context.Coupons.ToList();
                return objList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
