using Models.Ingredients;

namespace Data.Repository.IngredientRepository;

public interface IIngredientRepository
{
    IList<Ingredient> GetIngredients();
    Ingredient GetIngredient(Guid id);
    bool IngredientExists(Guid id);
    Ingredient UpdateIngredient(Guid id, Ingredient ingredient);
    void DeleteIngredient(Guid id);
    Ingredient CreateIngredient(Ingredient ingredient);
    IList<Ingredient> GetAvailableIngredients();
}