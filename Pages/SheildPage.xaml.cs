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
    /// Interaction logic for SheildPage.xaml
    /// </summary>
    public partial class SheildPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.SheildScore = Properties.Settings.Default.SheildScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.SheildScore = Properties.Settings.Default.SheildScore - pointsToRemove;
        }

        public void CheckShields()
        {
            if (Properties.Settings.Default.Pelta_Lunata)
            {
                Pelta_Lunata.IsChecked = true;
            }
            if (Properties.Settings.Default.Umbral_Disk)
            {
                Umbral_Disk.IsChecked = true;
            }
            if (Properties.Settings.Default.Stormguild)
            {
                Stormguild.IsChecked = true;
            }
            if (Properties.Settings.Default.Steelclash)
            {
                Steelclash.IsChecked = true;
            }
            if (Properties.Settings.Default.Swordback_Hold)
            {
                Swordback_Hold.IsChecked = true;
            }
            if (Properties.Settings.Default.Bverrit_Keep)
            {
                Bverrit_Keep.IsChecked = true;
            }
            if (Properties.Settings.Default.Wall_of_the_Eyeless)
            {
                Wall_of_the_Eyeless.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Ward)
            {
                The_Ward.IsChecked = true;
            }
            if (Properties.Settings.Default.Visceratuant)
            {
                Visceratuant.IsChecked = true;
            }
            if (Properties.Settings.Default.Mosers_Blessed_Circle)
            {
                Mosers_Blessed_Circle.IsChecked = true;
            }
            if (Properties.Settings.Default.Stormchaser)
            {
                Stormchaser.IsChecked = true;
            }
            if (Properties.Settings.Default.Tiamatas_Rebuke)
            {
                Tiamatas_Rebuke.IsChecked = true;
            }
            if (Properties.Settings.Default.Lance_Guard)
            {
                Lance_Guard.IsChecked = true;
            }
            if (Properties.Settings.Default.Gerkes_Sanctuary)
            {
                Gerkes_Sanctuary.IsChecked = true;
            }
            if (Properties.Settings.Default.Lidless_Wall)
            {
                Lidless_Wall.IsChecked = true;
            }
            if (Properties.Settings.Default.Radaments_Sphere)
            {
                Radaments_Sphere.IsChecked = true;
            }
            if (Properties.Settings.Default.Blackoak_Shield)
            {
                Blackoak_Shield.IsChecked = true;
            }
            if (Properties.Settings.Default.Stormshield)
            {
                Stormshield.IsChecked = true;
            }
            if (Properties.Settings.Default.Spike_Thorn)
            {
                Spike_Thorn.IsChecked = true;
            }
            if (Properties.Settings.Default.Medusas_Gaze)
            {
                Medusas_Gaze.IsChecked = true;
            }
            if (Properties.Settings.Default.Head_Hunters_Glory)
            {
                Head_Hunters_Glory.IsChecked = true;
            }
            if (Properties.Settings.Default.Spirit_Ward)
            {
                Spirit_Ward.IsChecked = true;
            }
        }

        public SheildPage()
        {
            InitializeComponent();
            Properties.Settings.Default.SheildScore = 0;
            CheckShields();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }
        //-------------------------------------------------------------------------------------------------------------------------
        private void Pelta_Lunata_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(816);
            Properties.Settings.Default.Pelta_Lunata = true;
            Properties.Settings.Default.Save();
        }

        private void Pelta_Lunata_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(816);
            Properties.Settings.Default.Pelta_Lunata = false;
            Properties.Settings.Default.Save();
        }

        private void Umbral_Disk_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(257);
            Properties.Settings.Default.Umbral_Disk = true;
            Properties.Settings.Default.Save();
        }

        private void Umbral_Disk_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(257);
            Properties.Settings.Default.Umbral_Disk = false;
            Properties.Settings.Default.Save();
        }

        private void Stormguild_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(250);
            Properties.Settings.Default.Stormguild = true;
            Properties.Settings.Default.Save();
        }

        private void Stormguild_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(250);
            Properties.Settings.Default.Stormguild = false;
            Properties.Settings.Default.Save();
        }

        private void Steelclash_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(127);
            Properties.Settings.Default.Steelclash = true;
            Properties.Settings.Default.Save();
        }

        private void Steelclash_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(127);
            Properties.Settings.Default.Steelclash = false;
            Properties.Settings.Default.Save();
        }

        private void Swordback_Hold_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(250);
            Properties.Settings.Default.Swordback_Hold = true;
            Properties.Settings.Default.Save();
        }

        private void Swordback_Hold_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(250);
            Properties.Settings.Default.Swordback_Hold = false;
            Properties.Settings.Default.Save();
        }

        private void Bverrit_Keep_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(250);
            Properties.Settings.Default.Bverrit_Keep = true;
            Properties.Settings.Default.Save();
        }

        private void Bverrit_Keep_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(250);
            Properties.Settings.Default.Bverrit_Keep = false;
            Properties.Settings.Default.Save();
        }

        private void Wall_of_the_Eyeless_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(229);
            Properties.Settings.Default.Wall_of_the_Eyeless = true;
            Properties.Settings.Default.Save();
        }

        private void Wall_of_the_Eyeless_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(229);
            Properties.Settings.Default.Wall_of_the_Eyeless = false;
            Properties.Settings.Default.Save();
        }

        private void The_Ward_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(224);
            Properties.Settings.Default.The_Ward = true;
            Properties.Settings.Default.Save();
        }

        private void The_Ward_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(224);
            Properties.Settings.Default.The_Ward = false;
            Properties.Settings.Default.Save();
        }

        private void Visceratuant_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(413);
            Properties.Settings.Default.Visceratuant = true;
            Properties.Settings.Default.Save();
        }

        private void Visceratuant_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(413);
            Properties.Settings.Default.Visceratuant = false;
            Properties.Settings.Default.Save();
        }

        private void Mosers_Blessed_Circle_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(715);
            Properties.Settings.Default.Mosers_Blessed_Circle = true;
            Properties.Settings.Default.Save();
        }

        private void Mosers_Blessed_Circle_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(715);
            Properties.Settings.Default.Mosers_Blessed_Circle = false;
            Properties.Settings.Default.Save();
        }

        private void Stormchaser_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(854);
            Properties.Settings.Default.Stormchaser = true;
            Properties.Settings.Default.Save();
        }

        private void Stormchaser_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(854);
            Properties.Settings.Default.Stormchaser = false;
            Properties.Settings.Default.Save();
        }

        private void Tiamatas_Rebuke_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(926);
            Properties.Settings.Default.Tiamatas_Rebuke = true;
            Properties.Settings.Default.Save();
        }

        private void Tiamatas_Rebuke_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(926);
            Properties.Settings.Default.Tiamatas_Rebuke = false;
            Properties.Settings.Default.Save();
        }

        private void Lance_Guard_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(854);
            Properties.Settings.Default.Lance_Guard = true;
            Properties.Settings.Default.Save();
        }

        private void Lance_Guard_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(854);
            Properties.Settings.Default.Lance_Guard = false;
            Properties.Settings.Default.Save();
        }

        private void Gerkes_Sanctuary_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1302);
            Properties.Settings.Default.Gerkes_Sanctuary = true;
            Properties.Settings.Default.Save();
        }

        private void Gerkes_Sanctuary_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1302);
            Properties.Settings.Default.Gerkes_Sanctuary = false;
            Properties.Settings.Default.Save();
        }

        private void Lidless_Wall_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(438);
            Properties.Settings.Default.Lidless_Wall = true;
            Properties.Settings.Default.Save();
        }

        private void Lidless_Wall_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(438);
            Properties.Settings.Default.Lidless_Wall = false;
            Properties.Settings.Default.Save();
        }

        private void Radaments_Sphere_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(571);
            Properties.Settings.Default.Radaments_Sphere = true;
            Properties.Settings.Default.Save();
        }

        private void Radaments_Sphere_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(571);
            Properties.Settings.Default.Radaments_Sphere = false;
            Properties.Settings.Default.Save();
        }

        private void Blackoak_Shield_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1027);
            Properties.Settings.Default.Blackoak_Shield = true;
            Properties.Settings.Default.Save();
        }

        private void Blackoak_Shield_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1027);
            Properties.Settings.Default.Blackoak_Shield = false;
            Properties.Settings.Default.Save();
        }

        private void Stormshield_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(890);
            Properties.Settings.Default.Stormshield = true;
            Properties.Settings.Default.Save();
        }

        private void Stormshield_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(890);
            Properties.Settings.Default.Stormshield = false;
            Properties.Settings.Default.Save();
        }

        private void Spike_Thorn_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1187);
            Properties.Settings.Default.Spike_Thorn = true;
            Properties.Settings.Default.Save();
        }

        private void Spike_Thorn_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1187);
            Properties.Settings.Default.Spike_Thorn = false;
            Properties.Settings.Default.Save();
        }

        private void Medusas_Gaze_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1133);
            Properties.Settings.Default.Medusas_Gaze = true;
            Properties.Settings.Default.Save();
        }

        private void Medusas_Gaze_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1133);
            Properties.Settings.Default.Medusas_Gaze = false;
            Properties.Settings.Default.Save();
        }

        private void Head_Hunters_Glory_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1404);
            Properties.Settings.Default.Head_Hunters_Glory = true;
            Properties.Settings.Default.Save();
        }

        private void Head_Hunters_Glory_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1404);
            Properties.Settings.Default.Head_Hunters_Glory = false;
            Properties.Settings.Default.Save();
        }

        private void Spirit_Ward_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(2024);
            Properties.Settings.Default.Spirit_Ward = true;
            Properties.Settings.Default.Save();
        }

        private void Spirit_Ward_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(2024);
            Properties.Settings.Default.Spirit_Ward = false;
            Properties.Settings.Default.Save();
        }
    }
}
