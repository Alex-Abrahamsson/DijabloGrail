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
    /// Interaction logic for DeathsPage.xaml
    /// </summary>
    public partial class DeathsPage : Page
    {


        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.DeathsScore = Properties.Settings.Default.DeathsScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.DeathsScore = Properties.Settings.Default.DeathsScore - pointsToRemove;
        }

        public void CheckDeathsSet()
        {
            if (Properties.Settings.Default.Deaths_Guard)
            {
                Deaths_Hand.IsChecked = true;
            }
            if (Properties.Settings.Default.Deaths_Touch)
            {
                Deaths_Touch.IsChecked = true;
            }
            if (Properties.Settings.Default.Deaths_Hand)
            {
                Deaths_Hand.IsChecked = true;
            }
        }


        public DeathsPage()
        {
            InitializeComponent();
            Properties.Settings.Default.DeathsScore = 0;
            CheckDeathsSet();
        }

        private void Deaths_Touch_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(79);
            Properties.Settings.Default.Deaths_Touch = true;
            Properties.Settings.Default.Save();
        }

        private void Deaths_Touch_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(79);
            Properties.Settings.Default.Deaths_Touch = false;
            Properties.Settings.Default.Save();
        }

        private void Deaths_Hand_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(293);
            Properties.Settings.Default.Deaths_Hand = true;
            Properties.Settings.Default.Save();
        }

        private void Deaths_Hand_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(293);
            Properties.Settings.Default.Deaths_Hand = false;
            Properties.Settings.Default.Save();
        }

        private void Deaths_Guard_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(293);
            Properties.Settings.Default.Deaths_Guard = true;
            Properties.Settings.Default.Save();
        }

        private void Deaths_Guard_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(293);
            Properties.Settings.Default.Deaths_Guard = false;
            Properties.Settings.Default.Save();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }
    }
}
