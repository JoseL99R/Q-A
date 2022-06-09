using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPayment.Models;
using RazorPagesPayment.Data;
//using RazorPagesAskUpdate.Data;

namespace RazorPagesPayment.Pages_Payment
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesPaymentContext _context;

        public CreateModel(RazorPagesPaymentContext context)
        {
            _context = context;
        }


        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Payment Payment { get; set; }

        //public AskUpdate AskUpdate { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {      
                return Page();
            }

            _context.Payment.Add(Payment);
            await _context.SaveChangesAsync();

           //_context2.AskUpdate.Add(AskUpdate);   
           //await _context.SaveChangesAsync(); 

            return RedirectToPage("./Index");
        }
    }
}
