using MauiShell.ViewModels;

namespace MauiShell.Views;

public partial class Page2 : ContentPage
{
    public ContentPageUtil<Page2Vm> PageUtil { get; set; }

    public Page2(Page2Vm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Page2Vm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}