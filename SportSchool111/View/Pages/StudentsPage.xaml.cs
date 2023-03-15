using SportSchool111.Model;
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
using SportSchool111.AppData;

namespace SportSchool111.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для StudentsPage.xaml
    /// </summary>
    public partial class StudentsPage : Page
    {
        public StudentsPage()
        {
            InitializeComponent();
            LwiewStudents.ItemsSource = AppConnect.BD.Students.ToList();

            ComboType.DisplayMemberPath = "section_name";
          
            ComboType.ItemsSource = AppData.AppConnect.BD.Sections.ToList();

        }
        private void UpdateStudents()
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void TboxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LwiewStudents_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
