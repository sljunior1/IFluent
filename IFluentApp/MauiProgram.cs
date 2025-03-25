using CommunityToolkit.Maui;
using IFluentApp.Services.Base.Dialog;
using IFluentApp.Services.Base.Navigation;
using IFluentApp.Services.Base.RequestProvider;
using IFluentApp.Services.Settings;
using IFluentApp.ViewModels.Login.v1;
using IFluentApp.Views.Login.v1;

namespace IFluentApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .RegisterAppServices()
                .RegisterViewModels()
                .RegisterViews()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            return builder.Build();
        }
        public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<INavigationService, NavigationService>();
            mauiAppBuilder.Services.AddSingleton<IDialogService, DialogService>();
            mauiAppBuilder.Services.AddSingleton<IRequestProviderService, RequestProviderService>();
            mauiAppBuilder.Services.AddSingleton<ISettingsService, SettingsService>();

            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            #region Login

            mauiAppBuilder.Services.AddTransient<LoginViewModel>();

            #endregion
         
            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            #region Login

            mauiAppBuilder.Services.AddTransient<LoginView>();

            #endregion

            return mauiAppBuilder;
        }
    }
}
