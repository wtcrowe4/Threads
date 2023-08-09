﻿using Microsoft.Extensions.Logging;
using DotNet.Meteor.HotReload.Plugin;

namespace Threads;

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
				fonts.AddFont("fa-brands.otf", "FAB");
				fonts.AddFont("fa-regular.otf", "FAR");
				fonts.AddFont("fa-solid.otf", "FAS");
			});

#if DEBUG
		builder.EnableHotReload();
		builder.Logging.AddDebug();
		
#endif

		return builder.Build();
	}
}
