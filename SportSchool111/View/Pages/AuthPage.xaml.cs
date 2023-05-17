using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Media;
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



        private void AuthLoginTbx_GotFocus(object sender, RoutedEventArgs e)
        {
            if (AuthLoginTbx.Text == "Login")
            {
                AuthLoginTbx.Text = string.Empty;
            }
        }

        private void AuthLoginTbx_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AuthLoginTbx.Text))
            {
                AuthLoginTbx.Text = "Login";
            }
        }

        private void AuthPassPbx_GotFocus(object sender, RoutedEventArgs e)
        {
            if (AuthPassPbx.Text == "Password")
            {
                AuthPassPbx.Text = string.Empty;
            }
        }
        private void Auth(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Sanya\Desktop\Not.wav");
           player.Load();
            player.Play();



            if (!(string.IsNullOrWhiteSpace(AuthLoginTbx.Text) || string.IsNullOrWhiteSpace(AuthPassPbx.Text)))
                {
                    string awsd = AppData.AppConnect.BD.Users.First(i => i.username == AuthLoginTbx.Text && i.password == AuthPassPbx.Text)?.user_type;
                    if (awsd != null)
                    {
                        // определение уровня доступа пользователя
                        switch (awsd)
                        {
                            case "admin":
                                // откройте страницу управления пользователями
                                NavigationService.Navigate(new MenuPage());
                                //Закрытие Frame Auth
                                NavigationService.RemoveBackEntry();
                                MessageBox.Show("Авторизация прошла успешно!");
                                // Очистка TextBox
                                AuthLoginTbx.Text = "";
                                AuthPassPbx.Text = "";
                                break;
                            default:
                                // Восстановление значения TextBox из свойства Tag
                                AuthLoginTbx.Text = AuthLoginTbx.Tag as string;
                                AuthPassPbx.Text = AuthPassPbx.Tag as string;
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
    private void AuthPassPbx_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AuthPassPbx.Text))
            {
                AuthPassPbx.Text = "Password";
            }
        }

        private void AuthPassPbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                // вызываем метод для обработки события нажатия кнопки
                Auth(sender, e);
            }
        }
    }
}

