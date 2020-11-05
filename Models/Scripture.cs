using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scripture_Journal.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        [StringLength(100, MinimumLength = 0)]
        public string Collection { get; set; }

        [StringLength(60, MinimumLength = 0)]
        public string Book { get; set; }

        public int Chapter { get; set; }
        public int Verse { get; set; }

        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }


        public string Notes { get; set; }



    }
}