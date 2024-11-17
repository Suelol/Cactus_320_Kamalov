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
    /// Логика взаимодействия для AddExhibition.xaml
    /// </summary>
    public partial class AddExhibition : Page
    {
        public AddExhibition()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
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

            // Добавляем выставку в базу данных
            var exhibition = new Exhibition
            {
                Date = date,
                Location = location,
                Awards = awards,
                Comments = comments
            };

            ConnectionClass.db.Exhibition.Add(exhibition);
            ConnectionClass.db.SaveChanges();

            MessageBox.Show("Выставка добавлена", "Успех");
            NavigationService.Navigate(new ExhibitionPage());
        }
    }
}
