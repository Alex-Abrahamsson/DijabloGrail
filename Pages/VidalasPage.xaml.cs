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
    /// Interaction logic for VidalasPage.xaml
    /// </summary>
    public partial class VidalasPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.VidalasScore = Properties.Settings.Default.VidalasScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.VidalasScore = Properties.Settings.Default.VidalasScore - pointsToRemove;
        }

        public void CheckVidalasSet()
        {
            if (Properties.Settings.Default.Vidala_s_Ambush)
            {
                Vidala_s_Ambush.IsChecked = true;
            }
            if (Properties.Settings.Default.Vidala_s_Barb)
            {
                Vidala_s_Barb.IsChecked = true;
            }
            if (Properties.Settings.Default.Vidala_s_Fetlock)
            {
                Vidala_s_Fetlock.IsChecked = true;
            }
            if (Properties.Settings.Default.Vidala_s_Snare)
            {
                Vidala_s_Snare.IsChecked = true;
            }
        }


        public VidalasPage()
        {
            InitializeComponent();
            Properties.Settings.Default.VidalasScore = 0;
            CheckVidalasSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Vidala_s_Barb_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(69);
            Properties.Settings.Default.Vidala_s_Barb = true;
            Properties.Settings.Default.Save();
        }

        private void Vidala_s_Barb_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(69);
            Properties.Settings.Default.Vidala_s_Barb = false;
            Properties.Settings.Default.Save();
        }

        private void Vidala_s_Ambush_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(1469);
            Properties.Settings.Default.Vidala_s_Ambush = true;
            Properties.Settings.Default.Save();
        }

        private void Vidala_s_Ambush_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(1469);
            Properties.Settings.Default.Vidala_s_Ambush = false;
            Properties.Settings.Default.Save();
        }

        private void Vidala_s_Fetlock_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(84);
            Properties.Settings.Default.Vidala_s_Fetlock = true;
            Properties.Settings.Default.Save();
        }

        private void Vidala_s_Fetlock_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(84);
            Properties.Settings.Default.Vidala_s_Fetlock = false;
            Properties.Settings.Default.Save();
        }

        private void Vidala_s_Snare_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(580);
            Properties.Settings.Default.Vidala_s_Snare = true;
            Properties.Settings.Default.Save();
        }

        private void Vidala_s_Snare_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(580);
            Properties.Settings.Default.Vidala_s_Snare = false;
            Properties.Settings.Default.Save();
        }
    }
}
