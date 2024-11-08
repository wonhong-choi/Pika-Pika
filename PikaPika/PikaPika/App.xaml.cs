using System.Configuration;
using System.Data;
using System.Windows;
using PikaPika.ViewModels;
using PikaPika.Views;

namespace PikaPika
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly MainWindowViewModel _mainWindowViewModel;

        public App()
        {
            _mainWindowViewModel = new MainWindowViewModel();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = _mainWindowViewModel,
            };
            NavigateToStartView();
            MainWindow.Show();

            base.OnStartup(e);
        }

        public void NavigateToStartView()
        {
            _mainWindowViewModel.CurrentViewModel = new StartViewModel(NavigateToWaitMatching);
        }

        public void NavigateToWaitMatching()
        {
            _mainWindowViewModel.CurrentViewModel = new WaitMatchingViewModel(NavigateToStartView);
        }
    }
}
