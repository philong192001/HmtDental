﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Production.HmtDental.Models
{
    public class Background
    {
        [Key]
        public int Id { get; set; }
        public int Hotline { get; set; }
        public int Landline { get; set; }
        public string Slogan { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
