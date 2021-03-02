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
    /// Interaction logic for OrphansPage.xaml
    /// </summary>
    public partial class OrphansPage : Page
    {
        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.OrphansScore = Properties.Settings.Default.OrphansScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.OrphansScore = Properties.Settings.Default.OrphansScore - pointsToRemove;
        }

        public void CheckOrphansSet()
        {
            if (Properties.Settings.Default.Guillaume_s_Face)
            {
                Guillaume_s_Face.IsChecked = true;
            }
            if (Properties.Settings.Default.Whitstan_s_Guard)
            {
                Whitstan_s_Guard.IsChecked = true;
            }
            if (Properties.Settings.Default.Magnus__Skin)
            {
                Magnus__Skin.IsChecked = true;
            }
            if (Properties.Settings.Default.Wilhelm_s_Pride)
            {
                Wilhelm_s_Pride.IsChecked = true;
            }
        }


        public OrphansPage()
        {
            InitializeComponent();
            Properties.Settings.Default.OrphansScore = 0;
            CheckOrphansSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Guillaume_s_Face_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(522);
            Properties.Settings.Default.Guillaume_s_Face = true;
            Properties.Settings.Default.Save();
        }

        private void Guillaume_s_Face_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(522);
            Properties.Settings.Default.Guillaume_s_Face = false;
            Properties.Settings.Default.Save();
        }

        private void Whitstan_s_Guard_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(286);
            Properties.Settings.Default.Whitstan_s_Guard = true;
            Properties.Settings.Default.Save();
        }

        private void Whitstan_s_Guard_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(286);
            Properties.Settings.Default.Whitstan_s_Guard = false;
            Properties.Settings.Default.Save();
        }

        private void Magnus__Skin_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(287);
            Properties.Settings.Default.Magnus__Skin = true;
            Properties.Settings.Default.Save();
        }

        private void Magnus__Skin_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(287);
            Properties.Settings.Default.Magnus__Skin = false;
            Properties.Settings.Default.Save();
        }

        private void Wilhelm_s_Pride_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(519);
            Properties.Settings.Default.Wilhelm_s_Pride = true;
            Properties.Settings.Default.Save();
        }

        private void Wilhelm_s_Pride_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(519);
            Properties.Settings.Default.Wilhelm_s_Pride = false;
            Properties.Settings.Default.Save();
        }
    }
}
