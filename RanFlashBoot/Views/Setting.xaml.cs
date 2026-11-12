
using RanFlashBoot.Resources.Locations;
using RanFlashBoot.ViewModels;
using System.Globalization;

namespace RanFlashBoot;

public partial class Setting : ContentPage
{
	public Setting(SettingViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;

		
    }
}