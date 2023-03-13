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
using System.Windows.Shapes;

namespace SportSchool111.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Tourmants_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Students_Click(object sender, RoutedEventArgs e)
        {
            StudentsAdd students = new StudentsAdd();
            students.Show();
            Close();
        }

        private void Coachs_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Groups_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
