using AutoMapper;
using Business.Service;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MenuItemRecipeController : Controller
{
    private readonly IMenuItemRecipeService _menuItemRecipeService;
    private readonly IMapper _mapper;

    public MenuItemRecipeController(IMenuItemRecipeService menuItemRecipeService, IMapper mapper)
    {
        _menuItemRecipeService = menuItemRecipeService;
        _mapper = mapper;
    }
    
    [HttpPut("{menuItemId}/AddRecipe")]
    public IActionResult AddRecipe(Guid menuItemId, [FromBody] Recipe recipe)
    {
        if (!_menuItemRecipeService.MenuItemRecipeExists(menuItemId))
        {
            return NotFound();
        }

        _menuItemRecipeService.AddRecipe(menuItemId, recipe);
        return Ok();
    }
    
}