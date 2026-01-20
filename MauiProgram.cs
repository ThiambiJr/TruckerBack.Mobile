builder
    .UseMauiApp<App>()
    .UseMauiMaps();

builder.Services.AddSingleton<AuthService>();
builder.Services.AddSingleton<ApiService>();
builder.Services.AddSingleton<TrackingService>();
