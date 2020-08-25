using Prism.Mvvm;

namespace SecondPrismApp.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private string displayName;
        public string DisplayName
        {
            get => displayName;
            set => SetProperty(ref displayName, value);
        }

        public MainViewModel()
        {
            DisplayName = "Prism App";
        }
    }
}
