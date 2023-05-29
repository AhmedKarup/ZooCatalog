using MauiApp12.Views;
using MauiApp12.ViewsModels;
using Microsoft.Extensions.Logging;

namespace MauiApp12;

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
				fonts.AddFont("Nexa-ExtraLight.ttf", "NexaLight");
                fonts.AddFont("Nexa-Heavy.ttf", "NexaHeavy");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<DashboardView>();
		builder.Services.AddSingleton<DashboardViewModel>();

		builder.Services.AddSingleton<DashboardView>();
		builder.Services.AddSingleton<DashboardViewModel>();

		return builder.Build();
	}
}
