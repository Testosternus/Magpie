namespace Magpie;
using FreshMvvm.Maui;
using Magpie.Pages;
using Magpie.Services.Data;
using Magpie.ViewModels;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var tabbedPage = new FreshTabbedNavigationContainer();
		tabbedPage.AddTab<MainPageModel>("Home", null);
		tabbedPage.AddTab<ConcertPageModel>("Concert", null);

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
