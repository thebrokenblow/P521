using System.IO;
using System.Windows;

namespace Lesson5_1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Action actions;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ShowMessageBox()
    {
        int num = Random.Shared.Next(100);
        MessageBox.Show(num.ToString());
    }

    private void WriteText()
    {
        int num = Random.Shared.Next(100);
        File.AppendAllText("C:\\Users\\artem\\OneDrive\\Рабочий стол\\test.txt", num.ToString());
    }

    private void Button_Subscribe_ShowMessage(object sender, RoutedEventArgs e)
    {
        actions += ShowMessageBox;
    }

    private void Button_Subscribe_WriteText(object sender, RoutedEventArgs e)
    {
        actions += WriteText;
    }

    private void Button_Subscribe_Start(object sender, RoutedEventArgs e)
    {
        actions.Invoke();
    }
}