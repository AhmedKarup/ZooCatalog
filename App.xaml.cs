using MauiApp12.Views;

namespace MauiApp12;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
