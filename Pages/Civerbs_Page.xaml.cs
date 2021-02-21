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
    /// Interaction logic for Civerbs_Page.xaml
    /// </summary>
    public partial class Civerbs_Page : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.CiverbScore = Properties.Settings.Default.CiverbScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.CiverbScore = Properties.Settings.Default.CiverbScore - pointsToRemove;
        }

        public void CheckCiverbsSet()
        {
            if (Properties.Settings.Default.Civerbs_Gudgel)
            {
                Civerbs_Cudgel.IsChecked = true;
            }
            if (Properties.Settings.Default.Civerbs_Icon)
            {
                Civerbs_Icon.IsChecked = true;
            }
            if (Properties.Settings.Default.Civerbs_Ward)
            {
                Civerbs_Ward.IsChecked = true;
            }
        }


        public Civerbs_Page()
        {
            InitializeComponent();
            Properties.Settings.Default.CiverbScore = 0;
            CheckCiverbsSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Civerbs_Cudgel_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(153);
            Properties.Settings.Default.Civerbs_Gudgel = true;
            Properties.Settings.Default.Save();
        }

        private void Civerbs_Cudgel_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(153);
            Properties.Settings.Default.Civerbs_Gudgel = false;
            Properties.Settings.Default.Save();
        }

        private void Civerbs_Icon_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(580);
            Properties.Settings.Default.Civerbs_Icon = true;
            Properties.Settings.Default.Save();
        }

        private void Civerbs_Icon_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(580);
            Properties.Settings.Default.Civerbs_Icon = false;
            Properties.Settings.Default.Save();
        }

        private void Civerbs_Ward_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(100);
            Properties.Settings.Default.Civerbs_Ward = true;
            Properties.Settings.Default.Save();
        }

        private void Civerbs_Ward_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(100);
            Properties.Settings.Default.Civerbs_Ward = false;
            Properties.Settings.Default.Save();
        }
    }
}
