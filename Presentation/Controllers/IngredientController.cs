using AutoMapper;
using Business.Service.IngredientService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Models.Ingredients;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IngredientController : ControllerBase
{
    private readonly IIngredientService _ingredientService;
    private readonly IMapper _mapper;
    private readonly ILogger<IngredientController> _logger;
    
    public IngredientController(IIngredientService ingredientService, IMapper mapper, ILogger<IngredientController> logger)
    {
        _ingredientService = ingredientService;
        _mapper = mapper;
        _logger = logger;
    }

    [HttpGet]
    [Route("GetIngredients")]
    public IActionResult GetIngredients()
    {
        var ingredients = _ingredientService.GetIngredients();
        _logger.Log(LogLevel.Information, "GetIngredients called, returning {0} ingredients", ingredients.Count);
        return Ok(ingredients);
    }

    [HttpGet("{id}")]
    public IActionResult GetIngredient(Guid id)
    {
        var ingredient = _ingredientService.GetIngredient(id);
        if (ingredient == null)
        {
            _logger.Log(LogLevel.Information, "GetIngredient called with id {0}, but no ingredient exists with that id", id);
            return NotFound();
        }
        
        _logger.Log(LogLevel.Information, "GetIngredient called with id {0}, returning ingredient", id);
        return Ok(ingredient);
    }

    [HttpPost]
    public IActionResult CreateIngredient([FromBody] Ingredient ingredient)
    {
        Ingredient newIngredient;

        try
        {
            newIngredient = _ingredientService.CreateIngredient(ingredient);
        }
        catch (Exception e)
        {
            var message = "CreateIngredient called, but an exception was thrown";
            _logger.Log(LogLevel.Error, message + ": {0}", e.Message);
            return StatusCode(500, message);
        }
       
        _logger.Log(LogLevel.Information, "CreateIngredient called, returning new ingredient");
        return CreatedAtAction(nameof(GetIngredient), new { id = newIngredient.Id }, newIngredient);    }

    [HttpDelete("{id}")]
    public IActionResult DeleteIngredient(Guid id)
    {
        if (!_ingredientService.IngredientExists(id))
        {
            _logger.Log(LogLevel.Information, "DeleteIngredient called with id {0}, but no ingredient exists with that id", id);
            return NotFound();
        }

        _ingredientService.DeleteIngredient(id);
        _logger.Log(LogLevel.Information, "DeleteIngredient called with id {0}, ingredient deleted", id);
        return NoContent();
    }

    [HttpGet]
    [Route("GetAvailableIngredients")]
    public IActionResult GetAvailableIngredients()
    {
        var ingredients = _ingredientService.GetAvailableIngredients();
        _logger.Log(LogLevel.Information, "GetAvailableIngredients called, returning {0} ingredients", ingredients.Count);
        return Ok(ingredients);
    }
    
    [HttpPut("availability/{id}")]
    public IActionResult UpdateAvailability(Guid id, [FromBody] IngredientAvailabilityDto ingredientAvailabilityDto)
    {
        var ingredient = _ingredientService.GetIngredient(id);
        _logger.Log(LogLevel.Information, ingredientAvailabilityDto.Available.ToString());

        if (ingredient == null)
        {
            _logger.Log(LogLevel.Information, "UpdateAvailability called with id {0}, but no ingredient exists with that id", id);
            return NotFound();
        }
        
        _mapper.Map(ingredientAvailabilityDto, ingredient);
        var updatedIngredient = _ingredientService.UpdateIngredient(id, ingredient);
        _logger.Log(LogLevel.Information, "UpdateAvailability called with id {0}, returning updated ingredient", id);
        return Ok(updatedIngredient);
    }
}
