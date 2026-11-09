using System.IO;
using System.Text;
using System.Windows;

namespace Lesson3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            IsSubscribeOnNotification.IsChecked = true;

            var personData = File.ReadAllText("C:\\Users\\artem\\Documents\\data.txt");

            if (personData.Length > 0)
            {
                var personDataElements = personData.Split(["FirstName:", "LastName:", "MiddleName:", "IsSubscribeOnNotification:", ","], StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList();

                if (personDataElements.Count == 4)
                {
                    var personalData = new PersonalData
                    {
                        FirstName = personDataElements[0],
                        LastName = personDataElements[1],
                        MiddleName = personDataElements[2],
                        IsSubscribeOnNotification = bool.Parse(personDataElements[3]),
                    };

                    FirstName.Text = personalData.FirstName;
                    LastName.Text = personalData.LastName;
                    MiddleName.Text = personalData.MiddleName;
                    IsSubscribeOnNotification.IsChecked = personalData.IsSubscribeOnNotification;
                }
            }
        }

        private void Button_Save_Data(object sender, RoutedEventArgs e)
        {
            if (IsAgreementForPersonalData.IsChecked.HasValue && IsAgreementForPersonalData.IsChecked.Value)
            {
                var personalData = new PersonalData
                {
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    MiddleName = MiddleName.Text,
                    IsSubscribeOnNotification = IsSubscribeOnNotification.IsChecked ?? IsSubscribeOnNotification.IsChecked!.Value
                };

                File.AppendAllText("C:\\Users\\artem\\Documents\\data.txt", personalData.ToString(), Encoding.UTF8);
            }
            else
            {
                MessageBox.Show("Вы должны согласиться на обработку персональных данных");
            }
        }
    }
}