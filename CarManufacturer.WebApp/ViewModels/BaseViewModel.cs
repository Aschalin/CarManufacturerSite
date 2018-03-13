namespace CarManufacturer.WebApp.ViewModels
{
    public class BaseViewModel
    {
        private string _title;
        protected virtual string Title { get { return _title; } set { _title = value; } }
    }
}