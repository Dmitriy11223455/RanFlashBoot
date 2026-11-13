using RanFlashBoot.ViewModels;
using RanFlashBoot.Views;
using RanFlashBoot.Servises.Navigation;
using RanFlashBoot.ViewModels;

namespace RanFlashBoot.Servises.Navigation
{
    internal class NavigationService : INavigationService
    {
        private readonly INavigationService _navigationService;
        private readonly IServiceProvider _serviceProvider;

        public NavigationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void NavigateTo<TView>(SettingViewModel viewModel) where TView : ContentView
        {
            var view = _serviceProvider.GetRequiredService<TView>();
            viewModel.CurrentView = view;
        }

        public void ClearNavigation(SettingViewModel viewModel)
        {
            viewModel.CurrentView = null;
        }

        



    }

}
