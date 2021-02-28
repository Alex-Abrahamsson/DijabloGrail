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
    /// Interaction logic for SazabisPage.xaml
    /// </summary>
    public partial class SazabisPage : Page
    {
        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.SazabisScore = Properties.Settings.Default.SazabisScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.SazabisScore = Properties.Settings.Default.SazabisScore - pointsToRemove;
        }

        public void CheckSazabiSet()
        {
            if (Properties.Settings.Default.Sazabi_s_Cobalt_Redeemer)
            {
                Sazabi_s_Cobalt_Redeemer.IsChecked = true;
            }
            if (Properties.Settings.Default.Sazabi_s_Ghost_Liberator)
            {
                Sazabi_s_Ghost_Liberator.IsChecked = true;
            }
            if (Properties.Settings.Default.Sazabi_s_Mental_Sheath)
            {
                Sazabi_s_Mental_Sheath.IsChecked = true;
            }
        }

        public SazabisPage()
        {
            InitializeComponent();
            Properties.Settings.Default.SazabisScore = 0;
            CheckSazabiSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menu = new MenuPage();
            this.NavigationService.Navigate(menu);
        }

        private void Sazabi_s_Mental_Sheath_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(370);
            Properties.Settings.Default.Sazabi_s_Mental_Sheath = true;
            Properties.Settings.Default.Save();
        }

        private void Sazabi_s_Mental_Sheath_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(370);
            Properties.Settings.Default.Sazabi_s_Mental_Sheath = false;
            Properties.Settings.Default.Save();
        }

        private void Sazabi_s_Cobalt_Redeemer_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(464);
            Properties.Settings.Default.Sazabi_s_Cobalt_Redeemer = true;
            Properties.Settings.Default.Save();
        }

        private void Sazabi_s_Cobalt_Redeemer_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(464);
            Properties.Settings.Default.Sazabi_s_Cobalt_Redeemer = false;
            Properties.Settings.Default.Save();
        }

        private void Sazabi_s_Ghost_Liberator_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(563);
            Properties.Settings.Default.Sazabi_s_Ghost_Liberator = true;
            Properties.Settings.Default.Save();
        }

        private void Sazabi_s_Ghost_Liberator_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(563);
            Properties.Settings.Default.Sazabi_s_Ghost_Liberator = false;
            Properties.Settings.Default.Save();
        }
    }
}
