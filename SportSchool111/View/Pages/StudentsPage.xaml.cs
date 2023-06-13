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
using System.ComponentModel;
using System.Media;
using SportSchool111.View.Windows;

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
            LviewStudents.ItemsSource = AppConnect.BD.Students.ToList();

            ComboType.DisplayMemberPath = "section_name";
            ComboType.ItemsSource = AppData.AppConnect.BD.Sections.ToList();
        }

        private void TboxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = TboxSearch.Text.ToLower();

            ICollectionView view = CollectionViewSource.GetDefaultView(LviewStudents.ItemsSource);
            if (view != null)
            {
                view.Filter = item =>
                {
                    if (item is Students student)
                    {
                        return student.FIO.ToLower().Contains(searchText);
                    }
                    return false;
                };
            }
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int sectionId = ((Sections)ComboType.SelectedItem).section_id;
            LviewStudents.ItemsSource = AppConnect.BD.Students.Where(s => s.section_id == sectionId).ToList();
        }

        private void Backk_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();

            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void StudentsAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StudentsAddPages());
        }

    

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }



        private void LviewStudents_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void LviewStudents_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            RedStudentsWindows Main = new RedStudentsWindows((Students)LviewStudents.SelectedItem);
            Main.Show();
        }
    }
}