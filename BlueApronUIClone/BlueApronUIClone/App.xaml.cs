using Prism;
using Prism.Ioc;
using BlueApronUIClone.ViewModels;
using BlueApronUIClone.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BlueApronUIClone
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/RecipeListPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<LearnMorePage, LearnMorePageViewModel>();
            containerRegistry.RegisterForNavigation<OnTheMenuPage, OnTheMenuPageViewModel>();
            containerRegistry.RegisterForNavigation<RecipeListPage, RecipeListPageViewModel>();
            containerRegistry.RegisterForNavigation<RecipeDetailsPage, RecipeDetailsPageViewModel>();
            containerRegistry.RegisterForNavigation<ProfilePage, ProfilePageViewModel>();
            containerRegistry.RegisterForNavigation<LogInPage, LogInPageViewModel>();
            containerRegistry.RegisterForNavigation<SignUpPage, SignUpPageViewModel>();
            containerRegistry.RegisterForNavigation<DeliveryAddressPage, DeliveryAddressPageViewModel>();
            containerRegistry.RegisterForNavigation<PlanSelectionPage, PlanSelectionPageViewModel>();
            containerRegistry.RegisterForNavigation<PlanTypePage, PlanTypePageViewModel>();
            containerRegistry.RegisterForNavigation<OrderSummaryPage, OrderSummaryPageViewModel>();
        }
    }
}
