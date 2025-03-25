using IFluentApp.ViewModels.Login.v1;

namespace IFluentApp.Views.Login.v1;

public partial class LoginView : ContentPageBase
{
    private bool _isPasswordVisible = false;
    private readonly LoginViewModel _viewModel;
    public LoginView(LoginViewModel viewModel)
	{
        BindingContext = _viewModel = viewModel;
        InitializeComponent();
	}
    private void imgVisiblePassword_Clicked(object sender, EventArgs e)
    {
        _isPasswordVisible = !_isPasswordVisible;
        entryPassword.IsPassword = !_isPasswordVisible;
        imgVisiblePassword.Source = _isPasswordVisible ? "icon_eye_open.svg" : "icon_eye_close.svg";
    }
}