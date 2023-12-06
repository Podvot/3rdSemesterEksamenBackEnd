namespace Models;

public class RecipeIngredients
{
        
        public Guid RecipeId { get; set; }

        public Guid? IngredientId { get; set; }

        public Recipe Recipe { get; set; }

        public Ingredient Ingredient { get; set; }

}