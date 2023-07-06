using MauiShell.ViewModels;

namespace MauiShell.Views;

public partial class Page9 : ContentPage
{
    public ContentPageUtil<Page9Vm> PageUtil { get; set; }

    public Page9(Page9Vm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Page9Vm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}