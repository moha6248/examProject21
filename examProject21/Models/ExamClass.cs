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
        public int id { get; set; }
        public int date { get; set; }
        public int energy { get; set; }
        public string unit { get; set; }
        public int water { get; set; }
        public string mUnit { get; set; }

    }
}
