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
    /// Interaction logic for DaggerPage.xaml
    /// </summary>
    public partial class DaggerPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.DaggerScore = Properties.Settings.Default.DaggerScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.DaggerScore = Properties.Settings.Default.DaggerScore - pointsToRemove;
        }

        public void CheckDaggers()
        {
            if (Properties.Settings.Default.Gull)
            {
                Gull.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Diggler)
            {
                The_Diggler.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Jade_Tan_Do)
            {
                The_Jade_Tan_Do.IsChecked = true;
            }
            if (Properties.Settings.Default.Spectral_Shard)
            {
                Spectral_Shard.IsChecked = true;
            }
            if (Properties.Settings.Default.Spineripper)
            {
                Spineripper.IsChecked = true;
            }
            if (Properties.Settings.Default.Heart_Carver)
            {
                Heart_Carver.IsChecked = true;
            }
            if (Properties.Settings.Default.Blackbog_s_Sharp)
            {
                Blackbog_s_Sharp.IsChecked = true;
            }
            if (Properties.Settings.Default.Stormspike)
            {
                Stormspike.IsChecked = true;
            }
            if (Properties.Settings.Default.Wizardspike)
            {
                Wizardspike.IsChecked = true;
            }
            if (Properties.Settings.Default.Fleshripper)
            {
                Fleshripper.IsChecked = true;
            }
            if (Properties.Settings.Default.Ghostflame)
            {
                Ghostflame.IsChecked = true;
            }

        }
        public DaggerPage()
        {
            InitializeComponent();
            Properties.Settings.Default.DaggerScore = 0;
            CheckDaggers();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Gull_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1055);
            Properties.Settings.Default.Gull = true;
            Properties.Settings.Default.Save();
        }

        private void Gull_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1055);
            Properties.Settings.Default.Gull = false;
            Properties.Settings.Default.Save();
        }

        private void The_Diggler_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(280);
            Properties.Settings.Default.The_Diggler = true;
            Properties.Settings.Default.Save();
        }

        private void The_Diggler_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(280);
            Properties.Settings.Default.The_Diggler = false;
            Properties.Settings.Default.Save();
        }

        private void The_Jade_Tan_Do_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(132);
            Properties.Settings.Default.The_Jade_Tan_Do = true;
            Properties.Settings.Default.Save();
        }

        private void The_Jade_Tan_Do_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(132);
            Properties.Settings.Default.The_Jade_Tan_Do = false;
            Properties.Settings.Default.Save();
        }

        private void Spectral_Shard_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(187);
            Properties.Settings.Default.Spectral_Shard = true;
            Properties.Settings.Default.Save();
        }

        private void Spectral_Shard_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(187);
            Properties.Settings.Default.Spectral_Shard = false;
            Properties.Settings.Default.Save();
        }

        private void Spineripper_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(337);
            Properties.Settings.Default.Spineripper = true;
            Properties.Settings.Default.Save();
        }

        private void Spineripper_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(337);
            Properties.Settings.Default.Spineripper = false;
            Properties.Settings.Default.Save();
        }

        private void Heart_Carver_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(360);
            Properties.Settings.Default.Heart_Carver = true;
            Properties.Settings.Default.Save();
        }

        private void Heart_Carver_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(360);
            Properties.Settings.Default.Heart_Carver = false;
            Properties.Settings.Default.Save();
        }

        private void Blackbog_s_Sharp_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(683);
            Properties.Settings.Default.Blackbog_s_Sharp = true;
            Properties.Settings.Default.Save();
        }

        private void Blackbog_s_Sharp_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(683);
            Properties.Settings.Default.Blackbog_s_Sharp = false;
            Properties.Settings.Default.Save();
        }

        private void Stormspike_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(595);
            Properties.Settings.Default.Stormspike = true;
            Properties.Settings.Default.Save();
        }

        private void Stormspike_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(595);
            Properties.Settings.Default.Stormspike = false;
            Properties.Settings.Default.Save();
        }

        private void Wizardspike_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(398);
            Properties.Settings.Default.Wizardspike = true;
            Properties.Settings.Default.Save();
        }

        private void Wizardspike_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(398);
            Properties.Settings.Default.Wizardspike = false;
            Properties.Settings.Default.Save();
        }

        private void Fleshripper_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1160);
            Properties.Settings.Default.Fleshripper = true;
            Properties.Settings.Default.Save();
        }

        private void Fleshripper_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1160);
            Properties.Settings.Default.Fleshripper = false;
            Properties.Settings.Default.Save();
        }

        private void Ghostflame_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(14565);
            Properties.Settings.Default.Ghostflame = true;
            Properties.Settings.Default.Save();
        }

        private void Ghostflame_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(14565);
            Properties.Settings.Default.Ghostflame = false;
            Properties.Settings.Default.Save();
        }
    }
}
