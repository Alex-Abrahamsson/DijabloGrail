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
    /// Interaction logic for ScepterPage.xaml
    /// </summary>
    public partial class ScepterPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.ScepterScore = Properties.Settings.Default.ScepterScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.ScepterScore = Properties.Settings.Default.ScepterScore - pointsToRemove;
        }

        public void CheckScepters()
        {
            if (Properties.Settings.Default.Knell_Striker)
            {
                Knell_Striker.IsChecked = true;
            }
            if (Properties.Settings.Default.Rusthandle)
            {
                Rusthandle.IsChecked = true;
            }
            if (Properties.Settings.Default.Stormeye)
            {
                Stormeye.IsChecked = true;
            }
            if (Properties.Settings.Default.Zakarum_s_Hand)
            {
                Zakarum_s_Hand.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Fetid_Sprinkler)
            {
                The_Fetid_Sprinkler.IsChecked = true;
            }
            if (Properties.Settings.Default.Hand_of_Blessed_Light)
            {
                Hand_of_Blessed_Light.IsChecked = true;
            }
            if (Properties.Settings.Default.Heaven_s_Light)
            {
                Heaven_s_Light.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Redeemer)
            {
                The_Redeemer.IsChecked = true;
            }
            if (Properties.Settings.Default.Astreon_s_Iron_Ward)
            {
                Astreon_s_Iron_Ward.IsChecked = true;
            }
        }


        public ScepterPage()
        {
            InitializeComponent();
            Properties.Settings.Default.ScepterScore = 0;
            CheckScepters();

        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }



        private void Knell_Striker_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(3165);
            Properties.Settings.Default.Knell_Striker = true;
            Properties.Settings.Default.Save();
        }

        private void Knell_Striker_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(3165);
            Properties.Settings.Default.Knell_Striker = false;
            Properties.Settings.Default.Save();
        }

        private void Rusthandle_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(380);
            Properties.Settings.Default.Rusthandle = true;
            Properties.Settings.Default.Save();
        }

        private void Rusthandle_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(380);
            Properties.Settings.Default.Rusthandle = false;
            Properties.Settings.Default.Save();
        }

        private void Stormeye_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(425);
            Properties.Settings.Default.Stormeye = true;
            Properties.Settings.Default.Save();
        }

        private void Stormeye_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(425);
            Properties.Settings.Default.Stormeye = false;
            Properties.Settings.Default.Save();
        }

        private void Zakarum_s_Hand_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1011);
            Properties.Settings.Default.Zakarum_s_Hand = true;
            Properties.Settings.Default.Save();
        }

        private void Zakarum_s_Hand_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1011);
            Properties.Settings.Default.Zakarum_s_Hand = false;
            Properties.Settings.Default.Save();
        }

        private void The_Fetid_Sprinkler_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(2040);
            Properties.Settings.Default.The_Fetid_Sprinkler = true;
            Properties.Settings.Default.Save();
        }

        private void The_Fetid_Sprinkler_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(2040);
            Properties.Settings.Default.The_Fetid_Sprinkler = false;
            Properties.Settings.Default.Save();
        }

        private void Hand_of_Blessed_Light_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1752);
            Properties.Settings.Default.Hand_of_Blessed_Light = true;
            Properties.Settings.Default.Save();
        }

        private void Hand_of_Blessed_Light_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1752);
            Properties.Settings.Default.Hand_of_Blessed_Light = false;
            Properties.Settings.Default.Save();
        }

        private void Heaven_s_Light_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(3397);
            Properties.Settings.Default.Heaven_s_Light = true;
            Properties.Settings.Default.Save();
        }

        private void Heaven_s_Light_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(3397);
            Properties.Settings.Default.Heaven_s_Light = false;
            Properties.Settings.Default.Save();
        }

        private void The_Redeemer_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(3397);
            Properties.Settings.Default.The_Redeemer = true;
            Properties.Settings.Default.Save();
        }

        private void The_Redeemer_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(3397);
            Properties.Settings.Default.The_Redeemer = false;
            Properties.Settings.Default.Save();
        }

        private void Astreon_s_Iron_Ward_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(43696);
            Properties.Settings.Default.Astreon_s_Iron_Ward = true;
            Properties.Settings.Default.Save();
        }

        private void Astreon_s_Iron_Ward_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(43696);
            Properties.Settings.Default.Astreon_s_Iron_Ward = false;
            Properties.Settings.Default.Save();
        }
    }
}
