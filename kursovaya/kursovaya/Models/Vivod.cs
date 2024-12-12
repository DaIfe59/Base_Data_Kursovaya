using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya.Models
{
    public class Vivod
    {
        [Key]
        public int ID1 { get; set; }
        public string result { get; set; }

        // Навигационное свойство
        public Table Table { get; set; }

        // Внешний ключ
        public int TableId { get; set; }

    }
}
