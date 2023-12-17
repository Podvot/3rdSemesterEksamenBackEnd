using Microsoft.EntityFrameworkCore;
using Models.Ingredients;
using Models.Recipes;

namespace Data.Repository.RecipeRepository;

public class RecipeIngredientRepository : IRecipeIngredientRepository
{
    
    private readonly KaffeshopContext _context;
    
    public RecipeIngredientRepository(KaffeshopContext context)
    {
        _context = context;
    }
    
    public void AddIngredient(Guid recipeIngredientId, Ingredient ingredient)
    {
        var recipeIngredient = GetRecipeIngredient(recipeIngredientId);
        recipeIngredient.AddedIngredients.Add(ingredient);
        _context.SaveChanges();
    }

    public IList<RecipeIngredients> GetRecipeIngredients()
    { 
        return _context.RecipeIngredients
            .Include(x => x.AddedIngredients)
            .ToList();
    }
    
    public RecipeIngredients GetRecipeIngredient(Guid id)
    {
        return _context
                   .RecipeIngredients
                   .FirstOrDefault(x => x.Id == id) 
               ?? throw new InvalidOperationException();    
    }
    
    public RecipeIngredients CreateRecipeIngredient(RecipeIngredients recipeIngredients)
    {
        _context.RecipeIngredients.Add(recipeIngredients);
        _context.SaveChanges();
        return recipeIngredients;
    }
    
    public bool RecipeIngredientExists(Guid id)
    {
        return _context.Recipes.Any(x => x.Id == id);
    }
    
    public void DeleteRecipeIngredient(Guid id)
    {
        var recipeIngredient = GetRecipeIngredient(id);
        
        _context.RecipeIngredients.Remove(recipeIngredient);
        _context.SaveChanges();
    }
    
}