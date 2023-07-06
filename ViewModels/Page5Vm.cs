using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiShell.Views;

namespace MauiShell.ViewModels
{
    public partial class Page5Vm: BaseViewModel
    {
        [RelayCommand]
        private void NextButtonPressed()
        {
            NavigationUtil.Navigate<Page6>();
        }

    }
}
