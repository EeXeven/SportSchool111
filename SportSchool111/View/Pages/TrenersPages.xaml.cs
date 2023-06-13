using SportSchool111.AppData;
using SportSchool111.Model;
using SportSchool111.View.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для TrenersPages.xaml
    /// </summary>
    public partial class TrenersPages : Page
    {
        public TrenersPages()
        {
            InitializeComponent();
            LviewStudents.ItemsSource = AppConnect.BD.Coaches.ToList();

            ComboType.DisplayMemberPath = "section_name";

            ComboType.ItemsSource = AppData.AppConnect.BD.Sections.ToList();
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
                    if (item is Coaches coaches)
                    {
                        return coaches.FIO.ToLower().Contains(searchText);
                    }
                    return false;
                };
            }
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int sectionId = ((Sections)ComboType.SelectedItem).section_id;
            LviewStudents.ItemsSource = AppConnect.BD.Coaches.Where(s => s.section_id == sectionId).ToList();
        }

        private void LviewStudents_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
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

        private void CoachessAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddCoaches());
        }

        private void LviewStudents_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            RedCoachesWindows Main = new RedCoachesWindows((Coaches)LviewStudents.SelectedItem);
            Main.Show();
            // Получить выбранный тренер или другую информацию об элементе

            // Создать или открыть окно редактирования с передачей выбранного тренера или информации
            //EditTrainerWindow editWindow = new EditTrainerWindow(selectedTrainer);
            //editWindow.ShowDialog(); // Показать окно редактирования как модальное

        }
    }
}
