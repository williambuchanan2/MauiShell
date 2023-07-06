using CommunityToolkit.Maui;
using MauiShell.ViewModels;
using MauiShell.Views;
using Microsoft.Extensions.Logging;

namespace MauiShell;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        RegisterViews(builder);
        return builder.Build();
    }
   
    public static void RegisterViews(MauiAppBuilder builder)
    {

        builder.Services.AddTransient<Page1Vm>(); 
        builder.Services.AddTransient<Page1>();
        Routing.RegisterRoute(nameof(Page1), typeof(Page1));

        builder.Services.AddTransient<Page2Vm>();
        builder.Services.AddTransient<Page2>();
        Routing.RegisterRoute(nameof(Page2), typeof(Page2));

        builder.Services.AddTransient<Page3Vm>();
        builder.Services.AddTransient<Page3>();
        Routing.RegisterRoute(nameof(Page3), typeof(Page3));

        builder.Services.AddTransient<Page4Vm>();
        builder.Services.AddTransient<Page4>();
        Routing.RegisterRoute(nameof(Page4), typeof(Page4));

        builder.Services.AddTransient<Page5Vm>();
        builder.Services.AddTransient<Page5>();
        Routing.RegisterRoute(nameof(Page5), typeof(Page5));

        builder.Services.AddTransient<Page6Vm>();
        builder.Services.AddTransient<Page6>();
        Routing.RegisterRoute(nameof(Page6), typeof(Page6));

        builder.Services.AddTransient<Page7Vm>();
        builder.Services.AddTransient<Page7>();
        Routing.RegisterRoute(nameof(Page7), typeof(Page7));

        builder.Services.AddTransient<Page8Vm>();
        builder.Services.AddTransient<Page8>();
        Routing.RegisterRoute(nameof(Page8), typeof(Page8));

        builder.Services.AddTransient<Page9Vm>();
        builder.Services.AddTransient<Page9>();
        Routing.RegisterRoute(nameof(Page9), typeof(Page9));

        builder.Services.AddTransient<Page10Vm>();
        builder.Services.AddTransient<Page10>();
        Routing.RegisterRoute(nameof(Page10), typeof(Page10));

    }
}
