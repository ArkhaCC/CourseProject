using System;

namespace CookbookApp.Model
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    namespace CookbookApp.Model
    {
        public class RecipeContext : DbContext
        {
           public DbSet<Recipe> Recipes { get; set; }
           public DbSet<Tags> Posts { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite("Data Source=cookbook.db");
        }

        public class User
        {
            [Key]
            public int UserName { get; set; }
            public string LastLogin { get; set; }

            public List<Recipe> Recipes { get; } = new List<Recipe>();
        }

        public class Recipe
        {
            [Key]
            public string RecipeNameId { get; set; }
            public byte[] SavedRecipe { get; set; }
            public DateTime DateSaved { get; set; }

            public Tags AppliedTags { get; set; }

        }

        public class Tags
        {
            [Key]
            public string TagName { get; set; }
            public Recipe recipe { get; }
        }

        public class AccessFrequency
        {
            [Key]
            public Recipe recipe { get; }
            public DateTime DateLastAccessed { get; set; }
            public int TimesAccessed { get; set; }
        }
    }
}

