﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Models
{
    public class Testimonial
    {
        public int Id { get; set; }

        [Required]
        public string Image { get; set; }

        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string Posinition { get; set; }



    }
}
