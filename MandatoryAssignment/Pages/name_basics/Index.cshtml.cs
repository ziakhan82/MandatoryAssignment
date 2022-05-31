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
    public class IndexModel : PageModel
    {
        private readonly MandatoryAssignment.Data.MandatoryAssignmentContext _context;

        public IndexModel(MandatoryAssignment.Data.MandatoryAssignmentContext context)
        {
            _context = context;
        }

        public IList<Models.name_basics> name_basics { get; set; }

        public async Task OnGetAsync()
        {
            name_basics = _context.name_Basics.Take(15).ToList();
           // name_basics = await _context.name_Basics.ToListAsync();
        }
    }
}
