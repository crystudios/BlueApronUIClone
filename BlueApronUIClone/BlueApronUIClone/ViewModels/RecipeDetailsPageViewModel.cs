using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;

namespace BlueApronUIClone.ViewModels
{
    public class RecipeDetailsPageViewModel : ViewModelBase
    {
        public RecipeDetailsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
