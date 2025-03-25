using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.Input;
using IFluentApp.Services.Base.Navigation;
using IFluentApp.Validations.Login;
using IFluentApp.ViewModels.Base;

namespace IFluentApp.ViewModels.Login.v1
{
    public partial class LoginViewModel : ViewModelBase
    {
        #region Properties

        private string _userText;
        private string _passwordText;

        [EmailValidation]
        public string UserText
        {
            get { return _userText; }
            set { SetProperty(ref _userText, value); }
        }
        [Required(ErrorMessage = "Password is required")]
        public string PasswordText
        {
            get { return _passwordText; }
            set { SetProperty(ref _passwordText, value); }
        }
        #endregion

        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
        [RelayCommand]
        public async Task SignInAsync()
        {
            await IsBusyFor(async () =>
            {
                try
                {
                    var validationContext = new ValidationContext(this);
                    var validationResult = new List<ValidationResult>();

                    if (!Validator.TryValidateObject(this, validationContext, validationResult, true))
                    {
                        var errorMessage = validationResult.FirstOrDefault()?.ErrorMessage;

                        App.Current?.MainPage?.DisplayAlert(SystemMessage.REMINDER_MANAGER, errorMessage, "ok");
                    }
                    else
                    {
                        App.ScreenMain();
                    }
                }
                catch (Exception)
                {
                }
            });
        }
    }
}
