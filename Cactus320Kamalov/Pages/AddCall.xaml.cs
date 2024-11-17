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
    /// Логика взаимодействия для AddCall.xaml
    /// </summary>
    public partial class AddCall : Page
    {
        public AddCall()
        {
            InitializeComponent();

            CactusComboBox.ItemsSource = ConnectionClass.db.Cactus.ToList();
            ExhibitionComboBox.ItemsSource = ConnectionClass.db.Exhibition.ToList();
        }

        private void AddRelationButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверить, выбран ли элемент в CactusComboBox
            if (CactusComboBox.SelectedItem != null ||
                ExhibitionComboBox.SelectedItem != null)
            {
                var cactus = CactusComboBox.SelectedItem as Cactus;
                var exhibition = ExhibitionComboBox.SelectedItem as Exhibition;
                // Получить выбранные значения
                int cactusId = cactus.IdCactus;
                int exhibitionId = exhibition.IdExhibition;

                // Добавить связь
                var newRelation = new Cactus_Exhibition1
                {
                    IdCactus = cactusId,
                    IdExhibition = exhibitionId
                };

                ConnectionClass.db.Cactus_Exhibition1.Add(newRelation);
                ConnectionClass.db.SaveChanges();

                // Обновить комбобоксы
                CactusComboBox.ItemsSource = ConnectionClass.db.Cactus.ToList();
                ExhibitionComboBox.ItemsSource = ConnectionClass.db.Exhibition.ToList();

                NavigationService.Navigate(new CallKatalog());
            }
            else
            {
                // Вывести сообщение об ошибке, если элемент не выбран
                MessageBox.Show("Выберите кактус или выставку!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
    }
}
