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
    /// Логика взаимодействия для CactusKatalog.xaml
    /// </summary>
    public partial class CactusKatalog : Page
    {
        public CactusKatalog()
        {
            InitializeComponent();
            LoadCacti();
        }

        private void LoadCacti()
        {
            var cacti = ConnectionClass.db.Cactus.ToList();
            dataGridCacti.ItemsSource = cacti;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddCactus());
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранный кактус из DataGrid
            var selectedCactus = dataGridCacti.SelectedItem as Cactus;

            // Проверяем, выбран ли кактус
            if (selectedCactus == null)
            {
                MessageBox.Show("Пожалуйста, выберите кактус", "Ошибка");
                return;
            }

            NavigationService.Navigate(new EditCactus(
                selectedCactus.Species, selectedCactus.Origin, 
                selectedCactus.Age.ToString(), selectedCactus.Cost.ToString(), 
                selectedCactus.CareInstructions)
                );
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridCacti.SelectedItem != null)
            {
                Cactus selectedCactus = (Cactus)dataGridCacti.SelectedItem;

                if (ConnectionClass.db.Cactus_Exhibition1.Any(ce => ce.IdCactus == selectedCactus.IdCactus))
                {
                    MessageBox.Show("Этот кактус уже участвует в выставке и не может быть удален.");
                    return;
                }

                ConnectionClass.db.Cactus.Remove(selectedCactus);
                dataGridCacti.ItemsSource = null;
                dataGridCacti.ItemsSource = ConnectionClass.db.Cactus.ToList();

                ConnectionClass.db.SaveChanges();

                LoadCacti();
            }
        }
    }
}
