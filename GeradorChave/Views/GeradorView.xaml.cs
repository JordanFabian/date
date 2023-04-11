using GeradorChave.ViewModels;

namespace GeradorChave.Views;

public partial class GeradorView : ContentPage
{
	public GeradorView(GeradorViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}