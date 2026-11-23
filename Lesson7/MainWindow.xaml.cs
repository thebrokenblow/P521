using Lesson7.Model;
using System.Collections.ObjectModel;
using System.Windows;

namespace Lesson7;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var pets = new ObservableCollection<Pet>
        {
            new Pet
            {
                Name = "Барсик",
                Description = "Красивый кот",
                Age = 3
            },
            new Pet
            {
                Name = "Барсик",
                Description = "Красивый кот",
                Age = 3
            },
            new Pet
            {
                Name = "Барсик",
                Description = "Красивый кот",
                Age = 3
            },
            new Pet
            {
                Name = "Барсик",
                Description = "Красивый кот",
                Age = 3
            },
            new Pet
            {
                Name = "Барсик",
                Description = "Красивый кот",
                Age = 3
            }
        };

        DataGridPets.ItemsSource = pets;
    }
}