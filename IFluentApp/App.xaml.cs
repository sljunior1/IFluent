using IFluentApp.ViewModels.Login.v1;
using IFluentApp.Views.Login.v1;
using IFluentApp.Views.Splash.v1;

namespace IFluentApp
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            Application.Current.UserAppTheme = AppTheme.Light;

            MainPage = new SplashStartView(serviceProvider);
        }
        public static async void ScreenLogin(IServiceProvider serviceProvider)
        {
            var mainPage = serviceProvider.GetRequiredService<LoginView>();
            var viewModel = serviceProvider.GetRequiredService<LoginViewModel>();

            mainPage.BindingContext = viewModel;

            Current.MainPage = mainPage;
        }
        public static async void ScreenNotRegistered(IServiceProvider serviceProvider)
        {
            //var mainPage = serviceProvider.GetRequiredService<NotRegisteredView>();
            //var viewModel = serviceProvider.GetRequiredService<NotRegisteredViewModel>();

            //await Current.MainPage.Navigation.PushAsync(new NavigationPage(mainPage)
            //{
            //    BarBackgroundColor = Colors.DodgerBlue,
            //    BarTextColor = Colors.White
            //});
        }
        public static async void ScreenForgotPassword(IServiceProvider serviceProvider)
        {
            //var mainPage = serviceProvider.GetRequiredService<ForgotPasswordView>();
            //var viewModel = serviceProvider.GetRequiredService<ForgotPasswordViewModel>();

            //await Current.MainPage.Navigation.PushAsync(new NavigationPage(mainPage)
            //{
            //    BarBackgroundColor = Colors.DodgerBlue,
            //    BarTextColor = Colors.White
            //});
        }
        public static void ScreenMain()
        {
            Current.MainPage = new AppShell();
        }
    }
}
