namespace Magpie;
using FreshMvvm.Maui;
using Magpie.Pages;
using Magpie.Services.Data;
using Magpie.ViewModels;

public partial class App : Application
{
	public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Nzc4ODAzQDMyMzAyZTMzMmUzMGQ1VHgyL0lUalVXU2hIUklpSms2VUdEKy9paXBoYkRucDFoNDROR05zNXc9");

		InitializeComponent();

		//var masterDetail = new FreshMasterDetailNavigationContainer();
		//masterDetail.Title = "Home";
		//masterDetail.Init("Menu");
		//masterDetail.AddPage<ConcertPageModel>("Concerts", null);
		//masterDetail.AddPage<FoodPageModel>("Places to eat", null);

		var tabbedPage = new FreshTabbedNavigationContainer();
		tabbedPage.AddTab<ConcertPageModel>("Concerts", null);
		tabbedPage.AddTab<FoodPageModel>("Places to eat", null);

		MainPage = tabbedPage;
	}

    internal class MagpieSingleton
    {
        static MagpieSingleton()
        {

        }
        internal static readonly MagpieContext magpieContext = new MagpieContext(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MagpieDB.db3"));
    }

}
