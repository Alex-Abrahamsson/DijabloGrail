using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DijabloGrail.Pages
{
    /// <summary>
    /// Interaction logic for CathansPage.xaml
    /// </summary>
    public partial class CathansPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.CatansScore = Properties.Settings.Default.CatansScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.CatansScore = Properties.Settings.Default.CatansScore - pointsToRemove;
        }

        public void CheckCathansSet()
        {
            if (Properties.Settings.Default.Cathans_Visage)
            {
                Cathan_s_Visage.IsChecked = true;
            }
            if (Properties.Settings.Default.Cathans_Mesh)
            {
                Cathan_s_Mesh.IsChecked = true;
            }
            if (Properties.Settings.Default.Cathans_Rule)
            {
                Cathan_s_Rule.IsChecked = true;
            }
            if (Properties.Settings.Default.Cathans_Sigil)
            {
                Cathan_s_Sigil.IsChecked = true;
            }
            if (Properties.Settings.Default.Cathans_Seal)
            {
                Cathan_s_Seal.IsChecked = true;
            }
        }
        public CathansPage()
        {
            InitializeComponent();
            Properties.Settings.Default.CatansScore = 0;
            CheckCathansSet();
        }

        private void Cathan_s_Visage_Checked(object sender, RoutedEventArgs e)
        {
            CathansHead_pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(84);
            Properties.Settings.Default.Cathans_Visage = true;
            Properties.Settings.Default.Save();
        }

        private void Cathan_s_Visage_Unchecked(object sender, RoutedEventArgs e)
        {
            CathansHead_pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(84);
            Properties.Settings.Default.Cathans_Visage = false;
            Properties.Settings.Default.Save();
        }

        private void Cathan_s_Mesh_Checked(object sender, RoutedEventArgs e)
        {
            CathansMesh_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(51);
            Properties.Settings.Default.Cathans_Mesh = true;
            Properties.Settings.Default.Save();
        }

        private void Cathan_s_Mesh_Unchecked(object sender, RoutedEventArgs e)
        {
            CathansMesh_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(51);
            Properties.Settings.Default.Cathans_Mesh = false;
            Properties.Settings.Default.Save();
        }

        private void Cathan_s_Rule_Checked(object sender, RoutedEventArgs e)
        {
            CathansRule_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(160);
            Properties.Settings.Default.Cathans_Rule = true;
            Properties.Settings.Default.Save();
        }

        private void Cathan_s_Rule_Unchecked(object sender, RoutedEventArgs e)
        {
            CathansRule_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(160);
            Properties.Settings.Default.Cathans_Rule = false;
            Properties.Settings.Default.Save();
        }

        private void Cathan_s_Sigil_Checked(object sender, RoutedEventArgs e)
        {
            CathansSigil_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(580);
            Properties.Settings.Default.Cathans_Sigil = true;
            Properties.Settings.Default.Save();
        }

        private void Cathan_s_Sigil_Unchecked(object sender, RoutedEventArgs e)
        {
            CathansSigil_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(580);
            Properties.Settings.Default.Cathans_Sigil = false;
            Properties.Settings.Default.Save();
        }

        private void Cathan_s_Seal_Checked(object sender, RoutedEventArgs e)
        {
            CathansSeal_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(69);
            Properties.Settings.Default.Cathans_Seal = true;
            Properties.Settings.Default.Save();
        }

        private void Cathan_s_Seal_Unchecked(object sender, RoutedEventArgs e)
        {
            CathansSeal_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(69);
            Properties.Settings.Default.Cathans_Seal = false;
            Properties.Settings.Default.Save();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }
    }
}
