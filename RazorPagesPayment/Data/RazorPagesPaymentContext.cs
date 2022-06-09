using Microsoft.EntityFrameworkCore;

namespace RazorPagesPayment.Data
{
    public class RazorPagesPaymentContext : DbContext
    {
        public RazorPagesPaymentContext (
            DbContextOptions<RazorPagesPaymentContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesPayment.Models.Payment> Payment { get; set; }
    }
}