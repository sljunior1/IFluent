namespace IFluentApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        private void Initialize(IServiceProvider serviceProvider, AppTheme currentTheme)
        {
            //var mainPage = serviceProvider.GetRequiredService<HomeNotLoggedView>();
            //var viewModel = serviceProvider.GetRequiredService<HomeNotLoggedViewModel>();

            //mainPage.BindingContext = viewModel;
            //MainPage = new NavigationPage(mainPage)
            //{
            //    BarBackgroundColor = currentTheme.Equals(AppTheme.Light) ? Colors.White : Colors.Black,
            //};
        }
        public static async void ScreenLogin(IServiceProvider serviceProvider)
        {
            //var mainPage = serviceProvider.GetRequiredService<LoginView>();
            //var viewModel = serviceProvider.GetRequiredService<LoginViewModel>();

            //await Current.MainPage.Navigation.PushAsync(new NavigationPage(mainPage)
            //{
            //    BarBackgroundColor = Colors.DodgerBlue,
            //    BarTextColor = Colors.White
            //});
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
