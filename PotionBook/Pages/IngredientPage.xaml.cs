using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            var currentIngredients = (sender as Button).DataContext as Entities.IngredientOne;
            NavigationService.Navigate(new AddEditIngredientPage(currentIngredients));
        }

        private void UpdateIngredient()
        {
            var ingredients = App.Context.IngredientOnes.ToList();
            ListIngredients.ItemsSource = ingredients;
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var currentIngredients = (sender as Button).DataContext as Entities.IngredientOne;
            if (MessageBox.Show($"Вы уверены, что хотите удалить ингредент: {currentIngredients.NameOne}?",
                    "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                App.Context.IngredientOnes.Remove(currentIngredients);

                SqlConnection myConnection = new SqlConnection("Server = PCSQLStud01; database = 10200296; Integrated Security=True; TrustServerCertificate=True");
                string selectquery = "Delete From IngredientTwo Where idTwo = " + currentIngredients.idOne;
                SqlDataAdapter adpt = new SqlDataAdapter(selectquery, myConnection);
                DataTable table = new DataTable();
                adpt.Fill(table);

                selectquery = "Delete From IngredientThr Where idThr = " + currentIngredients.idOne;
                adpt = new SqlDataAdapter(selectquery, myConnection);
                table = new DataTable();
                adpt.Fill(table);

                selectquery = "Delete From IngredientFour Where idFour = " + currentIngredients.idOne;
                adpt = new SqlDataAdapter(selectquery, myConnection);
                table = new DataTable();
                adpt.Fill(table);
                
                App.Context.SaveChanges();
                UpdateIngredient();
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
            UpdateIngredient();
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
