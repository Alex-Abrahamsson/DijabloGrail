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
    /// Interaction logic for TancredsPage.xaml
    /// </summary>
    public partial class TancredsPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.TancredsScore = Properties.Settings.Default.TancredsScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.TancredsScore = Properties.Settings.Default.TancredsScore - pointsToRemove;
        }

        public void CheckTancredSet()
        {
            if (Properties.Settings.Default.Tancred_s_Crowbill)
            {
                Tancred_s_Crowbill.IsChecked = true;
            }
            if (Properties.Settings.Default.Tancred_s_Hobnails)
            {
                Tancred_s_Hobnails.IsChecked = true;
            }
            if (Properties.Settings.Default.Tancred_s_Skull)
            {
                Tancred_s_Skull.IsChecked = true;
            }
            if (Properties.Settings.Default.Tancred_s_Spine)
            {
                Tancred_s_Spine.IsChecked = true;
            }
            if (Properties.Settings.Default.Tancred_s_Weird)
            {
                Tancred_s_Weird.IsChecked = true;
            }
        }


        public TancredsPage()
        {
            InitializeComponent();
            Properties.Settings.Default.TancredsScore = 0;
            CheckTancredSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Tancred_s_Skull_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(109);
            Properties.Settings.Default.Tancred_s_Skull = true;
            Properties.Settings.Default.Save();
        }

        private void Tancred_s_Skull_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(109);
            Properties.Settings.Default.Tancred_s_Skull = false;
            Properties.Settings.Default.Save();
        }

        private void Tancred_s_Spine_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(286);
            Properties.Settings.Default.Tancred_s_Spine = true;
            Properties.Settings.Default.Save();
        }

        private void Tancred_s_Spine_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(286);
            Properties.Settings.Default.Tancred_s_Spine = false;
            Properties.Settings.Default.Save();
        }

        private void Tancred_s_Hobnails_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(1596);
            Properties.Settings.Default.Tancred_s_Hobnails = true;
            Properties.Settings.Default.Save();
        }

        private void Tancred_s_Hobnails_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(1596);
            Properties.Settings.Default.Tancred_s_Hobnails = false;
            Properties.Settings.Default.Save();
        }

        private void Tancred_s_Crowbill_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(56);
            Properties.Settings.Default.Tancred_s_Crowbill = true;
            Properties.Settings.Default.Save();
        }

        private void Tancred_s_Crowbill_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(56);
            Properties.Settings.Default.Tancred_s_Crowbill = false;
            Properties.Settings.Default.Save();
        }

        private void Tancred_s_Weird_Checked(object sender, RoutedEventArgs e)
        {
            Pic5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(622);
            Properties.Settings.Default.Tancred_s_Weird = true;
            Properties.Settings.Default.Save();
        }

        private void Tancred_s_Weird_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(622);
            Properties.Settings.Default.Tancred_s_Weird = false;
            Properties.Settings.Default.Save();
        }
    }
}
