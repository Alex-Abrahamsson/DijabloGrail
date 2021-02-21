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
    /// Interaction logic for Hsarus_Page.xaml
    /// </summary>
    public partial class Hsarus_Page : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.HsarusScore = Properties.Settings.Default.HsarusScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.HsarusScore = Properties.Settings.Default.HsarusScore - pointsToRemove;
        }

        public void CheckHsarusSet()
        {
            if (Properties.Settings.Default.Hsarus_IronFist)
            {
                Hsarus_IronFist.IsChecked = true;
            }
            if (Properties.Settings.Default.Hsarus_IronHeel)
            {
                Hsarus_IronHeel.IsChecked = true;
            }
            if (Properties.Settings.Default.Hsarus_IronStay)
            {
                Hsarus_IronStay.IsChecked = true;
            }
        }


        public Hsarus_Page()
        {
            InitializeComponent();
            Properties.Settings.Default.HsarusScore = 0;
            CheckHsarusSet();
        }

        private void Hsarus_IronFist_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(291);
            Properties.Settings.Default.Hsarus_IronFist = true;
            Properties.Settings.Default.Save();
        }

        private void Hsarus_IronFist_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(291);
            Properties.Settings.Default.Hsarus_IronFist = false;
            Properties.Settings.Default.Save();
        }

        private void Hsarus_IronStay_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(76);
            Properties.Settings.Default.Hsarus_IronStay = true;
            Properties.Settings.Default.Save();
        }

        private void Hsarus_IronStay_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(76);
            Properties.Settings.Default.Hsarus_IronStay = false;
            Properties.Settings.Default.Save();
        }

        private void Hsarus_IronHeel_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(76);
            Properties.Settings.Default.Hsarus_IronHeel = true;
            Properties.Settings.Default.Save();
        }

        private void Hsarus_IronHeel_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(76);
            Properties.Settings.Default.Hsarus_IronHeel = false;
            Properties.Settings.Default.Save();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }
    }
}
