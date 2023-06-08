using HackNightMaui.DependencyServices;
using System.Windows.Input;

namespace HackNightMaui.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly IPlatformNameService _nameService;

        private int _count = 0;
        public int Count
        {
            get => _count;
            set => SetProperty(ref _count, value);
        }

        public String PlatformName
        {
            get => _nameService.receiveName();
        }

        public ICommand onButtonClickCommand { get; set; }


        public MainPageViewModel(IPlatformNameService platformNameService)
        {
            this.onButtonClickCommand = new Command(() => onButtonClick());
            this._nameService = platformNameService;
        }

        void onButtonClick()
        {
            Count += 1;
        }
    }
}
