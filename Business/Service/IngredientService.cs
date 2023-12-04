﻿using Data.Repository;
using Models;

namespace Business.Service;

public class IngredientService : IIngredientService
{
    private IIngredientRepository _ingredientRepository;

    public IngredientService(IIngredientRepository ingredientRepository)
    {
        _ingredientRepository = ingredientRepository;
    }
    
    public IList<Ingredient> GetIngredients()
    {
        return _ingredientRepository.GetIngredients();
    }

    public Ingredient GetIngredient(Guid id)
    {
        return _ingredientRepository.GetIngredient(id);
    }

    public bool IngredientExists(Guid id)
    {
        return _ingredientRepository.IngredientExists(id);
    }

    public Ingredient UpdateIngredient(Guid id, Ingredient ingredient)
    {
        return _ingredientRepository.UpdateIngredient(id, ingredient);
    }

    public void DeleteIngredient(Guid id)
    {
        _ingredientRepository.DeleteIngredient(id);
    }

    public Ingredient CreateIngredient(Ingredient ingredient)
    {
        return _ingredientRepository.CreateIngredient(ingredient);
    }

    public IList<Ingredient> GetAvailableIngredients()
    {
        return _ingredientRepository.GetAvailableIngredients();
    }
}