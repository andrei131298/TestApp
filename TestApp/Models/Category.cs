using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Category
    {
        [Key]
        public Guid id { get; set; }

        public string name { get; set; }

        public List<Product> product { get; set; }//one to many

    }
}
