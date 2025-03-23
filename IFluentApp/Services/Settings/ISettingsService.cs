namespace IFluentApp.Services.Settings
{
    public interface ISettingsService
    {
        string AuthAccessToken { get; set; }
        int IdUser { get; set; }
    }
}
