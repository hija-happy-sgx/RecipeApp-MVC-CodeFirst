namespace Recipe_App_MVC_CodeFirst.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Instructions { get; set; }

        // Relationships
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
