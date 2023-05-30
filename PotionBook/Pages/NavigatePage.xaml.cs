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
using System.Diagnostics;
using PotionBook.Windows;

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

            if (App.CurrentUser == null || App.CurrentUser.RoleID == 3)
            {
                NextBtn.Visibility = Visibility.Collapsed;
            }
        }

        private void PracticBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TestBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LessonBtn_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://minecraft.fandom.com/ru/wiki/%D0%97%D0%B5%D0%BB%D1%8C%D0%B5%D0%B2%D0%B0%D1%80%D0%B5%D0%BD%D0%B8%D0%B5?file=%25D0%25A1%25D0%25B8%25D1%2581%25D1%2582%25D0%25B5%25D0%25BC%25D0%25B0_%25D0%25B7%25D0%25B5%25D0%25BB%25D1%258C%25D0%25B5%25D0%25B2%25D0%25B0%25D1%2580%25D0%25B5%25D0%25B");
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NavigateForAdminPage());
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
