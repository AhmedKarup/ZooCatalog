using MauiApp12.Models;
using MauiApp12.ViewsModels;
using System.Collections.ObjectModel;

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
}