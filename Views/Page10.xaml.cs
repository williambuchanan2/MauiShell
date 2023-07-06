using MauiShell.ViewModels;

namespace MauiShell.Views;

public partial class Page10 : ContentPage
{
    public ContentPageUtil<Page10Vm> PageUtil { get; set; }

    public Page10(Page10Vm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Page10Vm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}