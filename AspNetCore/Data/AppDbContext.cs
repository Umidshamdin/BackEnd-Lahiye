﻿using AspNetCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetails { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<About> Abouts { get; set; }

        public DbSet<CourseFeatures> CourseFeatures { get; set; }

        public DbSet<Notice> Notices { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<EventDetail> EventDetails { get; set; }








    }
}
