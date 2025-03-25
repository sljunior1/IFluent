using IFluentApp.Animations.Splash.v1;

namespace IFluentApp.Views.Splash.v1;

public partial class SplashStartView : ContentPage
{
    private readonly IServiceProvider _serviceProvider;
    public SplashStartView(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        InitializeComponent();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        var splashStartAnimation = new SplashStartAnimation(_serviceProvider);
        await splashStartAnimation.AnimationPage(animatedImage, animatedStackLayout1, animatedStackLayout2, animatedStackLayout3);
    }
}