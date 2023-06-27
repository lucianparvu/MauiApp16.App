namespace MauiApp16;

public partial class App : Application
{
    Dictionary<string, Type> Routes { get; set; } = new Dictionary<string, Type>();
    public App()
	{
		InitializeComponent();      
        Routes.Add(nameof(IncrementalLoadingPage), typeof(IncrementalLoadingPage));
        foreach (var item in Routes)
        {
            Routing.RegisterRoute(item.Key, item.Value);
        }
        MainPage = new AppShell();
	}
}
