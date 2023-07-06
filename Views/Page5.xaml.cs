using MauiShell.ViewModels;

namespace MauiShell.Views;

public partial class Page5 : ContentPage
{
    public ContentPageUtil<Page5Vm> PageUtil { get; set; }

    public Page5(Page5Vm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Page5Vm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}