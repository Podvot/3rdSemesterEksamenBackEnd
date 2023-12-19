using AutoMapper;
using Business.Service.MenuItemService;
using Microsoft.AspNetCore.Mvc;
using Models.MenuItems;
using Models.Recipes;

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
    
    [HttpGet]
    [Route("GetMenuRecipes")]
    public IActionResult GetMenuRecipes()
    { 
        var menuRecipes = _menuItemRecipeService.GetMenuRecipes(); 
        return Ok(menuRecipes);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetMenuRecipe(Guid id)
    {
        var menuRecipe = _menuItemRecipeService.GetMenuRecipe(id);
        if (menuRecipe == null)
        {
            return NotFound();
        }

        return Ok(menuRecipe);
    }
    
    [HttpPost]
    public IActionResult CreateMenuRecipe([FromBody] CreateMenuRecipeDTO createMenuRecipeDTO)
    {
        var menuRecipe = new MenuRecipe();
        _mapper.Map(createMenuRecipeDTO, menuRecipe);
        var newMenuRecipe = _menuItemRecipeService.CreateMenuRecipe(menuRecipe);
        return CreatedAtAction(nameof(GetMenuRecipe), new { id = newMenuRecipe.Id }, newMenuRecipe);
    }

    [HttpPut("{menuItemId}/AddRecipe")]
    public IActionResult AddRecipe(Guid menuItemId, [FromBody] Recipe recipe)
    {
        if (!_menuItemRecipeService.MenuRecipeExists(menuItemId))
        {
            return NotFound();
        }
        else
        {
            _menuItemRecipeService.AddRecipe(menuItemId, recipe);
        }

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteMenuRecipe(Guid id)
    {
        if (!_menuItemRecipeService.MenuRecipeExists(id))
        {
            return NotFound();
        }

        _menuItemRecipeService.DeleteMenuRecipe(id);
        return NoContent();
    }
    
}