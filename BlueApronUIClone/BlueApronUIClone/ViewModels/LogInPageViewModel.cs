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
    public class LogInPageViewModel : ViewModelBase
    {
        public ICommand SignUpCommand { get; private set; }
        public ICommand NavigateDeliveryCommand { get; private set; }

        public LogInPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            SignUpCommand = new Command(NavigateSignUp);
            NavigateDeliveryCommand = new Command(NavigateDelivery);
        }

        void NavigateDelivery()
        {
            NavigationService.NavigateAsync("DeliveryAddressPage");
        }
        void NavigateSignUp()
        {
            NavigationService.NavigateAsync("SignUpPage");
        }
    }
}
