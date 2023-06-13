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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SportSchool111.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Training.xaml
    /// </summary>
    public partial class Training : Page
    {
        public Training()
        {
            InitializeComponent();
            DataContext = AppData.AppConnect.BD.trainigs.ToList().FirstOrDefault();
            this.trainigs.ItemsSource = AppData.AppConnect.BD.trainigs.ToList();
            this.CbSections.ItemsSource = AppData.AppConnect.BD.Sections.ToList();
            this.group.ItemsSource = AppData.AppConnect.BD.Groups.ToList();
            this.trainer.ItemsSource = AppData.AppConnect.BD.Coaches.ToList();
        }

        private void Redact_Click(object sender, RoutedEventArgs e)
        {
            AppData.AppConnect.BD.SaveChanges();
            this.trainigs.ItemsSource = AppData.AppConnect.BD.trainigs.ToList();
        }

        private void days_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(this.trainigs.SelectedItem is trainigs tr)
            {
                DataContext = tr;
            }
        }
    }
}
