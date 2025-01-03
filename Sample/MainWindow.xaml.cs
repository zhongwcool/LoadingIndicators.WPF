using System.Windows;
using System.Windows.Input;
using LoadingIndicators.WPF;

namespace Sample;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }

    const double TOLERANCE = 0.01f;

    // Handlers
    private void LoadingIndicator_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        var li = (LoadingIndicator)sender;

        if (Math.Abs(li.SpeedRatio - 1.0) < TOLERANCE)
        {
            li.SpeedRatio = 0.3;
        }
        else
        {
            li.SpeedRatio = 1.0;
        }
    }
}