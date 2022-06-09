using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesPayment.Models;
using RazorPagesPayment.Data;
//using RazorPagesAskUpdate.Data;

namespace RazorPagesPayment.Pages_Payment
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesPaymentContext _context;

        public DetailsModel(RazorPagesPaymentContext context)
        {
            _context = context;
        }

        public Payment Payment { get; set; } 
  
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Payment = await _context.Payment.FirstOrDefaultAsync(m => m.ID == id);

            //AskUpdate = await _context2.AskUpdate.FirstOrDefaultAsync(m => m.ID == id);

            if (Payment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
