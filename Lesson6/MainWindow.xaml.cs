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
    private ObservableCollection<Product> products;
    private Product? updatingProduct;

    public MainWindow()
    {
        InitializeComponent();

        var categories = new List<string>
        {
            "Телефон",
            "Ноутбук",
            "Телевизоры"
        };

        ComboBoxCategories.ItemsSource = categories;
        ComboBoxCategoriesAdd.ItemsSource = categories;
        ComboBoxCategoriesUpdate.ItemsSource = categories;

        products = [];

        var product1 = new Product
        {
            Name = "IPhone",
            Description = "Телефон Apple",
            Price = 100_000,
            Category = categories[0],
        };

        var product2 = new Product
        {
            Name = "Xiaomi",
            Description = "Китайский телефон",
            Price = 10_000,
            Category = categories[0],
        };

        var product3 = new Product
        {
            Name = "Huawei",
            Description = "Китайский телефон",
            Price = 100_000,
            Category = categories[0],
        };

        var product4 = new Product
        {
            Name = "MacBook",
            Description = "Ноут от Apple",
            Price = 100_000,
            Category = categories[1],
        };

        var product5 = new Product
        {
            Name = "Samsung Телевизор",
            Description = "Очень большой телевизор",
            Price = 100_000,
            Category = categories[2],
        };

        products.Add(product1);
        products.Add(product2);
        products.Add(product3);
        products.Add(product4);
        products.Add(product5);

        ListBoxProducts.ItemsSource = products;
    }

    private void ComboBoxCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is ComboBox comboBox)
        {
            var searchString = TextBoxSerchString.Text;
            var category = (string)comboBox.SelectedItem ?? string.Empty;

            var result = FilteringProducts(searchString, category);

            ListBoxProducts.ItemsSource = result;
        }
    }

    private List<Product> FilteringProducts(string searchString, string category)
    {
        var result = from product in products
                     where product.Name.Contains(searchString, StringComparison.CurrentCultureIgnoreCase) ||
                         product.Description.Contains(searchString, StringComparison.CurrentCultureIgnoreCase)
                     select product;

        if (!string.IsNullOrEmpty(category))
        {
            result = result.Where(products => products.Category == category);
        }

        return [.. result];
    }

    private void TextBoxSerchString_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (sender is TextBox textBoxSearchString)
        {
            var searchString = textBoxSearchString.Text;
            var category = (string)ComboBoxCategories.SelectedItem ?? string.Empty;

            var result = FilteringProducts(searchString, category);

            ListBoxProducts.ItemsSource = result;
        }
    }

    private void ButtonAddProduct_Click(object sender, RoutedEventArgs e)
    {
        var nameProduct = TextBoxNameProduct.Text;
        var descriptionProduct = TextBoxDescriptionProduct.Text;
        var priceProduct = TextBoxPriceProduct.Text;
        var category = (string)ComboBoxCategoriesAdd.SelectedItem;

        var product = new Product
        {
            Name = nameProduct,
            Description = descriptionProduct,
            Price = decimal.Parse(priceProduct),
            Category = category,
        };

        products.Add(product);

        TextBoxNameProduct.Text = string.Empty;
        TextBoxDescriptionProduct.Text = string.Empty;
        TextBoxPriceProduct.Text = string.Empty;
        ComboBoxCategoriesAdd.SelectedItem = null;

        ClearFiledsData(TextBoxNameProduct,
                TextBoxDescriptionProduct,
                TextBoxPriceProduct,
                ComboBoxCategoriesAdd);
    }

    private void ListBoxProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is ListBox listBoxProducts)
        {
            if (listBoxProducts.SelectedItem is Product product)
            {
                UpdatingForm.Visibility = Visibility.Visible;

                TextBoxUpdateNameProduct.Text = product.Name;
                TextBoxUpdateDescriptionProduct.Text = product.Description;
                TextBoxUpdatePriceProduct.Text = product.Price.ToString();
                TextBoxUpdatePriceProduct.Text = product.Price.ToString();

                ComboBoxCategoriesUpdate.SelectedItem = product.Category;

                updatingProduct = product;
            }
        }
    }

    private void ButtonUpdateProduct_Click(object sender, RoutedEventArgs e)
    {
        updatingProduct.Name = TextBoxUpdateNameProduct.Text;
        updatingProduct.Description = TextBoxUpdateDescriptionProduct.Text;
        updatingProduct.Price = decimal.Parse(TextBoxUpdatePriceProduct.Text);
        updatingProduct.Category = (string)ComboBoxCategoriesUpdate.SelectedItem;

        ListBoxProducts.ItemsSource = null; 
        ListBoxProducts.ItemsSource = products;

        ClearFiledsData(TextBoxUpdateNameProduct, 
                        TextBoxUpdateDescriptionProduct, 
                        TextBoxUpdatePriceProduct, 
                        ComboBoxCategoriesUpdate);

        UpdatingForm.Visibility = Visibility.Hidden;
    }

    private static void ClearFiledsData(TextBox textBoxName, TextBox textBoxDescription, TextBox textBoxPrice, ComboBox comboBoxCategories)
    {
        textBoxName.Text = string.Empty;
        textBoxDescription.Text = string.Empty;
        textBoxPrice.Text = string.Empty;
        comboBoxCategories.SelectedItem = null;
    }

    private void ButtonHiddenUpdateProduct_Click(object sender, RoutedEventArgs e)
    {
        TextBoxUpdateNameProduct.Text = string.Empty;
        TextBoxUpdateDescriptionProduct.Text = string.Empty;
        TextBoxUpdatePriceProduct.Text = string.Empty;

        ComboBoxCategoriesUpdate.SelectedItem = null;

        UpdatingForm.Visibility = Visibility.Hidden;

        updatingProduct = null;
    }

    private void ButtonDelete_Click(object sender, RoutedEventArgs e)
    {
        if (sender is Button button)
        {
            if (button.CommandParameter is Product product)
            {
                products.Remove(product);
            }
        }
    }
}