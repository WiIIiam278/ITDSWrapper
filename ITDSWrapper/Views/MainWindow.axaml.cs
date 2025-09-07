using Avalonia.Controls;
using Avalonia.Input;
using ITDSWrapper.ViewModels;

namespace ITDSWrapper.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    protected override void OnClosing(WindowClosingEventArgs e)
    {
        ((MainViewModel)View.DataContext!).Closing = true;
        base.OnClosing(e);
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e);
        ((MainViewModel)View.DataContext!).HandleKey(e.PhysicalKey, true);
    }

    protected override void OnKeyUp(KeyEventArgs e)
    {
        base.OnKeyUp(e);
        ((MainViewModel)View.DataContext!).HandleKey(e.PhysicalKey, false);
    }
}