﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class KaffeshopContext : DbContext
    {
        public KaffeshopContext(DbContextOptions<KaffeshopContext> options) : base(options)
        {
            
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

       
        
    }
}