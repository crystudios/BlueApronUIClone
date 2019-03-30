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
    public class PlanTypePageViewModel : ViewModelBase
    {
        public PlanTypePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Let's Personalize your plan." + Environment.NewLine + "Which one fits your lifestyle?";
        }
    }
}
