﻿using System;
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
using System.Diagnostics;

namespace PotionBook.Pages
{
    /// <summary>
    /// Логика взаимодействия для NavigatePage.xaml
    /// </summary>
    public partial class NavigatePage : Page
    {
        public NavigatePage()
        {
            InitializeComponent();
           
            MainWindow main = new MainWindow();
            main.BackBtn.Visibility = Visibility.Visible;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void PracticBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TestBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LessonBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
