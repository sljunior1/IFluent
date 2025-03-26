using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using TabbedPage = Microsoft.Maui.Controls.TabbedPage;

namespace IFluentApp.Behaviors
{
    public class HideTabbedBarBehavior : Behavior<TabbedPage>
    {
        protected override void OnAttachedTo(TabbedPage bindable)
        {
            base.OnAttachedTo(bindable);

            // Esconder a TabBar no Android
            bindable.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>()
                .SetIsSwipePagingEnabled(false)
                .SetToolbarPlacement(ToolbarPlacement.Bottom);

            // Esconder a TabBar no iOS
            bindable.On<Microsoft.Maui.Controls.PlatformConfiguration.iOS>().SetPrefersStatusBarHidden(StatusBarHiddenMode.True);
        }
    }
}
