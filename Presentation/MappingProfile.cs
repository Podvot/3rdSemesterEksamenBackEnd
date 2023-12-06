using AutoMapper;
using Models;

namespace Presentation;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateRecipeDTO, Recipe>();
        CreateMap<Recipe, CreateRecipeDTO>();
        CreateMap<CreateMenuItemDTO, MenuItem>();
        CreateMap<MenuItem, CreateMenuItemDTO>();
        CreateMap<IngredientAvailabilityDto, Ingredient>();
        CreateMap<Ingredient, IngredientAvailabilityDto>();
    }
}