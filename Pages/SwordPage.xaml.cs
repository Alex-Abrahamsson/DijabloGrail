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

namespace DijabloGrail.Pages
{
    /// <summary>
    /// Interaction logic for SwordPage.xaml
    /// </summary>
    public partial class SwordPage : Page
    {
        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.SwordScore = Properties.Settings.Default.SwordScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.SwordScore = Properties.Settings.Default.SwordScore - pointsToRemove;
        }

        public void CheckSwords()
        {
            if (Properties.Settings.Default.Rixot_s_Keen)
            {
                Rixot_s_Keen.IsChecked = true;
            }
            if (Properties.Settings.Default.Blood_Crescent)
            {
                Blood_Crescent.IsChecked = true;
            }
            if (Properties.Settings.Default.Skewer_of_Krintiz)
            {
                Skewer_of_Krintiz.IsChecked = true;
            }
            if (Properties.Settings.Default.Gleamscythe)
            {
                Gleamscythe.IsChecked = true;
            }
            if (Properties.Settings.Default.Griswold_s_Edge)
            {
                Griswold_s_Edge.IsChecked = true;
            }
            if (Properties.Settings.Default.Hellplague)
            {
                Hellplague.IsChecked = true;
            }
            if (Properties.Settings.Default.Culwen_s_Point)
            {
                Culwen_s_Point.IsChecked = true;
            }
            if (Properties.Settings.Default.Shadowfang)
            {
                Shadowfang.IsChecked = true;
            }
            if (Properties.Settings.Default.Soulflay)
            {
                Soulflay.IsChecked = true;
            }
            if (Properties.Settings.Default.Kinemil_s_Awl)
            {
                Kinemil_s_Awl.IsChecked = true;
            }
            if (Properties.Settings.Default.Blacktongue)
            {
                Blacktongue.IsChecked = true;
            }
            if (Properties.Settings.Default.Ripsaw)
            {
                Ripsaw.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Patriarch)
            {
                The_Patriarch.IsChecked = true;
            }
            if (Properties.Settings.Default.Bloodletter)
            {
                Bloodletter.IsChecked = true;
            }
            if (Properties.Settings.Default.Coldsteel_Eye)
            {
                Coldsteel_Eye.IsChecked = true;
            }
            if (Properties.Settings.Default.Hexfire)
            {
                Hexfire.IsChecked = true;
            }
            if (Properties.Settings.Default.Blade_Of_Ali_Baba)
            {
                Blade_Of_Ali_Baba.IsChecked = true;
            }
            if (Properties.Settings.Default.Ginther_s_Rift)
            {
                Ginther_s_Rift.IsChecked = true;
            }
            if (Properties.Settings.Default.Headstriker)
            {
                Headstriker.IsChecked = true;
            }
            if (Properties.Settings.Default.Plague_Bearer)
            {
                Plague_Bearer.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Atlantean)
            {
                The_Atlantean.IsChecked = true;
            }
            if (Properties.Settings.Default.Crainte_Vomir)
            {
                Crainte_Vomir.IsChecked = true;
            }
            if (Properties.Settings.Default.Bing_Sz_Wang)
            {
                Bing_Sz_Wang.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Vile_Husk)
            {
                The_Vile_Husk.IsChecked = true;
            }
            if (Properties.Settings.Default.Cloudcrack)
            {
                Cloudcrack.IsChecked = true;
            }
            if (Properties.Settings.Default.Todesfaelle_Flamme)
            {
                Todesfaelle_Flamme.IsChecked = true;
            }
            if (Properties.Settings.Default.Swordguard)
            {
                Swordguard.IsChecked = true;
            }
            if (Properties.Settings.Default.Djinn_Slayer)
            {
                Djinn_Slayer.IsChecked = true;
            }
            if (Properties.Settings.Default.Bloodmoon)
            {
                Bloodmoon.IsChecked = true;
            }
            if (Properties.Settings.Default.Lightsabre)
            {
                Lightsabre.IsChecked = true;
            }
            if (Properties.Settings.Default.Azurewrath)
            {
                Azurewrath.IsChecked = true;
            }
            if (Properties.Settings.Default.Frostwind)
            {
                Frostwind.IsChecked = true;
            }
            if (Properties.Settings.Default.Flamebellow)
            {
                Flamebellow.IsChecked = true;
            }
            if (Properties.Settings.Default.Doombringer)
            {
                Doombringer.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Grandfather)
            {
                The_Grandfather.IsChecked = true;
            }
        }


            public SwordPage()
        {
            InitializeComponent();
            Properties.Settings.Default.SwordScore = 0;
            CheckSwords();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Rixot_s_Keen_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1050);
            Properties.Settings.Default.Rixot_s_Keen = true;
            Properties.Settings.Default.Save();
        }

        private void Rixot_s_Keen_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1050);
            Properties.Settings.Default.Rixot_s_Keen = false;
            Properties.Settings.Default.Save();
        }

        private void Blood_Crescent_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(237);
            Properties.Settings.Default.Blood_Crescent = true;
            Properties.Settings.Default.Save();
        }

        private void Blood_Crescent_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(237);
            Properties.Settings.Default.Blood_Crescent = false;
            Properties.Settings.Default.Save();
        }

        private void Skewer_of_Krintiz_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(208);
            Properties.Settings.Default.Skewer_of_Krintiz = true;
            Properties.Settings.Default.Save();
        }

        private void Skewer_of_Krintiz_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(208);
            Properties.Settings.Default.Skewer_of_Krintiz = false;
            Properties.Settings.Default.Save();
        }

        private void Gleamscythe_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(155);
            Properties.Settings.Default.Gleamscythe = true;
            Properties.Settings.Default.Save();
        }

        private void Gleamscythe_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(155);
            Properties.Settings.Default.Gleamscythe = false;
            Properties.Settings.Default.Save();
        }

        private void Griswold_s_Edge_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(127);
            Properties.Settings.Default.Griswold_s_Edge = true;
            Properties.Settings.Default.Save();
        }

        private void Griswold_s_Edge_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(127);
            Properties.Settings.Default.Griswold_s_Edge = false;
            Properties.Settings.Default.Save();
        }

        private void Hellplague_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(141);
            Properties.Settings.Default.Hellplague = true;
            Properties.Settings.Default.Save();
        }

        private void Hellplague_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(141);
            Properties.Settings.Default.Hellplague = false;
            Properties.Settings.Default.Save();
        }

        private void Culwen_s_Point_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(191);
            Properties.Settings.Default.Culwen_s_Point = true;
            Properties.Settings.Default.Save();
        }

        private void Culwen_s_Point_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(191);
            Properties.Settings.Default.Culwen_s_Point = false;
            Properties.Settings.Default.Save();
        }

        private void Shadowfang_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(155);
            Properties.Settings.Default.Shadowfang = true;
            Properties.Settings.Default.Save();
        }

        private void Shadowfang_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(155);
            Properties.Settings.Default.Shadowfang = false;
            Properties.Settings.Default.Save();
        }

        private void Soulflay_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(132);
            Properties.Settings.Default.Soulflay = true;
            Properties.Settings.Default.Save();
        }

        private void Soulflay_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(132);
            Properties.Settings.Default.Soulflay = false;
            Properties.Settings.Default.Save();
        }

        private void Kinemil_s_Awl_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(142);
            Properties.Settings.Default.Kinemil_s_Awl = true;
            Properties.Settings.Default.Save();
        }

        private void Kinemil_s_Awl_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(142);
            Properties.Settings.Default.Kinemil_s_Awl = false;
            Properties.Settings.Default.Save();
        }

        private void Blacktongue_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(188);
            Properties.Settings.Default.Blacktongue = true;
            Properties.Settings.Default.Save();
        }

        private void Blacktongue_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(188);
            Properties.Settings.Default.Blacktongue = false;
            Properties.Settings.Default.Save();
        }

        private void Ripsaw_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(196);
            Properties.Settings.Default.Ripsaw = true;
            Properties.Settings.Default.Save();
        }

        private void Ripsaw_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(196);
            Properties.Settings.Default.Ripsaw = false;
            Properties.Settings.Default.Save();
        }

        private void The_Patriarch_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(338);
            Properties.Settings.Default.The_Patriarch = true;
            Properties.Settings.Default.Save();
        }

        private void The_Patriarch_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(338);
            Properties.Settings.Default.The_Patriarch = false;
            Properties.Settings.Default.Save();
        }

        private void Bloodletter_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(238);
            Properties.Settings.Default.Bloodletter = true;
            Properties.Settings.Default.Save();
        }

        private void Bloodletter_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(238);
            Properties.Settings.Default.Bloodletter = false;
            Properties.Settings.Default.Save();
        }

        private void Coldsteel_Eye_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(581);
            Properties.Settings.Default.Coldsteel_Eye = true;
            Properties.Settings.Default.Save();
        }

        private void Coldsteel_Eye_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(581);
            Properties.Settings.Default.Coldsteel_Eye = false;
            Properties.Settings.Default.Save();
        }

        private void Hexfire_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(359);
            Properties.Settings.Default.Hexfire = true;
            Properties.Settings.Default.Save();
        }

        private void Hexfire_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(359);
            Properties.Settings.Default.Hexfire = false;
            Properties.Settings.Default.Save();
        }

        private void Blade_Of_Ali_Baba_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(529);
            Properties.Settings.Default.Blade_Of_Ali_Baba = true;
            Properties.Settings.Default.Save();
        }

        private void Blade_Of_Ali_Baba_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(529);
            Properties.Settings.Default.Blade_Of_Ali_Baba = false;
            Properties.Settings.Default.Save();
        }

        private void Ginther_s_Rift_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(529);
            Properties.Settings.Default.Ginther_s_Rift = true;
            Properties.Settings.Default.Save();
        }

        private void Ginther_s_Rift_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(529);
            Properties.Settings.Default.Ginther_s_Rift = false;
            Properties.Settings.Default.Save();
        }

        private void Headstriker_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(680);
            Properties.Settings.Default.Headstriker = true;
            Properties.Settings.Default.Save();
        }

        private void Headstriker_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(680);
            Properties.Settings.Default.Headstriker = false;
            Properties.Settings.Default.Save();
        }

        private void Plague_Bearer_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(583);
            Properties.Settings.Default.Plague_Bearer = true;
            Properties.Settings.Default.Save();
        }

        private void Plague_Bearer_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(583);
            Properties.Settings.Default.Plague_Bearer = false;
            Properties.Settings.Default.Save();
        }

        private void The_Atlantean_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(598);
            Properties.Settings.Default.The_Atlantean = true;
            Properties.Settings.Default.Save();
        }

        private void The_Atlantean_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(598);
            Properties.Settings.Default.The_Atlantean = false;
            Properties.Settings.Default.Save();
        }

        private void Crainte_Vomir_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(529);
            Properties.Settings.Default.Crainte_Vomir = true;
            Properties.Settings.Default.Save();
        }

        private void Crainte_Vomir_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(529);
            Properties.Settings.Default.Crainte_Vomir = false;
            Properties.Settings.Default.Save();
        }

        private void Bing_Sz_Wang_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(683);
            Properties.Settings.Default.Bing_Sz_Wang = true;
            Properties.Settings.Default.Save();
        }

        private void Bing_Sz_Wang_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(683);
            Properties.Settings.Default.Bing_Sz_Wang = false;
            Properties.Settings.Default.Save();
        }

        private void The_Vile_Husk_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(584);
            Properties.Settings.Default.The_Vile_Husk = true;
            Properties.Settings.Default.Save();
        }

        private void The_Vile_Husk_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(584);
            Properties.Settings.Default.The_Vile_Husk = false;
            Properties.Settings.Default.Save();
        }

        private void Cloudcrack_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(598);
            Properties.Settings.Default.Cloudcrack = true;
            Properties.Settings.Default.Save();
        }

        private void Cloudcrack_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(598);
            Properties.Settings.Default.Cloudcrack = false;
            Properties.Settings.Default.Save();
        }

        private void Todesfaelle_Flamme_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(598);
            Properties.Settings.Default.Todesfaelle_Flamme = true;
            Properties.Settings.Default.Save();
        }

        private void Todesfaelle_Flamme_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(598);
            Properties.Settings.Default.Todesfaelle_Flamme = false;
            Properties.Settings.Default.Save();
        }

        private void Swordguard_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(549);
            Properties.Settings.Default.Swordguard = true;
            Properties.Settings.Default.Save();
        }

        private void Swordguard_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(549);
            Properties.Settings.Default.Swordguard = false;
            Properties.Settings.Default.Save();
        }

        private void Djinn_Slayer_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(565);
            Properties.Settings.Default.Djinn_Slayer = true;
            Properties.Settings.Default.Save();
        }

        private void Djinn_Slayer_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(565);
            Properties.Settings.Default.Djinn_Slayer = false;
            Properties.Settings.Default.Save();
        }

        private void Bloodmoon_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(568);
            Properties.Settings.Default.Bloodmoon = true;
            Properties.Settings.Default.Save();
        }

        private void Bloodmoon_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(568);
            Properties.Settings.Default.Bloodmoon = false;
            Properties.Settings.Default.Save();
        }

        private void Lightsabre_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(560);
            Properties.Settings.Default.Lightsabre = true;
            Properties.Settings.Default.Save();
        }

        private void Lightsabre_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(560);
            Properties.Settings.Default.Lightsabre = false;
            Properties.Settings.Default.Save();
        }

        private void Azurewrath_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(2799);
            Properties.Settings.Default.Azurewrath = true;
            Properties.Settings.Default.Save();
        }

        private void Azurewrath_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(2799);
            Properties.Settings.Default.Azurewrath = false;
            Properties.Settings.Default.Save();
        }

        private void Frostwind_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1158);
            Properties.Settings.Default.Frostwind = true;
            Properties.Settings.Default.Save();
        }

        private void Frostwind_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1158);
            Properties.Settings.Default.Frostwind = false;
            Properties.Settings.Default.Save();
        }

        private void Flamebellow_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(582);
            Properties.Settings.Default.Flamebellow = true;
            Properties.Settings.Default.Save();
        }

        private void Flamebellow_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(582);
            Properties.Settings.Default.Flamebellow = false;
            Properties.Settings.Default.Save();
        }

        private void Doombringer_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1029);
            Properties.Settings.Default.Doombringer = true;
            Properties.Settings.Default.Save();
        }

        private void Doombringer_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1029);
            Properties.Settings.Default.Doombringer = false;
            Properties.Settings.Default.Save();
        }

        private void The_Grandfather_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(14565);
            Properties.Settings.Default.The_Grandfather = true;
            Properties.Settings.Default.Save();
        }

        private void The_Grandfather_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(14565);
            Properties.Settings.Default.The_Grandfather = false;
            Properties.Settings.Default.Save();
        }
    }
}
