using PotionBook.Windows;
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
            NavigationService.Navigate(new NavigatePage());
        }

        private void UserBtn_Click(object sender, RoutedEventArgs e)
        {
            PotionWindow potion = new PotionWindow();
            potion.FrameMain.Navigate(new UserPage());
            potion.Show();
            Window.GetWindow(this).Close();
        }

        private void IngredientsBtn_Click(object sender, RoutedEventArgs e)
        {
            PotionWindow potion = new PotionWindow();
            potion.FrameMain.Navigate(new IngredientPage());
            potion.Show();
            Window.GetWindow(this).Close();
        }

        private void PotionBtn_Click(object sender, RoutedEventArgs e)
        {
            PotionWindow potion = new PotionWindow();
            potion.FrameMain.Navigate(new PotionPage());
            potion.Show();
            Window.GetWindow(this).Close();
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Вы уверены, что хотите выйти?",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                NavigationService.Navigate(new LoginPage());
            }
        }
    }
}
