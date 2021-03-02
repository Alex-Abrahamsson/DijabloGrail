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
    /// Interaction logic for Artic_Gear_Page.xaml
    /// </summary>
    public partial class Artic_Gear_Page1 : Page
    {
        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.ArticScore = Properties.Settings.Default.ArticScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.ArticScore = Properties.Settings.Default.ArticScore - pointsToRemove;
        }

        public void CheckArcticSet()
        {
            if (Properties.Settings.Default.Arctic_Binding)
            {
                Arctic_Binding.IsChecked = true;
            }
            if (Properties.Settings.Default.Arctic_Furs)
            {
                Arctic_Furs.IsChecked = true;
            }
            if (Properties.Settings.Default.Arctic_Horn)
            {
                Arctic_Horn.IsChecked = true;
            }
            if (Properties.Settings.Default.Arctic_Mitts)
            {
                Arctic_Mitts.IsChecked = true;
            }
        }


        public Artic_Gear_Page1()
        {
            InitializeComponent();
            Properties.Settings.Default.ArticScore = 0;
            CheckArcticSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Arctic_Furs_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(291);
            Properties.Settings.Default.Arctic_Furs = true;
            Properties.Settings.Default.Save();
        }

        private void Arctic_Furs_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(291);
            Properties.Settings.Default.Arctic_Furs = false;
            Properties.Settings.Default.Save();
        }

        private void Arctic_Binding_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(51);
            Properties.Settings.Default.Arctic_Binding = true;
            Properties.Settings.Default.Save();
        }

        private void Arctic_Binding_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(51);
            Properties.Settings.Default.Arctic_Binding = false;
            Properties.Settings.Default.Save();
        }

        private void Arctic_Mitts_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(169);
            Properties.Settings.Default.Arctic_Mitts = true;
            Properties.Settings.Default.Save();
        }

        private void Arctic_Mitts_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(169);
            Properties.Settings.Default.Arctic_Mitts = false;
            Properties.Settings.Default.Save();
        }

        private void Arctic_Horn_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(79);
            Properties.Settings.Default.Arctic_Horn = true;
            Properties.Settings.Default.Save();
        }

        private void Arctic_Horn_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(79);
            Properties.Settings.Default.Arctic_Horn = false;
            Properties.Settings.Default.Save();
        }
    }
}
