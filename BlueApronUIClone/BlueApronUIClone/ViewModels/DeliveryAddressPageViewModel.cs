using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;
using Xamarin.Forms;
using System.Windows.Input;

namespace BlueApronUIClone.ViewModels
{
    public class DeliveryAddressPageViewModel : ViewModelBase
    {
        public ICommand ContinueButtonCommand { get; private set; }
        public DeliveryAddressPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            ContinueButtonCommand = new Command(NavigatePlanSelection);
        }
        public void NavigatePlanSelection()
        {
            NavigationService.NavigateAsync("PlanTypePage");
        }
    }
}
