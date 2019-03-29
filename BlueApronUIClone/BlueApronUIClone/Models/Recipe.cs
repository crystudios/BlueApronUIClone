using System;
using SQLite;

namespace BlueApronUIClone.Models
{
    public class Recipe
    {
        //[PrimaryKey, AutoIncrement]
        public int RecipeId { get; set; }
        public String RecipeName { get; set; }
        public String RecipeDesc { get; set; }
        public String Picture { get; set; }
    }
}
