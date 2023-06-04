using MauiApp12.ViewsModels;

namespace MauiApp12.Views;

public partial class IntroScreenView : ContentPage
{

	private readonly IntroScreenViewModel _vm;
	public IntroScreenView(IntroScreenViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		_vm = vm;
	}

    private void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    {
		if(_vm.Position == 2)
		{
			_vm.ButtonText = "Get started";
		}
		else
		{
			_vm.ButtonText = "Next";
		}
    }
}