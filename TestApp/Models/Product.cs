using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Product
    {
        [Key]
        public Guid id { get; set; }

        public string name { get; set; }

        public int price { get; set; }

        public string description { get; set; }

        public DateTime createdAt { get; set; }

        public Guid categoryId { get; set; }

        public virtual Category category { get; set; }

    }
}
