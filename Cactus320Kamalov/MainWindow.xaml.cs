using Cactus320Kamalov.Pages;
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
using System.IO;

namespace Cactus320Kamalov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button cactusBtnField;
        private Button exhibitionBtnField;
        private Button objectCallBtnField;
        private Button exitBtnField;

        public MainWindow()
        {
            InitializeComponent();
            cactusBtnField = cactusBtn;
            exhibitionBtnField = exhibitionBtn;
            objectCallBtnField = objectCallBtn;
            exitBtnField = exitBtn;

            mainFrame.Navigated += (sender, e) =>
            {
                if (mainFrame.Content is AuthPage)
                {
                    cactusBtnField.Visibility = Visibility.Collapsed;
                    exhibitionBtnField.Visibility = Visibility.Collapsed;
                    objectCallBtnField.Visibility = Visibility.Collapsed;
                    exitBtnField.Visibility = Visibility.Collapsed;
                }
                else
                {
                    cactusBtnField.Visibility = Visibility.Visible;
                    exhibitionBtnField.Visibility = Visibility.Visible;
                    objectCallBtnField.Visibility = Visibility.Visible;
                    exitBtnField.Visibility = Visibility.Visible;
                }
            };

            mainFrame.NavigationService.Navigate(new AuthPage());
        }

        private void Button_Clck(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new CactusKatalog());
        }

        private void exhibitionBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ExhibitionPage());
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new AuthPage());
        }

        private void objectCallBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new CallKatalog());
        }
    }
}
