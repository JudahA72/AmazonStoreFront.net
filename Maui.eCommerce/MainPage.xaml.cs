using System.Diagnostics.Metrics;
using Maui.eCommerce.ViewModels;

namespace Maui.eCommerce;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
	
	
	private void InventoryClicked(object sender, EventArgs e)
	{
		count++;
		Shell.Current.GoToAsync("//InventoryManagement");
	}


}

