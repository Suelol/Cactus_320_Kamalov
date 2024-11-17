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
    /// Логика взаимодействия для AddCactus.xaml
    /// </summary>
    public partial class AddCactus : Page
    {
        public AddCactus()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем значения полей
            string species = SpeciesTextBox.Text;
            string origin = OriginTextBox.Text;
            string age = AgeTextBox.Text;
            string cost = CostTextBox.Text;
            string careInstructions = CareInstructionsTextBox.Text;

            // Проверяем, не пустые ли поля
            if (string.IsNullOrEmpty(species) || string.IsNullOrEmpty(origin) || 
                string.IsNullOrEmpty(age) || string.IsNullOrEmpty(cost) || 
                string.IsNullOrEmpty(careInstructions))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка");
                return;
            }

            // Проверяем возраст и стоимость на корректность
            if (!int.TryParse(age, out int ageValue) || ageValue < 0)
            {
                MessageBox.Show("Возраст должен быть целым числом и не меньше 0", "Ошибка");
                return;
            }

            if (!decimal.TryParse(cost, out decimal costValue) || costValue < 0)
            {
                MessageBox.Show("Стоимость должна быть числом и не меньше 0", "Ошибка");
                return;
            }

            // Добавляем кактус в базу данных
            var cactus = new Cactus
            {
                Species = species,
                Origin = origin,
                Age = ageValue,
                Cost = costValue,
                CareInstructions = careInstructions
            };

            ConnectionClass.db.Cactus.Add(cactus);
            ConnectionClass.db.SaveChanges();

            MessageBox.Show("Кактус добавлен", "Успех");

            NavigationService.Navigate(new CactusKatalog());
        }
    }
}
