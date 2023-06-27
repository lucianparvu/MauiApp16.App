using MauiApp16.ViewModels;
using System.Windows.Input;

namespace MauiApp16;

public partial class HomePage : ContentPage
{	
    public HomePage(HomeViewModel model)
	{
		InitializeComponent();        
        BindingContext = model ;
    }	 
}

