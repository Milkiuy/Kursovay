﻿using PotionBook.Windows;
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

namespace PotionBook.Pages
{
    /// <summary>
    /// Логика взаимодействия для NavigateForAdminPage.xaml
    /// </summary>
    public partial class NavigateForAdminPage : Page
    {
        public NavigateForAdminPage()
        {
            InitializeComponent();
            if (App.CurrentUser == null || App.CurrentUser.RoleID == 2)
            {
                UserBtn.Visibility = Visibility.Collapsed;
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Вы уверены, что хотите вернуться?",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                NavigationService.GoBack();
            }
        }

        private void UserBtn_Click(object sender, RoutedEventArgs e)
        {
            PotionWindow potion = new PotionWindow();
            potion.FrameMain.Navigate(new UserPage());
            potion.Title = "Зелья";
            potion.Show();
            Window.GetWindow(this).Close();
        }

        private void IngredientsBtn_Click(object sender, RoutedEventArgs e)
        {
            PotionWindow potion = new PotionWindow();
            potion.FrameMain.Navigate(new IngredientPage());
            potion.Title = "Ингредиенты";
            potion.Show();
            Window.GetWindow(this).Close();
        }

        private void PotionBtn_Click(object sender, RoutedEventArgs e)
        {
            PotionWindow potion = new PotionWindow();
            potion.FrameMain.Navigate(new PotionPage());
            potion.Title = "Пользователи";
            potion.Show();
            Window.GetWindow(this).Close();
        }
    }
}