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
    /// Interaction logic for ClassitemPage.xaml
    /// </summary>
    public partial class ClassitemPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.ClassItemScore = Properties.Settings.Default.ClassItemScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.ClassItemScore = Properties.Settings.Default.ClassItemScore - pointsToRemove;
        }

        public void CheckClassItems()
        {
            if (Properties.Settings.Default.Stoneraven)
            {
                Stoneraven.IsChecked = true;
            }
            if (Properties.Settings.Default.Lycander_s_Flank)
            {
                Lycander_s_Flank.IsChecked = true;
            }
            if (Properties.Settings.Default.Lycander_s_Aim)
            {
                Lycander_s_Aim.IsChecked = true;
            }
            if (Properties.Settings.Default.Titan_s_Revenge)
            {
                Titan_s_Revenge.IsChecked = true;
            }
            if (Properties.Settings.Default.Thunderstroke)
            {
                Thunderstroke.IsChecked = true;
            }
            if (Properties.Settings.Default.Blood_Raven_s_Charge)
            {
                Blood_Raven_s_Charge.IsChecked = true;
            }
            if (Properties.Settings.Default.Shadow_Killer)
            {
                Shadow_Killer.IsChecked = true;
            }
            if (Properties.Settings.Default.Bartuc_s_Cut_Throat)
            {
                Bartuc_s_Cut_Throat.IsChecked = true;
            }
            if (Properties.Settings.Default.Jade_Talon)
            {
                Jade_Talon.IsChecked = true;
            }
            if (Properties.Settings.Default.Firelizard_s_Talons)
            {
                Firelizard_s_Talons.IsChecked = true;
            }
            if (Properties.Settings.Default.Jalal_s_Mane)
            {
                Jalal_s_Mane.IsChecked = true;
            }
            if (Properties.Settings.Default.Cerebus__Bite)
            {
                Cerebus__Bite.IsChecked = true;
            }
            if (Properties.Settings.Default.Ravenlore)
            {
                Ravenlore.IsChecked = true;
            }
            if (Properties.Settings.Default.Spirit_Keeper)
            {
                Spirit_Keeper.IsChecked = true;
            }
            if (Properties.Settings.Default.Arreat_s_Face)
            {
                Arreat_s_Face.IsChecked = true;
            }
            if (Properties.Settings.Default.Wolfhowl)
            {
                Wolfhowl.IsChecked = true;
            }
            if (Properties.Settings.Default.Demonhorn_s_Edge)
            {
                Demonhorn_s_Edge.IsChecked = true;
            }
            if (Properties.Settings.Default.Halaberd_s_Reign)
            {
                Halaberd_s_Reign.IsChecked = true;
            }
            if (Properties.Settings.Default.Homunculus)
            {
                Homunculus.IsChecked = true;
            }
            if (Properties.Settings.Default.Darkforce_Spawn)
            {
                Darkforce_Spawn.IsChecked = true;
            }
            if (Properties.Settings.Default.Boneflame)
            {
                Boneflame.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Oculus)
            {
                The_Oculus.IsChecked = true;
            }
            if (Properties.Settings.Default.Eschuta_s_Temper)
            {
                Eschuta_s_Temper.IsChecked = true;
            }
            if (Properties.Settings.Default.Death_s_Fathom)
            {
                Death_s_Fathom.IsChecked = true;
            }
            if (Properties.Settings.Default.Alma_Negra)
            {
                Alma_Negra.IsChecked = true;
            }
            if (Properties.Settings.Default.Herald_Of_Zakarum)
            {
                Herald_Of_Zakarum.IsChecked = true;
            }
            if (Properties.Settings.Default.Dragonscale)
            {
                Dragonscale.IsChecked = true;
            }

        }


        public ClassitemPage()
        {
            InitializeComponent();
            Properties.Settings.Default.ClassItemScore = 0;
            CheckClassItems();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }




        private void Stoneraven_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1052);
            Properties.Settings.Default.Stoneraven = true;
            Properties.Settings.Default.Save();
        }

        private void Stoneraven_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1052);
            Properties.Settings.Default.Stoneraven = false;
            Properties.Settings.Default.Save();
        }

        private void Lycander_s_Flank_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1113);
            Properties.Settings.Default.Lycander_s_Flank = true;
            Properties.Settings.Default.Save();
        }

        private void Lycander_s_Flank_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1113);
            Properties.Settings.Default.Lycander_s_Flank = false;
            Properties.Settings.Default.Save();
        }

        private void Lycander_s_Aim_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1092);
            Properties.Settings.Default.Lycander_s_Aim = true;
            Properties.Settings.Default.Save();
        }

        private void Lycander_s_Aim_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1092);
            Properties.Settings.Default.Lycander_s_Aim = false;
            Properties.Settings.Default.Save();
        }

        private void Titan_s_Revenge_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(667);
            Properties.Settings.Default.Titan_s_Revenge = true;
            Properties.Settings.Default.Save();
        }

        private void Titan_s_Revenge_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(667);
            Properties.Settings.Default.Titan_s_Revenge = false;
            Properties.Settings.Default.Save();
        }

        private void Thunderstroke_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(809);
            Properties.Settings.Default.Thunderstroke = true;
            Properties.Settings.Default.Save();
        }

        private void Thunderstroke_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(809);
            Properties.Settings.Default.Thunderstroke = false;
            Properties.Settings.Default.Save();
        }

        private void Blood_Raven_s_Charge_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1164);
            Properties.Settings.Default.Blood_Raven_s_Charge = true;
            Properties.Settings.Default.Save();
        }

        private void Blood_Raven_s_Charge_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1164);
            Properties.Settings.Default.Blood_Raven_s_Charge = false;
            Properties.Settings.Default.Save();
        }

        private void Shadow_Killer_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(430);
            Properties.Settings.Default.Shadow_Killer = true;
            Properties.Settings.Default.Save();
        }

        private void Shadow_Killer_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(430);
            Properties.Settings.Default.Shadow_Killer = false;
            Properties.Settings.Default.Save();
        }

        private void Bartuc_s_Cut_Throat_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(556);
            Properties.Settings.Default.Bartuc_s_Cut_Throat = true;
            Properties.Settings.Default.Save();
        }

        private void Bartuc_s_Cut_Throat_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(556);
            Properties.Settings.Default.Bartuc_s_Cut_Throat = false;
            Properties.Settings.Default.Save();
        }

        private void Jade_Talon_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(526);
            Properties.Settings.Default.Jade_Talon = true;
            Properties.Settings.Default.Save();
        }

        private void Jade_Talon_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(526);
            Properties.Settings.Default.Jade_Talon = false;
            Properties.Settings.Default.Save();
        }

        private void Firelizard_s_Talons_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(951);
            Properties.Settings.Default.Firelizard_s_Talons = true;
            Properties.Settings.Default.Save();
        }

        private void Firelizard_s_Talons_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(951);
            Properties.Settings.Default.Firelizard_s_Talons = false;
            Properties.Settings.Default.Save();
        }

        private void Jalal_s_Mane_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1053);
            Properties.Settings.Default.Jalal_s_Mane = true;
            Properties.Settings.Default.Save();
        }

        private void Jalal_s_Mane_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1053);
            Properties.Settings.Default.Jalal_s_Mane = false;
            Properties.Settings.Default.Save();
        }

        private void Cerebus__Bite_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1912);
            Properties.Settings.Default.Cerebus__Bite = true;
            Properties.Settings.Default.Save();
        }

        private void Cerebus__Bite_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1912);
            Properties.Settings.Default.Cerebus__Bite = false;
            Properties.Settings.Default.Save();
        }

        private void Ravenlore_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(3705);
            Properties.Settings.Default.Ravenlore = true;
            Properties.Settings.Default.Save();
        }

        private void Ravenlore_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(3705);
            Properties.Settings.Default.Ravenlore = false;
            Properties.Settings.Default.Save();
        }

        private void Spirit_Keeper_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(2602);
            Properties.Settings.Default.Spirit_Keeper = true;
            Properties.Settings.Default.Save();
        }

        private void Spirit_Keeper_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(2602);
            Properties.Settings.Default.Spirit_Keeper = false;
            Properties.Settings.Default.Save();
        }

        private void Arreat_s_Face_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1688);
            Properties.Settings.Default.Arreat_s_Face = true;
            Properties.Settings.Default.Save();
        }

        private void Arreat_s_Face_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1688);
            Properties.Settings.Default.Arreat_s_Face = false;
            Properties.Settings.Default.Save();
        }

        private void Wolfhowl_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1258);
            Properties.Settings.Default.Wolfhowl = true;
            Properties.Settings.Default.Save();
        }

        private void Wolfhowl_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1258);
            Properties.Settings.Default.Wolfhowl = false;
            Properties.Settings.Default.Save();
        }

        private void Demonhorn_s_Edge_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1417);
            Properties.Settings.Default.Demonhorn_s_Edge = true;
            Properties.Settings.Default.Save();
        }

        private void Demonhorn_s_Edge_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1417);
            Properties.Settings.Default.Demonhorn_s_Edge = false;
            Properties.Settings.Default.Save();
        }

        private void Halaberd_s_Reign_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1906);
            Properties.Settings.Default.Halaberd_s_Reign = true;
            Properties.Settings.Default.Save();
        }

        private void Halaberd_s_Reign_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1906);
            Properties.Settings.Default.Halaberd_s_Reign = false;
            Properties.Settings.Default.Save();
        }

        private void Homunculus_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1688);
            Properties.Settings.Default.Homunculus = true;
            Properties.Settings.Default.Save();
        }

        private void Homunculus_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1688);
            Properties.Settings.Default.Homunculus = false;
            Properties.Settings.Default.Save();
        }

        private void Darkforce_Spawn_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(32682);
            Properties.Settings.Default.Darkforce_Spawn = true;
            Properties.Settings.Default.Save();
        }

        private void Darkforce_Spawn_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(32682);
            Properties.Settings.Default.Darkforce_Spawn = false;
            Properties.Settings.Default.Save();
        }

        private void Boneflame_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(2095);
            Properties.Settings.Default.Boneflame = true;
            Properties.Settings.Default.Save();
        }

        private void Boneflame_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(2095);
            Properties.Settings.Default.Boneflame = false;
            Properties.Settings.Default.Save();
        }

        private void The_Oculus_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1113);
            Properties.Settings.Default.The_Oculus = true;
            Properties.Settings.Default.Save();
        }

        private void The_Oculus_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1113);
            Properties.Settings.Default.The_Oculus = false;
            Properties.Settings.Default.Save();
        }

        private void Eschuta_s_Temper_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(825);
            Properties.Settings.Default.Eschuta_s_Temper = true;
            Properties.Settings.Default.Save();
        }

        private void Eschuta_s_Temper_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(825);
            Properties.Settings.Default.Eschuta_s_Temper = false;
            Properties.Settings.Default.Save();
        }

        private void Death_s_Fathom_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(26740);
            Properties.Settings.Default.Death_s_Fathom = true;
            Properties.Settings.Default.Save();
        }

        private void Death_s_Fathom_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(26740);
            Properties.Settings.Default.Death_s_Fathom = false;
            Properties.Settings.Default.Save();
        }

        private void Alma_Negra_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1639);
            Properties.Settings.Default.Alma_Negra = true;
            Properties.Settings.Default.Save();
        }

        private void Alma_Negra_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1639);
            Properties.Settings.Default.Alma_Negra = false;
            Properties.Settings.Default.Save();
        }

        private void Herald_Of_Zakarum_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(2419);
            Properties.Settings.Default.Herald_Of_Zakarum = true;
            Properties.Settings.Default.Save();
        }

        private void Herald_Of_Zakarum_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(2419);
            Properties.Settings.Default.Herald_Of_Zakarum = false;
            Properties.Settings.Default.Save();
        }

        private void Dragonscale_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(3705);
            Properties.Settings.Default.Dragonscale = true;
            Properties.Settings.Default.Save();
        }

        private void Dragonscale_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(3705);
            Properties.Settings.Default.Dragonscale = false;
            Properties.Settings.Default.Save();
        }
    }
}
