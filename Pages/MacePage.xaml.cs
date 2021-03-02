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
    /// Interaction logic for MacePage.xaml
    /// </summary>
    public partial class MacePage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.MaceScore = Properties.Settings.Default.MaceScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.MaceScore = Properties.Settings.Default.MaceScore - pointsToRemove;
        }

        public void CheckMaces()
        {
            if (Properties.Settings.Default.Felloak)
            {
                Felloak.IsChecked = true;
            }
            if (Properties.Settings.Default.Stoutnail)
            {
                Stoutnail.IsChecked = true;
            }
            if (Properties.Settings.Default.Crushflange)
            {
                Crushflange.IsChecked = true;
            }
            if (Properties.Settings.Default.Bloodrise)
            {
                Bloodrise.IsChecked = true;
            }
            if (Properties.Settings.Default.The_General_s_Tan_Do_Li_Ga)
            {
                The_General_s_Tan_Do_Li_Ga.IsChecked = true;
            }
            if (Properties.Settings.Default.Ironstone)
            {
                Ironstone.IsChecked = true;
            }
            if (Properties.Settings.Default.Bonesnap)
            {
                Bonesnap.IsChecked = true;
            }
            if (Properties.Settings.Default.Steeldriver)
            {
                Steeldriver.IsChecked = true;
            }
            if (Properties.Settings.Default.Dark_Clan_Crusher)
            {
                Dark_Clan_Crusher.IsChecked = true;
            }
            if (Properties.Settings.Default.Fleshrender)
            {
                Fleshrender.IsChecked = true;
            }
            if (Properties.Settings.Default.Sureshrill_Frost)
            {
                Sureshrill_Frost.IsChecked = true;
            }
            if (Properties.Settings.Default.Moonfall)
            {
                Moonfall.IsChecked = true;
            }
            if (Properties.Settings.Default.Baezil_s_Vortex)
            {
                Baezil_s_Vortex.IsChecked = true;
            }
            if (Properties.Settings.Default.Earthshaker)
            {
                Earthshaker.IsChecked = true;
            }
            if (Properties.Settings.Default.Bloodtree_Stump)
            {
                Bloodtree_Stump.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Gavel_Of_Pain)
            {
                The_Gavel_Of_Pain.IsChecked = true;
            }
            if (Properties.Settings.Default.Nord_s_Tenderizer)
            {
                Nord_s_Tenderizer.IsChecked = true;
            }
            if (Properties.Settings.Default.Demon_Limb)
            {
                Demon_Limb.IsChecked = true;
            }
            if (Properties.Settings.Default.Baranar_s_Star)
            {
                Baranar_s_Star.IsChecked = true;
            }
            if (Properties.Settings.Default.Horizon_s_Tornado)
            {
                Horizon_s_Tornado.IsChecked = true;
            }
            if (Properties.Settings.Default.Stormlash)
            {
                Stormlash.IsChecked = true;
            }
            if (Properties.Settings.Default.Stone_Crusher)
            {
                Stone_Crusher.IsChecked = true;
            }
            if (Properties.Settings.Default.Schaefer_s_Hammer)
            {
                Schaefer_s_Hammer.IsChecked = true;
            }
            if (Properties.Settings.Default.Windhammer)
            {
                Windhammer.IsChecked = true;
            }
            if (Properties.Settings.Default.Earth_Shifter)
            {
                Earth_Shifter.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Cranium_Basher)
            {
                The_Cranium_Basher.IsChecked = true;
            }
        }


        public MacePage()
        {
            InitializeComponent();
            Properties.Settings.Default.MaceScore = 0;
            CheckMaces();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Felloak_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1050);
            Properties.Settings.Default.Felloak = true;
            Properties.Settings.Default.Save();
        }

        private void Felloak_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1050);
            Properties.Settings.Default.Felloak = false;
            Properties.Settings.Default.Save();
        }

        private void Stoutnail_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(236);
            Properties.Settings.Default.Stoutnail = true;
            Properties.Settings.Default.Save();
        }

        private void Stoutnail_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(236);
            Properties.Settings.Default.Stoutnail = false;
            Properties.Settings.Default.Save();
        }

        private void Crushflange_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(110);
            Properties.Settings.Default.Crushflange = true;
            Properties.Settings.Default.Save();
        }

        private void Crushflange_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(110);
            Properties.Settings.Default.Crushflange = false;
            Properties.Settings.Default.Save();
        }

        private void Bloodrise_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(126);
            Properties.Settings.Default.Bloodrise = true;
            Properties.Settings.Default.Save();
        }

        private void Bloodrise_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(126);
            Properties.Settings.Default.Bloodrise = false;
            Properties.Settings.Default.Save();
        }

        private void The_General_s_Tan_Do_Li_Ga_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(141);
            Properties.Settings.Default.The_General_s_Tan_Do_Li_Ga = true;
            Properties.Settings.Default.Save();
        }

        private void The_General_s_Tan_Do_Li_Ga_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(141);
            Properties.Settings.Default.The_General_s_Tan_Do_Li_Ga = false;
            Properties.Settings.Default.Save();
        }

        private void Ironstone_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(195);
            Properties.Settings.Default.Ironstone = true;
            Properties.Settings.Default.Save();
        }

        private void Ironstone_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(195);
            Properties.Settings.Default.Ironstone = false;
            Properties.Settings.Default.Save();
        }

        private void Bonesnap_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(142);
            Properties.Settings.Default.Bonesnap = true;
            Properties.Settings.Default.Save();
        }

        private void Bonesnap_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(142);
            Properties.Settings.Default.Bonesnap = false;
            Properties.Settings.Default.Save();
        }

        private void Steeldriver_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(338);
            Properties.Settings.Default.Steeldriver = true;
            Properties.Settings.Default.Save();
        }

        private void Steeldriver_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(338);
            Properties.Settings.Default.Steeldriver = false;
            Properties.Settings.Default.Save();
        }

        private void Dark_Clan_Crusher_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(238);
            Properties.Settings.Default.Dark_Clan_Crusher = true;
            Properties.Settings.Default.Save();
        }

        private void Dark_Clan_Crusher_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(238);
            Properties.Settings.Default.Dark_Clan_Crusher = false;
            Properties.Settings.Default.Save();
        }

        private void Fleshrender_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(338);
            Properties.Settings.Default.Fleshrender = true;
            Properties.Settings.Default.Save();
        }

        private void Fleshrender_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(338);
            Properties.Settings.Default.Fleshrender = false;
            Properties.Settings.Default.Save();
        }

        private void Sureshrill_Frost_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(359);
            Properties.Settings.Default.Sureshrill_Frost = true;
            Properties.Settings.Default.Save();
        }

        private void Sureshrill_Frost_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(359);
            Properties.Settings.Default.Sureshrill_Frost = false;
            Properties.Settings.Default.Save();
        }

        private void Moonfall_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(531);
            Properties.Settings.Default.Moonfall = true;
            Properties.Settings.Default.Save();
        }

        private void Moonfall_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(531);
            Properties.Settings.Default.Moonfall = false;
            Properties.Settings.Default.Save();
        }

        private void Baezil_s_Vortex_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(581);
            Properties.Settings.Default.Baezil_s_Vortex = true;
            Properties.Settings.Default.Save();
        }

        private void Baezil_s_Vortex_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(581);
            Properties.Settings.Default.Baezil_s_Vortex = false;
            Properties.Settings.Default.Save();
        }

        private void Earthshaker_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(598);
            Properties.Settings.Default.Earthshaker = true;
            Properties.Settings.Default.Save();
        }

        private void Earthshaker_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(598);
            Properties.Settings.Default.Earthshaker = false;
            Properties.Settings.Default.Save();
        }

        private void Bloodtree_Stump_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(584);
            Properties.Settings.Default.Bloodtree_Stump = true;
            Properties.Settings.Default.Save();
        }

        private void Bloodtree_Stump_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(584);
            Properties.Settings.Default.Bloodtree_Stump = false;
            Properties.Settings.Default.Save();
        }

        private void The_Gavel_Of_Pain_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(548);
            Properties.Settings.Default.The_Gavel_Of_Pain = true;
            Properties.Settings.Default.Save();
        }

        private void The_Gavel_Of_Pain_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(548);
            Properties.Settings.Default.The_Gavel_Of_Pain = false;
            Properties.Settings.Default.Save();
        }

        private void Nord_s_Tenderizer_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(618);
            Properties.Settings.Default.Nord_s_Tenderizer = true;
            Properties.Settings.Default.Save();
        }

        private void Nord_s_Tenderizer_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(618);
            Properties.Settings.Default.Nord_s_Tenderizer = false;
            Properties.Settings.Default.Save();
        }

        private void Demon_Limb_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(450);
            Properties.Settings.Default.Demon_Limb = true;
            Properties.Settings.Default.Save();
        }

        private void Demon_Limb_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(450);
            Properties.Settings.Default.Demon_Limb = false;
            Properties.Settings.Default.Save();
        }

        private void Baranar_s_Star_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(581);
            Properties.Settings.Default.Baranar_s_Star = true;
            Properties.Settings.Default.Save();
        }

        private void Baranar_s_Star_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(581);
            Properties.Settings.Default.Baranar_s_Star = false;
            Properties.Settings.Default.Save();
        }

        private void Horizon_s_Tornado_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1231);
            Properties.Settings.Default.Horizon_s_Tornado = true;
            Properties.Settings.Default.Save();
        }

        private void Horizon_s_Tornado_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1231);
            Properties.Settings.Default.Horizon_s_Tornado = false;
            Properties.Settings.Default.Save();
        }

        private void Stormlash_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(6155);
            Properties.Settings.Default.Stormlash = true;
            Properties.Settings.Default.Save();
        }

        private void Stormlash_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(6155);
            Properties.Settings.Default.Stormlash = false;
            Properties.Settings.Default.Save();
        }

        private void Stone_Crusher_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1447);
            Properties.Settings.Default.Stone_Crusher = true;
            Properties.Settings.Default.Save();
        }

        private void Stone_Crusher_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1447);
            Properties.Settings.Default.Stone_Crusher = false;
            Properties.Settings.Default.Save();
        }

        private void Schaefer_s_Hammer_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(5789);
            Properties.Settings.Default.Schaefer_s_Hammer = true;
            Properties.Settings.Default.Save();
        }

        private void Schaefer_s_Hammer_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(5789);
            Properties.Settings.Default.Schaefer_s_Hammer = false;
            Properties.Settings.Default.Save();
        }

        private void Windhammer_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(446);
            Properties.Settings.Default.Windhammer = true;
            Properties.Settings.Default.Save();
        }

        private void Windhammer_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(446);
            Properties.Settings.Default.Windhammer = false;
            Properties.Settings.Default.Save();
        }

        private void Earth_Shifter_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(29131);
            Properties.Settings.Default.Earth_Shifter = true;
            Properties.Settings.Default.Save();
        }

        private void Earth_Shifter_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(29131);
            Properties.Settings.Default.Earth_Shifter = false;
            Properties.Settings.Default.Save();
        }

        private void The_Cranium_Basher_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(29131);
            Properties.Settings.Default.The_Cranium_Basher = true;
            Properties.Settings.Default.Save();
        }

        private void The_Cranium_Basher_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(29131);
            Properties.Settings.Default.The_Cranium_Basher = false;
            Properties.Settings.Default.Save();
        }
    }
}
