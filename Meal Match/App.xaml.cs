using System;
using System.Threading.Tasks;
using Template10.Services.NavigationService;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Data;

namespace Meal_Match
{
    [Bindable]
    sealed partial class App : Template10.Common.BootStrapper
    {
        public App()
        {
            InitializeComponent();
        }

        public override async Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            await NavigationService.NavigateAsync(typeof(Views.MainPage));
        }
    }
}