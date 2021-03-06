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
    /// Interaction logic for PolearmPage.xaml
    /// </summary>
    public partial class PolearmPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.PolearmScore = Properties.Settings.Default.PolearmScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.PolearmScore = Properties.Settings.Default.PolearmScore - pointsToRemove;
        }

        public void CheckPolearm()
        {
            if (Properties.Settings.Default.Dimoak_s_Hew)
            {
                Dimoak_s_Hew.IsChecked = true;
            }
            if (Properties.Settings.Default.Steelgoad)
            {
                Steelgoad.IsChecked = true;
            }
            if (Properties.Settings.Default.Soul_Harvest)
            {
                Soul_Harvest.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Battlebranch)
            {
                The_Battlebranch.IsChecked = true;
            }
            if (Properties.Settings.Default.Woestave)
            {
                Woestave.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Grim_Reaper)
            {
                The_Grim_Reaper.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Meat_Scraper)
            {
                The_Meat_Scraper.IsChecked = true;
            }
            if (Properties.Settings.Default.Blackleach_Blade)
            {
                Blackleach_Blade.IsChecked = true;
            }
            if (Properties.Settings.Default.Athena_s_Wrath)
            {
                Athena_s_Wrath.IsChecked = true;
            }
            if (Properties.Settings.Default.Pierre_Tombale_Couant)
            {
                Pierre_Tombale_Couant.IsChecked = true;
            }
            if (Properties.Settings.Default.Husoldal_Evo)
            {
                Husoldal_Evo.IsChecked = true;
            }
            if (Properties.Settings.Default.Grim_s_Burning_Dead)
            {
                Grim_s_Burning_Dead.IsChecked = true;
            }
            if (Properties.Settings.Default.Bonehew)
            {
                Bonehew.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Reaper_s_Toll)
            {
                The_Reaper_s_Toll.IsChecked = true;
            }
            if (Properties.Settings.Default.Tomb_Reaver)
            {
                Tomb_Reaver.IsChecked = true;
            }
            if (Properties.Settings.Default.Stormspire)
            {
                Stormspire.IsChecked = true;
            }

        }



        public PolearmPage()
        {
            InitializeComponent();
            Properties.Settings.Default.PolearmScore = 0;
            CheckPolearm();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }



        private void Dimoak_s_Hew_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(501);
            Properties.Settings.Default.Dimoak_s_Hew = true;
            Properties.Settings.Default.Save();
        }

        private void Dimoak_s_Hew_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(501);
            Properties.Settings.Default.Dimoak_s_Hew = false;
            Properties.Settings.Default.Save();
        }

        private void Steelgoad_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(155);
            Properties.Settings.Default.Steelgoad = true;
            Properties.Settings.Default.Save();
        }

        private void Steelgoad_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(155);
            Properties.Settings.Default.Steelgoad = false;
            Properties.Settings.Default.Save();
        }

        private void Soul_Harvest_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(127);
            Properties.Settings.Default.Soul_Harvest = true;
            Properties.Settings.Default.Save();
        }

        private void Soul_Harvest_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(127);
            Properties.Settings.Default.Soul_Harvest = false;
            Properties.Settings.Default.Save();
        }

        private void The_Battlebranch_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(142);
            Properties.Settings.Default.The_Battlebranch = true;
            Properties.Settings.Default.Save();
        }

        private void The_Battlebranch_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(142);
            Properties.Settings.Default.The_Battlebranch = false;
            Properties.Settings.Default.Save();
        }

        private void Woestave_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(237);
            Properties.Settings.Default.Woestave = true;
            Properties.Settings.Default.Save();
        }

        private void Woestave_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(237);
            Properties.Settings.Default.Woestave = false;
            Properties.Settings.Default.Save();
        }

        private void The_Grim_Reaper_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(358);
            Properties.Settings.Default.The_Grim_Reaper = true;
            Properties.Settings.Default.Save();
        }

        private void The_Grim_Reaper_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(358);
            Properties.Settings.Default.The_Grim_Reaper = false;
            Properties.Settings.Default.Save();
        }

        private void The_Meat_Scraper_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(338);
            Properties.Settings.Default.The_Meat_Scraper = true;
            Properties.Settings.Default.Save();
        }

        private void The_Meat_Scraper_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(338);
            Properties.Settings.Default.The_Meat_Scraper = false;
            Properties.Settings.Default.Save();
        }

        private void Blackleach_Blade_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(529);
            Properties.Settings.Default.Blackleach_Blade = true;
            Properties.Settings.Default.Save();
        }

        private void Blackleach_Blade_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(529);
            Properties.Settings.Default.Blackleach_Blade = false;
            Properties.Settings.Default.Save();
        }

        private void Athena_s_Wrath_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(680);
            Properties.Settings.Default.Athena_s_Wrath = true;
            Properties.Settings.Default.Save();
        }

        private void Athena_s_Wrath_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(680);
            Properties.Settings.Default.Athena_s_Wrath = false;
            Properties.Settings.Default.Save();
        }

        private void Pierre_Tombale_Couant_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(359);
            Properties.Settings.Default.Pierre_Tombale_Couant = true;
            Properties.Settings.Default.Save();
        }

        private void Pierre_Tombale_Couant_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(359);
            Properties.Settings.Default.Pierre_Tombale_Couant = false;
            Properties.Settings.Default.Save();
        }

        private void Husoldal_Evo_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(601);
            Properties.Settings.Default.Husoldal_Evo = true;
            Properties.Settings.Default.Save();
        }

        private void Husoldal_Evo_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(601);
            Properties.Settings.Default.Husoldal_Evo = false;
            Properties.Settings.Default.Save();
        }

        private void Grim_s_Burning_Dead_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(447);
            Properties.Settings.Default.Grim_s_Burning_Dead = true;
            Properties.Settings.Default.Save();
        }

        private void Grim_s_Burning_Dead_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(447);
            Properties.Settings.Default.Grim_s_Burning_Dead = false;
            Properties.Settings.Default.Save();
        }

        private void Bonehew_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(399);
            Properties.Settings.Default.Bonehew = true;
            Properties.Settings.Default.Save();
        }

        private void Bonehew_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(399);
            Properties.Settings.Default.Bonehew = false;
            Properties.Settings.Default.Save();
        }

        private void The_Reaper_s_Toll_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(582);
            Properties.Settings.Default.The_Reaper_s_Toll = true;
            Properties.Settings.Default.Save();
        }

        private void The_Reaper_s_Toll_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(582);
            Properties.Settings.Default.The_Reaper_s_Toll = false;
            Properties.Settings.Default.Save();
        }

        private void Tomb_Reaver_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(850);
            Properties.Settings.Default.Tomb_Reaver = true;
            Properties.Settings.Default.Save();
        }

        private void Tomb_Reaver_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(850);
            Properties.Settings.Default.Tomb_Reaver = false;
            Properties.Settings.Default.Save();
        }

        private void Stormspire_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(14565);
            Properties.Settings.Default.Stormspire = true;
            Properties.Settings.Default.Save();
        }

        private void Stormspire_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(14565);
            Properties.Settings.Default.Stormspire = false;
            Properties.Settings.Default.Save();
        }
    }
}
