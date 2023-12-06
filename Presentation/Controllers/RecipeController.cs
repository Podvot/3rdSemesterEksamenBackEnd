using AutoMapper;
using Business.Service;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RecipeController : Controller
{
    private readonly IRecipeService _recipeService;
    private readonly IMapper _mapper;

    public RecipeController(IRecipeService recipeService, IMapper mapper)
    {
        _recipeService = recipeService;
        _mapper = mapper;
    }

    [HttpGet]
    [Route("GetRecipes")]
    public IActionResult GetRecipes()
    {
        var recipes = _recipeService.GetRecipes();
        return Ok(recipes);
    }

    [HttpGet("{id}")]
    public IActionResult GetRecipe(Guid id)
    {
        var recipe = _recipeService.GetRecipe(id);
        if (recipe == null)
        {
            return NotFound();
        }

        return Ok(recipe);
    }

    [HttpPost]
    public IActionResult CreateRecipe([FromBody] CreateRecipeDTO createRecipeDto)
    {
        var recipe = new Recipe();
        _mapper.Map(createRecipeDto, recipe);
        var newRecipe = _recipeService.CreateRecipe(recipe);
        return CreatedAtAction(nameof(GetRecipe), new { id = newRecipe.Id }, newRecipe);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateRecipe(Guid id, [FromBody] Recipe recipe)
    {
        if (!_recipeService.RecipeExists(id))
        {
            return NotFound();
        }

        var updatedIngredient = _recipeService.UpdateRecipe(id, recipe);
        return Ok(updatedIngredient);
    }

    [HttpPut("{recipeId}/AddIngredient")]
    public IActionResult AddIngredient(Guid recipeId, [FromBody] Ingredient ingredient)
    {
        if (!_recipeService.RecipeExists(recipeId))
        {
            return NotFound();
        }

        _recipeService.AddIngredient(recipeId, ingredient);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteRecipe(Guid id)
    {
        if (!_recipeService.RecipeExists(id))
        {
            return NotFound();
        }

        _recipeService.DeleteRecipe(id);
        return NoContent();
    }
}