using SportSchool111.Model;
using SportSchool111.View.Pages;
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

namespace SportSchool111.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для RedStudentsWindows.xaml
    /// </summary>
    public partial class RedStudentsWindows : Window
    {
        public RedStudentsWindows()
        {
            InitializeComponent();
            
        }


        public RedStudentsWindows(Students students)
        {
            InitializeComponent();
            DataContext = students;
            comboBoxGender.ItemsSource = AppData.AppConnect.BD.Genders.ToList();
            CbSections.ItemsSource = AppData.AppConnect.BD.Sections.ToList();
        }

        private void Redact_Click(object sender, RoutedEventArgs e)
        {
            AppData.AppConnect.BD.SaveChanges();
            MessageBox.Show("Редактирование успешно сохранено.");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            StudentsPage studentsPages = new StudentsPage();
            MessageBox.Show("Изменения сохранены.");
            this.Close();
        }

        private void remove_click(object sender, RoutedEventArgs e)
        {
            AppData.AppConnect.BD.Students.Remove(DataContext as Students);
                AppData.AppConnect.BD.SaveChanges();
            MessageBox.Show("Архивирование успешно выполнено.");
        }
    }
}
