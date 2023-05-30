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
    /// Логика взаимодействия для AddEditUserPage.xaml
    /// </summary>
    public partial class AddEditUserPage : Page
    {
        private Entities.User currentuser = null;
        public AddEditUserPage()
        {
            InitializeComponent();
        }
        public AddEditUserPage(Entities.User user)
        {
            InitializeComponent();
            Title = "Редактирование пользователей";
            currentuser = user;
            TxtSurname.Text = currentuser.Surname;
            TxtName.Text = currentuser.Name;
            if (user.Patronymic == "NULL")
                TxtPatronymic.Text = "";
            else TxtPatronymic.Text = currentuser.Patronymic;
            TxtLogin.Text = currentuser.Login;
            TxtPass.Text = currentuser.Password;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            string patronymic;
            if (TxtPatronymic.Text == null)
                patronymic = "NULL";
            else patronymic = TxtPatronymic.Text;
            var errorMessage = CheckErrors();

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (currentuser == null)
                {
                    var user = new Entities.User
                    {
                        Surname = TxtSurname.Text,
                        Name = TxtName.Text,
                        Patronymic = patronymic,
                        Login = TxtLogin.Text,
                        Password = TxtPass.Text
                    };

                    App.Context.Users.Add(user);
                    App.Context.SaveChanges();
                    MessageBox.Show("Пользователь успешно создан", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new UserPage());
                }
                else
                {
                    currentuser.Surname = TxtSurname.Text;
                    currentuser.Name = TxtName.Text;
                    currentuser.Patronymic = patronymic;
                    currentuser.Login = TxtLogin.Text;
                    currentuser.Password = TxtPass.Text;

                    App.Context.SaveChanges();
                    MessageBox.Show("Пользователь успешно обновлен", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new UserPage());
                }
            }
        }
        private string CheckErrors()
        {
            var errorBuilder = new StringBuilder();
            if (string.IsNullOrWhiteSpace(TxtSurname.Text))
                errorBuilder.AppendLine("Фамилия обязателена для заполнения;");
            if (string.IsNullOrWhiteSpace(TxtName.Text))
                errorBuilder.AppendLine("Имя обязателено для заполнения;");
            if (string.IsNullOrWhiteSpace(TxtLogin.Text))
                errorBuilder.AppendLine("Логин обязателен для заполнения;");
            if (string.IsNullOrWhiteSpace(TxtPass.Text))
                errorBuilder.AppendLine("Пароль обязателен для заполнения;");
            if (errorBuilder.Length > 0)
                errorBuilder.Insert(0, "Устраните следующие ошибки:\n");

            return errorBuilder.ToString();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Вы уверены, что хотите вернуться?\nНесохраненные данные могут быть утеряны",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                NavigationService.Navigate(new UserPage());
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
