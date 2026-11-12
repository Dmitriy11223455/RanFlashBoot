


using RanFlashBoot.ViewModels;

namespace RanFlashBoot
{
    public partial class MainPage : ContentView
    {
        int count = 0;

        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
        }

        private void OnChangeLanguageClicked(object sender, EventArgs e) { }
        private void OnChangeThemeClicked(object sender, EventArgs e) { }
        private void OnSelectDeviceClicked(object sender, EventArgs e) { }
        private void OnSelectFileClicked(object sender, EventArgs e) { }

        
        
    }
}
