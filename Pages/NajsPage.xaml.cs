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
    /// Interaction logic for NajsPage.xaml
    /// </summary>
    public partial class NajsPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.NajsScore = Properties.Settings.Default.NajsScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.NajsScore = Properties.Settings.Default.NajsScore - pointsToRemove;
        }

        public void CheckNajsSet()
        {
            if (Properties.Settings.Default.Naj_s_Circlet)
            {
                Naj_s_Circlet.IsChecked = true;
            }
            if (Properties.Settings.Default.Naj_s_Light_Plate)
            {
                Naj_s_Light_Plate.IsChecked = true;
            }
            if (Properties.Settings.Default.Naj_s_Puzzler)
            {
                Naj_s_Puzzler.IsChecked = true;
            }
        }


        public NajsPage()
        {
            InitializeComponent();
            Properties.Settings.Default.NajsScore = 0;
            CheckNajsSet();
        }

        private void Naj_s_Circlet_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(117);
            Properties.Settings.Default.Naj_s_Circlet = true;
            Properties.Settings.Default.Save();
        }

        private void Naj_s_Circlet_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(117);
            Properties.Settings.Default.Naj_s_Circlet = false;
            Properties.Settings.Default.Save();
        }

        private void Naj_s_Light_Plate_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(566);
            Properties.Settings.Default.Naj_s_Light_Plate = true;
            Properties.Settings.Default.Save();
        }

        private void Naj_s_Light_Plate_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(566);
            Properties.Settings.Default.Naj_s_Light_Plate = false;
            Properties.Settings.Default.Save();
        }

        private void Naj_s_Puzzler_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(561);
            Properties.Settings.Default.Naj_s_Puzzler = true;
            Properties.Settings.Default.Save();
        }

        private void Naj_s_Puzzler_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(561);
            Properties.Settings.Default.Naj_s_Puzzler = false;
            Properties.Settings.Default.Save();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }
    }
}
