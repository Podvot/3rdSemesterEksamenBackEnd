using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Models.Ingredients;
using Models.Recipes;
using Models.MenuItems;

namespace Data
{
    public class KaffeshopContext : DbContext
    {
        public KaffeshopContext(DbContextOptions<KaffeshopContext> options) : base(options)
        {
            
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredients> RecipeIngredients { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<MenuRecipe> MenuRecipes { get; set; }
       
        
    }
}