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
    /// Логика взаимодействия для AddEditPotionPage.xaml
    /// </summary>
    public partial class AddEditPotionPage : Page
    {
        private Entities.Potion currentpotion = null;
        public AddEditPotionPage()
        {
            InitializeComponent();
        }

        public AddEditPotionPage(Entities.Potion potion)
        {
            InitializeComponent();
            Title = "Редактирование зелий";
            currentpotion = potion;
            //currentMaterial = material;
            //TxtArticul.Text = currentMaterial.Articul;
            //TxtCost.Text = currentMaterial.Cost.ToString();
            //TxtDescription.Text = currentMaterial.Description;
            //TxtDiscountAm.Text = currentMaterial.Discount.ToString();
            //TxtDiscountMax.Text = currentMaterial.MaxDiscount.ToString();
            //TxtInStock.Text = currentMaterial.QuantityOnStock.ToString();
            //TxtMaterialName.Text = currentMaterial.MaterialName;
            //ComboCategory.SelectedIndex = currentMaterial.CategoryID - 1;
            //ComboManufacturer.SelectedIndex = currentMaterial.ManufacturerID - 1;
            //ComboProvider.SelectedIndex = currentMaterial.ProviderID - 1;
            //ComboUnit.SelectedIndex = currentMaterial.UnitID - 1;
            //ImageService.Text = currentMaterial.Image;
            //TxtArticul.IsEnabled = false;
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

        }
    }
}
