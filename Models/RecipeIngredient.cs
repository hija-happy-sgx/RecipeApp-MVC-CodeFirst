namespace Recipe_App_MVC_CodeFirst.Models
{
    // junction table
    public class RecipeIngredient
    {
        public required int  RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public string Quantity { get; set; }
    }
}
