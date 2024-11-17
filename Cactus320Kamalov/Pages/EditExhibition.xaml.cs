using Cactus320Kamalov.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cactus320Kamalov.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditExhibition.xaml
    /// </summary>
    public partial class EditExhibition : Page
    {
        public EditExhibition()
        {
            InitializeComponent();
        }

        public EditExhibition(DateTime date, string location, string awards, string comment)
        {
            InitializeComponent();
            DateDatePicker.SelectedDate = date;
            LocationTextBox.Text = location;
            AwardsTextBox.Text = awards;
            CommentsTextBox.Text = comment;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем значения полей
            DateTime date = DateDatePicker.SelectedDate.Value;
            string location = LocationTextBox.Text;
            string awards = AwardsTextBox.Text;
            string comments = CommentsTextBox.Text;

            // Проверяем, не пустые ли поля
            if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(awards) || string.IsNullOrEmpty(comments))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка");
                return;
            }

            Exhibition exhibition = new Exhibition()
            {
                Location = location,
                Awards = awards,
                Comments = comments,
                Date = date
            };

            ConnectionClass.db.Exhibition.Add(exhibition);
            ConnectionClass.db.SaveChanges();

            MessageBox.Show("Выставка обновлена", "Успех");

            NavigationService.Navigate(new ExhibitionPage());
        }
    }
}
