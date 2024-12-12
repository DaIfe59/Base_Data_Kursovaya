using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace kursovaya.Models
{
    public class Table
    {
        [Key]
        public int ID { get; set; }
        public float rnr { get; set; }
        public float b1 { get; set; }
        public float z2 { get; set; }
        public float rmosh { get; set; }
        public float zp { get; set; }
        public float t { get; set; }
        public float i { get; set; }
        public float mddn { get; set; }

        // Навигационное свойство
        public Vivod Vivod { get; set; }
    }
}
