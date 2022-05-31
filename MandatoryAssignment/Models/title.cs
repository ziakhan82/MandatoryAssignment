using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MandatoryAssignment.Models
{
    public class title
    {
        [Key]
        public string title_id { get; set; }
        public int? content_type_id { get; set; }
        public string primary_title { get; set; }
        public string original_title { get; set; }

        public bool? is_adult{ get; set; }
        public int? start_year { get; set; }
        public int? end_year { get; set; }
        public int? runtime_mintues { get; set; }






        
      

    } }