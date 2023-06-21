using FromGermanyStoreDataAccessLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromGermanyStoreDataAccessLibrary.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        
        [Required]
        public int Price { get; set; }

        [MaxLength(1024)]
        public string Description { get; set; }

        public Categories Category { get; set; }
    }
}
