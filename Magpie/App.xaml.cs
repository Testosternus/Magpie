﻿namespace Magpie;
using FreshMvvm.Maui;
using Magpie.Pages;
using Magpie.Services.Data;
using Magpie.ViewModels;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var masterDetail = new FreshMasterDetailNavigationContainer();
		masterDetail.Title = "Home";
		masterDetail.Init("Menu");
		masterDetail.AddPage<ConcertPageModel>("Concerts", null);
		masterDetail.AddPage<FoodPageModel>("Places to eat", null);

		MainPage = masterDetail;
	}

    internal class MagpieSingleton
    {
        static MagpieSingleton()
        {

        }
        internal static readonly MagpieContext magpieContext = new MagpieContext(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MagpieDB.db3"));
    }

}
