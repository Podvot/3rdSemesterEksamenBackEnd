namespace Models;

public class CreateIngredientDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Available { get; set; }
}