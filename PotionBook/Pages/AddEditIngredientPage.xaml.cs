using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
        private byte[] data = null;
        public AddEditIngredientPage()
        {
            InitializeComponent();
            
        }

        public AddEditIngredientPage(Entities.IngredientOne engredientOne)
        {
            InitializeComponent();
            Title = "Редактирование ингредиентов";
            currentingOne = engredientOne;
            TxtName.Text = currentingOne.NameOne;
            if (currentingOne.ImageOne != null)
                ImageSerice.Source = new ImageSourceConverter()
                    .ConvertFrom(currentingOne.ImageOne) as ImageSource;
        }

        private void SelectImageBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Multiselect = false;
            fileOpen.Filter = "Image | *.png; *.jpg; *.jpeg";
            if (fileOpen.ShowDialog() == true)
            {
                data = File.ReadAllBytes(fileOpen.FileName);
                ImageSerice.Source = new ImageSourceConverter()
                   .ConvertFrom(data) as ImageSource;
            }
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
                if (currentingOne == null)
                {
                    var ingredientOne = new Entities.IngredientOne
                    {
                        NameOne = TxtName.Text,
                        ImageOne = data
                    };
                    var ingredientTwo = new Entities.IngredientTwo
                    {
                        NameTwo = TxtName.Text,
                        ImageTwo = data
                    };
                    var ingredientThr = new Entities.IngredientThr
                    {
                        NameThr = TxtName.Text,
                        ImageThr = data
                    };
                    var ingredientFour = new Entities.IngredientFour
                    {
                        NameFour = TxtName.Text,
                        ImageFour = data
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
                    if (data != null)
                        currentingOne.ImageOne = data;

                    App.Context.SaveChanges();

                    SqlConnection myConnection = new SqlConnection("Server = PCSQLStud01; database = 10200296; Integrated Security=True; TrustServerCertificate=True");
                    string selectquery;
                    if (data != null)
                        selectquery = "Update IngredientTwo Set NameTwo = '" + TxtName.Text + "', ImageTwo = (Select ImageOne From IngredientOne Where idOne=" + currentingOne.idOne + ") Where idTwo = " + currentingOne.idOne;
                    else selectquery = "Update IngredientTwo Set NameTwo = '" + TxtName.Text + "', ImageTwo = NULL Where idTwo = " + currentingOne.idOne;
                    SqlDataAdapter adpt = new SqlDataAdapter(selectquery, myConnection);
                    DataTable table = new DataTable();
                    adpt.Fill(table);

                    if (data != null)
                        selectquery = "Update IngredientThr Set NameThr = '" + TxtName.Text + "', ImageThr = (Select ImageOne From IngredientOne Where idOne=" + currentingOne.idOne + ") Where idThr = " + currentingOne.idOne;
                    else selectquery = "Update IngredientThr Set NameThr = '" + TxtName.Text + "', ImageThr = NULL Where idThr = " + currentingOne.idOne;
                    adpt = new SqlDataAdapter(selectquery, myConnection);
                    table = new DataTable();
                    adpt.Fill(table);

                    if (data != null)
                        selectquery = "Update IngredientFour Set NameFour = '" + TxtName.Text + "', ImageFour = (Select ImageOne From IngredientOne Where idOne=" + currentingOne.idOne + ") Where idFour = " + currentingOne.idOne;
                    else selectquery = "Update IngredientFour Set NameFour = '" + TxtName.Text + "', ImageFour = NULL Where idFour = " + currentingOne.idOne;
                    adpt = new SqlDataAdapter(selectquery, myConnection);
                    table = new DataTable();
                    adpt.Fill(table);

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
                App.CurrentUser = null;
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Window.GetWindow(this).Close();
            }
        }
    }
}
