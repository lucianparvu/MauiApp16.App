using MauiApp16.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiApp16.ViewModels
{
    public class HomeViewModel 
    {
        public ICommand NavigateToDetailCommand => new Command(async () =>
        {
            await Shell.Current.GoToAsync($"IncrementalLoadingPage",false);
        });

        public HomeViewModel()
        {
             
        }       
    }
}
