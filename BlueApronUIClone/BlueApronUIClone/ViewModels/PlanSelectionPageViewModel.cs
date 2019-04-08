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
    public class PlanSelectionPageViewModel : ViewModelBase
    {
        public ICommand ContinueButtonCommand { get; private set; }
        public PlanSelectionPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            ContinueButtonCommand = new Command(NavigateOrderSummary);
        }
        public void NavigateOrderSummary()
        {
            NavigationService.NavigateAsync("OrderSummaryPage");
        }
    }
}
