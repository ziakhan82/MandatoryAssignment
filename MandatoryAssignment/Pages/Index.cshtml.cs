using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MandatoryAssignment.Models;
using MandatoryAssignment.Data;
using System;


namespace MandatoryAssignment.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MandatoryAssignment.Data.MandatoryAssignmentContext _context;

        public IndexModel(MandatoryAssignment.Data.MandatoryAssignmentContext context)
        {
            _context= context;
        }
        public IList< Models.name_basics> name_Basics { get; set; }

        public async Task  OnGet()
        {
          //  name_Basics = _context.name_Basics.ToListAsync();
            name_Basics = _context.name_Basics.Take(15).ToList();
        }
    }
}
