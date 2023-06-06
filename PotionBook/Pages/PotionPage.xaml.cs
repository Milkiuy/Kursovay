using PotionBook.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для PotionPage.xaml
    /// </summary>
    public partial class PotionPage : Page
    {
        Regex name = new Regex(@"^[А-ЯЁ][а-яё]+$");
        public PotionPage()
        {
            InitializeComponent();
        }

        private void AddPotionBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditPotionPage());
        }

        private void UpdatePotion()
        {
            var potions = App.Context.Potions.ToList();
            ListPotions.ItemsSource = potions;
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var currentPotions = (sender as Button).DataContext as Entities.Potion;
            NavigationService.Navigate(new AddEditPotionPage(currentPotions));
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var currentPotions = (sender as Button).DataContext as Entities.Potion;
            if (MessageBox.Show($"Вы уверены, что хотите удалить зелье: {currentPotions.Name}?",
                    "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                App.Context.Potions.Remove(currentPotions);
                App.Context.SaveChanges();
                UpdatePotion();
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Вы уверены, что хотите вернуться?",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.FrameMain.Navigate(new NavigateForAdminPage());
                mainWindow.Show();
                Window.GetWindow(this).Close();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdatePotion();
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Вы уверены, что хотите выйти?",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Window.GetWindow(this).Close();
            }
        }
    }
}
