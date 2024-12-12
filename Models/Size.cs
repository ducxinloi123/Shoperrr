﻿using System.ComponentModel.DataAnnotations;

namespace Shopper.Models
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }
        [StringLength(10)]
        public string? SizeName { get; set; }

    }
}
