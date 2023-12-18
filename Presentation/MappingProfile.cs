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
        CreateMap<IngredientAvailabilityDTO, Ingredient>();
        CreateMap<Ingredient, IngredientAvailabilityDTO>();
        CreateMap<Ingredient, IngredientAvailabilityDTO>();
        CreateMap<IngredientAvailabilityDTO, Ingredient>();
    }
}