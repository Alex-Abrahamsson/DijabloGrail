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
    /// Interaction logic for SandersPage.xaml
    /// </summary>
    public partial class SandersPage : Page
    {
        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.SandersScore = Properties.Settings.Default.SandersScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.SandersScore = Properties.Settings.Default.SandersScore - pointsToRemove;
        }

        public void CheckSanderSet()
        {
            if (Properties.Settings.Default.Sander_s_Paragon)
            {
                Sander_s_Paragon.IsChecked = true;
            }
            if (Properties.Settings.Default.Sander_s_Superstition)
            {
                Sander_s_Superstition.IsChecked = true;
            }
            if (Properties.Settings.Default.Sander_s_Taboo)
            {
                Sander_s_Taboo.IsChecked = true;
            }
            if (Properties.Settings.Default.Sander_s_Riprap)
            {
                Sander_s_Riprap.IsChecked = true;
            }
        }


        public SandersPage()
        {
            InitializeComponent();
            Properties.Settings.Default.SandersScore = 0;
            CheckSanderSet();
        }

        private void Sander_s_Paragon_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(4871);
            Properties.Settings.Default.Sander_s_Paragon = true;
            Properties.Settings.Default.Save();
        }

        private void Sander_s_Paragon_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(4871);
            Properties.Settings.Default.Sander_s_Paragon = false;
            Properties.Settings.Default.Save();
        }

        private void Sander_s_Superstition_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(159);
            Properties.Settings.Default.Sander_s_Superstition = true;
            Properties.Settings.Default.Save();
        }

        private void Sander_s_Superstition_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(159);
            Properties.Settings.Default.Sander_s_Superstition = false;
            Properties.Settings.Default.Save();
        }

        private void Sander_s_Taboo_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(95);
            Properties.Settings.Default.Sander_s_Taboo = true;
            Properties.Settings.Default.Save();
        }

        private void Sander_s_Taboo_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(95);
            Properties.Settings.Default.Sander_s_Taboo = false;
            Properties.Settings.Default.Save();
        }

        private void Sander_s_Riprap_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(190);
            Properties.Settings.Default.Sander_s_Riprap = true;
            Properties.Settings.Default.Save();
        }

        private void Sander_s_Riprap_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(190);
            Properties.Settings.Default.Sander_s_Riprap = false;
            Properties.Settings.Default.Save();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menu = new MenuPage();
            this.NavigationService.Navigate(menu);
        }
    }
}
