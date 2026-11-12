using RanFlashBoot.ViewModels;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace RanFlashBoot.Servises.Navigation
{
    public interface INavigationService
    {
        void NavigateTo<TView>(SettingViewModel viewModel) where TView : ContentView;
        void ClearNavigation(SettingViewModel viewModel);




    }
}
