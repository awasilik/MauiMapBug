﻿namespace MapBugApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void GoToMapView(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new MapPage());
    }
}