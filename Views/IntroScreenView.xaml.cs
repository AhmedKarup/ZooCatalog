using MauiApp12.ViewsModels;

namespace MauiApp12.Views;

public partial class IntroScreenView : ContentPage
{
	public IntroScreenView()
	{
		InitializeComponent();
		this.BindingContext = new IntroScreenViewModel();
	}
}