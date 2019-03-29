using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;
using BlueApronUIClone.Models;
using System.Collections.ObjectModel;

namespace BlueApronUIClone.ViewModels
{
    public class RecipeListPageViewModel : ViewModelBase
    {
        public ObservableCollection<Recipe> RecipeList { get; set; }

        public RecipeListPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "All Recipes";
            RecipeList = new ObservableCollection<Recipe>();
            PopulateList();
        }

        private void PopulateList()
        {
            RecipeList.Add(new Recipe()
            {
                RecipeId = 1,
                RecipeName = "Cheesy Pesto Chicken Calzones",
                RecipeDesc = "with Tomato Sauce & Marinated Zucchini",
                Picture = "img1"
            });
            RecipeList.Add(new Recipe()
            {
                RecipeId = 2,
                RecipeName = "Monterey Jack Cheeseburgers",
                RecipeDesc = "topped with Poblano & Tomato Salsa",
                Picture = "img2"
            });
            RecipeList.Add(new Recipe()
            {
                RecipeId = 3,
                RecipeName = "Roast Pork & Vegetables",
                RecipeDesc = "with Basil Pesto & Marinated Tomatoes",
                Picture = "img3"
            });
            RecipeList.Add(new Recipe()
            {
                RecipeId = 4,
                RecipeName = "Orange-Soy Barramundi & Fried Rice",
                RecipeDesc = "with Snow Peas & Bok Choy",
                Picture = "img4"
            });
            RecipeList.Add(new Recipe()
            {
                RecipeId = 5,
                RecipeName = "Sweet Potato & Spicy Cucumber Bao",
                RecipeDesc = "with Black Garlic Mayo",
                Picture = "img5"
            });
            RecipeList.Add(new Recipe()
            {
                RecipeId = 6,
                RecipeName = "Tahini Chicken",
                RecipeDesc = "with Tomato Sauce & Marinated Zucchini",
                Picture = "img6"
            });
        }
    }
}
