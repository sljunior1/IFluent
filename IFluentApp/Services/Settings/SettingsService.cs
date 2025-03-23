namespace IFluentApp.Services.Settings
{
    public class SettingsService : ISettingsService
    {
        private const string AccessToken = "access_token";
        private const string SessionIdUser = "id_user";
        private readonly string AccessTokenDefault = string.Empty;
        private readonly int IdUserDefault = 0;
        public string AuthAccessToken
        {
            get => Preferences.Get(AccessToken, AccessTokenDefault);
            set => Preferences.Set(AccessToken, value);
        }
        public int IdUser
        {
            get => Preferences.Get(SessionIdUser, IdUserDefault);
            set => Preferences.Set(SessionIdUser, value);
        }
    }
}
