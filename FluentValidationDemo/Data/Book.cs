using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationDemo.Data
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(2010,2021)]
        public int Year { get; set; }

        [Range(1,1000)]
        public int Price { get; set; }
    }
}
