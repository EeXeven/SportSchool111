using SportSchool111.AppData;
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

namespace SportSchool111.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для StudentsPages.xaml
    /// </summary>
    public partial class StudentsPages : Page
    {
        public StudentsPages()
        {
            InitializeComponent();
            LviewStudents.ItemsSource = AppConnect.BD.Students.ToList();

            ComboType.DisplayMemberPath = "section_name";

            ComboType.ItemsSource = AppData.AppConnect.BD.Sections.ToList();
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int sectionId = ((Sections)ComboType.SelectedItem).section_id;
            LviewStudents.ItemsSource = AppConnect.BD.Students.Where(s => s.section_id == sectionId).ToList();
        }

        private void TboxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LviewStudents_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
