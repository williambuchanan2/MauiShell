using MauiShell.ViewModels;

namespace MauiShell.Views;

public partial class Page6 : ContentPage
{
    public ContentPageUtil<Page6Vm> PageUtil { get; set; }

    public Page6(Page6Vm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Page6Vm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}