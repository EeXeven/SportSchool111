﻿using SportSchool111.View.Pages;
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
using System.Windows.Shapes;

namespace SportSchool111.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowsStatic.xaml
    /// </summary>
    public partial class WindowsStatic : Window
    {
        public WindowsStatic()
        {
            InitializeComponent();
            MainFrame.Content = new AuthPage();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
