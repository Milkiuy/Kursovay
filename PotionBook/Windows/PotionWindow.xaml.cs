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

namespace PotionBook.Windows
{
    /// <summary>
    /// Логика взаимодействия для PotionWindow.xaml
    /// </summary>
    public partial class PotionWindow : Window
    {
        object frameContent = null;
        public PotionWindow()
        {
            InitializeComponent();
            FrameMain.Navigate(new Pages.NavigateForAdminPage());
        }

        private void FrameMain_ContentRendered(object sender, EventArgs e)
        {
            if (FrameMain.Content != frameContent)
            {
                if (App.CurrentUser != null)
                {
                    UserName.Text = App.CurrentUser.Surname + " " + App.CurrentUser.Name;
                }
                else
                {
                    UserName.Text = "Гость";
                }
            }
            else
            {
                UserName.Text = String.Empty;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            frameContent = FrameMain.Content;
        }
    }
}
