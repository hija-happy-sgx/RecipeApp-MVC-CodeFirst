namespace Recipe_App_MVC_CodeFirst.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public ICollection<Recipe> Recipes { get; set; }

    }
}
