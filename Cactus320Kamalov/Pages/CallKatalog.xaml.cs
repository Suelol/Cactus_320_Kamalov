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
    /// Логика взаимодействия для CallKatalog.xaml
    /// </summary>
    public partial class CallKatalog : Page
    {
        public CallKatalog()
        {
            InitializeComponent();
            LoadExhibitions();
        }

        private void LoadExhibitions()
        {
            var exhibitions = ConnectionClass.db.Cactus_Exhibition1
                .Include("Cactus")
                .Include("Exhibition")
                .Select(ce => new CactusExhibitionViewModel
                {
                    Species = ce.Cactus.Species,
                    Awards = ce.Exhibition.Awards,
                    ExhibitionDate = ce.Exhibition.Date
                })
                .ToList();

            ExhibitionsDataGrid.ItemsSource = exhibitions;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddCall());
        }


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
