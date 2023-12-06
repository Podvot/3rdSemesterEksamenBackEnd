using AutoMapper;
using Business.Service;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MenuItemController : Controller
{
    private readonly IMenuItemService _menuItemService;
    private readonly IMapper _mapper;
    
    public MenuItemController(IMenuItemService menuItemService, IMapper mapper)
    {
        _menuItemService = menuItemService;
        _mapper = mapper;
    }
    
    [HttpGet]
    [Route("GetMenuItems")]
    public IActionResult GetMenuItems()
    {
        var menuItems = _menuItemService.GetMenuItems();
        return Ok(menuItems);
    }

    [HttpGet("{id}")]
    public IActionResult GetMenuItem(Guid id)
    {
        var menuItem = _menuItemService.GetMenuItem(id);
        if (menuItem == null)
        {
            return NotFound();
        }
        return Ok(menuItem);
    }

    [HttpPost]
    public IActionResult CreateMenuItem([FromBody] CreateMenuItemDTO createMenuItemDto)
    {
        var menuItem = new MenuItem();
        _mapper.Map(createMenuItemDto, menuItem);
        var newMenuItem = _menuItemService.CreateMenuItem(menuItem);
        return CreatedAtAction(nameof(GetMenuItem), new { id = newMenuItem.Id }, newMenuItem);
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateMenuItem(Guid id, [FromBody] MenuItem menuItem)
    {
        if (!_menuItemService.MenuItemExists(id))
        {
            return NotFound();
        }

        var updatedIngredient = _menuItemService.UpdateMenuItem(id, menuItem);
        return Ok(updatedIngredient);
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteMenuItem(Guid id)
    {
        if (!_menuItemService.MenuItemExists(id))
        {
            return NotFound();
        }

        _menuItemService.DeleteMenuItem(id);
        return NoContent();
    }
}