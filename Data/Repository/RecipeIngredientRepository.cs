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
    
    public void AddIngredient(Guid recipeId, Guid ingredient)
    {
        var recipe = _context.Recipes.FirstOrDefault(r => (r.Id == recipeId));
    
        if (recipe == null)
        {
            recipe = new Recipe
            {
                Id = recipeId
            };
            _context.Recipes.Add(recipe);
        }
    
        recipe.Ingredients.Add(ingredient);
        _context.SaveChanges();
    }

    public IList<Recipe> GetRecipes()
    {
        return _context
            .Recipes
            .Include(x => x.Ingredients)
            .ToList();
    }

    public Recipe GetRecipe(Guid id)
    {
        return _context
                   .Recipes
                   .FirstOrDefault(x => x.Id == id) 
               ?? throw new InvalidOperationException();    
    }
    
    public bool RecipeIngredientExists(Guid id)
    {
        return _context.Recipes.Any(x => x.Id == id);
    }
    
}