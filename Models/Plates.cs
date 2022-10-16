using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NB_Plates.Models
{
    public class Plates
    {
        public int Id { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public int Weight { get; set; }


         [Column(TypeName = "decimal(18, 2)")]       
        public decimal Price { get; set; }

        public string Shape { get; set; }

        public int Rating { get; set; }

    }
}
