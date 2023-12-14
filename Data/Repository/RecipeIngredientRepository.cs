using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Repository;

public class RecipeIngredientRepository : IRecipeIngredientRepository
{
    
    private readonly KaffeshopContext _context;
    
    public RecipeIngredientRepository(KaffeshopContext context)
    {
        _context = context;
    }
    
    public void AddIngredient(Guid recipeId, Ingredient ingredient)
    {
        var recipe = GetRecipe(recipeId);
        recipe.AddedIngredients.Add(ingredient);
        _context.SaveChanges();
    }
    
    public Recipe GetRecipe(Guid id)
    {
        return _context
                   .Recipes
                   .FirstOrDefault(x => x.Id == id) 
               ?? throw new InvalidOperationException();    
    }
    
    public bool RecipeExists(Guid id)
    {
        return _context.Recipes.Any(x => x.Id == id);
    }
    
}