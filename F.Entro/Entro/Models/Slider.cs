﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(100)]
        public string Subtitle { get; set; }
        [MaxLength(2000)]
        public string Content { get; set; }
        [MaxLength(250)]
        public string BgSliderImage { get; set; }
        [NotMapped]
        public IFormFile BgSliderImageFile { get; set; }



    }
}
