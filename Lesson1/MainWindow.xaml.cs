using Equation;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Lesson1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }


    //ax ^ 2 + bx + c = 0

    private static void SetErrorTextField(TextBlock resultTextBox, string message)
    {
        resultTextBox.Text = message;
        resultTextBox.Foreground = Brushes.Red;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        var aIsNumber = double.TryParse(aTextBox.Text, out double a);
        var bIsNumber = double.TryParse(bTextBox.Text, out double b);
        var cIsNumber = double.TryParse(cTextBox.Text, out double c);

        if (!aIsNumber)
        {
            SetErrorTextField(resultTextBlock, $"{aTextBox.Text} Не число");
            return;
        }

        if (!bIsNumber)
        {
            SetErrorTextField(resultTextBlock, $"{bTextBox.Text} Не число");
            return;
        }

        if (!cIsNumber)
        {
            SetErrorTextField(resultTextBlock, $"{cTextBox.Text} Не число");
            return;
        }

        //Мобильные / Настольные (only windows, для всего), web приложения, games

        resultTextBlock.Text = SquareEquation.Solve(a, b, c);
    }
}