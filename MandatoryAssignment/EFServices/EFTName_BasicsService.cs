using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MandatoryAssignment.EFServices
{
    public class EFTName_BasicsService
    {
        private readonly MandatoryAssignment.Data.MandatoryAssignmentContext _context;
        public EFTName_BasicsService(MandatoryAssignment.Data.MandatoryAssignmentContext context)
        {
            _context = context;

        }

        public void DeleteName_basic_Id(string name_basic_id)
        {
            _context.Database.ExecuteSqlInterpolated($"exec deleteRecord @name_basic_id={name_basic_id}");

        }


       // public void InsertIntoNameBasic()
    }
}
