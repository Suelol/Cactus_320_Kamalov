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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем значения логина и пароля из полей ввода
            string login = LoginTextBox.Text;
            string password = PasswordBox.Password;

            // Проверяем, не пустые ли поля логина и пароля
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка авторизации");
                return;
            }

            // Проверяем логин и пароль на соответствие с данными из БД
            var user = ConnectionClass.db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);

            if (user != null)
            {
                // Авторизация успешна, можно открыть главное окно приложения
                MessageBox.Show("Авторизация успешна", "Успех");
                // Открываем главное окно приложения
                NavigationService.Navigate(new CactusKatalog());
            }
            else
            {
                // Авторизация неуспешна, показываем сообщение об ошибке
                MessageBox.Show("Неправильный логин или пароль", "Ошибка авторизации");
            }
        }
    }
}
