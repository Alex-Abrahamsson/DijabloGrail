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
    /// Interaction logic for ThrowingPage.xaml
    /// </summary>
    public partial class ThrowingPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.ThrowingScore = Properties.Settings.Default.ThrowingScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.ThrowingScore = Properties.Settings.Default.ThrowingScore - pointsToRemove;
        }

        public void CheckThrowing()
        {
            if (Properties.Settings.Default.Deathbit)
            {
                Deathbit.IsChecked = true;
            }
            if (Properties.Settings.Default.TheScalper)
            {
                TheScalper.IsChecked = true;
            }
            if (Properties.Settings.Default.Warshrike)
            {
                Warshrike.IsChecked = true;
            }
            if (Properties.Settings.Default.Gimmershred)
            {
                Gimmershred.IsChecked = true;
            }
            if (Properties.Settings.Default.Lacerator)
            {
                Lacerator.IsChecked = true;
            }
        }


        public ThrowingPage()
        {
            InitializeComponent();
            Properties.Settings.Default.ThrowingScore = 0;
            CheckThrowing();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }




        private void Deathbit_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(337);
            Properties.Settings.Default.Deathbit = true;
            Properties.Settings.Default.Save();
        }

        private void Deathbit_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(337);
            Properties.Settings.Default.Deathbit = false;
            Properties.Settings.Default.Save();
        }

        private void TheScalper_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(411);
            Properties.Settings.Default.TheScalper = true;
            Properties.Settings.Default.Save();
        }

        private void TheScalper_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(411);
            Properties.Settings.Default.TheScalper = false;
            Properties.Settings.Default.Save();
        }

        private void Warshrike_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1029);
            Properties.Settings.Default.Warshrike = true;
            Properties.Settings.Default.Save();
        }

        private void Warshrike_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1029);
            Properties.Settings.Default.Warshrike = false;
            Properties.Settings.Default.Save();
        }

        private void Gimmershred_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(482);
            Properties.Settings.Default.Gimmershred = true;
            Properties.Settings.Default.Save();
        }

        private void Gimmershred_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(482);
            Properties.Settings.Default.Gimmershred = false;
            Properties.Settings.Default.Save();
        }

        private void Lacerator_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(852);
            Properties.Settings.Default.Lacerator = true;
            Properties.Settings.Default.Save();
        }

        private void Lacerator_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(852);
            Properties.Settings.Default.Lacerator = false;
            Properties.Settings.Default.Save();
        }
    }
}
