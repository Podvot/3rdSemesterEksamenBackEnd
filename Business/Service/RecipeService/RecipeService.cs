using Data.Repository.RecipeRepository;
using Models.Recipes;

namespace Business.Service.RecipeService;

public class RecipeService : IRecipeService
{
    private IRecipeRepository _recipeRepository;
    
    public RecipeService(IRecipeRepository recipeRepository)
    {
        _recipeRepository = recipeRepository;
    }

    public IList<Recipe> GetRecipes()
    {
        return _recipeRepository.GetRecipes();
    }
    
    public Recipe? GetRecipe(Guid id)
    {
        return _recipeRepository.GetRecipe(id);
    }

    public Recipe CreateRecipe(Recipe recipe)
    {
        return _recipeRepository.CreateRecipe(recipe);
    }

    public bool RecipeExists(Guid id)
    {
        return _recipeRepository.RecipeExists(id);
    }

    public void DeleteRecipe(Guid id)
    {
        _recipeRepository.DeleteRecipe(id);
    }
}