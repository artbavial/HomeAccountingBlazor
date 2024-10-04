using HomeAccountingBlazor.Pages;
using Microsoft.Maui.Controls;

namespace HomeAccountingBlazor
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new LoginPage());
		}
	}
}