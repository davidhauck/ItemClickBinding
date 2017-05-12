using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ItemClickBinding
{
    public class MainPageViewModel : BaseViewModel
    {
        private ObservableCollection<string> _mySource;
        public ObservableCollection<string> MySource
        {
            get
            {
                return _mySource;
            }
            set
            {
                _mySource = value;
                OnPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            MySource = new ObservableCollection<string>
            {
                "First Entry",
                "Second Entry",
                "Third Entry",
            };
        }

        private string _alertMessage;
        public string AlertMessage
        {
            get
            {
                return _alertMessage;
            }
            set
            {
                _alertMessage = value;
                OnPropertyChanged();
            }
        }

        public ICommand ItemClickCommand
        {
            get
            {
                return new Command((item) =>
                {
                    AlertMessage = item as string;
                });
            }
        }
    }
}
