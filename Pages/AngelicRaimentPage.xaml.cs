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
    /// Interaction logic for AngelicRaimentPage.xaml
    /// </summary>
    public partial class AngelicRaimentPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.AngelicScore = Properties.Settings.Default.AngelicScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.AngelicScore = Properties.Settings.Default.AngelicScore - pointsToRemove;
        }

        public void CheckAngelicSet()
        {
            if (Properties.Settings.Default.Angelic_Mantle)
            {
                Angelic_Mantle.IsChecked = true;
            }
            if (Properties.Settings.Default.Angelic_Sickle)
            {
                Angelic_Sickle.IsChecked = true;
            }
            if (Properties.Settings.Default.Angelic_Halo)
            {
                Angelic_Halo.IsChecked = true;
            }
            if (Properties.Settings.Default.Angelic_Wings)
            {
                Angelic_Wings.IsChecked = true;
            }
        }
        public AngelicRaimentPage()
        {
            InitializeComponent();
            Properties.Settings.Default.AngelicScore = 0;
            CheckAngelicSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Angelic_Mantle_Checked(object sender, RoutedEventArgs e)
        {
            Angelic_Mantle_Pic.Opacity = 1;
            AddPoints(100);
            Properties.Settings.Default.Angelic_Mantle = true;
            Properties.Settings.Default.Save();
        }

        private void Angelic_Mantle_Unchecked(object sender, RoutedEventArgs e)
        {
            Angelic_Mantle_Pic.Opacity = 0.5;
            RemovePoints(100);
            Properties.Settings.Default.Angelic_Mantle = false;
            Properties.Settings.Default.Save();
        }

        private void Angelic_Mantle_Pic_MouseEnter(object sender, MouseEventArgs e)
        {
            Angelic_Mantel_stats.Visibility = Visibility.Visible;
        }

        private void Angelic_Mantle_Pic_MouseLeave(object sender, MouseEventArgs e)
        {
            Angelic_Mantel_stats.Visibility = Visibility.Hidden;
        }



        private void Angelic_Sickle_Checked(object sender, RoutedEventArgs e)
        {
            Angelic_Sickle_Pic.Opacity = 1;
            AddPoints(83);
            Properties.Settings.Default.Angelic_Sickle = true;
            Properties.Settings.Default.Save();
        }

        private void Angelic_Sickle_Unchecked(object sender, RoutedEventArgs e)
        {
            Angelic_Sickle_Pic.Opacity = 0.5;
            RemovePoints(83);
            Properties.Settings.Default.Angelic_Sickle = false;
            Properties.Settings.Default.Save();
        }

        private void Angelic_Sickle_Pic_MouseEnter(object sender, MouseEventArgs e)
        {
            Angelic_Sickle_Stats.Visibility = Visibility.Visible;
        }

        private void Angelic_Sickle_Pic_MouseLeave(object sender, MouseEventArgs e)
        {
            Angelic_Sickle_Stats.Visibility = Visibility.Hidden;
        }



        private void Angelic_Halo_Checked(object sender, RoutedEventArgs e)
        {
            Angelic_Halo_Pic.Opacity = 1;
            AddPoints(161);
            Properties.Settings.Default.Angelic_Halo = true;
            Properties.Settings.Default.Save();
        }

        private void Angelic_Halo_Unchecked(object sender, RoutedEventArgs e)
        {
            Angelic_Halo_Pic.Opacity = 0.5;
            RemovePoints(161);
            Properties.Settings.Default.Angelic_Halo = false;
            Properties.Settings.Default.Save();
        }

        private void Angelic_Halo_Pic_MouseEnter(object sender, MouseEventArgs e)
        {
            Angelic_Halo_Stats.Visibility = Visibility.Visible;
        }

        private void Angelic_Halo_Pic_MouseLeave(object sender, MouseEventArgs e)
        {
            Angelic_Halo_Stats.Visibility = Visibility.Hidden;
        }



        private void Angelic_Wings_Checked(object sender, RoutedEventArgs e)
        {
            Angelic_Wings_Pic.Opacity = 1;
            AddPoints(580);
            Properties.Settings.Default.Angelic_Wings = true;
            Properties.Settings.Default.Save();
        }

        private void Angelic_Wings_Unchecked(object sender, RoutedEventArgs e)
        {
            Angelic_Wings_Pic.Opacity = 0.5;
            RemovePoints(580);
            Properties.Settings.Default.Angelic_Wings = false;
            Properties.Settings.Default.Save();
        }

        private void Angelic_Wings_Pic_MouseEnter(object sender, MouseEventArgs e)
        {
            Angelic_Wings_Stats.Visibility = Visibility.Visible;
        }

        private void Angelic_Wings_Pic_MouseLeave(object sender, MouseEventArgs e)
        {
            Angelic_Wings_Stats.Visibility = Visibility.Hidden;
        }
    }
}
