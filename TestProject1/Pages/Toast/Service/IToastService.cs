namespace TestProject1.Pages.Toast.Service
{
    public interface IToastService
    {
        event Action<ToastLevel, string, string> OnShow;
        void ShowError(string message, string heading = "");
        void ShowInfo(string message, string heading = "");
        void ShowSuccess(string message, string heading = "");
        void ShowToast(ToastLevel level, string message, string heading = "");
        void ShowWarning(string message, string heading = "");
    }
}