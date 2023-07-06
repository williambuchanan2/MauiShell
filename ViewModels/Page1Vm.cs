using CommunityToolkit.Mvvm.Input;
using MauiShell.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiShell.ViewModels
{
    public partial class Page1Vm: BaseViewModel
    {

        [RelayCommand]
        private void NextButtonPressed()
        {
            NavigationUtil.Navigate<Page2>();
        }

       
    }
}
