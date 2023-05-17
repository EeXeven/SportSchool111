using Microsoft.Win32;
using SportSchool111.AppData;
using SportSchool111.Model;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для StudentsAddPages.xaml
    /// </summary>
    public partial class StudentsAddPages : Page
    {
        public StudentsAddPages()
        {
            InitializeComponent();
            comboBoxGender.DisplayMemberPath = "Name";
            comboBoxGender.ItemsSource = AppConnect.BD.Genders.ToList();

            CbSections.DisplayMemberPath = "section_name";
            CbSections.ItemsSource = AppConnect.BD.Sections.ToList();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            // Проверка заполнения всех полей 
            if (string.IsNullOrWhiteSpace(textBoxFIO.Text) ||
                comboBoxGender.SelectedItem == null ||
                string.IsNullOrWhiteSpace(comboBoxGender.SelectedItem.ToString()) ||
                string.IsNullOrWhiteSpace(textBoxAge.Text) ||
                CbSections.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxPassport.Text) ||
                string.IsNullOrWhiteSpace(textBoxPolicy.Text) ||
                string.IsNullOrWhiteSpace(textBoxINN.Text) ||
                string.IsNullOrWhiteSpace(textBoxSNILS.Text))
            {
                MessageBox.Show("Пожалуйста проверьте заполнение всех полей", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            // добавление записи в базу данных
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.ShowDialog();

                Students students = new Students()
                {
                    FIO = textBoxFIO.Text,
                    gender = ((Genders)comboBoxGender.SelectedItem).Id,
                    age = Convert.ToInt32(textBoxAge.Text),
                    Sections = CbSections.SelectedItem as Model.Sections,
                    passport = textBoxPassport.Text,
                    policy = textBoxPolicy.Text,
                    inn = textBoxINN.Text,
                    snils = textBoxSNILS.Text,
                    birth_certificate = textBoxBirthCertificate.Text,
                    Photo = File.ReadAllBytes(openFileDialog.FileName)
                };
                // Сохранение студента в базе данных
                AppConnect.BD.Students.Add(students);
                AppConnect.BD.SaveChanges();
                MessageBox.Show("Студент успешно добавлен.");
            }
        }
     

        private void Backk_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();

            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
