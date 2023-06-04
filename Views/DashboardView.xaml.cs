using MauiApp12.Models;
using MauiApp12.ViewsModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiApp12.Views;

public partial class DashboardView : ContentPage
{
    private readonly DashboardViewModel _viewModel;

    public DashboardView(DashboardViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = viewModel;


    }

    private async void AnimalClicked(object sender, TappedEventArgs e)
    {
        Animal animal = _viewModel.Animal;
        if (animal != null)
        {
            await Shell.Current.GoToAsync(nameof(DetailView), true, new Dictionary<string, object>
            {
                {"Animal", animal }
            });
        }
    }

    private void CategoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

        Category category = _viewModel.SelectedCategory;
        if (category != null)
        {
            _viewModel.ChangeCategorie();
        }
    }
}