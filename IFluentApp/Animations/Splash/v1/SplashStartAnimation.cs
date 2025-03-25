namespace IFluentApp.Animations.Splash.v1
{
    public class SplashStartAnimation
    {
        private readonly IServiceProvider _serviceProvider;
        public SplashStartAnimation(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public async Task AnimationPage(Image animatedImage,StackLayout animatedStackLayout1, StackLayout animatedStackLayout2, StackLayout animatedStackLayout3)
        {
            await Task.Delay(2000);

            await animatedImage.RelScaleTo(-0.45, 1000, Easing.CubicInOut);
            await animatedImage.TranslateTo(0, -350, 2000, Easing.CubicOut);

            animatedStackLayout1.IsVisible = true;
            animatedStackLayout1.FadeTo(1, 1000, Easing.CubicInOut);

            await Task.Delay(3000);
            await animatedStackLayout1.FadeTo(0, 1000, Easing.CubicInOut);

            animatedStackLayout2.IsVisible = true;
            await animatedStackLayout2.FadeTo(1, 1000, Easing.CubicInOut);
            await Task.Delay(3000);
            await animatedStackLayout2.FadeTo(0, 1000, Easing.CubicInOut);

            animatedStackLayout3.IsVisible = true;
            await animatedStackLayout3.FadeTo(1, 1000, Easing.CubicInOut);
            await Task.Delay(3000);
            await animatedStackLayout3.FadeTo(0, 1000, Easing.CubicInOut);

            animatedStackLayout1.IsVisible = false;
            animatedStackLayout2.IsVisible = false;

            await animatedImage.TranslateTo(0, 0, 1000, Easing.CubicOut);

            await Task.Delay(500);

            App.ScreenLogin(_serviceProvider);
        }
    }
}
