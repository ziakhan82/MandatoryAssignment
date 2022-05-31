using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MandatoryAssignment.Data;
using MandatoryAssignment.Models;

namespace MandatoryAssignment.Pages.name_basics
{
    public class EditModel : PageModel
    {
        private readonly MandatoryAssignment.Data.MandatoryAssignmentContext _context;

        public EditModel(MandatoryAssignment.Data.MandatoryAssignmentContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models. name_basics name_basics { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            name_basics = await _context.name_Basics.FirstOrDefaultAsync(m => m.name_basic_id == id);

            if (name_basics == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(name_basics).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!name_basicsExists(name_basics.name_basic_id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool name_basicsExists(string id)
        {
            return _context.name_Basics.Any(e => e.name_basic_id == id);
        }
    }
}
