using System.IO;
using System.Text;
using System.Text.Json;
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
                var personalDataObj = JsonSerializer.Deserialize<PersonalData>(personData);

                FirstName.Text = personalDataObj.FirstName;
                LastName.Text = personalDataObj.LastName;
                MiddleName.Text = personalDataObj.MiddleName;
            }
        }

        private void Button_Save_Data(object sender, RoutedEventArgs e)
        {
            if (GenderMale.IsChecked.Value == false && GenderFemale.IsChecked.Value == false)
            {
                MessageBox.Show("Необходимо выбрать пол");
            }

            if (NationalityRus.IsChecked.Value == false && NationalityNotRus.IsChecked.Value == false)
            {
                MessageBox.Show("Необходимо выбрать тип гражданства");
            }

            if (IsAgreementForPersonalData.IsChecked.HasValue && IsAgreementForPersonalData.IsChecked.Value)
            {
                var personalData = new PersonalData
                {
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    MiddleName = MiddleName.Text,
                    IsSubscribeOnNotification = IsSubscribeOnNotification.IsChecked ?? IsSubscribeOnNotification.IsChecked!.Value
                };

                string jsonString = JsonSerializer.Serialize(personalData);

                File.AppendAllText("C:\\Users\\artem\\Documents\\data.txt", jsonString, Encoding.UTF8);
            }
            else
            {
                MessageBox.Show("Вы должны согласиться на обработку персональных данных");
            }
        }
    }
}