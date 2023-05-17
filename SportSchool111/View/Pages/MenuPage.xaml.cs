using SportSchool111.View.Windows;
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
            NavigationService.Navigate(new StudentsPages());
           
           
        }

        private void Coachs_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Groups_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Students_Copy_Click(object sender, RoutedEventArgs e)
        {
            StudentsAdd students = new StudentsAdd();
            students.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            WindowsStatic start = new WindowsStatic();       

            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
