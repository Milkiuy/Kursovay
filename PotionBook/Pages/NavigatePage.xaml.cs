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

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            PotionWindow potionWindow = new PotionWindow();
            potionWindow.Show();
            Window.GetWindow(this).Close();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Вы уверены, что хотите вернуться?\nНесохраненные данные могут быть утеряны",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                PotionWindow potion = new PotionWindow();
                potion.Show();
                Window.GetWindow(this).Close();
            }
        }
    }
}
