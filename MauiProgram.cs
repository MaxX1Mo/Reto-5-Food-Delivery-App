using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace Reto_5_Food_Delivery_App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Roboto-Regular.ttf", "RobotoR");
                    fonts.AddFont("Roboto-Light.ttf", "RobotoL");
                    fonts.AddFont("Roboto-Bold.ttf", "RobotoB");
                    fonts.AddFont("fontello.ttf", "Icons");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
