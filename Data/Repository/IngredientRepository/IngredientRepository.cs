using Models;
using Models.Ingredients;

namespace Data.Repository.IngredientRepository;

public class IngredientRepository : IIngredientRepository
{
    private readonly KaffeshopContext _context;

    public IngredientRepository(KaffeshopContext context)
    {
        _context = context;
    }

    public IList<Ingredient> GetIngredients()
    {
        return _context.Ingredients.ToList();
    }

    public Ingredient GetIngredient(Guid id)
    {
        return _context.Ingredients.Find(id);
    }

    public bool IngredientExists(Guid id)
    {
        return _context.Ingredients.Any(x => x.Id == id);
    }

    public Ingredient UpdateIngredient(Guid id, Ingredient ingredient)
    {
        var ingredientToUpdate = GetIngredient(id);
        ingredientToUpdate.Name = ingredient.Name;
        ingredientToUpdate.Available = ingredient.Available;
        _context.SaveChanges();
        return ingredientToUpdate;
    }

    public void DeleteIngredient(Guid id)
    {
        _context.Ingredients.Remove(GetIngredient(id));
        _context.SaveChanges();
    }

    public Ingredient CreateIngredient(Ingredient ingredient)
    {
        _context.Ingredients.Add(ingredient);
        _context.SaveChanges();
        return ingredient;
    }

    public IList<Ingredient> GetAvailableIngredients()
    {
        return _context.Ingredients.Where(x => x.Available).ToList();
    }
}