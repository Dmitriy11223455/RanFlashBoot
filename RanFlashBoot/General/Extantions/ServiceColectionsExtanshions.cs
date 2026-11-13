using RanFlashBoot.Servises.Navigation;
using RanFlashBoot.ViewModels;
using RanFlashBoot;
using RanFlashBoot.Servises.Navigation;
using RanFlashBoot.ViewModels;
using RanFlashBoot;
using RanFlashBoot.Servises.Navigation;
using RanFlashBoot.ViewModels;
using RanFlashBoot;
using RanFlashBoot.Servises.Navigation;
using RanFlashBoot.ViewModels;
using RanFlashBoot.Servises.Navigation;
using RanFlashBoot.Servises.Navigation;

namespace RanFlashBoot.General.Extantions
{
    public static class ServiceColectionsExtanshions
    {
        public static void AddViewModels(this IServiceCollection services)
        {
            services.AddSingleton<SettingViewModel>();
            services.AddSingleton<MainPageViewModel>();

        }
        public static void AddViews(this IServiceCollection services)
        {
            services.AddTransient<MainPage>();
            services.AddSingleton<App>();
            services.AddSingleton<Setting>();
            

        }
        public static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<INavigationService, NavigationService>();
        }


    }
}
