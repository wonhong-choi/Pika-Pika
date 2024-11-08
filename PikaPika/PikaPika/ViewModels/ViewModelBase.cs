using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PikaPika.ViewModels
{
    public class ViewModelBase : ObservableObject
    {
        protected void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
        }

        protected void RaisePropertyChanging([CallerMemberName] string? propertyName = null)
        {
            base.OnPropertyChanging(propertyName);
        }
    }
}
