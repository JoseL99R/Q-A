using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesPayment.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace RazorPagesPayment.Pages_Payment
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesPayment.Data.RazorPagesPaymentContext _context;

        public IndexModel(RazorPagesPayment.Data.RazorPagesPaymentContext context)
        {
            _context = context;
        }

        public IList<Payment> Payment { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Pagos { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Preguntas { get; set; } 

        public async Task OnGetAsync()
        {
          var payment = from m in _context.Payment
                select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                payment = payment.Where(s => s.Pago.Contains(SearchString));
            }
            Payment = await payment.ToListAsync();
        }
    }
}

