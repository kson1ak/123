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

namespace Conference.Paages
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
            if (string.IsNullOrEmpty(LoginTextBox.Text) || string.IsNullOrEmpty(PasswordBox.Password))
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }
            using (var bd12 = new bd02Entities())
            {
                var user = bd12.Users
                    .AsNoTracking()
                    .FirstOrDefault(u => u.Login == LoginTextBox.Text && u.Password == PasswordBox.Password);
                if (user == null)
                {
                    MessageBox.Show("Пользователь с такими данными не найден!");
                    return;
                }
                MessageBox.Show("Пользователь успешно найден!");
                switch (user.Role)
                {
                    case "jure":
                        NavigationService?.Navigate(new JurePage());
                        break;
                    case "user":
                        NavigationService?.Navigate(new UserPage());
                        break;
                    case "moderator":
                        NavigationService?.Navigate(new ModeratorPage());
                        break;
                    case "organizer":
                        NavigationService?.Navigate(new OrganizatorPage());
                        break;
                }
            }
        }



        private void LoginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtHintLogin.Visibility = Visibility.Visible;
            if (LoginTextBox.Text.Length > 0)
            {
                txtHintLogin.Visibility = Visibility.Hidden;
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            txtHintPassword.Visibility = Visibility.Visible;
            if (PasswordBox.Password.Length > 0)
            {
                txtHintPassword.Visibility = Visibility.Hidden;
            }
        }
    }
}