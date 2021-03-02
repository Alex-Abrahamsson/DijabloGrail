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
    /// Interaction logic for JewleryPage.xaml
    /// </summary>
    public partial class JewleryPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.JewleryScore = Properties.Settings.Default.JewleryScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.JewleryScore = Properties.Settings.Default.JewleryScore - pointsToRemove;
        }

        public void CheckJewlery()
        {
            if (Properties.Settings.Default.Nagelring)
            {
                Nagelring.IsChecked = true;
            }
            if (Properties.Settings.Default.Manald_Heal)
            {
                Manald_Heal.IsChecked = true;
            }
            if (Properties.Settings.Default.Stone_of_Jordan)
            {
                Stone_of_Jordan.IsChecked = true;
            }
            if (Properties.Settings.Default.Dwarf_Star)
            {
                Dwarf_Star.IsChecked = true;
            }
            if (Properties.Settings.Default.Raven_Frost)
            {
                Raven_Frost.IsChecked = true;
            }
            if (Properties.Settings.Default.Bul_Kathos_Wedding_Band)
            {
                Bul_Kathos__Wedding_Band.IsChecked = true;
            }
            if (Properties.Settings.Default.Carrion_Wind)
            {
                Carrion_Wind.IsChecked = true;
            }
            if (Properties.Settings.Default.Natures_Peace)
            {
                Nature_s_Peace.IsChecked = true;
            }
            if (Properties.Settings.Default.Wisp_Projector)
            {
                Wisp_Projector.IsChecked = true;
            }
            if (Properties.Settings.Default.Nokozan_Relic)
            {
                Nokozan_Relic.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Eye_of_Etlich)
            {
                The_Eye_of_Etlich.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Mahim_Oak_Curio)
            {
                The_Mahim_Oak_Curio.IsChecked = true;
            }
            if (Properties.Settings.Default.Saracens_Chance)
            {
                Saracen_s_Chance.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Cats_Eye)
            {
                The_Cat_s_Eye.IsChecked = true;
            }
            if (Properties.Settings.Default.Crescent_Moon)
            {
                Crescent_Moon.IsChecked = true;
            }
            if (Properties.Settings.Default.Atmas_Scarab)
            {
                Atma_s_Scarab.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Rising_Sun)
            {
                The_Rising_Sun.IsChecked = true;
            }
            if (Properties.Settings.Default.Highlords_Wrath)
            {
                Highlord_s_Wrath.IsChecked = true;
            }
            if (Properties.Settings.Default.Maras_Kaleidoscope)
            {
                Mara_s_Kaleidoscope.IsChecked = true;
            }
            if (Properties.Settings.Default.Seraphs_Hymn)
            {
                Seraph_s_Hymn_.IsChecked = true;
            }
            if (Properties.Settings.Default.Metalgrid)
            {
                Metalgrid.IsChecked = true;
            }
            if (Properties.Settings.Default.Annihilus)
            {
                Annihilus.IsChecked = true;
            }
            if (Properties.Settings.Default.Gheeds_Fortune)
            {
                Gheed_s_Fortune.IsChecked = true;
            }
            if (Properties.Settings.Default.Hellfire_Torch)
            {
                Hellfire_Torch.IsChecked = true;
            }
        }


        public JewleryPage()
        {
            InitializeComponent();
            Properties.Settings.Default.JewleryScore = 0;
            CheckJewlery();

        }

        private void Nagelring_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(144);
            Properties.Settings.Default.Nagelring = true;
            Properties.Settings.Default.Save();
        }

        private void Nagelring_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(144);
            Properties.Settings.Default.Nagelring = false;
            Properties.Settings.Default.Save();
        }

        private void Manald_Heal_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(278);
            Properties.Settings.Default.Manald_Heal = true;
            Properties.Settings.Default.Save();
        }

        private void Manald_Heal_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(278);
            Properties.Settings.Default.Manald_Heal = false;
            Properties.Settings.Default.Save();
        }

        private void Stone_of_Jordan_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(4175);
            Properties.Settings.Default.Stone_of_Jordan = true;
            Properties.Settings.Default.Save();
        }

        private void Stone_of_Jordan_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(4175);
            Properties.Settings.Default.Stone_of_Jordan = false;
            Properties.Settings.Default.Save();
        }

        private void Dwarf_Star_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(676);
            Properties.Settings.Default.Dwarf_Star = true;
            Properties.Settings.Default.Save();
        }

        private void Dwarf_Star_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(676);
            Properties.Settings.Default.Dwarf_Star = false;
            Properties.Settings.Default.Save();
        }

        private void Raven_Frost_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(676);
            Properties.Settings.Default.Raven_Frost = true;
            Properties.Settings.Default.Save();
        }

        private void Raven_Frost_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(676);
            Properties.Settings.Default.Raven_Frost = false;
            Properties.Settings.Default.Save();
        }

        private void Bul_Kathos__Wedding_Band_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(6964);
            Properties.Settings.Default.Bul_Kathos_Wedding_Band = true;
            Properties.Settings.Default.Save();
        }

        private void Bul_Kathos__Wedding_Band_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(6964);
            Properties.Settings.Default.Bul_Kathos_Wedding_Band = false;
            Properties.Settings.Default.Save();
        }

        private void Carrion_Wind_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(2321);
            Properties.Settings.Default.Carrion_Wind = true;
            Properties.Settings.Default.Save();
        }

        private void Carrion_Wind_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(2321);
            Properties.Settings.Default.Carrion_Wind = false;
            Properties.Settings.Default.Save();
        }

        private void Nature_s_Peace_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(2428);
            Properties.Settings.Default.Natures_Peace = true;
            Properties.Settings.Default.Save();
        }

        private void Nature_s_Peace_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(2428);
            Properties.Settings.Default.Natures_Peace = false;
            Properties.Settings.Default.Save();
        }

        private void Wisp_Projector_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(7289);
            Properties.Settings.Default.Wisp_Projector = true;
            Properties.Settings.Default.Save();
        }

        private void Wisp_Projector_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(7289);
            Properties.Settings.Default.Wisp_Projector = false;
            Properties.Settings.Default.Save();
        }

        private void Nokozan_Relic_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(351);
            Properties.Settings.Default.Nokozan_Relic = true;
            Properties.Settings.Default.Save();
        }

        private void Nokozan_Relic_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(351);
            Properties.Settings.Default.Nokozan_Relic = false;
            Properties.Settings.Default.Save();
        }

        private void The_Eye_of_Etlich_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1406);
            Properties.Settings.Default.The_Eye_of_Etlich = true;
            Properties.Settings.Default.Save();
        }

        private void The_Eye_of_Etlich_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1406);
            Properties.Settings.Default.The_Eye_of_Etlich = false;
            Properties.Settings.Default.Save();
        }

        private void The_Mahim_Oak_Curio_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(943);
            Properties.Settings.Default.The_Mahim_Oak_Curio = true;
            Properties.Settings.Default.Save();
        }

        private void The_Mahim_Oak_Curio_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(943);
            Properties.Settings.Default.The_Mahim_Oak_Curio = false;
            Properties.Settings.Default.Save();
        }

        private void Saracen_s_Chance_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(2119);
            Properties.Settings.Default.Saracens_Chance = true;
            Properties.Settings.Default.Save();
        }

        private void Saracen_s_Chance_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(2119);
            Properties.Settings.Default.Saracens_Chance = false;
            Properties.Settings.Default.Save();
        }

        private void The_Cat_s_Eye_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(3126);
            Properties.Settings.Default.The_Cats_Eye = true;
            Properties.Settings.Default.Save();
        }

        private void The_Cat_s_Eye_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(3126);
            Properties.Settings.Default.The_Cats_Eye = false;
            Properties.Settings.Default.Save();
        }

        private void Crescent_Moon_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(3126);
            Properties.Settings.Default.Crescent_Moon = true;
            Properties.Settings.Default.Save();
        }

        private void Crescent_Moon_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(3126);
            Properties.Settings.Default.Crescent_Moon = false;
            Properties.Settings.Default.Save();
        }

        private void Atma_s_Scarab_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(3409);
            Properties.Settings.Default.Atmas_Scarab = true;
            Properties.Settings.Default.Save();
        }

        private void Atma_s_Scarab_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(3409);
            Properties.Settings.Default.Atmas_Scarab = false;
            Properties.Settings.Default.Save();
        }

        private void The_Rising_Sun_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(3444);
            Properties.Settings.Default.The_Rising_Sun = true;
            Properties.Settings.Default.Save();
        }

        private void The_Rising_Sun_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(3444);
            Properties.Settings.Default.The_Rising_Sun = false;
            Properties.Settings.Default.Save();
        }

        private void Highlord_s_Wrath_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(3444);
            Properties.Settings.Default.Highlords_Wrath = true;
            Properties.Settings.Default.Save();
        }

        private void Highlord_s_Wrath_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(3444);
            Properties.Settings.Default.Highlords_Wrath = false;
            Properties.Settings.Default.Save();
        }

        private void Mara_s_Kaleidoscope_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(3703);
            Properties.Settings.Default.Maras_Kaleidoscope = true;
            Properties.Settings.Default.Save();
        }

        private void Mara_s_Kaleidoscope_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(3703);
            Properties.Settings.Default.Maras_Kaleidoscope = false;
            Properties.Settings.Default.Save();
        }

        private void Seraph_s_Hymn__Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(5740);
            Properties.Settings.Default.Seraphs_Hymn = true;
            Properties.Settings.Default.Save();
        }

        private void Seraph_s_Hymn__Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(5740);
            Properties.Settings.Default.Seraphs_Hymn = false;
            Properties.Settings.Default.Save();
        }

        private void Metalgrid_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(9259);
            Properties.Settings.Default.Metalgrid = true;
            Properties.Settings.Default.Save();
        }

        private void Metalgrid_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(9259);
            Properties.Settings.Default.Metalgrid = false;
            Properties.Settings.Default.Save();
        }

        private void Annihilus_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(10000);
            Properties.Settings.Default.Annihilus = true;
            Properties.Settings.Default.Save();
        }

        private void Annihilus_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(10000);
            Properties.Settings.Default.Annihilus = false;
            Properties.Settings.Default.Save();
        }

        private void Gheed_s_Fortune_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(494);
            Properties.Settings.Default.Gheeds_Fortune = true;
            Properties.Settings.Default.Save();
        }

        private void Gheed_s_Fortune_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(494);
            Properties.Settings.Default.Gheeds_Fortune = false;
            Properties.Settings.Default.Save();
        }

        private void Hellfire_Torch_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(10000);
            Properties.Settings.Default.Hellfire_Torch = true;
            Properties.Settings.Default.Save();
        }

        private void Hellfire_Torch_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(10000);
            Properties.Settings.Default.Hellfire_Torch = false;
            Properties.Settings.Default.Save();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }
    }
}
