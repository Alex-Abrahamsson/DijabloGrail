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
using System.IO;

namespace DijabloGrail
{

    public partial class HelmsPage : Page
    {
        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.HelmScore = Properties.Settings.Default.HelmScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.HelmScore = Properties.Settings.Default.HelmScore - pointsToRemove;
        }
        public void CheckHelmets()
        {
            if (Properties.Settings.Default.Tarnhelm)
            {
                Tarnhelm.IsChecked = true;
            }
            if (Properties.Settings.Default.Coif_of_Glory)
            {
                Coif_of_Glory.IsChecked = true;
            }
            if (Properties.Settings.Default.Biggins_Bonnet)
            {
                BigginsBonnet.IsChecked = true;
            }
            if (Properties.Settings.Default.Duskdeep)
            {
                Duskdeep.IsChecked = true;
            }
            if (Properties.Settings.Default.Howltusk)
            {
                Howltusk.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Face_of_Horror)
            {
                The_Face_of_Horror.IsChecked = true;
            }
            if (Properties.Settings.Default.Undead_Crown)
            {
                Undead_Crown.IsChecked = true;
            }
            if (Properties.Settings.Default.Wormskull)
            {
                Wormskull.IsChecked = true;
            }
            if (Properties.Settings.Default.Peasant_Crown)
            {
                Peasant_Crown.IsChecked = true;
            }
            if (Properties.Settings.Default.Rockstopper)
            {
                Rockstopper.IsChecked = true;
            }
            if (Properties.Settings.Default.Stealskull)
            {
                Stealskull.IsChecked = true;
            }
            if (Properties.Settings.Default.Darksight_Helm)
            {
                Darksight_Helm.IsChecked = true;
            }
            if (Properties.Settings.Default.Valkyrie_Wing)
            {
                Valkyrie_Wing.IsChecked = true;
            }
            if (Properties.Settings.Default.Blackhorns_Face)
            {
                Blackhorn_s_Face.IsChecked = true;
            }
            if (Properties.Settings.Default.Crown_of_Thieves)
            {
                Crown_of_Thieves.IsChecked = true;
            }
            if (Properties.Settings.Default.Vampire_Gaze)
            {
                Vampire_Gaze.IsChecked = true;
            }
            if (Properties.Settings.Default.Harlequin_Crest)
            {
                Harlequin_Crest.IsChecked = true;
            }
            if (Properties.Settings.Default.Steel_Shade)
            {
                Steel_Shade.IsChecked = true;
            }
            if (Properties.Settings.Default.Veil_of_Steel)
            {
                Veil_of_Steel.IsChecked = true;
            }
            if (Properties.Settings.Default.Nightwings_Veil)
            {
                Nightwing_s_Veil.IsChecked = true;
            }
            if (Properties.Settings.Default.Andariels_Visage)
            {
                Andariel_s_Visage.IsChecked = true;
            }
            if (Properties.Settings.Default.Crown_of_Ages)
            {
                Crown_of_Ages.IsChecked = true;
            }
            if (Properties.Settings.Default.Giant_Skull)
            {
                Giant_Skull.IsChecked = true;
            }
            if (Properties.Settings.Default.Kiras_Guardian)
            {
                Kira_s_Guardian.IsChecked = true;
            }
            if (Properties.Settings.Default.Griffons_Eye)
            {
                Griffon_s_Eye.IsChecked = true;
            }
        }


        public HelmsPage()
        {
            InitializeComponent();
            Properties.Settings.Default.HelmScore = 0;
            CheckHelmets();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void BigginsBonnet_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(816);
            Properties.Settings.Default.Biggins_Bonnet = true;
            Properties.Settings.Default.Save();
        }

        private void BigginsBonnet_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(816);
            Properties.Settings.Default.Biggins_Bonnet = false;
            Properties.Settings.Default.Save();
        }

        private void Tarnhelm_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(543);
            Properties.Settings.Default.Tarnhelm = true;
            Properties.Settings.Default.Save();
        }

        private void Tarnhelm_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(543);
            Properties.Settings.Default.Tarnhelm = false;
            Properties.Settings.Default.Save();
        }

        private void Coif_of_Glory_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(250);
            Properties.Settings.Default.Coif_of_Glory = true;
            Properties.Settings.Default.Save();
        }

        private void Coif_of_Glory_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(250);
            Properties.Settings.Default.Coif_of_Glory = false;
            Properties.Settings.Default.Save();
        }

        private void Duskdeep_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(127);
            Properties.Settings.Default.Duskdeep = true;
            Properties.Settings.Default.Save();
        }

        private void Duskdeep_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(127);
            Properties.Settings.Default.Duskdeep = false;
            Properties.Settings.Default.Save();
        }

        private void Howltusk_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(274);
            Properties.Settings.Default.Howltusk = true;
            Properties.Settings.Default.Save();
        }

        private void Howltusk_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(274);
            Properties.Settings.Default.Howltusk = false;
            Properties.Settings.Default.Save();
        }

        private void The_Face_of_Horror_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(229);
            Properties.Settings.Default.The_Face_of_Horror = true;
            Properties.Settings.Default.Save();
        }

        private void The_Face_of_Horror_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(229);
            Properties.Settings.Default.The_Face_of_Horror = false;
            Properties.Settings.Default.Save();
        }

        private void Undead_Crown_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(224);
            Properties.Settings.Default.Undead_Crown = true;
            Properties.Settings.Default.Save();
        }

        private void Undead_Crown_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(224);
            Properties.Settings.Default.Undead_Crown = false;
            Properties.Settings.Default.Save();
        }

        private void Wormskull_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(273);
            Properties.Settings.Default.Wormskull = true;
            Properties.Settings.Default.Save();
        }

        private void Wormskull_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(273);
            Properties.Settings.Default.Wormskull = false;
            Properties.Settings.Default.Save();
        }

        private void Peasant_Crown_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(413);
            Properties.Settings.Default.Peasant_Crown = true;
            Properties.Settings.Default.Save();
        }

        private void Peasant_Crown_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(413);
            Properties.Settings.Default.Peasant_Crown = false;
            Properties.Settings.Default.Save();
        }

        private void Rockstopper_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(715);
            Properties.Settings.Default.Rockstopper = true;
            Properties.Settings.Default.Save();
        }

        private void Rockstopper_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(715);
            Properties.Settings.Default.Rockstopper = false;
            Properties.Settings.Default.Save();
        }

        private void Stealskull_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(854);
            Properties.Settings.Default.Stealskull = true;
            Properties.Settings.Default.Save();
        }

        private void Stealskull_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(854);
            Properties.Settings.Default.Stealskull = false;
            Properties.Settings.Default.Save();
        }

        private void Darksight_Helm_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(926);
            Properties.Settings.Default.Darksight_Helm = true;
            Properties.Settings.Default.Save();
        }

        private void Darksight_Helm_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(926);
            Properties.Settings.Default.Darksight_Helm = false;
            Properties.Settings.Default.Save();
        }

        private void Valkyrie_Wing_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1307);
            Properties.Settings.Default.Valkyrie_Wing = true;
            Properties.Settings.Default.Save();
        }

        private void Valkyrie_Wing_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1307);
            Properties.Settings.Default.Valkyrie_Wing = false;
            Properties.Settings.Default.Save();
        }

        private void Blackhorn_s_Face_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(438);
            Properties.Settings.Default.Blackhorns_Face = true;
            Properties.Settings.Default.Save();
        }

        private void Blackhorn_s_Face_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(438);
            Properties.Settings.Default.Blackhorns_Face = false;
            Properties.Settings.Default.Save();
        }

        private void Crown_of_Thieves_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(569);
            Properties.Settings.Default.Crown_of_Thieves = true;
            Properties.Settings.Default.Save();
        }

        private void Crown_of_Thieves_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(569);
            Properties.Settings.Default.Crown_of_Thieves = false;
            Properties.Settings.Default.Save();
        }

        private void Vampire_Gaze_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1302);
            Properties.Settings.Default.Vampire_Gaze = true;
            Properties.Settings.Default.Save();
        }

        private void Vampire_Gaze_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1302);
            Properties.Settings.Default.Vampire_Gaze = false;
            Properties.Settings.Default.Save();
        }

        private void Harlequin_Crest_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(711);
            Properties.Settings.Default.Harlequin_Crest = true;
            Properties.Settings.Default.Save();
        }

        private void Harlequin_Crest_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(711);
            Properties.Settings.Default.Harlequin_Crest = false;
            Properties.Settings.Default.Save();
        }

        private void Steel_Shade_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1187);
            Properties.Settings.Default.Steel_Shade = true;
            Properties.Settings.Default.Save();
        }

        private void Steel_Shade_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1187);
            Properties.Settings.Default.Steel_Shade = false;
            Properties.Settings.Default.Save();
        }

        private void Veil_of_Steel_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(2266);
            Properties.Settings.Default.Veil_of_Steel = true;
            Properties.Settings.Default.Save();
        }

        private void Veil_of_Steel_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(2266);
            Properties.Settings.Default.Veil_of_Steel = false;
            Properties.Settings.Default.Save();
        }

        private void Nightwing_s_Veil_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(2266);
            Properties.Settings.Default.Nightwings_Veil = true;
            Properties.Settings.Default.Save();
        }

        private void Nightwing_s_Veil_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(2266);
            Properties.Settings.Default.Nightwings_Veil = false;
            Properties.Settings.Default.Save();
        }

        private void Andariel_s_Visage_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(770);
            Properties.Settings.Default.Andariels_Visage = true;
            Properties.Settings.Default.Save();
        }

        private void Andariel_s_Visage_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(770);
            Properties.Settings.Default.Andariels_Visage = false;
            Properties.Settings.Default.Save();
        }

        private void Crown_of_Ages_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(17802);
            Properties.Settings.Default.Crown_of_Ages = true;
            Properties.Settings.Default.Save();
        }

        private void Crown_of_Ages_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(17802);
            Properties.Settings.Default.Crown_of_Ages = false;
            Properties.Settings.Default.Save();
        }

        private void Giant_Skull_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(2024);
            Properties.Settings.Default.Giant_Skull = true;
            Properties.Settings.Default.Save();
        }

        private void Giant_Skull_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(2024);
            Properties.Settings.Default.Giant_Skull = false;
            Properties.Settings.Default.Save();
        }

        private void Kira_s_Guardian_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(885);
            Properties.Settings.Default.Kiras_Guardian = true;
            Properties.Settings.Default.Save();
        }

        private void Kira_s_Guardian_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(885);
            Properties.Settings.Default.Kiras_Guardian = false;
            Properties.Settings.Default.Save();
        }

        private void Griffon_s_Eye_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(17802);
            Properties.Settings.Default.Griffons_Eye = true;
            Properties.Settings.Default.Save();
        }

        private void Griffon_s_Eye_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(17802);
            Properties.Settings.Default.Griffons_Eye = false;
            Properties.Settings.Default.Save();
        }
    }
}
