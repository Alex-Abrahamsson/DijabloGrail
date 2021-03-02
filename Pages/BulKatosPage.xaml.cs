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
    /// Interaction logic for BulKatosPage.xaml
    /// </summary>
    public partial class BulKatosPage : Page
    {
        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.BulKatosScore = Properties.Settings.Default.BulKatosScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.BulKatosScore = Properties.Settings.Default.BulKatosScore - pointsToRemove;
        }

        public void CheckBulkathosSet()
        {
            if (Properties.Settings.Default.Bul_Kathos__Tribal_Guardian)
            {
                Bul_Kathos__Tribal_Guardian.IsChecked = true;
            }
            if (Properties.Settings.Default.Bul_Kathos__Sacred_Charge)
            {
                Bul_Kathos__Sacred_Charge.IsChecked = true;
            }
        }




        public BulKatosPage()
        {
            InitializeComponent();
            Properties.Settings.Default.BulKatosScore = 0;
            CheckBulkathosSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menu = new MenuPage();
            this.NavigationService.Navigate(menu);
        }

        private void Bul_Kathos__Sacred_Charge_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(5826);
            Properties.Settings.Default.Bul_Kathos__Sacred_Charge = true;
            Properties.Settings.Default.Save();
        }

        private void Bul_Kathos__Sacred_Charge_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(5826);
            Properties.Settings.Default.Bul_Kathos__Sacred_Charge = false;
            Properties.Settings.Default.Save();
        }

        private void Bul_Kathos__Tribal_Guardian_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(5826);
            Properties.Settings.Default.Bul_Kathos__Tribal_Guardian = true;
            Properties.Settings.Default.Save();
        }

        private void Bul_Kathos__Tribal_Guardian_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(5826);
            Properties.Settings.Default.Bul_Kathos__Tribal_Guardian = false;
            Properties.Settings.Default.Save();
        }
    }
}
