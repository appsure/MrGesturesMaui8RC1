using Microsoft.Extensions.Logging;
using MR.Gestures;

namespace MrGesturesMaui8RC1;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .ConfigureMRGestures()//"DW5K-FZ2G-2VHD-7ZHY-DM5V-B22A-UK3S-EK7M-3CB9-PJ8H-L3GZ-QWMY-9TVJ")
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

