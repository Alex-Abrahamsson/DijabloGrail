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
    /// Interaction logic for BerserkersPage.xaml
    /// </summary>
    public partial class BerserkersPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.BerserkersScore = Properties.Settings.Default.BerserkersScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.BerserkersScore = Properties.Settings.Default.BerserkersScore - pointsToRemove;
        }

        public void CheckBerserkersSet()
        {
            if (Properties.Settings.Default.Berserk_s_Headgear)
            {
                Berserk_s_Headgear.IsChecked = true;
            }
            if (Properties.Settings.Default.Berserk_s_Haubark)
            {
                Berserk_s_Haubark.IsChecked = true;
            }
            if (Properties.Settings.Default.Berserk_s_Hatchet)
            {
                Berserk_s_Hatchet.IsChecked = true;
            }
        }


        public BerserkersPage()
        {
            InitializeComponent();
            Properties.Settings.Default.BerserkersScore = 0;
            CheckBerserkersSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }




        private void Berserk_s_Headgear_Checked(object sender, RoutedEventArgs e)
        {
            BerserkHead_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(76);
            Properties.Settings.Default.Berserk_s_Headgear = true;
            Properties.Settings.Default.Save();
        }

        private void Berserk_s_Headgear_Unchecked(object sender, RoutedEventArgs e)
        {
            BerserkHead_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(76);
            Properties.Settings.Default.Berserk_s_Headgear = false;
            Properties.Settings.Default.Save();
        }

        private void Berserk_s_Haubark_Checked(object sender, RoutedEventArgs e)
        {
            BerserkArmor_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(84);
            Properties.Settings.Default.Berserk_s_Haubark = true;
            Properties.Settings.Default.Save();
        }

        private void Berserk_s_Haubark_Unchecked(object sender, RoutedEventArgs e)
        {
            BerserkArmor_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(84);
            Properties.Settings.Default.Berserk_s_Haubark = false;
            Properties.Settings.Default.Save();
        }

        private void Berserk_s_Hatchet_Checked(object sender, RoutedEventArgs e)
        {
            BerserkAxe_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(51);
            Properties.Settings.Default.Berserk_s_Hatchet = true;
            Properties.Settings.Default.Save();
        }

        private void Berserk_s_Hatchet_Unchecked(object sender, RoutedEventArgs e)
        {
            BerserkAxe_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(51);
            Properties.Settings.Default.Berserk_s_Hatchet = false;
            Properties.Settings.Default.Save();
        }
    }
}
