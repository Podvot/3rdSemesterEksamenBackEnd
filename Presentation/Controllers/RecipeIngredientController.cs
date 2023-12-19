using AutoMapper;
using Business.Service.RecipeService;
using Microsoft.AspNetCore.Mvc;
using Models.Ingredients;
using Models.Recipes;

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
    
    [HttpGet]
    [Route("GetRecipeIngredients")]
    public IActionResult GetRecipeIngredients()
    { 
        
        var recipeIngredients = _recipeIngredientsService.GetRecipeIngredients(); 
        return Ok(recipeIngredients);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetRecipeIngredient(Guid id)
    {
        var recipeIngredient = _recipeIngredientsService.GetRecipeIngredient(id);
        if (recipeIngredient == null)
        {
            return NotFound();
        }

        return Ok(recipeIngredient);
    }
    
    [HttpPost]
    public IActionResult CreateRecipeIngredient([FromBody] CreateRecipeIngredientDto createRecipeIngredientDto)
    {
        var recipeIngredient = new RecipeIngredients();
        _mapper.Map(createRecipeIngredientDto, recipeIngredient);
        var newRecipeIngredient = _recipeIngredientsService.CreateRecipeIngredient(recipeIngredient);
        return CreatedAtAction(nameof(GetRecipeIngredient), new { id = newRecipeIngredient.Id }, newRecipeIngredient);
    }

    [HttpPut("{recipeIngredientId}/AddIngredient")]
    public IActionResult AddIngredient(Guid recipeIngredientId, [FromBody] Ingredient ingredient)
    {
        if (!_recipeIngredientsService.RecipeIngredientExists(recipeIngredientId))
        {
            return NotFound();
        }
        else
        {
            _recipeIngredientsService.AddIngredient(recipeIngredientId, ingredient);
        }

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteRecipeIngredient(Guid id)
    {
        if (!_recipeIngredientsService.RecipeIngredientExists(id))
        {
            return NotFound();
        }

        _recipeIngredientsService.DeleteRecipeIngredient(id);
        return NoContent();
    }
    
    
}