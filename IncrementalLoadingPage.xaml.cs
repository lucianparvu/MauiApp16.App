using MauiApp16.ViewModels;

namespace MauiApp16
{
    public partial class IncrementalLoadingPage : ContentPage
    {
        public IncrementalLoadingPage(AnimalsViewModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
        void OnCollectionViewRemainingItemsThresholdReached(object sender, EventArgs e)
        {
            // Retrieve more data here, or via the RemainingItemsThresholdReachedCommand.
            // This sample retrieves more data using the RemainingItemsThresholdReachedCommand.
        }
    }
}
