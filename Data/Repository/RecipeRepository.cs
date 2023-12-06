using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Repository;

public class RecipeRepository : IRecipeRepository
{
    private readonly KaffeshopContext _context;
    
    public RecipeRepository(KaffeshopContext context)
    {
        _context = context;
    }
    
    public IList<Recipe> GetRecipes()
    { 
        return _context
            .Recipes
            .ToList();
    }
    
    public Recipe CreateRecipe(Recipe recipe)
    {
        _context.Recipes.Add(recipe);
        _context.SaveChanges();
        return recipe;
    }

    public bool RecipeExists(Guid id)
    {
        return _context.Recipes.Any(x => x.Id == id);
    }
    
    public void DeleteRecipe(Guid id)
    {
        var recipe = GetRecipe(id);
        
        _context.Recipes.Remove(recipe);
        _context.SaveChanges();
    }
    
    public Recipe GetRecipe(Guid id)
    {
        return _context
                   .Recipes
                   .FirstOrDefault(x => x.Id == id) 
               ?? throw new InvalidOperationException();
    }
    
}