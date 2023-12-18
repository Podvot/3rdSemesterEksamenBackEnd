using Models.Ingredients;

namespace Data.Repository.IngredientRepository;

public interface IIngredientRepository
{
    IList<Ingredient> GetIngredients();
    Models.Ingredients.Ingredient GetIngredient(Guid id);
    bool IngredientExists(Guid id);
    Models.Ingredients.Ingredient UpdateIngredient(Guid id, Ingredient ingredient);
    void DeleteIngredient(Guid id);
    Models.Ingredients.Ingredient CreateIngredient(Ingredient ingredient);
    IList<Ingredient> GetAvailableIngredients();
}