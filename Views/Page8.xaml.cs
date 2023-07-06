using MauiShell.ViewModels;

namespace MauiShell.Views;

public partial class Page8 : ContentPage
{
    public ContentPageUtil<Page8Vm> PageUtil { get; set; }

    public Page8(Page8Vm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Page8Vm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}