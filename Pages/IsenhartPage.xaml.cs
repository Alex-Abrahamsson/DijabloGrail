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
    /// Interaction logic for IsenhartPage.xaml
    /// </summary>
    public partial class IsenhartPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.IsenheartScore = Properties.Settings.Default.IsenheartScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.IsenheartScore = Properties.Settings.Default.IsenheartScore - pointsToRemove;
        }

        public void CheckIsenhartSet()
        {
            if (Properties.Settings.Default.Isenhart_s_Case)
            {
                Isenhart_s_Case.IsChecked = true;
            }
            if (Properties.Settings.Default.Isenhart_s_Horns)
            {
                Isenhart_s_Horns.IsChecked = true;
            }
            if (Properties.Settings.Default.Isenhart_s_Lightbrand)
            {
                Isenhart_s_Lightbrand.IsChecked = true;
            }
            if (Properties.Settings.Default.Isenhart_s_Parry)
            {
                Isenhart_s_Parry.IsChecked = true;
            }
        }


        public IsenhartPage()
        {
            InitializeComponent();
            Properties.Settings.Default.IsenheartScore = 0;
            CheckIsenhartSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Isenhart_s_Lightbrand_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(51);
            Properties.Settings.Default.Isenhart_s_Lightbrand = true;
            Properties.Settings.Default.Save();
        }

        private void Isenhart_s_Lightbrand_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(51);
            Properties.Settings.Default.Isenhart_s_Lightbrand = false;
            Properties.Settings.Default.Save();
        }

        private void Isenhart_s_Horns_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(55);
            Properties.Settings.Default.Isenhart_s_Horns = true;
            Properties.Settings.Default.Save();
        }

        private void Isenhart_s_Horns_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(55);
            Properties.Settings.Default.Isenhart_s_Horns = false;
            Properties.Settings.Default.Save();
        }

        private void Isenhart_s_Case_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(29);
            Properties.Settings.Default.Isenhart_s_Case = true;
            Properties.Settings.Default.Save();
        }

        private void Isenhart_s_Case_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(29);
            Properties.Settings.Default.Isenhart_s_Case = false;
            Properties.Settings.Default.Save();
        }

        private void Isenhart_s_Parry_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(89);
            Properties.Settings.Default.Isenhart_s_Parry = true;
            Properties.Settings.Default.Save();
        }

        private void Isenhart_s_Parry_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(89);
            Properties.Settings.Default.Isenhart_s_Parry = false;
            Properties.Settings.Default.Save();
        }
    }
}
