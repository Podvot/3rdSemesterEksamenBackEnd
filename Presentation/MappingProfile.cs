using AutoMapper;
using Models;

namespace Presentation;

public class MappingProfile :  Profile
{
    public MappingProfile()
    {
        CreateMap<IngredientAvailabilityDto, Ingredient>();
        CreateMap<Ingredient, IngredientAvailabilityDto>();
        CreateMap<CreateMenuItemDTO, MenuItem>();
        CreateMap<MenuItem, CreateMenuItemDTO>();
    }
}