using SportSchool111.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using System.Windows.Threading;

namespace SportSchool111.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для StartWindows.xaml
    /// </summary>
    public partial class StartWindows : Window
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public StartWindows()
        {
            InitializeComponent();

            //SoundPlayer player = new SoundPlayer(@"C:\Users\Sanya\Desktop\pravila.wav");
            //SoundPlayer player = new SoundPlayer(@"C:\Users\Sanya\Desktop\Rik.wav");
            SoundPlayer player = new SoundPlayer(@"C:\Users\ПРОСТО ВАСЯ\Downloads\Sounds.wav");
            player.Load();
            player.Play();

            dispatcherTimer.Tick += new EventHandler(MySplash);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 10);
            dispatcherTimer.Start();
        }
        private void MySplash(object sender, EventArgs e)
        {
            WindowsStatic Main = new WindowsStatic();
            Main.Show();
            dispatcherTimer.Stop();
            this.Close();
        }
    }
}
