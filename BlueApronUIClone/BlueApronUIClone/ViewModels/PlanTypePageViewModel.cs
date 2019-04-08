using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace BlueApronUIClone.ViewModels
{
    public class PlanTypePageViewModel : ViewModelBase
    {
        public ICommand PlanTypeSelectCommand { get; private set; }

        public PlanTypePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Let's Personalize your plan." + Environment.NewLine + "Which one fits your lifestyle?";
            PlanTypeSelectCommand = new Command(NavigatePlanSelection);

        }
        public void NavigatePlanSelection()
        {
            NavigationService.NavigateAsync("PlanSelectionPage");
        }
    }
}
