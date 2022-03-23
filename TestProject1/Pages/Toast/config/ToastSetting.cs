namespace TestProject1.Pages.Toast.config
{
    public class ToastSetting
    {
        public ToastSetting(string heading,string message,string baseClass, string addtionalClass, string iconClass)
        {
            Heading = heading;
            Message = message;
            BaseClass = baseClass;
            AddtionalClass = addtionalClass;
            IconClass = iconClass;
        }
        public string Heading { get; set; }
        public string Message { get; set; }
        public string BaseClass { get; set; }
        public string AddtionalClass { get; set; }
        public string IconClass { get; set; }
    }
}
