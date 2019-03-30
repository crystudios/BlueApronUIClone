using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BlueApronUIClone.Views
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            var _learnPage = new LearnMorePage();
            _learnPage.Icon = "icon";
            _learnPage.Title = "Learn More";

            var _menuPage = new OnTheMenuPage();
            _menuPage.Icon = "icon";
            _menuPage.Title = "On The Menu";

            var _allRecipes = new RecipeListPage();
            _allRecipes.Icon = "icon";
            _allRecipes.Title = "All Recipes";

            Children.Add(_learnPage);
            Children.Add(_menuPage);
            Children.Add(_allRecipes);
        }
    }
}