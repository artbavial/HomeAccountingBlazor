using Microsoft.Maui.Controls;

namespace HomeAccountingBlazor.Pages
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		private async void SkipLogin(object sender, EventArgs e)
		{
			// �������� ������� AppShell
			AppShell appShell = (AppShell)Application.Current.MainPage;

			// ��������� � ��������� ����������
			await appShell.Navigation.PushAsync(new MainPage());
		}
	}
}