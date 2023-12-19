using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Models.Recipes;

namespace Models.MenuItems;

public class MenuRecipe
{

    [Column(TypeName = "uniqueidentifier")]
    public Guid Id { get; set; }

    public string Name { get; set; }

    public IList<Recipe>? AttachRecipe { get; set; }

}