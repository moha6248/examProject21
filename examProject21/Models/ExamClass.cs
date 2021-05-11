using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace examProject21.Models
{
    public class ExamClass
    {
        [Key]
        public double id { get; set; }
        public string date { get; set; }
        public double energy { get; set; }
        public string unit { get; set; }
        public double water { get; set; }
        public string mUnit { get; set; }
        public string address { get; set; }

    }
}
