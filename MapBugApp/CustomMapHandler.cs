using Microsoft.Maui.Maps.Handlers;

namespace MapBugApp;

public class CustomMapHandler : MapHandler
{
    public CustomMapHandler()
    {
        
    }
    
    #if IOS
    protected override void DisconnectHandler(Microsoft.Maui.Maps.Platform.MauiMKMapView platformView)
    {
        base.DisconnectHandler(platformView);
    }
#endif
}