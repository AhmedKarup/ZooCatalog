using MauiApp12.Models;
using MauiApp12.ViewsModels;

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

}