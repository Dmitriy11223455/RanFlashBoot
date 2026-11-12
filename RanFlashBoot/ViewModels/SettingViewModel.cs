using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RanFlashBoot.Servises.Navigation;
using Microsoft.Maui.Controls;
using RanFlashBoot.Servises.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RanFlashBoot.ViewModels
{
    
    public partial class SettingViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _isCurrentViewVisible = false;
        [ObservableProperty]
        private bool _isVerticalStackLayoutVisible = true;
        [ObservableProperty]
        private ContentView _currentView;
        private readonly INavigationService _navigationService;
        public SettingViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            
        }

        [RelayCommand]
        private void NavigateToMainPage()
        {
            _navigationService.NavigateTo<MainPage>(this);
            UseNavigation();
        }
        
        
        private void UseNavigation() 
        {
            IsCurrentViewVisible = true;
            IsVerticalStackLayoutVisible = false;
        }




    }
}