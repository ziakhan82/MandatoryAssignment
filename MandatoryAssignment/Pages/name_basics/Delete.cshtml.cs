using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MandatoryAssignment.Data;
using MandatoryAssignment.Models;

namespace MandatoryAssignment.Pages.name_basics
{
    public class DeleteModel : PageModel
    {
        private readonly MandatoryAssignment.Data.MandatoryAssignmentContext _context;

        private EFServices.EFTName_BasicsService _service;

        public DeleteModel(MandatoryAssignment.Data.MandatoryAssignmentContext context,EFServices.EFTName_BasicsService service)
        {
            _context = context;
            _service = service;
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            name_basics = await _context.name_Basics.FindAsync(id);

            if (name_basics != null)
            {
                _service.DeleteName_basic_Id(id);

                //_context.name_Basics.Remove(name_basics);
                //await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
