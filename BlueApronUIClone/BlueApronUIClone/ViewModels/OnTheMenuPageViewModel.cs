using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;
using System.Collections.ObjectModel;
using BlueApronUIClone.Models;

namespace BlueApronUIClone.ViewModels
{
    public class OnTheMenuPageViewModel : ViewModelBase
    {
        public ObservableCollection<Recipe> RecipeList { get; set; }

        public String WeekLabel1 { get; set; }
        public String WeekLabel2 { get; set; }
        public String WeekLabel3 { get; set; }
        public String WeekLabel4 { get; set; }
        //public object MyProperty { get; set; }

        public OnTheMenuPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "On The Menu";

            WeekLabel1 = "Week of" + Environment.NewLine +
                         "July 1";
            WeekLabel2 = "Week of" + Environment.NewLine +
                         "July 8";
            WeekLabel3 = "Week of" + Environment.NewLine +
                         "July 15";
            WeekLabel4 = "Week of" + Environment.NewLine +
                         "July 22";

            RecipeList = new ObservableCollection<Recipe>();
            PopulateList();
        }

        private void PopulateList()
        {

            RecipeList.Add(new Recipe()
            {
                RecipeId = 1,
                RecipeName = "Sweet Chilli Beef & Vegetable Stir-Fry",
                RecipeDesc = "with Garlic Rice",
                Picture = "sweetchilli"
            });

            RecipeList.Add(new Recipe()
            {
                RecipeId = 2,
                RecipeName = "Cheesy Pesto Chicken Calzones",
                RecipeDesc = "with Tomato Sauce & Marinated Zucchini",
                Picture = "img1"
            });
            RecipeList.Add(new Recipe()
            {
                RecipeId = 3,
                RecipeName = "Monterey Jack Cheeseburgers",
                RecipeDesc = "topped with Poblano & Tomato Salsa",
                Picture = "img2"
            });
            RecipeList.Add(new Recipe()
            {
                RecipeId = 4,
                RecipeName = "Roast Pork & Vegetables",
                RecipeDesc = "with Basil Pesto & Marinated Tomatoes",
                Picture = "img3"
            });
            RecipeList.Add(new Recipe()
            {
                RecipeId = 5,
                RecipeName = "Orange-Soy Barramundi & Fried Rice",
                RecipeDesc = "with Snow Peas & Bok Choy",
                Picture = "img4"
            });
            RecipeList.Add(new Recipe()
            {
                RecipeId = 6,
                RecipeName = "Sweet Potato & Spicy Cucumber Bao",
                RecipeDesc = "with Black Garlic Mayo",
                Picture = "img5"
            });
            RecipeList.Add(new Recipe()
            {
                RecipeId = 7,
                RecipeName = "Tahini Chicken",
                RecipeDesc = "with Tomato Sauce & Marinated Zucchini",
                Picture = "img6"
            });
        }
    }
}
