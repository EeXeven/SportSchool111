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

namespace SportSchool111.View.Pages
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

        private void loginTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (loginTextBox.Text == "Login")
            {
                loginTextBox.Text = "";
            }
        }

        private void loginTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(loginTextBox.Text))
            {
                loginTextBox.Text = "Login";
            }
        }

        private void loginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (loginTextBox.Text == "Введите логин")
            {
                loginTextBox.Text = "";
            }
        }

        private void LoginBth_Click(object sender, RoutedEventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(loginTextBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Password)))
            {
                string awsd = AppData.AppConnect.BD.Users.First(i => i.username == loginTextBox.Text && i.password == passwordBox.Password)?.user_type;
                if (awsd != null)
                {
                    // определение уровня доступа пользователя
                    switch (awsd)
                    {
                        case "admin":
                            // откройте страницу управления пользователями
                            NavigationService.Navigate(new MenuPage());

                            MessageBox.Show("Авторизация прошла успешно!");

                            break;
                        case "coach":
                            // откройте страницу тренера
                            break;
                        case "student":
                            // откройте страницу ученика
                            break;

                    }

                }


                else
                {
                    MessageBox.Show("Ошибка авторизации. Пожалуйста, проверьте свои учетные данные и повторите попытку.");
                }

            }
            else
            {
                MessageBox.Show("Ошибка авторизации. Пожалуйста, заполните все поля");
            }
        }
    }
    }
