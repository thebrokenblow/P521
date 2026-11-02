using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Input;

namespace Lesson1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var expression = "123 + 112 * 5 / 3 / 2";

        var expressionElements1 = expression.Split(' ', StringSplitOptions.TrimEntries).ToList();
        var expressionElements2 = expression.Split(['+', '-', '*', '/'], StringSplitOptions.TrimEntries).ToList();

        // Margin="10, 20, 30, 40"
        //• 10 — Слева(Left)
        //• 20 — Сверху(Top)
        //• 30 — Справа(Right)
        //• 40 — Снизу(Bottom)
    }


    //ax ^ 2 + bx + c = 0

    //private static void SetErrorTextField(TextBlock resultTextBox, string message)
    //{
    //    resultTextBox.Text = message;
    //    resultTextBox.Foreground = Brushes.Red;
    //}

    //private void Button_Click(object sender, RoutedEventArgs e)
    //{
    //    var aIsNumber = double.TryParse(aTextBox.Text, out double a);
    //    var bIsNumber = double.TryParse(bTextBox.Text, out double b);
    //    var cIsNumber = double.TryParse(cTextBox.Text, out double c);

    //    if (!aIsNumber)
    //    {
    //        SetErrorTextField(resultTextBlock, $"{aTextBox.Text} Не число");
    //        return;
    //    }

    //    if (!bIsNumber)
    //    {
    //        SetErrorTextField(resultTextBlock, $"{bTextBox.Text} Не число");
    //        return;
    //    }

    //    if (!cIsNumber)
    //    {
    //        SetErrorTextField(resultTextBlock, $"{cTextBox.Text} Не число");
    //        return;
    //    }

    //    if (a == 0)
    //    {
    //        if (b == 0)
    //        {
    //            if (c == 0)
    //            {
    //                resultTextBlock.Text = "Бесконечное число корней";
    //                return;
    //            }
    //            else
    //            {
    //                resultTextBlock.Text = "Нет решений";
    //                return;
    //            }
    //        }
    //        else
    //        {
    //            var x = -c / b;
    //            resultTextBlock.Text = $"x = {x}";
    //            return;
    //        }
    //    }

    //    var D = b * b - 4 * a * c;

    //    if (D > 0)
    //    {
    //        var x1 = (-b + Math.Sqrt(D)) / (2 * a);
    //        var x2 = (-b - Math.Sqrt(D)) / (2 * a);

    //        resultTextBlock.Text = $"x1 = {x1}, x2 = {x2}";
    //    }
    //    else if (D == 0)
    //    {
    //        var x = -b / (2 * a);
    //        resultTextBlock.Text = $"x = {x}";
    //    }
    //    else
    //    {
    //        resultTextBlock.Text = "нет корней x > R";
    //    }
    //}

    private void SumButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        //123 + 112 * 5 / 3 / 2
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {

    }

    private void Button_Click_2(object sender, RoutedEventArgs e)
    {

    }

    private void Button_Click_3(object sender, RoutedEventArgs e)
    {

    }

    private void Button_Click_4(object sender, RoutedEventArgs e)
    {

    }

    private void Button_Click_5(object sender, RoutedEventArgs e)
    {

    }

    private void Button_Click_6(object sender, RoutedEventArgs e)
    {

    }

    private void Button_Click_7(object sender, RoutedEventArgs e)
    {

    }

    private void Button_Click_8(object sender, RoutedEventArgs e)
    {

    }

    private void Button_Click_9(object sender, RoutedEventArgs e)
    {

    
    }
    private void Button_Click_10(object sender, RoutedEventArgs e)
    {

    }

    private void Button_Click_11(object sender, RoutedEventArgs e)
    {

    }

    private void Button_Click_12(object sender, RoutedEventArgs e)
    {

    }

    private void Button_Click_13(object sender, RoutedEventArgs e)
    {

    }

    private void Button_Click_14(object sender, RoutedEventArgs e)
    {

    }

    private void Button_Click_15(object sender, RoutedEventArgs e)
    {

    }
}