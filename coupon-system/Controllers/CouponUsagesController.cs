using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using coupon_system.data;
using coupon_system.models;

namespace coupon_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponUsagesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CouponUsagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CouponUsages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CouponUsage>>> GetCouponUsages()
        {
            return await _context.CouponUsages.ToListAsync();
        }

        // GET: api/CouponUsages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CouponUsage>> GetCouponUsage(int id)
        {
            var couponUsage = await _context.CouponUsages.FindAsync(id);

            if (couponUsage == null)
            {
                return NotFound();
            }

            return couponUsage;
        }

        // PUT: api/CouponUsages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCouponUsage(int id, CouponUsage couponUsage)
        {
            if (id != couponUsage.Id)
            {
                return BadRequest();
            }

            _context.Entry(couponUsage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CouponUsageExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CouponUsages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CouponUsage>> PostCouponUsage(CouponUsage couponUsage)
        {
            _context.CouponUsages.Add(couponUsage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCouponUsage", new { id = couponUsage.Id }, couponUsage);
        }

        // DELETE: api/CouponUsages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCouponUsage(int id)
        {
            var couponUsage = await _context.CouponUsages.FindAsync(id);
            if (couponUsage == null)
            {
                return NotFound();
            }

            _context.CouponUsages.Remove(couponUsage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CouponUsageExists(int id)
        {
            return _context.CouponUsages.Any(e => e.Id == id);
        }
    }
}
