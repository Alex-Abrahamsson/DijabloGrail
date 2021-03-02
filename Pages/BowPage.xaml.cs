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
    /// Interaction logic for BowPage.xaml
    /// </summary>
    public partial class BowPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.BowScore = Properties.Settings.Default.BowScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.BowScore = Properties.Settings.Default.BowScore - pointsToRemove;
        }

        public void CheckBows()
        {
            if (Properties.Settings.Default.Pluckeye)
            {
                Pluckeye.IsChecked = true;
            }
            if (Properties.Settings.Default.Witherstring)
            {
                Witherstring.IsChecked = true;
            }
            if (Properties.Settings.Default.Raven_Claw)
            {
                Raven_Claw.IsChecked = true;
            }
            if (Properties.Settings.Default.Rogue_Bow)
            {
                Rogue_s_Bow.IsChecked = true;
            }
            if (Properties.Settings.Default.Stormstrike)
            {
                Stormstrike.IsChecked = true;
            }
            if (Properties.Settings.Default.Wizendraw)
            {
                Wizendraw.IsChecked = true;
            }
            if (Properties.Settings.Default.Hellclap)
            {
                Hellclap.IsChecked = true;
            }
            if (Properties.Settings.Default.Blastbark)
            {
                Blastbark.IsChecked = true;
            }
            if (Properties.Settings.Default.Skystrike)
            {
                Skystrike.IsChecked = true;
            }
            if (Properties.Settings.Default.Riphook)
            {
                Riphook.IsChecked = true;
            }
            if (Properties.Settings.Default.Kuko_Shakaku)
            {
                Kuko_Shakaku.IsChecked = true;
            }
            if (Properties.Settings.Default.Endlesshail)
            {
                Endlesshail.IsChecked = true;
            }
            if (Properties.Settings.Default.Witchwild_String)
            {
                Witchwild_String.IsChecked = true;
            }
            if (Properties.Settings.Default.Cliffkiller)
            {
                Cliffkiller.IsChecked = true;
            }
            if (Properties.Settings.Default.Magewrath)
            {
                Magewrath.IsChecked = true;
            }
            if (Properties.Settings.Default.Goldstrike_Arch)
            {
                Goldstrike_Arch.IsChecked = true;
            }
            if (Properties.Settings.Default.Eaglehorn)
            {
                Eaglehorn.IsChecked = true;
            }
            if (Properties.Settings.Default.Widowmaker)
            {
                Widowmaker.IsChecked = true;
            }
            if (Properties.Settings.Default.Windforce)
            {
                Windforce.IsChecked = true;
            }

        }
            public BowPage()
        {
            InitializeComponent();
            Properties.Settings.Default.BowScore = 0;
            CheckBows();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Pluckeye_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1050);
            Properties.Settings.Default.Pluckeye = true;
            Properties.Settings.Default.Save();
        }

        private void Pluckeye_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1050);
            Properties.Settings.Default.Pluckeye = false;
            Properties.Settings.Default.Save();
        }

        private void Witherstring_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(501);
            Properties.Settings.Default.Witherstring = true;
            Properties.Settings.Default.Save();
        }

        private void Witherstring_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(501);
            Properties.Settings.Default.Witherstring = false;
            Properties.Settings.Default.Save();
        }

        private void Raven_Claw_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(208);
            Properties.Settings.Default.Raven_Claw = true;
            Properties.Settings.Default.Save();
        }

        private void Raven_Claw_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(208);
            Properties.Settings.Default.Raven_Claw = false;
            Properties.Settings.Default.Save();
        }

        private void Rogue_s_Bow_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(170);
            Properties.Settings.Default.Rogue_Bow = true;
            Properties.Settings.Default.Save();
        }

        private void Rogue_s_Bow_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(170);
            Properties.Settings.Default.Rogue_Bow = false;
            Properties.Settings.Default.Save();
        }

        private void Stormstrike_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(145);
            Properties.Settings.Default.Stormstrike = true;
            Properties.Settings.Default.Save();
        }

        private void Stormstrike_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(145);
            Properties.Settings.Default.Stormstrike = false;
            Properties.Settings.Default.Save();
        }

        private void Wizendraw_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(187);
            Properties.Settings.Default.Wizendraw = true;
            Properties.Settings.Default.Save();
        }

        private void Wizendraw_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(187);
            Properties.Settings.Default.Wizendraw = false;
            Properties.Settings.Default.Save();
        }

        private void Hellclap_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(196);
            Properties.Settings.Default.Hellclap = true;
            Properties.Settings.Default.Save();
        }

        private void Hellclap_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(196);
            Properties.Settings.Default.Hellclap = false;
            Properties.Settings.Default.Save();
        }

        private void Blastbark_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(337);
            Properties.Settings.Default.Blastbark = true;
            Properties.Settings.Default.Save();
        }

        private void Blastbark_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(337);
            Properties.Settings.Default.Blastbark = false;
            Properties.Settings.Default.Save();
        }

        private void Skystrike_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(238);
            Properties.Settings.Default.Skystrike = true;
            Properties.Settings.Default.Save();
        }

        private void Skystrike_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(238);
            Properties.Settings.Default.Skystrike = false;
            Properties.Settings.Default.Save();
        }

        private void Riphook_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(338);
            Properties.Settings.Default.Riphook = true;
            Properties.Settings.Default.Save();
        }

        private void Riphook_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(338);
            Properties.Settings.Default.Riphook = false;
            Properties.Settings.Default.Save();
        }

        private void Kuko_Shakaku_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(359);
            Properties.Settings.Default.Kuko_Shakaku = true;
            Properties.Settings.Default.Save();
        }

        private void Kuko_Shakaku_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(359);
            Properties.Settings.Default.Kuko_Shakaku = false;
            Properties.Settings.Default.Save();
        }

        private void Endlesshail_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(531);
            Properties.Settings.Default.Endlesshail = true;
            Properties.Settings.Default.Save();
        }

        private void Endlesshail_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(531);
            Properties.Settings.Default.Endlesshail = false;
            Properties.Settings.Default.Save();
        }

        private void Witchwild_String_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(338);
            Properties.Settings.Default.Witchwild_String = true;
            Properties.Settings.Default.Save();
        }

        private void Witchwild_String_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(338);
            Properties.Settings.Default.Witchwild_String = false;
            Properties.Settings.Default.Save();
        }

        private void Cliffkiller_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(595);
            Properties.Settings.Default.Cliffkiller = true;
            Properties.Settings.Default.Save();
        }

        private void Cliffkiller_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(595);
            Properties.Settings.Default.Cliffkiller = false;
            Properties.Settings.Default.Save();
        }

        private void Magewrath_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(598);
            Properties.Settings.Default.Magewrath = true;
            Properties.Settings.Default.Save();
        }

        private void Magewrath_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(598);
            Properties.Settings.Default.Magewrath = false;
            Properties.Settings.Default.Save();
        }


        private void Goldstrike_Arch_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(546);
            Properties.Settings.Default.Goldstrike_Arch = true;
            Properties.Settings.Default.Save();
        }

        private void Goldstrike_Arch_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(546);
            Properties.Settings.Default.Goldstrike_Arch = false;
            Properties.Settings.Default.Save();
        }

        private void Eaglehorn_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1029);
            Properties.Settings.Default.Eaglehorn = true;
            Properties.Settings.Default.Save();
        }

        private void Eaglehorn_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1029);
            Properties.Settings.Default.Eaglehorn = false;
            Properties.Settings.Default.Save();
        }

        private void Widowmaker_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(852);
            Properties.Settings.Default.Widowmaker = true;
            Properties.Settings.Default.Save();
        }

        private void Widowmaker_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(852);
            Properties.Settings.Default.Widowmaker = false;
            Properties.Settings.Default.Save();
        }

        private void Windforce_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(14565);
            Properties.Settings.Default.Windforce = true;
            Properties.Settings.Default.Save();
        }

        private void Windforce_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(14565);
            Properties.Settings.Default.Windforce = false;
            Properties.Settings.Default.Save();
        }
    }
}
