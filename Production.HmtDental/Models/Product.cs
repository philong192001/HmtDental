using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Production.HmtDental.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Category_Id { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public int Code_Product { get; set; }
        public string Sub_Description { get; set; }

    }
}
