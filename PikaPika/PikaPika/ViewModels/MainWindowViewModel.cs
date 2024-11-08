using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PikaPika.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase? _currentViewModel;
        public ViewModelBase? CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                (_currentViewModel as IDisposable)?.Dispose();
                _currentViewModel = value;
                RaisePropertyChanged(nameof(CurrentViewModel));
            }
        }
    }
}
