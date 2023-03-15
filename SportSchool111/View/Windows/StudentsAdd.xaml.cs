using Microsoft.Win32;
using SportSchool111.AppData;
using SportSchool111.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace SportSchool111.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для StudentsAdd.xaml
    /// </summary>
    public partial class StudentsAdd : Window
    {
        public StudentsAdd()
        {
            InitializeComponent();
            comboBoxGender.DisplayMemberPath = "Name";
            comboBoxGender.ItemsSource = AppConnect.BD.Genders.ToList();

            CbSections.DisplayMemberPath = "section_name";
            CbSections.ItemsSource = AppConnect.BD.Sections.ToList();
        }



        private void ButtonRefresh_Click(object sender, RoutedEventArgs e)
        {
            // Код для обновления записи в базе данных

        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            // Код для добавления записи в базу данных

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

            // Сохранение данных
            AppConnect.BD.Students.Add(students);
            AppConnect.BD.SaveChanges();


            {
                MessageBox.Show("Студент успешно добавлен в базу данных.");
            }
        }
    }
}

