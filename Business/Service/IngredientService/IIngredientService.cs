using Models.Ingredients;

namespace Business.Service.IngredientService;

public interface IIngredientService
{
    IList<Ingredient> GetIngredients();
    Ingredient? GetIngredient(Guid id);
    bool IngredientExists(Guid id);
    Ingredient UpdateIngredient(Guid id, Ingredient ingredient);
    void DeleteIngredient(Guid id);
    Ingredient CreateIngredient(Ingredient ingredient);
    IList<Ingredient> GetAvailableIngredients();
}