using Microsoft.Maui.Maps;

namespace MapBugApp;

public partial class MapPage : ContentPage
{
    public MapPage()
    {
        InitializeComponent();

        MoveMap();
        

    }

    private async void MoveMap()
    {
        await Task.Delay(1000).ConfigureAwait(false);
        
        MainThread.BeginInvokeOnMainThread(() =>
        {
            var mapSpan = MapSpan.FromCenterAndRadius(new Location(5, 5), Distance.FromMeters(10000));

            Map.MoveToRegion(mapSpan);
        });
    }

    private void GoBack(object? sender, EventArgs e)
    {
        Map.Handler?.DisconnectHandler();
        Navigation.PopAsync();
    }
}