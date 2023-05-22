using SportSchool111.View.Windows;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void Tourmants_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Students_Click(object sender, RoutedEventArgs e)
        {
            //SoundPlayer player = new SoundPlayer(@"C:\Users\Sanya\Downloads\click.wav");
            //player.Load();
            //player.Play();
            NavigationService.Navigate(new StudentsPage());
           
           
        }

        private void Coachs_Click(object sender, RoutedEventArgs e)
        {
            //SoundPlayer player = new SoundPlayer(@"C:\Users\Sanya\Downloads\click.wav");
            //player.Load();
            //player.Play();
            NavigationService.Navigate(new TrenersPages());
        }

        private void Groups_Click(object sender, RoutedEventArgs e)
        {

        }

      

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Sanya\Downloads\click.wav");
            player.Load();
            player.Play();
            WindowsStatic start = new WindowsStatic();       

            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

       

        private void ExitAcc_Click(object sender, RoutedEventArgs e)
        {
            //SoundPlayer player = new SoundPlayer(@"C:\Users\Sanya\Downloads\click.wav");
            //player.Load();
            //player.Play();
            AuthPage auth = new AuthPage();

            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
