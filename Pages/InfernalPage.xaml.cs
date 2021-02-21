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
    /// Interaction logic for InfernalPage.xaml
    /// </summary>
    public partial class InfernalPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.InfernalsScore = Properties.Settings.Default.InfernalsScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.InfernalsScore = Properties.Settings.Default.InfernalsScore - pointsToRemove;
        }

        public void CheckInfernalSet()
        {
            if (Properties.Settings.Default.Infernal_Cranium)
            {
                Infernal_Cranium.IsChecked = true;
            }
            if (Properties.Settings.Default.Infernal_Sign)
            {
                Infernal_Sign.IsChecked = true;
            }
            if (Properties.Settings.Default.Infernal_Torch)
            {
                Infernal_Torch.IsChecked = true;
            }
        }


        public InfernalPage()
        {
            InitializeComponent();
            Properties.Settings.Default.InfernalsScore = 0;
            CheckInfernalSet();
        }

        private void Infernal_Cranium_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(291);
            Properties.Settings.Default.Infernal_Cranium = true;
            Properties.Settings.Default.Save();
        }

        private void Infernal_Cranium_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(291);
            Properties.Settings.Default.Infernal_Cranium = false;
            Properties.Settings.Default.Save();
        }

        private void Infernal_Sign_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(169);
            Properties.Settings.Default.Infernal_Sign = true;
            Properties.Settings.Default.Save();
        }

        private void Infernal_Sign_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(169);
            Properties.Settings.Default.Infernal_Sign = false;
            Properties.Settings.Default.Save();
        }

        private void Infernal_Torch_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(234);
            Properties.Settings.Default.Infernal_Torch = true;
            Properties.Settings.Default.Save();
        }

        private void Infernal_Torch_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(234);
            Properties.Settings.Default.Infernal_Torch = false;
            Properties.Settings.Default.Save();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }
    }
}
