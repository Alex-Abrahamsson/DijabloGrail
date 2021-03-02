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
    /// Interaction logic for CowkingsPage.xaml
    /// </summary>
    public partial class CowkingsPage : Page
    {
        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.CowKingsScore = Properties.Settings.Default.CowKingsScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.CowKingsScore = Properties.Settings.Default.CowKingsScore - pointsToRemove;
        }

        public void CheckCowkingsSet()
        {
            if (Properties.Settings.Default.Cow_King_s_Hide)
            {
                Cow_King_s_Hide.IsChecked = true;
            }
            if (Properties.Settings.Default.Cow_King_s_Hooves)
            {
                Cow_King_s_Hooves.IsChecked = true;
            }
            if (Properties.Settings.Default.Cow_King_s_Horns)
            {
                Cow_King_s_Horns.IsChecked = true;
            }
        }

        public CowkingsPage()
        {
            InitializeComponent();
            Properties.Settings.Default.CowKingsScore = 0;
            CheckCowkingsSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menu = new MenuPage();
            this.NavigationService.Navigate(menu);
        }

        private void Cow_King_s_Horns_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(240);
            Properties.Settings.Default.Cow_King_s_Horns = true;
            Properties.Settings.Default.Save();
        }

        private void Cow_King_s_Horns_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(240);
            Properties.Settings.Default.Cow_King_s_Horns = false;
            Properties.Settings.Default.Save();
        }

        private void Cow_King_s_Hide_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(21);
            Properties.Settings.Default.Cow_King_s_Hide = true;
            Properties.Settings.Default.Save();
        }

        private void Cow_King_s_Hide_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(21);
            Properties.Settings.Default.Cow_King_s_Hide = false;
            Properties.Settings.Default.Save();
        }

        private void Cow_King_s_Hooves_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(42);
            Properties.Settings.Default.Cow_King_s_Hooves = true;
            Properties.Settings.Default.Save();
        }

        private void Cow_King_s_Hooves_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(42);
            Properties.Settings.Default.Cow_King_s_Hooves = false;
            Properties.Settings.Default.Save();
        }
    }
}
