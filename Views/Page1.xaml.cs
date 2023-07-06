using MauiShell.ViewModels;

namespace MauiShell.Views;

public partial class Page1 : ContentPage
{
    public ContentPageUtil<Page1Vm> PageUtil { get; set; }

    public Page1(Page1Vm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Page1Vm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}