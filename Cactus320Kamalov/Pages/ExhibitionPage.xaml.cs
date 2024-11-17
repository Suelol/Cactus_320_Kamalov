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
    /// Логика взаимодействия для ExhibitionPage.xaml
    /// </summary>
    public partial class ExhibitionPage : Page
    {
        public ExhibitionPage()
        {
            InitializeComponent();
            LoadExhibition();
        }
        private void LoadExhibition()
        {
            var Exhibition = ConnectionClass.db.Exhibition.ToList();
            dataGridExhibition.ItemsSource = Exhibition;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddExhibition());
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранный кактус из DataGrid
            var selectedEx = dataGridExhibition.SelectedItem as Exhibition;

            // Проверяем, выбран ли кактус
            if (selectedEx == null)
            {
                MessageBox.Show("Пожалуйста, выберите выставку", "Ошибка");
                return;
            }

            NavigationService.Navigate(new EditExhibition(
                selectedEx.Date, selectedEx.Location,
                selectedEx.Awards, selectedEx.Comments)
                );
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridExhibition.SelectedItem != null)
            {
                Exhibition selectedExhibition = (Exhibition)dataGridExhibition.SelectedItem;

                if (ConnectionClass.db.Cactus_Exhibition1.Any(ce => ce.IdExhibition == selectedExhibition.IdExhibition))
                {
                    MessageBox.Show("У этой выставки имеются прикрепленный кактус и не может быть удален.");
                    return;
                }

                ConnectionClass.db.Exhibition.Remove(selectedExhibition);
                dataGridExhibition.ItemsSource = null;
                dataGridExhibition.ItemsSource = ConnectionClass.db.Exhibition.ToList();

                ConnectionClass.db.SaveChanges();

                LoadExhibition();
            }
        }
    }
}
