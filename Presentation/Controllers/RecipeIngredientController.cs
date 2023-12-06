using AutoMapper;
using Business.Service;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RecipeIngredientController : Controller
{
    private readonly IRecipeIngredientsService _recipeIngredientsService;
    private readonly IMapper _mapper;

    public RecipeIngredientController(IRecipeIngredientsService recipeIngredientsService, IMapper mapper)
    {
        _recipeIngredientsService = recipeIngredientsService;
        _mapper = mapper;
    }
    
    [HttpPut("{recipeId}/AddIngredient")]
    public IActionResult AddIngredient(Guid recipeId, [FromBody] Guid ingredient)
    {
        if (!_recipeIngredientsService.RecipeExists(recipeId))
        {
            return NotFound();
        }

        _recipeIngredientsService.AddIngredient(recipeId, ingredient);
        return Ok();
    }
    
}