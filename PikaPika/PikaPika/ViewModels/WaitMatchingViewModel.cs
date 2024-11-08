using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PikaPika.ViewModels
{
    public class WaitMatchingViewModel : ViewModelBase
    {
        public RelayCommand CancelCommand { get; }

        public WaitMatchingViewModel(Action navigateToStart)
        {
            CancelCommand = new RelayCommand(() => { navigateToStart?.Invoke(); });
        }
    }
}
