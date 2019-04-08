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
            _learnPage.Icon = "ic_nav_current_menu_unselected";
            _learnPage.Title = "Learn More";

            var _menuPage = new OnTheMenuPage();
            _menuPage.Icon = "ic_nav_upcoming_unselected";
            _menuPage.Title = "On The Menu";

            var _allRecipes = new RecipeListPage();
            _allRecipes.Icon = "ic_nav_recipe_search_unselected";
            _allRecipes.Title = "All Recipes";

            Children.Add(_learnPage);
            Children.Add(_menuPage);
            Children.Add(_allRecipes);

            var _profile = new ProfilePage();
            _profile.Icon = "ic_nav_profile_unselected";
            _profile.Title = "Profile";

            Children.Add(_profile);

            /*if (Application.Current.Properties.ContainsKey("IS_LOGGED_IN")
                && (bool) Application.Current.Properties["IS_LOGGED_IN"] == true )
            {
                var _profile = new ProfilePage();
                _profile.Icon = "ic_nav_profile_uselected";
                _profile.Title = "Profile";

                Children.Add(_profile);
            }*/


        }
    }
}