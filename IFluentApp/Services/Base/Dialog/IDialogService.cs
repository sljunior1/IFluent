namespace IFluentApp.Services.Base.Dialog
{
    public interface IDialogService
    {
        Task DisplayAlertAsync(string title, string message, string buttonlabel);
        Task<bool> DisplayAlertAsync(string title, string message, string acceptbutton, string cancelbutton);
    }
}
