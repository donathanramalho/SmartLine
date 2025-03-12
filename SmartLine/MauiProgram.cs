using Microsoft.Extensions.Logging;
using SmartLine.Shared.Services;
using SmartLine.Services;
using SmartLine.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace SmartLine;

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
            });

        // Add device-specific services used by the SmartLine.Shared project
        builder.Services.AddSingleton<IFormFactor, FormFactor>();
        builder.Services.AddTransient<TodoContext>();

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
