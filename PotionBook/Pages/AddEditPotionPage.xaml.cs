using Microsoft.Win32;
using PotionBook.Entities;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddEditPotionPage.xaml
    /// </summary>
    public partial class AddEditPotionPage : Page
    {
        private Entities.Potion currentpotion = null;
        private byte[] data = null;
        public AddEditPotionPage()
        {
            InitializeComponent();
        }

        public AddEditPotionPage(Entities.Potion potion)
        {
            InitializeComponent();
            Title = "Редактирование зелий";
            currentpotion = potion;
            TxtName.Text = currentpotion.Name;
            ComboOne.SelectedIndex = currentpotion.IngredientOne -1;
            ComboTwo.SelectedIndex = currentpotion.IngredientTwo - 1;
            if (currentpotion.IngredientThr != null)
                ComboThr.SelectedIndex = (int)currentpotion.IngredientThr - 1;
            if (currentpotion.IngredientFour != null)
                ComboFour.SelectedIndex = (int)currentpotion.IngredientFour - 1; 
            if (currentpotion.Image != null)
                ImageSerice.Source = new ImageSourceConverter()
                    .ConvertFrom(currentpotion.Image) as ImageSource;

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var ingredient = App.Context.IngredientOnes.OrderBy(p => p.idOne).Select(p => p.NameOne).ToArray();
            for (int i = 0; i < ingredient.Length; i++)
                ComboOne.Items.Add(ingredient[i]);
            for (int i = 0;i < ingredient.Length;i++)
                ComboTwo.Items.Add(ingredient[i]);
            for(int i = 0;i < ingredient.Length;i++)
                ComboThr.Items.Add(ingredient[i]);
            for (int i = 0; i < ingredient.Length; i++)
                ComboFour.Items.Add(ingredient[i]);
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
                if (currentpotion == null)
                {
                    var potion = new Entities.Potion();
                    if (ComboThr.SelectedItem == null && ComboFour.SelectedItem == null)
                    {
                        potion = new Entities.Potion
                        {
                            Name = TxtName.Text,
                            IngredientOne = App.Context.IngredientOnes.Where(p => p.NameOne == ComboOne.SelectedItem.ToString())
                        .Select(p => p.idOne).FirstOrDefault(),
                            IngredientTwo = App.Context.IngredientTwoes.Where(p => p.NameTwo == ComboTwo.SelectedItem.ToString())
                        .Select(p => p.idTwo).FirstOrDefault(),
                            IngredientThr = null,
                            IngredientFour = null,
                            Image = data
                        };
                    }
                    else if (ComboFour.SelectedItem == null)
                    {
                        potion = new Entities.Potion
                        {
                            Name = TxtName.Text,
                            IngredientOne = App.Context.IngredientOnes.Where(p => p.NameOne == ComboOne.SelectedItem.ToString())
                        .Select(p => p.idOne).FirstOrDefault(),
                            IngredientTwo = App.Context.IngredientTwoes.Where(p => p.NameTwo == ComboTwo.SelectedItem.ToString())
                        .Select(p => p.idTwo).FirstOrDefault(),
                            IngredientThr = App.Context.IngredientThrs.Where(p => p.NameThr == ComboThr.SelectedItem.ToString())
                        .Select(p => p.idThr).FirstOrDefault(),
                            IngredientFour = null,
                            Image = data
                        };
                    }
                    else
                    {
                        potion = new Entities.Potion
                        {
                            Name = TxtName.Text,
                            IngredientOne = App.Context.IngredientOnes.Where(p => p.NameOne == ComboOne.SelectedItem.ToString())
                        .Select(p => p.idOne).FirstOrDefault(),
                            IngredientTwo = App.Context.IngredientTwoes.Where(p => p.NameTwo == ComboTwo.SelectedItem.ToString())
                        .Select(p => p.idTwo).FirstOrDefault(),
                            IngredientThr = App.Context.IngredientThrs.Where(p => p.NameThr == ComboThr.SelectedItem.ToString())
                        .Select(p => p.idThr).FirstOrDefault(),
                            IngredientFour = App.Context.IngredientFours.Where(p => p.NameFour == ComboFour.SelectedItem.ToString())
                        .Select(p => p.idFour).FirstOrDefault(),
                            Image = data
                        };
                    }

                    App.Context.Potions.Add(potion);
                    App.Context.SaveChanges();
                    MessageBox.Show("Зелье успешно создано", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new PotionPage());
                }
                else
                {
                    currentpotion.Name = TxtName.Text;
                    currentpotion.IngredientOne = App.Context.IngredientOnes.Where(p => p.NameOne == ComboOne.SelectedItem.ToString())
                        .Select(p => p.idOne).FirstOrDefault();
                    currentpotion.IngredientTwo = App.Context.IngredientTwoes.Where(p => p.NameTwo == ComboTwo.SelectedItem.ToString())
                        .Select(p => p.idTwo).FirstOrDefault();
                    if (ComboThr.SelectedItem == null)
                        currentpotion.IngredientThr = null;
                    else
                        currentpotion.IngredientThr = App.Context.IngredientThrs.Where(p => p.NameThr == ComboThr.SelectedItem.ToString())
                            .Select(p => p.idThr).FirstOrDefault();
                    if (ComboFour.SelectedItem == null)
                        currentpotion.IngredientFour = null;
                    else
                        currentpotion.IngredientFour = App.Context.IngredientFours.Where(p => p.NameFour == ComboFour.SelectedItem.ToString())
                            .Select(p => p.idFour).FirstOrDefault();
                    if (data != null)
                    currentpotion.Image = data;

                    App.Context.SaveChanges();
                    MessageBox.Show("Зелье успешно обновлено", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new PotionPage());
                }
            }    
        }

        private string CheckErrors()
        {
            var errorBuilder = new StringBuilder();
            var potionFromBD = App.Context.Potions.ToList()
                .FirstOrDefault(p => p.Name.ToLower() == TxtName.Text.ToLower());
            if (string.IsNullOrWhiteSpace(TxtName.Text))
                errorBuilder.AppendLine("Имя зелья обязателено для заполнения;");
            else if (potionFromBD != null && potionFromBD != currentpotion)
                errorBuilder.AppendLine("Такое имя уже есть в базе данных;");
            if (ComboOne.SelectedItem == null)
                errorBuilder.AppendLine("Выберите первый ингредиент;");
            if (ComboTwo.SelectedItem == null)
                errorBuilder.AppendLine("Выберите второй ингредиент;");
            if (ComboThr.SelectedItem == null && ComboFour.SelectedItem != null)
                errorBuilder.AppendLine("Сначала выберите третий ингредиент;");
            if (errorBuilder.Length > 0)
                errorBuilder.Insert(0, "Устраните следующие ошибки:\n");

            return errorBuilder.ToString();
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

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Вы уверены, что хотите вернуться?\nНесохраненные данные могут быть утеряны",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                NavigationService.Navigate(new PotionPage());
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
