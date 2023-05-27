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
    /// Логика взаимодействия для IngredientPage.xaml
    /// </summary>
    public partial class IngredientPage : Page
    {
        public IngredientPage()
        {
            InitializeComponent();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var currentIngredients = (sender as Button).DataContext as Entities.Potion;
            NavigationService.Navigate(new AddEditPotionPage(currentIngredients));
        }

        private void UpdatePotion()
        {
            var ingredients = App.Context.Potions.ToList();
            ListIngredients.ItemsSource = ingredients;
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var currentIngredients = (sender as Button).DataContext as Entities.IngredientOne;
            if (MessageBox.Show($"Вы уверены, что хотите удалить ингредент: {currentIngredients.NameOne}?",
                    "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                App.Context.IngredientOnes.Remove(currentIngredients);
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

        private void AddIngredientBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditIngredientPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdatePotion();
        }
    }
}
