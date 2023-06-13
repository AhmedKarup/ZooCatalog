using MauiApp12.Views;
using MauiApp12.ViewsModels;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Maps;

namespace MauiApp12;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiMaps()
            

            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("BadScript-Regular.ttf", "BadScript");
                fonts.AddFont("Nexa-Heavy.ttf", "NexaHeavy");
				fonts.AddFont("Merriweather-Regular.ttf", "desc");
                fonts.AddFont("Merriweather-BoldItalic.ttf", "desc1");
                fonts.AddFont("Merriweather-Italic.ttf", "desc2");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<DashboardView>();
		builder.Services.AddSingleton<DashboardViewModel>();

		builder.Services.AddSingleton<IntroScreenView>();
		builder.Services.AddSingleton<IntroScreenViewModel>();

		builder.Services.AddTransient<DetailView>();
		builder.Services.AddTransient<DetailViewModel>();
		builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);

		return builder.Build();
	}
}
