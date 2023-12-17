using AutoMapper;
using Models.Ingredients;
using Models.Recipes;


namespace Presentation;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateRecipeIngredientDto, RecipeIngredients>();
        CreateMap<RecipeIngredients, CreateRecipeIngredientDto>();
        CreateMap<IngredientAvailabilityDto, Ingredient>();
        CreateMap<Ingredient, IngredientAvailabilityDto>();
        CreateMap<Ingredient, IngredientAvailabilityDto>();
        CreateMap<IngredientAvailabilityDto, Ingredient>();
    }
}