using BibleRecallTrainer.Services;
using BibleRecallTrainer.ViewModels;
using BibleRecallTrainer.Views;
using Microsoft.Extensions.Logging;
namespace BibleRecallTrainer;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts => { fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold"); });
        builder.Services.AddSingleton<IBibleContentService, JsonBibleContentService>();
        builder.Services.AddSingleton<DashboardViewModel>(); builder.Services.AddTransient<BooksViewModel>(); builder.Services.AddTransient<ChapterReaderViewModel>();
        builder.Services.AddSingleton<DashboardPage>(); builder.Services.AddTransient<BooksPage>(); builder.Services.AddTransient<ChapterReaderPage>(); builder.Services.AddSingleton<AppShell>();
#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }
}
