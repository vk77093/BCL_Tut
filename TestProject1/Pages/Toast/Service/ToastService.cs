﻿namespace TestProject1.Pages.Toast.Service
{
    public class ToastService : IToastService
    {
        public ToastService() { }

        event Action<ToastLevel, string, string> OnShow;
        public void ShowInfo(string message, string heading = "")
        {
            ShowToast(ToastLevel.Info, message, heading);
        }
        public void ShowSuccess(string message, string heading = "")
        {
            ShowToast(ToastLevel.Success, message, heading);
        }
        public void ShowWarning(string message, string heading = "")
        {
            ShowToast(ToastLevel.Warning, message, heading);
        }
        public void ShowError(string message, string heading = "")
        {
            ShowToast(ToastLevel.Error, message, heading);
        }
        public void ShowToast(ToastLevel level, string message, string heading = "")
        {
            OnShow?.Invoke(level, message, heading);
        }
    }
}
