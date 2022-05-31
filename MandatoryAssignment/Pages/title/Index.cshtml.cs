using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MandatoryAssignment.Data;
using MandatoryAssignment.Models;

namespace MandatoryAssignment.Pages.title
{
    public class IndexModel : PageModel
    {
        private readonly MandatoryAssignment.Data.MandatoryAssignmentContext _context;

        public IndexModel(MandatoryAssignment.Data.MandatoryAssignmentContext context)
        {
            _context = context;
        }

        public IList <Models.title> title { get;set; }

        public async Task OnGetAsync()
        {
            // title = await _context.title.ToListAsync();

            title =_context.title.Take(1000).ToList();
        }
    }
}
