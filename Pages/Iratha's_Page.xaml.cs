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
    /// Interaction logic for Iratha_s_Page.xaml
    /// </summary>
    public partial class Iratha_s_Page : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.IrathasScore = Properties.Settings.Default.IrathasScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.IrathasScore = Properties.Settings.Default.IrathasScore - pointsToRemove;
        }

        public void CheckIrathaSet()
        {
            if (Properties.Settings.Default.Iratha_s_Coil)
            {
                Iratha_s_Coil.IsChecked = true;
            }
            if (Properties.Settings.Default.Iratha_s_Collar)
            {
                Iratha_s_Collar.IsChecked = true;
            }
            if (Properties.Settings.Default.Iratha_s_Cord)
            {
                Iratha_s_Cord.IsChecked = true;
            }
            if (Properties.Settings.Default.Iratha_s_Cuff)
            {
                Iratha_s_Cuff.IsChecked = true;
            }
        }


        public Iratha_s_Page()
        {
            InitializeComponent();
            Properties.Settings.Default.IrathasScore = 0;
            CheckIrathaSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Iratha_s_Coil_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(179);
            Properties.Settings.Default.Iratha_s_Coil = true;
            Properties.Settings.Default.Save();
        }

        private void Iratha_s_Coil_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(179);
            Properties.Settings.Default.Iratha_s_Coil = false;
            Properties.Settings.Default.Save();
        }

        private void Iratha_s_Collar_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(580);
            Properties.Settings.Default.Iratha_s_Collar = true;
            Properties.Settings.Default.Save();
        }

        private void Iratha_s_Collar_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(580);
            Properties.Settings.Default.Iratha_s_Collar = false;
            Properties.Settings.Default.Save();
        }

        private void Iratha_s_Cord_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(169);
            Properties.Settings.Default.Iratha_s_Cord = true;
            Properties.Settings.Default.Save();
        }

        private void Iratha_s_Cord_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(169);
            Properties.Settings.Default.Iratha_s_Cord = false;
            Properties.Settings.Default.Save();
        }

        private void Iratha_s_Cuff_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(169);
            Properties.Settings.Default.Iratha_s_Cuff = true;
            Properties.Settings.Default.Save();
        }

        private void Iratha_s_Cuff_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(169);
            Properties.Settings.Default.Iratha_s_Cuff = false;
            Properties.Settings.Default.Save();
        }
    }
}
