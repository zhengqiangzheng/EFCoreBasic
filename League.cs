﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Domain
{
    public class League
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required,MaxLength(50)]
        public string Country { get; set; }
    }
}
