using Microsoft.Extensions.DependencyInjection;
using RanFlashBoot.Resources.Locations;
using System.Globalization;

namespace RanFlashBoot
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var culture = new CultureInfo("uk-UA");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;

            AppResources.Culture = culture;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            MainPage = new AppShell();
            return new Window(MainPage);

        }

        

    }
}