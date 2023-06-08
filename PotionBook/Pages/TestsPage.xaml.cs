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
    /// Логика взаимодействия для TestsPage.xaml
    /// </summary>
    public partial class TestsPage : Page
    {
        string answerone, answertwo, answerthr, answerfour, answerfive, answersix;

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            answerone = "False";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            answertwo = "False";
        }

        private void AnswerSpeed_Checked(object sender, RoutedEventArgs e)
        {
            answertwo = "True";
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            answerthr = "False";
        }

        private void AnswerVision_Checked(object sender, RoutedEventArgs e)
        {
            answerthr = "True";
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            answerfour = "False";
        }
        private void AnswerRegeneration_Checked(object sender, RoutedEventArgs e)
        {
            answerfour = "True";
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            answerfive = "False";
        }

        private void AnswerHarmOne_Checked(object sender, RoutedEventArgs e)
        {
            answerfive = "True";
        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            answersix = "False";
        }
        private void AnswerDust_Checked(object sender, RoutedEventArgs e)
        {
            answersix = "True";
        }

        public TestsPage()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Вы уверены, что хотите вернуться?",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.FrameMain.Navigate(new NavigatePage());
                mainWindow.Show();
                Window.GetWindow(this).Close();
            }
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Вы уверены, что хотите выйти?",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                App.CurrentUser = null;
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Window.GetWindow(this).Close();
            }
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            if (answerone == "True")
                count++;
            if (answertwo == "True")
                count++;
            if (answerthr == "True")
                count++;
            if (answerfour == "True")
                count++;
            if (answerfive == "True")
                count++;
            if (answersix == "True")
                count++;
            MessageBox.Show("Вы набрали " + count + " баллов из 6",
                "Внимание", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void AnswerFall_Checked(object sender, RoutedEventArgs e)
        {
            answerone = "True";
        }
    }
}
