using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MandatoryAssignment.Data;
using MandatoryAssignment.Models;

namespace MandatoryAssignment.Pages.title
{
    public class CreateModel : PageModel
    {
        private readonly MandatoryAssignment.Data.MandatoryAssignmentContext _context;

        public CreateModel(MandatoryAssignment.Data.MandatoryAssignmentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.title title { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.title.Add(title);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
