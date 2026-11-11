using System.Windows;

namespace Lesson4;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private int coins = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Check_Answers(object sender, RoutedEventArgs e)
    {
        coins = 0;

        if (FirstQuestionCorrectAnswer.IsChecked.Value)
        {
            coins += 10;
        }

        int coinsForSecondtQuestion = 0;
        if (!SecondQuestionNotCorrectAnswer1.IsChecked.Value)
        {
            if (SecondQuestionCorrectAnswer1.IsChecked.Value)
            {
                coinsForSecondtQuestion += 10;
            }

            if (SecondQuestionCorrectAnswer2.IsChecked.Value)
            {
                coinsForSecondtQuestion += 10;
            }

            if (SecondQuestionCorrectAnswer3.IsChecked.Value)
            {
                coinsForSecondtQuestion += 10;
            }
        }

        coins += coinsForSecondtQuestion;

        Result.Text = $"Общее количество очков: {coins}";
    }
}