using AutoMapper;
using Models.Ingredients;
using Models.MenuItems;
using Models.Recipes;


namespace Presentation;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<MenuItem, MenuItem>();
        CreateMap<Recipe, Recipe>();
        CreateMap<CreateMenuRecipeDTO, MenuRecipe>();
        CreateMap<MenuRecipe, CreateMenuRecipeDTO>();
        CreateMap<CreateRecipeIngredientDto, RecipeIngredients>();
        CreateMap<RecipeIngredients, CreateRecipeIngredientDto>();
        CreateMap<IngredientAvailabilityDTO, Ingredient>();
        CreateMap<Ingredient, IngredientAvailabilityDTO>();
        CreateMap<Ingredient, IngredientAvailabilityDTO>();
        CreateMap<IngredientAvailabilityDTO, Ingredient>();
    }
}