using System.Linq.Expressions;
using System.Windows;

namespace Lesson4;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private int coins = 0;

    private List<int> myList = new List<int> { 1, 2, 3, 4, 5 };

    public MainWindow()
    {
        InitializeComponent();

        var list1 = GetNumbers(IsEvenNumber);
        var list2 = GetNumbers(IsNotEvenNumber);
    }

    private List<int> GetNumbers(Func<int, bool> condition)
    {
        var result = new List<int>();

        for (int i = 0; i < myList.Count; i++)
        {
            if (condition.Invoke(myList[i]))
            {
                result.Add(myList[i]);
            }
        }

        return result;
    }

    private bool IsEvenNumber(int number)
    {
        return (number % 2 == 0);
    }

    private bool IsNotEvenNumber(int number)
    {
        return (number % 2 == 1);
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