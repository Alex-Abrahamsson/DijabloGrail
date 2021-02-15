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

namespace DijabloGrail
{
    /// <summary>
    /// Interaction logic for CrossbowPage.xaml
    /// </summary>
    public partial class CrossbowPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.CrossbowScore = Properties.Settings.Default.CrossbowScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.CrossbowScore = Properties.Settings.Default.CrossbowScore - pointsToRemove;
        }

        public void CheckCrossbows()
        {
            if (Properties.Settings.Default.Leadcrow)
            {
                Leadcrow.IsChecked = true;
            }
            if (Properties.Settings.Default.Ichorsting)
            {
                Ichorsting.IsChecked = true;
            }
            if (Properties.Settings.Default.Hellcast)
            {
                Hellcast.IsChecked = true;
            }
            if (Properties.Settings.Default.Doomslinger)
            {
                Doomslinger.IsChecked = true;
            }
            if (Properties.Settings.Default.Langer_Briser)
            {
                Langer_Briser.IsChecked = true;
            }
            if (Properties.Settings.Default.Pus_Spitter)
            {
                Pus_Spitter.IsChecked = true;
            }
            if (Properties.Settings.Default.Buriza_Do_Kyanon)
            {
                Buriza_Do_Kyanon.IsChecked = true;
            }
            if (Properties.Settings.Default.Demon_Machine)
            {
                Demon_Machine.IsChecked = true;
            }
            if (Properties.Settings.Default.Hellrack)
            {
                Hellrack.IsChecked = true;
            }
            if (Properties.Settings.Default.Gut_Siphon)
            {
                Gut_Siphon.IsChecked = true;
            }

        }
        public CrossbowPage()
        {
            InitializeComponent();
            Properties.Settings.Default.CrossbowScore = 0;
            CheckCrossbows();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Leadcrow_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(237);
            Properties.Settings.Default.Leadcrow = true;
            Properties.Settings.Default.Save();
        }

        private void Leadcrow_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(237);
            Properties.Settings.Default.Leadcrow = false;
            Properties.Settings.Default.Save();
        }

        private void Ichorsting_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(127);
            Properties.Settings.Default.Ichorsting = true;
            Properties.Settings.Default.Save();
        }

        private void Ichorsting_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(127);
            Properties.Settings.Default.Ichorsting = false;
            Properties.Settings.Default.Save();
        }

        private void Hellcast_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(188);
            Properties.Settings.Default.Hellcast = true;
            Properties.Settings.Default.Save();
        }

        private void Hellcast_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(188);
            Properties.Settings.Default.Hellcast = false;
            Properties.Settings.Default.Save();
        }

        private void Doomslinger_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(338);
            Properties.Settings.Default.Doomslinger = true;
            Properties.Settings.Default.Save();
        }

        private void Doomslinger_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(338);
            Properties.Settings.Default.Doomslinger = false;
            Properties.Settings.Default.Save();
        }

        private void Langer_Briser_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(358);
            Properties.Settings.Default.Langer_Briser = true;
            Properties.Settings.Default.Save();
        }

        private void Langer_Briser_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(358);
            Properties.Settings.Default.Langer_Briser = false;
            Properties.Settings.Default.Save();
        }

        private void Pus_Spitter_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(680);
            Properties.Settings.Default.Pus_Spitter = true;
            Properties.Settings.Default.Save();
        }

        private void Pus_Spitter_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(680);
            Properties.Settings.Default.Pus_Spitter = false;
            Properties.Settings.Default.Save();
        }

        private void Buriza_Do_Kyanon_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(597);
            Properties.Settings.Default.Buriza_Do_Kyanon = true;
            Properties.Settings.Default.Save();
        }

        private void Buriza_Do_Kyanon_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(597);
            Properties.Settings.Default.Buriza_Do_Kyanon = false;
            Properties.Settings.Default.Save();
        }

        private void Demon_Machine_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(549);
            Properties.Settings.Default.Demon_Machine = true;
            Properties.Settings.Default.Save();
        }

        private void Demon_Machine_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(549);
            Properties.Settings.Default.Demon_Machine = false;
            Properties.Settings.Default.Save();
        }

        private void Hellrack_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(469);
            Properties.Settings.Default.Hellrack = true;
            Properties.Settings.Default.Save();
        }

        private void Hellrack_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(469);
            Properties.Settings.Default.Hellrack = false;
            Properties.Settings.Default.Save();
        }

        private void Gut_Siphon_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1164);
            Properties.Settings.Default.Gut_Siphon = true;
            Properties.Settings.Default.Save();
        }

        private void Gut_Siphon_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1164);
            Properties.Settings.Default.Gut_Siphon = false;
            Properties.Settings.Default.Save();
        }
    }
}
