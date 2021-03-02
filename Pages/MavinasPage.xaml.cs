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
    /// Interaction logic for MavinasPage.xaml
    /// </summary>
    public partial class MavinasPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.MavinasScore = Properties.Settings.Default.MavinasScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.MavinasScore = Properties.Settings.Default.MavinasScore - pointsToRemove;
        }

        public void CheckMavinasSet()
        {
            if (Properties.Settings.Default.M_avina_s_True_Sight)
            {
                M_avina_s_True_Sight.IsChecked = true;
            }
            if (Properties.Settings.Default.M_avina_s_Caster)
            {
                M_avina_s_Caster.IsChecked = true;
            }
            if (Properties.Settings.Default.M_avina_s_Embrace)
            {
                M_avina_s_Embrace.IsChecked = true;
            }
            if (Properties.Settings.Default.M_avina_s_Icy_Clutch)
            {
                M_avina_s_Icy_Clutch.IsChecked = true;
            }
            if (Properties.Settings.Default.M_avina_s_Tenet)
            {
                M_avina_s_Tenet.IsChecked = true;
            }
        }


        public MavinasPage()
        {
            InitializeComponent();
            Properties.Settings.Default.MavinasScore = 0;
            CheckMavinasSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void M_avina_s_True_Sight_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(7121);
            Properties.Settings.Default.M_avina_s_True_Sight = true;
            Properties.Settings.Default.Save();
        }

        private void M_avina_s_True_Sight_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(7121);
            Properties.Settings.Default.M_avina_s_True_Sight = false;
            Properties.Settings.Default.Save();
        }

        private void M_avina_s_Caster_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(1042);
            Properties.Settings.Default.M_avina_s_Caster = true;
            Properties.Settings.Default.Save();
        }

        private void M_avina_s_Caster_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(1042);
            Properties.Settings.Default.M_avina_s_Caster = false;
            Properties.Settings.Default.Save();
        }

        private void M_avina_s_Embrace_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(456);
            Properties.Settings.Default.M_avina_s_Embrace = true;
            Properties.Settings.Default.Save();
        }

        private void M_avina_s_Embrace_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(456);
            Properties.Settings.Default.M_avina_s_Embrace = false;
            Properties.Settings.Default.Save();
        }

        private void M_avina_s_Icy_Clutch_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(519);
            Properties.Settings.Default.M_avina_s_Icy_Clutch = true;
            Properties.Settings.Default.Save();
        }

        private void M_avina_s_Icy_Clutch_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(519);
            Properties.Settings.Default.M_avina_s_Icy_Clutch = false;
            Properties.Settings.Default.Save();
        }

        private void M_avina_s_Tenet_Checked(object sender, RoutedEventArgs e)
        {
            Pic5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(287);
            Properties.Settings.Default.M_avina_s_Tenet = true;
            Properties.Settings.Default.Save();
        }

        private void M_avina_s_Tenet_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(287);
            Properties.Settings.Default.M_avina_s_Tenet = false;
            Properties.Settings.Default.Save();
        }
    }
}
