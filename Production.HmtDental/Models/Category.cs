using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Production.HmtDental.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Parent_Id { get; set; }
    }
}
