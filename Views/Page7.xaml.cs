using MauiShell.ViewModels;

namespace MauiShell.Views;

public partial class Page7 : ContentPage
{
    public ContentPageUtil<Page7Vm> PageUtil { get; set; }

    public Page7(Page7Vm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Page7Vm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}