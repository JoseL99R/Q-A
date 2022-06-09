using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesPayment.Models;
using RazorPagesPayment.Data;

namespace RazorPagesPayment.Pages_Payment
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesPaymentContext _context;

        public DeleteModel(RazorPagesPaymentContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Payment Payment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Payment = await _context.Payment.FirstOrDefaultAsync(m => m.ID == id);

            if (Payment == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Payment = await _context.Payment.FindAsync(id);

            if (Payment != null)
            {
                _context.Payment.Remove(Payment);
                await _context.SaveChangesAsync();

                // _context.Payment.Remove(AskUpdate);
                //await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
