using MauiApp16.ViewModels;
 
using Microsoft.Extensions.Logging;

namespace MauiApp16;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.Services.AddTransient<IncrementalLoadingPage>();
        builder.Services.AddTransient<HomePage>();

        builder.Services.AddTransient<AnimalsViewModel>();
        builder.Services.AddTransient<HomeViewModel>();    


        return builder.Build();
	}
}
