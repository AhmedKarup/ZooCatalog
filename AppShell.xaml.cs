using MauiApp12.Views;

namespace MauiApp12;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(DetailView), typeof(DetailView));
        Routing.RegisterRoute(nameof(DashboardView), typeof(DashboardView));
    }
}
