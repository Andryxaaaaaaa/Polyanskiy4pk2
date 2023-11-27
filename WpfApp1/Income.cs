using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Income
    {
        [Key] 
        public int code { get; set; }

        public byte point { get; set; }
        public DateTime date { get; set; }
        public decimal inc { get; set; }
    }
}
