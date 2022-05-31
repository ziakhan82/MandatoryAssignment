using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MandatoryAssignment.Models
{
    public class name_basics
    {
        [Key]
        public string name_basic_id { get; set; }
        public string primary_name { get; set; }
        public int? birth_year { get; set; }
        public int? death_year { get; set; }


}
}
