using MauiShell.ViewModels;

namespace MauiShell.Views;

public partial class Page3 : ContentPage
{
    public ContentPageUtil<Page3Vm> PageUtil { get; set; }

    public Page3(Page3Vm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Page3Vm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}