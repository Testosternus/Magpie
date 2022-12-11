namespace Magpie;
using Magpie.Services.Data;
using Microsoft.Extensions.DependencyInjection;
using FreshMvvm.Maui.Extensions;
using Magpie.ViewModels;
using Magpie.Pages;
using static Magpie.App;
using Magpie.Services.Interfaces;
using Magpie.Services;

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
		builder.Services.AddSingleton<MagpieContext>(Database);

		builder.Services.AddTransient<ConcertPage>();
		builder.Services.AddTransient<ConcertPageModel>();

		builder.Services.AddTransient<FoodPage>();
		builder.Services.AddTransient<FoodPageModel>();

		builder.Services.AddTransient<IConcertService, ConcertService>();
		builder.Services.AddTransient<IFoodService, FoodPlaceService>();

		var app = builder.Build();
		StartUpExtensions.UseFreshMvvm(app);
		return app;
	}

    internal static MagpieContext Database => MagpieSingleton.magpieContext;


}
