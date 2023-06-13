using MauiApp12.Models;
using MauiApp12.ViewsModels;
using Microsoft.Maui.Devices.Sensors;

namespace MauiApp12.Views;

public partial class DetailView : ContentPage
{
    private readonly DetailViewModel _vm;

    public DetailView(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		_vm = vm;
	}
   async private void btnMap_Clicked(object sender,EventArgs e)
    {

        
        var location = new Location(_vm.Animal.Long, _vm.Animal.Lat);
        var options = new MapLaunchOptions { Name = _vm.Animal.Naziv };

        try
        {
            
            await Map.Default.OpenAsync(location, options);
        }
        catch (Exception )
        {
            // No map application available to open
        }
    }
    private async void OnBorderTapped(object sender, EventArgs e)
    {
        // Navigation logic to navigate to the DashboardView
        // Assuming you're using Xamarin.Forms.NavigationPage
        await Shell.Current.GoToAsync("..");
    }

}