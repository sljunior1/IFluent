using IFluentApp.Views.Configuration.v1;
using IFluentApp.Views.Courses.v1;
using IFluentApp.Views.Home.v1;
using IFluentApp.Views.Progress.v1;
using IFluentApp.Views.Translate.v1;

namespace IFluentApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            InitializeRoutes();
        }
        private void InitializeRoutes()
        {
            Routing.RegisterRoute(nameof(HomeView), typeof(HomeView));
            Routing.RegisterRoute(nameof(CourseView), typeof(CourseView));
            Routing.RegisterRoute(nameof(ProgressView), typeof(ProgressView));
            Routing.RegisterRoute(nameof(TranslateView), typeof(TranslateView));
            Routing.RegisterRoute(nameof(ConfigurationView), typeof(ConfigurationView));
        }
    }
}
