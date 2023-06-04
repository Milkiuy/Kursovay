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
    /// Логика взаимодействия для PracticePage.xaml
    /// </summary>
    public partial class PracticePage : Page
    {
        public static readonly DependencyProperty IsChildeVisibleProperty =
            DependencyProperty.Register("IsChildeVisible", typeof(bool), typeof(Canvas), new PropertyMetadata(true));
        public bool IsChildeVisible
        {
            get { return (bool)GetValue(IsChildeVisibleProperty); }
            set { SetValue(IsChildeVisibleProperty, value); }
        }

        string ingredient;

        public PracticePage()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var potion = new List<string> { };

        }

        private void ArbuzImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                IsChildeVisible = false;
                DragDrop.DoDragDrop(ArbuzImg, new DataObject(DataFormats.Serializable, ArbuzImg), DragDropEffects.Move);
                IsChildeVisible = true;
            }
        }

        private void GlazImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                IsChildeVisible = false;
                DragDrop.DoDragDrop(GlazImg, new DataObject(DataFormats.Serializable, GlazImg), DragDropEffects.Move);
                IsChildeVisible = true;
            }
        }

        private void IgloImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                IsChildeVisible = false;
                DragDrop.DoDragDrop(IgloImg, new DataObject(DataFormats.Serializable, IgloImg), DragDropEffects.Move);
                IsChildeVisible = true;
            }
        }

        private void LapkaImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                IsChildeVisible = false;
                DragDrop.DoDragDrop(LapkaImg, new DataObject(DataFormats.Serializable, LapkaImg), DragDropEffects.Move);
                IsChildeVisible = true;
            }
        }

        private void MarinImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                IsChildeVisible = false;
                DragDrop.DoDragDrop(MarinImg, new DataObject(DataFormats.Serializable, MarinImg), DragDropEffects.Move);
                IsChildeVisible = true;
            }
        }

        private void MembranaImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                IsChildeVisible = false;
                DragDrop.DoDragDrop(MembranaImg, new DataObject(DataFormats.Serializable, MembranaImg), DragDropEffects.Move);
                IsChildeVisible = true;
            }
        }

        private void MorkovImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                IsChildeVisible = false;
                DragDrop.DoDragDrop(MorkovImg, new DataObject(DataFormats.Serializable, MorkovImg), DragDropEffects.Move);
                IsChildeVisible = true;
            }
        }

        private void NarostImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                IsChildeVisible = false;
                DragDrop.DoDragDrop(NarostImg, new DataObject(DataFormats.Serializable, NarostImg), DragDropEffects.Move);
                IsChildeVisible = true;
            }
        }

        private void PansirImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                IsChildeVisible = false;
                DragDrop.DoDragDrop(PansirImg, new DataObject(DataFormats.Serializable, PansirImg), DragDropEffects.Move);
                IsChildeVisible = true;
            }
        }

        private void PoroshokImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                IsChildeVisible = false;
                DragDrop.DoDragDrop(PoroshokImg, new DataObject(DataFormats.Serializable, PoroshokImg), DragDropEffects.Move);
                IsChildeVisible = true;
            }
        }

        private void PylImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                IsChildeVisible = false;
                DragDrop.DoDragDrop(PylImg, new DataObject(DataFormats.Serializable, PylImg), DragDropEffects.Move);
                IsChildeVisible = true;
            }
        }

        private void RedstoneImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                IsChildeVisible = false;
                DragDrop.DoDragDrop(RedstoneImg, new DataObject(DataFormats.Serializable, RedstoneImg), DragDropEffects.Move);
                IsChildeVisible = true;
            }
        }

        private void SaharImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                IsChildeVisible = false;
                DragDrop.DoDragDrop(SaharImg, new DataObject(DataFormats.Serializable, SaharImg), DragDropEffects.Move);
                IsChildeVisible = true;
            }
        }

        private void SgustokImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                IsChildeVisible = false;
                DragDrop.DoDragDrop(SgustokImg, new DataObject(DataFormats.Serializable, SgustokImg), DragDropEffects.Move);
                IsChildeVisible = true;
            }
        }

        private void SlezaImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                IsChildeVisible = false;
                DragDrop.DoDragDrop(SlezaImg, new DataObject(DataFormats.Serializable, SlezaImg), DragDropEffects.Move);
                IsChildeVisible = true;
            }
        }

        private void MainCanvas_DragOver(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(MainCanvas);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);
            }
        }

        private void Sleza_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void Sgustok_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void Sahar_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void Redstone_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void Pyl_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void Poroshok_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void Pansir_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void Narost_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void Morkov_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void Membrana_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void Marin_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void Lapka_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void Iglo_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void Glaz_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void Arbuz_DragLeave(object sender, DragEventArgs e)
        {

        }
    }
}
