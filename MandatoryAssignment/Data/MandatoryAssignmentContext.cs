using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MandatoryAssignment.Models;

namespace MandatoryAssignment.Data
{
    public class MandatoryAssignmentContext : DbContext
    {
        public MandatoryAssignmentContext(DbContextOptions<MandatoryAssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<MandatoryAssignment.Models.title> title { get; set; }
        public DbSet<MandatoryAssignment.Models.name_basics> name_Basics{get; set;}
    }
}
