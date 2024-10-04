namespace HomeAccountingBlazor
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();
			BindingContext = this;

			Routing.RegisterRoute(nameof(ContactsPage), typeof(ContactsPage));
			Routing.RegisterRoute(nameof(AccountsPage), typeof(AccountsPage));
			Routing.RegisterRoute(nameof(CurrenciesPage), typeof(CurrenciesPage));
			Routing.RegisterRoute(nameof(SearchPage), typeof(SearchPage));
			Routing.RegisterRoute(nameof(CalculatorPage), typeof(CalculatorPage)); // Добавьте этот маршрут
		}

		public Command<string> NavigateCommand => new Command<string>(async (page) =>
		{
			switch (page)
			{
				case "ContactsPage":
					await Shell.Current.GoToAsync(nameof(ContactsPage));
					break;
				case "AccountsPage":
					await Shell.Current.GoToAsync(nameof(AccountsPage));
					break;
				case "CurrenciesPage":
					await Shell.Current.GoToAsync(nameof(CurrenciesPage));
					break;
				case "SearchPage":
					await Shell.Current.GoToAsync(nameof(SearchPage));
					break;
				case "CalculatorPage":
					await Shell.Current.GoToAsync(nameof(CalculatorPage));
					break;
			}
		});
	}
}
