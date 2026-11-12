

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RanFlashBoot.Servises.Navigation;
using RanFlashBoot.ServisesDisks;

namespace RanFlashBoot.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        private string _isoFilePath;
        [ObservableProperty]
        private string _selectedDrive;
        [ObservableProperty]
        private List<string> _drives = new List<string>();
        [ObservableProperty]
        private string _title;
        [ObservableProperty]

        private INavigationService _navigationService;
        private readonly DriveServis _driveServis;
        private readonly ISOWriterServises _isoWriterServises;
        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            _driveServis = new DriveServis();
            _isoWriterServises = new ISOWriterServises();
            LoadRemoveDrivers();

        }



        private void LoadRemoveDrivers()
        {
            Drives = _driveServis.SearchDrives();



        }

        [RelayCommand]
        public  async void WriteISOToDrive()
        {
            _isoWriterServises.WriteISO(_isoFilePath, SelectedDrive.First().ToString());
            await Application.Current.MainPage.DisplayAlertAsync("FINISHED", "ISO file written successfully.", "ОК");
        }

        [RelayCommand]
        public async void OpenDirectory()
        {
            try
            {
                FileResult? result = await FilePicker.Default.PickAsync();

                if (result != null)
                {
                    _isoFilePath = result.FullPath;

                }
                else
                {
                    Title = "No file selected.";
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlertAsync("Error",ex.Message, "ОК");
            }











        }
    }
}
