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
        private Entities.Potion currentpotion = null;
        public AddEditUserPage()
        {
            InitializeComponent();
        }
        public AddEditUserPage(Entities.Potion user)
        {
            InitializeComponent();
            Title = "Редактирование пользователей";
            currentpotion = user;
        }
    }
}
