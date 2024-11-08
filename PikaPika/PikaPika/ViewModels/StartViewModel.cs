using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PikaPika.ViewModels
{
    public class StartViewModel : ViewModelBase
    {
        public RelayCommand WaitMatchingCommand { get; }
        public RelayCommand EndGameCommand { get; }

        public StartViewModel(Action navigateToWaitMatching)
        {
            WaitMatchingCommand = new RelayCommand(() => { navigateToWaitMatching?.Invoke(); });
            EndGameCommand = new RelayCommand(() => { Application.Current.Shutdown(); });
        }
    }
}
