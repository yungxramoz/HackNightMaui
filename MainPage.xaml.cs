using HackNightMaui.ViewModels;

namespace HackNightMaui;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}

