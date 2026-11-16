using Lesson6.Model;
using System.Windows;
using System.Windows.Controls;

namespace Lesson6;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var products = new List<Product>();
        var product = new Product
        {
            Name = "123",
            Description = "123",
            Price = 123,
        };

        products.Add(product);
        products.Add(product);
        products.Add(product);
        products.Add(product);
        products.Add(product);

        ListBoxProducts.ItemsSource = products;
    }

    private void countriesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is ComboBox comboBox)
        {
            var value = (string)comboBox.SelectedItem;
            //MessageBox.Show(value);
        }
    }

    private void Button_Search(object sender, RoutedEventArgs e)
    {

    }
}