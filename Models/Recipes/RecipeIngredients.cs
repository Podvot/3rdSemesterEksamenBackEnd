using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Models.Ingredients;

namespace Models.Recipes;

public class RecipeIngredients
{
        [Column(TypeName = "uniqueidentifier")]
        public Guid Id { get; set; }

        public string Name { get; set; }
    
        public bool Seasonal { get; set; }
    
        public bool Available { get; set; }
    
        public List<Ingredient> AddedIngredients { get; set; } = new List<Ingredient>();

}