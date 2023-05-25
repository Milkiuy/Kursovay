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
    }
}
