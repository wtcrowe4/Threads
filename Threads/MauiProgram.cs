﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
//using DotNet.Meteor.HotReload.Plugin;

namespace Threads;

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
				fonts.AddFont("Font Awesome 6 Brands-Regular-400.otf", "FAB");
				fonts.AddFont("Font Awesome 6 Free-Regular-400.otf", "FAR");
				fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "FAS");
			});

#if DEBUG
		//builder.EnableHotReload();
		builder.Logging.AddDebug();
		
#endif

		return builder.Build();
	}
}
