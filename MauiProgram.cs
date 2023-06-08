using HackNightMaui.CustomRenderer;
using HackNightMaui.DependencyServices;
using HackNightMaui.Platforms;
using HackNightMaui.ViewModels;
using Microsoft.Extensions.Logging;

namespace HackNightMaui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        builder.Services.AddSingleton<IPlatformNameService, PlatformNameService>();
        builder.Services.AddTransient<MainPageViewModel>();
        builder.Services.AddTransient<MainPage>();
        builder.ConfigureMauiHandlers(builder =>
        {
            builder.AddHandler(typeof(HighlightedLabel), typeof(HighlightedLabelHandler));
        });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
