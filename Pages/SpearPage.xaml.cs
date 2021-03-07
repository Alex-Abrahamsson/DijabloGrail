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
    /// Interaction logic for SpearPage.xaml
    /// </summary>
    public partial class SpearPage : Page
    {
        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.SpearScore = Properties.Settings.Default.SpearScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.SpearScore = Properties.Settings.Default.SpearScore - pointsToRemove;
        }

        public void CheckSpears()
        {
            if (Properties.Settings.Default.The_Dragon_Chang)
            {
                The_Dragon_Chang.IsChecked = true;
            }
            if (Properties.Settings.Default.Razortine)
            {
                Razortine.IsChecked = true;
            }
            if (Properties.Settings.Default.Bloodthief)
            {
                Bloodthief.IsChecked = true;
            }
            if (Properties.Settings.Default.Lance_of_Yaggai)
            {
                Lance_of_Yaggai.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Tannr_Gorerod)
            {
                The_Tannr_Gorerod.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Impaler)
            {
                The_Impaler.IsChecked = true;
            }
            if (Properties.Settings.Default.Kelpie_Snare)
            {
                Kelpie_Snare.IsChecked = true;
            }
            if (Properties.Settings.Default.Soulfeast_Tine)
            {
                Soulfeast_Tine.IsChecked = true;
            }
            if (Properties.Settings.Default.Hone_Sundan)
            {
                Hone_Sundan.IsChecked = true;
            }
            if (Properties.Settings.Default.Spire_of_Honor)
            {
                Spire_of_Honor.IsChecked = true;
            }
            if (Properties.Settings.Default.Arioc_s_Needle)
            {
                Arioc_s_Needle.IsChecked = true;
            }
            if (Properties.Settings.Default.Viperfork)
            {
                Viperfork.IsChecked = true;
            }
            if (Properties.Settings.Default.Steel_Pillar)
            {
                Steel_Pillar.IsChecked = true;
            }
        }


            public SpearPage()
        {
            InitializeComponent();
            Properties.Settings.Default.SpearScore = 0;
            CheckSpears();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }



        private void The_Dragon_Chang_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(237);
            Properties.Settings.Default.The_Dragon_Chang = true;
            Properties.Settings.Default.Save();
        }

        private void The_Dragon_Chang_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(237);
            Properties.Settings.Default.The_Dragon_Chang = false;
            Properties.Settings.Default.Save();
        }

        private void Razortine_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(208);
            Properties.Settings.Default.Razortine = true;
            Properties.Settings.Default.Save();
        }

        private void Razortine_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(208);
            Properties.Settings.Default.Razortine = false;
            Properties.Settings.Default.Save();
        }

        private void Bloodthief_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(132);
            Properties.Settings.Default.Bloodthief = true;
            Properties.Settings.Default.Save();
        }

        private void Bloodthief_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(132);
            Properties.Settings.Default.Bloodthief = false;
            Properties.Settings.Default.Save();
        }

        private void Lance_of_Yaggai_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(141);
            Properties.Settings.Default.Lance_of_Yaggai = true;
            Properties.Settings.Default.Save();
        }

        private void Lance_of_Yaggai_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(141);
            Properties.Settings.Default.Lance_of_Yaggai = false;
            Properties.Settings.Default.Save();
        }

        private void The_Tannr_Gorerod_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(188);
            Properties.Settings.Default.The_Tannr_Gorerod = true;
            Properties.Settings.Default.Save();
        }

        private void The_Tannr_Gorerod_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(188);
            Properties.Settings.Default.The_Tannr_Gorerod = false;
            Properties.Settings.Default.Save();
        }

        private void The_Impaler_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(338);
            Properties.Settings.Default.The_Impaler = true;
            Properties.Settings.Default.Save();
        }

        private void The_Impaler_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(338);
            Properties.Settings.Default.The_Impaler = false;
            Properties.Settings.Default.Save();
        }

        private void Kelpie_Snare_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(360);
            Properties.Settings.Default.Kelpie_Snare = true;
            Properties.Settings.Default.Save();
        }

        private void Kelpie_Snare_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(360);
            Properties.Settings.Default.Kelpie_Snare = false;
            Properties.Settings.Default.Save();
        }

        private void Soulfeast_Tine_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(681);
            Properties.Settings.Default.Soulfeast_Tine = true;
            Properties.Settings.Default.Save();
        }

        private void Soulfeast_Tine_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(681);
            Properties.Settings.Default.Soulfeast_Tine = false;
            Properties.Settings.Default.Save();
        }

        private void Hone_Sundan_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(583);
            Properties.Settings.Default.Hone_Sundan = true;
            Properties.Settings.Default.Save();
        }

        private void Hone_Sundan_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(583);
            Properties.Settings.Default.Hone_Sundan = false;
            Properties.Settings.Default.Save();
        }

        private void Spire_of_Honor_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(597);
            Properties.Settings.Default.Spire_of_Honor = true;
            Properties.Settings.Default.Save();
        }

        private void Spire_of_Honor_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(597);
            Properties.Settings.Default.Spire_of_Honor = false;
            Properties.Settings.Default.Save();
        }

        private void Arioc_s_Needle_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(262);
            Properties.Settings.Default.Arioc_s_Needle = true;
            Properties.Settings.Default.Save();
        }

        private void Arioc_s_Needle_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(262);
            Properties.Settings.Default.Arioc_s_Needle = false;
            Properties.Settings.Default.Save();
        }

        private void Viperfork_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(467);
            Properties.Settings.Default.Viperfork = true;
            Properties.Settings.Default.Save();
        }

        private void Viperfork_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(467);
            Properties.Settings.Default.Viperfork = false;
            Properties.Settings.Default.Save();
        }

        private void Steel_Pillar_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(14565);
            Properties.Settings.Default.Steel_Pillar = true;
            Properties.Settings.Default.Save();
        }

        private void Steel_Pillar_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(14565);
            Properties.Settings.Default.Steel_Pillar = false;
            Properties.Settings.Default.Save();
        }
    }
}
