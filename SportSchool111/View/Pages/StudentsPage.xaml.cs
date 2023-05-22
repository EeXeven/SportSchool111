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
            LviewStudents.MouseDoubleClick += ListViewItem_MouseDoubleClick;
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
            string searchText = TboxSearch.Text.ToLower(); // Получение текста поиска и приведение его к нижнему регистру

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
       
        //Фильтрация(выборка) секций 
        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
     
        {         
                int sectionId = ((Sections)ComboType.SelectedItem).section_id;
                LviewStudents.ItemsSource = AppConnect.BD.Students.Where(s => s.section_id == sectionId).ToList();           
        } 

        private void LwiewStudents_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void LviewStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
            //SoundPlayer player = new SoundPlayer(@"C:\Users\Sanya\Downloads\click.wav");
            //player.Load();
            //player.Play();
            NavigationService.Navigate(new StudentsAddPages());
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Получение выбранного студента
            ListViewItem item = sender as ListViewItem;
            StudentsApp selectedStudent = item.DataContext as StudentsApp;

            if (selectedStudent != null)
    {
        // Отображение карточки студента с данными
        MessageBox.Show($"Паспорт: {selectedStudent.passport}\nСНИЛС: {selectedStudent.snils}\nИНН: {selectedStudent.inn}\nДата рождения: {selectedStudent.birth_certificate}");
    }
        }
    }
}
    