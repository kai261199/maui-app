using translator_app.Helper;

namespace translator_app
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureMopups()
                .UseUraniumUI()
                .UseUraniumUIMaterial()
                .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFontAwesomeIconFonts();
            });

            builder.Services.AddMopupsDialogs();
            builder.RegisterServices();
            builder.RegisterViewModels();
            builder.RegisterViews();

            var app = builder.Build();

            ServiceHelper.Initialize(app.Services);

            return app;
        }
    }
}