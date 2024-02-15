namespace MapBugApp;

public partial class MapPage : ContentPage
{
    public MapPage()
    {
        InitializeComponent();
    }

    private void GoBack(object? sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}