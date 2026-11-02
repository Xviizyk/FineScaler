using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;

namespace FineScaler.Desktop.Screen;

public class MainScreen : Window
{
    public MainScreen()
    {
        Title = ScreenProperties.DefaultTitle;
        Width = ScreenProperties.DefaultWidth;
        Height = ScreenProperties.DefaultHeight;
        CanResize = true;
        CanMaximize = true;
        Icon = ScreenProperties.DefaultIcon;

        Panel mainPanel = new()
        {
            Background = new SolidColorBrush(ScreenProperties.DefaultDarkBackground),
        };
        
        Content = mainPanel;
    }
}