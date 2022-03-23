namespace TestProject1.Pages.Toast.config
{
    public interface IToastInstance
    {
        public Guid guid { get; set; }
        public DateTime TimeStamps { get; set; }
        public ToastSetting ToastSetting { get; set; }
    }
}
