﻿using System.ComponentModel.DataAnnotations;

namespace Mission06_Bronson.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string Category { get; set; }

    }
}
