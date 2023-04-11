using GeradorChave.Views;

namespace GeradorChave;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(GeradorView), typeof(GeradorView));
    }
}
