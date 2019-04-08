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
    public class LearnMorePageViewModel : ViewModelBase
    {
        public ICommand LogInCommand { get; private set; }

        public LearnMorePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            LogInCommand = new Command(NavigateLogIn);
        }
        public void NavigateLogIn()
        {
            NavigationService.NavigateAsync("LogInPage");
        }

    }
}
