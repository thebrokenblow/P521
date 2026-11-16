using Lesson6.Model;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Lesson6;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private List<Product> products;

    public MainWindow()
    {
        InitializeComponent();

        products = [];

        var product1 = new Product
        {
            Name = "IPhone",
            Description = "Телефон Apple",
            Price = 100_000,
        };

        var product2 = new Product
        {
            Name = "Xiaomi",
            Description = "Китайский телефон",
            Price = 10_000,
        };

        var product3 = new Product
        {
            Name = "Huawei",
            Description = "Китайский телефон",
            Price = 100_000,
        };

        products.Add(product1);
        products.Add(product2);
        products.Add(product3);

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
        var searchString = TextBoxSerchString.Text;

        var result = from product in products
                     where product.Name.Contains(searchString, StringComparison.CurrentCultureIgnoreCase) ||
                         product.Description.Contains(searchString, StringComparison.CurrentCultureIgnoreCase)

                     select product;

        ListBoxProducts.ItemsSource = result;
    }
}