using MauiShell.ViewModels;

namespace MauiShell.Views;

public partial class Page4 : ContentPage
{
    public ContentPageUtil<Page4Vm> PageUtil { get; set; }

    public Page4(Page4Vm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Page4Vm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}