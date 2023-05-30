using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для AddEditIngredientPage.xaml
    /// </summary>
    public partial class AddEditIngredientPage : Page
    {
        private Entities.IngredientOne currentingOne = null;
        private Entities.IngredientTwo currentingTwo = null;
        private Entities.IngredientThr currentingThr = null;
        private Entities.IngredientFour currentingFour = null;
        public AddEditIngredientPage()
        {
            InitializeComponent();
        }

        public AddEditIngredientPage(Entities.IngredientOne engredientOne, Entities.IngredientTwo engredientTwo, Entities.IngredientThr engredientThr, Entities.IngredientFour engredientFour)
        {
            InitializeComponent();
            Title = "Редактирование ингредиентов";
            currentingOne = engredientOne;
            currentingTwo = engredientTwo;
            currentingThr = engredientThr;
            currentingFour = engredientFour;
            TxtName.Text = currentingOne.NameOne;
        }

        private void SelectImageBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var errorMessage = CheckErrors();

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (currentingOne == null && currentingTwo == null && currentingThr == null && currentingFour == null)
                {
                    var ingredientOne = new Entities.IngredientOne
                    {
                        NameOne = TxtName.Text,
                        ImageOne = "NULL"
                    };
                    var ingredientTwo = new Entities.IngredientTwo
                    {
                        NameTwo = TxtName.Text,
                        ImageTwo = "NULL"
                    };
                    var ingredientThr = new Entities.IngredientThr
                    {
                        NameThr = TxtName.Text,
                        ImageThr = "NULL"
                    };
                    var ingredientFour = new Entities.IngredientFour
                    {
                        NameFour = TxtName.Text,
                        ImageFour = "NULL"
                    };

                    App.Context.IngredientOnes.Add(ingredientOne);
                    App.Context.IngredientTwoes.Add(ingredientTwo);
                    App.Context.IngredientThrs.Add(ingredientThr);
                    App.Context.IngredientFours.Add(ingredientFour);
                    App.Context.SaveChanges();
                    MessageBox.Show("Ингредиент успешно создан", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new IngredientPage());
                }
                else
                {
                    currentingOne.NameOne = TxtName.Text;
                    currentingOne.ImageOne = "NULL";

                    //App.Context.IngredientTwoes.
                    currentingTwo.NameTwo = TxtName.Text;
                    currentingTwo.ImageTwo = "NULL";

                    currentingThr.NameThr = TxtName.Text;
                    currentingThr.ImageThr = "NULL";

                    currentingFour.NameFour = TxtName.Text;
                    currentingFour.ImageFour = "NULL";

                    App.Context.SaveChanges();
                    MessageBox.Show("Ингредиент успешно обновлен", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new IngredientPage());
                }
            }
        }

        private string CheckErrors()
        {
            var errorBuilder = new StringBuilder();
            var engredientFromBD = App.Context.IngredientOnes.ToList()
                .FirstOrDefault(p => p.NameOne.ToLower() == TxtName.Text.ToLower());
            if (string.IsNullOrWhiteSpace(TxtName.Text))
                errorBuilder.AppendLine("Имя игредиента обязателено для заполнения;");
            else if (engredientFromBD != null && engredientFromBD != currentingOne)
                errorBuilder.AppendLine("Такое имя уже есть в базе данных;");
            if (errorBuilder.Length > 0)
                errorBuilder.Insert(0, "Устраните следующие ошибки:\n");

            return errorBuilder.ToString();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Вы уверены, что хотите вернуться?\nНесохраненные данные могут быть утеряны",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                NavigationService.Navigate(new IngredientPage());
            }
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Вы уверены, что хотите выйти?\nНесохраненные данные могут быть утеряны",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Window.GetWindow(this).Close();
            }
        }
    }
}
