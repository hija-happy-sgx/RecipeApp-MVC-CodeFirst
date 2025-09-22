using Microsoft.EntityFrameworkCore;
using Recipe_App_MVC_CodeFirst.Models;

namespace Recipe_App_MVC_CodeFirst.Data
{
    public class RecipeDbContext: DbContext
    {

        // constructor
        public RecipeDbContext(DbContextOptions<RecipeDbContext> options) : base(options) { }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeIngredient>()
                .HasKey(ri => new { ri.RecipeId, ri.IngredientId, });
        }
    }
}
