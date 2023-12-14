using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;

public class Recipe
{
    [Column(TypeName = "uniqueidentifier")]
    public Guid Id { get; set; }

    public string Name { get; set; }
    
    public bool Seasonal { get; set; }
    
    public bool Available { get; set; }
    
    public IList<Ingredient> AddedIngredients { get; set; } = new List<Ingredient>();
    
}    