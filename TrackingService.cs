public class TrackingService
{
    HubConnection _hub;

    public async Task StartAsync()
    {
        _hub = new HubConnectionBuilder()
            .WithUrl("https://api.truckerback.com/trackingHub")
            .Build();

        await _hub.StartAsync();
    }

    public async Task SendLocation(string truckId, Location loc)
    {
        await _hub.InvokeAsync("UpdateLocation",
            truckId, loc.Latitude, loc.Longitude);
    }
}
