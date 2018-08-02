﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VegaNew.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
